﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextProcessing;

// Namespace for the TextFileProcessorForm
namespace TextFileProcessing
{
    // Form for processing a text file
    public partial class TextFileProcessorForm : Form
    {

        public TextFileProcessorForm()
        {
            InitializeComponent();

        }

        // Create a CancellationTokenSource to allow the user to cancel the process
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken? cancellationToken;



        // Event handler for choosing a file
        private async void btn_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cancellationTokenSource = new CancellationTokenSource();

                // Get the file path from the open file dialog
                String filePath = openFileDialog.FileName;

                try
                {
                    // Run a task to process the text file
                    await Task.Run(() =>
                    {
                        string[] words = TextParsing.ExtractWords(filePath, ' ', cancellationToken); Dictionary<string, int> wordCounts = new Dictionary<string, int>();
                        int count = 0;
                        int total = words.Length;
                        foreach (string word in words)
                        {
                            if (cancellationTokenSource.IsCancellationRequested)
                            {
                                break;
                            }

                            count++;

                            if (wordCounts.ContainsKey(word))
                            {
                                wordCounts[word]++;
                            }
                            else
                            {
                                wordCounts[word] = 1;
                            }
                        }

                        if (!cancellationTokenSource.IsCancellationRequested)
                        {
                            // Sort the word counts in descending order
                            var sortedWordCounts = wordCounts.OrderByDescending(wc => wc.Value);
                            this.Invoke((Action)delegate
                            {
                                listView1.View = View.Details;
                                listView1.Columns.Add("Word", 150);
                                listView1.Columns.Add("Occurrence", 150);
                                // Add the word counts to the ListView
                                foreach (var wordCount in sortedWordCounts)
                                {
                                    ListViewItem item = new ListViewItem(wordCount.Key);
                                    item.SubItems.Add(wordCount.Value.ToString());
                                    listView1.Items.Add(item);
                                }
                            });
                        }
                    });
                }
                catch (OperationCanceledException)
                {
                    // Handle the cancellation here, if needed
                }
            }
        }

        // Method called when the user clicks the "Reset" button
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            this.Invoke((Action)delegate
            {
                // Update UI
                listView1.Clear();
                MessageBox.Show("The process has been successfully reset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

            });
        }

        // Method called when the user clicks the "End" button
        private void btn_End_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to end the program?", "End Program Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancellationTokenSource != null && result == DialogResult.Yes)
            {
                cancellationTokenSource.Cancel();
                Application.Exit();
            }
            if ((cancellationTokenSource == null && result == DialogResult.Yes))
            {
                Application.Exit();
            }

        }
    }
}


namespace TextProcessing
{
    public static class TextParsing
    {
        // This method reads the text file at the specified file path and splits it into words
        // The cancellationToken parameter allows for cancellation of the task during execution
        public static string[] ExtractWords(string filePath, char separator, CancellationToken? cancellationToken = null)
        {
            string[] words = File.ReadAllText(filePath).Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Return an empty array if there are no words
            if (words.Length == 0)
            {
                return new string[0];
            }

            return words;
        }
    }

    class WordProcessing
    {
        // This method takes a file path and a CancellationToken, and returns a dictionary containing the count of each word in the file
        public static Dictionary<string, int> GetWordCounts(string filePath, CancellationToken cancellationToken)
        {
            // Get an array of words from the file
            string[] words = TextParsing.ExtractWords(filePath, ' ', cancellationToken);

            // Initialize a dictionary to store the count of each word
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // Iterate through the words, incrementing the count of each word in the dictionary
            foreach (string word in words)
            {
                // Check if the task has been cancelled
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
            return wordCounts;
        }
    }
}


