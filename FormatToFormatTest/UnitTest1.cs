using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormatToFormat;
using System.IO;

namespace FormatToFormatTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                //frmProcessor processor = new frmProcessor();
                string pdfFolderPath = @"C:\Users\Dell\Desktop\Test";
                string[] pdfFiles = Directory.GetFiles(pdfFolderPath);
                //DirectoryInfo dir_info = new DirectoryInfo(pdfFolderPath + "\\Output");
                //if (dir_info.Exists == false)
                //{
                //    dir_info.Create();
                //}
                Processor.PdfToWord(pdfFolderPath, pdfFiles);

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            
        }
    }
}
