namespace TextFileProcessing
{
    partial class TextFileProcessorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_End = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(30, 30);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(145, 48);
            this.btn_chooseFile.TabIndex = 1;
            this.btn_chooseFile.Text = "Choose a file";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.btn_chooseFile_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(30, 450);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(145, 48);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(885, 310);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_End
            // 
            this.btn_End.BackColor = System.Drawing.SystemColors.Control;
            this.btn_End.Location = new System.Drawing.Point(765, 450);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(145, 48);
            this.btn_End.TabIndex = 5;
            this.btn_End.Text = "End";
            this.btn_End.UseVisualStyleBackColor = false;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(50, 30);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(0, 20);
            this.fileNameLabel.TabIndex = 7;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Empty;
            this.toolTip1.ForeColor = System.Drawing.Color.Ivory;
            // 
            // TextFileProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 524);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_chooseFile);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextFileProcessorForm";
            this.Text = "TextFileProcessorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

