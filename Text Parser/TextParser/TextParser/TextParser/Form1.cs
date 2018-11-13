using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TextParser
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            // Read from text file.
            string content = File.ReadAllText(openTextBox.Text);

            // Eliminate tabs & new lines using regex and turn it into a space.
            string replacement = Regex.Replace(content, @"\t|\n|\r", " ");

            // Elminate multiple whitespaces. 
            replacement = Regex.Replace(replacement, @"\s+", " ");

            // To Upper Case.
            replacement = replacement.ToUpper();

            // Split between white space.
            string[] wordList = replacement.Split(' ');

            // Write into 1 string.
            string stor = "";
            for (int i = 0; i < wordList.Count(); i++)
            {
                if (wordList[i] != " ")
                {
                    //split by something
                    stor = stor + wordList[i] + " ";
                }                
            }

            // Replace all special characters with comma.
            string stor2 = Regex.Replace(stor, @"[^0-9a-zA-Z]+", ",");

            // Split between comma.
            string[] comma = stor2.Split(',');

            // Eliminating numeric strings. Adding non numeric character.
            string stor3 = "";
            for (int i = 0; i < comma.Count(); i++)
            {
                if ( !Regex.IsMatch(comma[i], @"^\d+$"))
                {
                    stor3 = stor3 + comma[i] + ",";
                }
             }

            // Split between comma.
            string[] comma2 = stor3.Split(',');

            // List Dictionary <word, count>:
            Dictionary<string, int> myDict = new Dictionary<string, int>();

            // itterate through string list.
            foreach (string word in comma2)
            {
                // if word is not in list.
                if (!myDict.ContainsKey(word))
                {
                    myDict.Add(word, 1);
                }
                // if word is in list, add 1 to count.
                else
                {
                    int count = myDict[word];
                    myDict[word] = count + 1;
                }
            }

            // Make String (xxxx: 00)
            string stor4 = "";
            foreach(KeyValuePair < string, int > entry in myDict)
            {
                stor4 = stor4 + entry.Key + ": " + entry.Value.ToString() + "\r\n";
            }

            // Create a text file to write to. 
            string path = directTextBox.Text + "\\" + createTextBox.Text + @".txt" ;
            File.WriteAllText(path, stor4);

            // Open the file to read from. 
            string readText = File.ReadAllText(path);

            // Notice Label
            noticeLabel.Text = "Parsing complete! \nText File created. Please check your directory folder...";

            // Open windows
            System.Diagnostics.Process.Start(path);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            openTextFile.ShowDialog();
            openTextBox.Text = openTextFile.FileName;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            openTextBox.Clear();
            directTextBox.Clear();
            createTextBox.Clear();
            noticeLabel.Text = "Please fill in the blanks...";
        }

        private void openTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void directortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void createTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void noticeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
