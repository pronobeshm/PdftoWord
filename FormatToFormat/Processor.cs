using SautinSoft;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatToFormat
{
    public static class Processor
    {
        public static void PdfToWord(string pdfFolderPath, string[] pdfFiles)
        {
            DirectoryInfo dir_info = new DirectoryInfo(pdfFolderPath + "\\PdfOutput");
            if (dir_info.Exists == false)
            {
                dir_info.Create();
            }
            for (int i = 0; i < pdfFiles.Length; i++)
            {
                string filePath = pdfFiles[i];

                FileInfo fileInfo = new FileInfo(filePath);
                if (fileInfo.Extension.ToLower() == ".pdf")
                {
                    MemoryStream docxStream = new MemoryStream();
                    PdfFocus f = new PdfFocus();
                    using (FileStream pdfStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        f.OpenPdf(pdfStream);
                        if (f.PageCount > 0)
                        {
                            int res = f.ToWord(docxStream);

                            if (res == 0)
                            {
                                string docxFile = Path.ChangeExtension(filePath, ".docx");
                                File.WriteAllBytes(docxFile, docxStream.ToArray());
                                FileInfo fileInfoDest = new FileInfo(docxFile);

                                string fileName = fileInfoDest.Name;
                                string destFile = pdfFolderPath + "\\PdfOutput\\" + fileName;
                                File.Copy(docxFile, destFile);
                                File.Delete(docxFile);
                            }
                        }
                    }
                }
            }
        }
    }
}
