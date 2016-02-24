using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace EasyTest.BL
{
    public interface IDocumentCreator
    {
        bool createWordDocument(Report report, UserInput inputObject);
    }

    public class DocumentCreator : IDocumentCreator
    {
        private string templateFileName;
        private string templateFileName_DT1 = @"ReportTemplates\reportTemplate_25051_dT1.doc";
        private string templateFileName_DT2 = @"ReportTemplates\reportTemplate_25051_dT2.doc"; 
        private string templateFileName_DT1_DT2 = @"ReportTemplates\reportTemplate_25051_dT1_dT2.doc";
        
        public bool createWordDocument(Report report, UserInput inputObject)
        {
            bool isDone = false;

            try
            {
                Word.Application wordApp = new Word.Application();

                wordApp.Visible = false;

                if (Math.Round(report.dT1, 1) == 0)
                {
                    templateFileName = templateFileName_DT2;
                }
                else if (Math.Round(report.dT2, 1) == 0)
                {
                    templateFileName = templateFileName_DT1;
                }
                else
                {
                    templateFileName = templateFileName_DT1_DT2;
                }


                Word.Document wordDoc = wordApp.Documents.Open(System.AppDomain.CurrentDomain.BaseDirectory + templateFileName);

                #region Значения в тексте

                replaceTokens("{tv}", Math.Round(report.targetValue, 1).ToString(), wordDoc, 2); //  targetValue
                replaceTokens("{dtNormal}", Math.Round(report.dtNormal, 1).ToString(), wordDoc, 3); //dtNormal
                replaceTokens("{date}", report.date, wordDoc, 1); // date
                replaceTokens("{maxAmp}", Math.Round(report.maxAmp, 1).ToString(), wordDoc, 1); // maxAmp
                replaceTokens("{tNer}", Math.Round(report.tNer, 1).ToString(), wordDoc, 1); // tNer
                replaceTokens("{dT1}", Math.Round(report.dT1, 1).ToString(), wordDoc, 2); // dT1
                replaceTokens("{dT2}", Math.Round(report.dT2, 1).ToString(), wordDoc, 2); // dT2
                replaceTokens("{dIU}", Math.Round(report.dIU, 1).ToString(), wordDoc, 3); // dIU
                replaceTokens("{delta}", Math.Round(report.delta, 1).ToString(), wordDoc, 2); // delta
                replaceTokens("{specialistName}", report.specialistName, wordDoc, 1); // specialistName
                replaceTokens("{headName}", report.headName, wordDoc, 1); // headName
                replaceTokens("{resolution}", report.resolution, wordDoc, 1); // resolution

                #endregion

                #region Значения в таблицах

                fillTables(report, wordDoc);

                #endregion

                string filePath = getFilePath(report, inputObject);//@"D:\result.doc";

                wordDoc.SaveAs(filePath);
                isDone = true;

                wordApp.Visible = true;
                                               
                return isDone;
            }
            catch
            {
                return isDone;
            }
        }
        
        // создает имя файла
        private string getFilePath(Report report, UserInput inputObject)
        {
            string filePath;

            int index = report.date.IndexOf(' ') + 1;
            string date = report.date.Substring(index);
            string dirPath = inputObject.reportDir;

            string filename = @"\" + report.chamberName + "_" + date + "_Режим_(" + report.targetValue.ToString() + ").doc";
            filePath = dirPath + filename;

            return filePath;
        }

        // меняет iterations одинаковых токенов в документе Word
        private void replaceTokens(string token, string text, Word.Document doc, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Word.Range range = doc.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: token, ReplaceWith: text);
            }
        }

        // заполняет таблицы документа 
        private void fillTables(Report report, Word.Document doc)
        {
            // заполняет основной
            for (int i = 0; i < report.reportArray.GetLength(0); i++)
            {
                for (int j = 0; j < report.reportArray.GetLength(1); j++)
                {
                    string token = "{" + i.ToString() + "," + j.ToString() + "}";
                    replaceTokens(token, report.reportArray[i, j].ToString("F1"), doc, 1);
                }
            }

            // заполняет средние
            for (int i = 0; i < report.avgArray.Length; i++)
            {
                string token = "{avg" + i.ToString() + "}";
                replaceTokens(token, report.avgArray[i].ToString("F1"), doc, 1);
            }
        }
    }
}
