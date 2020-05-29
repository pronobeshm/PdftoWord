using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System.Diagnostics;
using Xceed.Words.NET;
using SautinSoft;

namespace FormatToFormat
{
    public partial class frmProcessor : Form
    {
        public string[] pdfFiles;
        public string[] wordFiles;
        public string pdfFolderPath;
        public string wordFolderPath;

        public frmProcessor()
        {           
            InitializeComponent();
            btnPdf.Enabled = false;
            btnWord.Enabled = false;
        }

        private void btnBrowsePdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.SelectedPath))
            {
                pdfFolderPath = fileDialog.SelectedPath;
                pdfFiles = Directory.GetFiles(fileDialog.SelectedPath);
                if(pdfFiles.Length >0)
                {
                    btnPdf.Enabled = true;
                    txtPdfToWord.Text = pdfFolderPath;
                }                
            }
        }

        private void btnBrowseWord_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.SelectedPath))
            {
                wordFolderPath = fileDialog.SelectedPath;
                wordFiles = Directory.GetFiles(fileDialog.SelectedPath);
                if (wordFiles.Length > 0)
                {
                    btnWord.Enabled = true;
                    txtWordToPdf.Text = wordFolderPath;
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir_info = new DirectoryInfo(pdfFolderPath + "\\Output");
                if (dir_info.Exists == false)
                {
                    dir_info.Create();
                }
                Processor.PdfToWord(pdfFolderPath, pdfFiles);               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir_info = new DirectoryInfo(wordFolderPath + "\\Output");
            if (dir_info.Exists == false)
            {
                dir_info.Create();
            }
        }


        
    }
}
