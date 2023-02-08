# TextFileProcessing
A C# .NET Framework application that extracts and counts the words from a text file using a Windows Form interface.


The purpose of this example is to demonstrate an approach for solving a problem for an actual user.

Below, there is a description of the scenario with some of the technical requirements as well. 


*** Scenario ***

-	A customer needs a small utility for processing a text file.

-	The user interface shall allow the user to specify the text file to be processed.

-	This file shall be analyzed and all the words within the file shall be extracted and counted.

-	As a result, a simple two-column table shall be shown.

-	The first column shall contain words, while the second one shall contain their occurrences.

-	The table shall be sorted by the number of occurrences.

-	The user shall be able to cancel the processing of the file.



*** Technical requirements ***


-	The program shall read an ANSI text file. The file to be read shall be specified by the user.

-	Separating the words out of the text file is only based on white space characters 

(space, LR, CR, ...). Handling punctuation marks is beyond the scope of this assignment.

-	It shall be considered that large text files (~50 MB) will be processed, and as such, 

the user interface shall show a progress bar.

-	It shall be possible to abort the program while parsing the text file.

-	The file parsing logic, responsible for extracting the words out of the input file should be 

modular and reusable. This is because this logic is intended to be reused in a future project.

-	It is desired that the parsing of the file offers decent performance.

-	The user interface is required to be responsive even during parsing the file so that the user

 can still interact with the application (e.g. when he/she wants to cancel the file processing).

