using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToText
{
    public partial class Form1 : Form
    {
        Bitmap Image;
        List<String> GreyScale = new List<String> { "█", "▓", "▒", "░", " "};
        List<String> ApplicationList = new List<String> { "notepad.exe", "notepad++.exe" };
        int selectedIndex = 0;
        List<List<int>> colours = new List<List<int>>();

        public Form1()
        {
            InitializeComponent();

            foreach (String app in ApplicationList)
            {
                uiOpenWithComboBox.Items.Add(app);
            }
            uiOpenWithComboBox.SelectedIndex = selectedIndex;
        }


        public void UploadImage(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = dialog.FileName;
                Image = new Bitmap(filePath);
                colours = Image.GetBrightnessByN(GreyScale.Count - 1, 2, 4);
                uiSelectImageButton.Text = filePath;
            }
        }

        public void CreateTxtFile(object sender, EventArgs e)
        {
            //change to not be hard coded
            String fileDir = @"C:\Users\jackd\OneDrive\Pictures\ImageToText\" + uiFileNameTextBox.Text + ".txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileDir))
            {
                foreach (List<int> pixelRow in colours)
                {
                    foreach (int pixel in pixelRow)
                    {
                        file.Write(GreyScale[pixel]);
                    }
                    file.WriteLine();
                }
            }

            Process.Start(ApplicationList[selectedIndex], fileDir);
        }

        private void uiOpenWithComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = uiOpenWithComboBox.SelectedIndex;
        }
    }
}
