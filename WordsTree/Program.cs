using System;
using System.IO;


namespace WordsTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree<string> wordsTree = new BSTree<string>();
            readFile("textfile.txt", ref wordsTree);
            Console.WriteLine("number of words: " + wordsTree.Count());
            Console.WriteLine("height of tree: " + wordsTree.Height());
        }

        static void readFile(string fileName, ref BSTree<string> tree)
        {
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(fileName);


            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                    if (word != "")
                        tree.InsertItem(word.ToLower());
            }
        }

    }
}
