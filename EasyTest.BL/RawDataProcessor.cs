using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EasyTest.BL
{
    public interface IRawDataProcessor
    {
        RawData getRawData(UserInput inputObject);
    }

    public class RawDataProcessor : IRawDataProcessor
    {
        // Поля
        private readonly Encoding _defEncoding = Encoding.GetEncoding(1251);
        private readonly int _verticalCut = 4; // параметр входного файла, количество ненужных строк в начале
        private readonly int nullLinesCount = 5; // параметр входного файла, общее количество отбрасываемых строк в файле лога

        private readonly int chCount = 8; // количество входных каналов прибора

        // Методы

        // Создание массива данных измерений 
        // Возвращает матрицу double-значений

        public RawData getRawData(UserInput inputObject)
        {
            string[] byLinesArray;
            string[] byWordsArray;

            byLinesArray = File.ReadAllLines(inputObject.filePath, _defEncoding);

            int outputHeight = (byLinesArray.Length - nullLinesCount);
            int outputWidth = chCount + 2; // + столбец итерация + столбец timestamp

            double[,] outputArray = new double[outputHeight, outputWidth];

            // обрезаем по строкам в соответсвии со структурой файла лога
            for (int i = 0; i < _verticalCut; i++)
            {
                byLinesArray = byLinesArray.Where(w => w != byLinesArray[0]).ToArray();
            }

            for (int i = 0; i < byLinesArray.Length - 1; i++) //последнюю строку убираем - они часто не полные
            {
                //разбиваем каждую строку на слова
                byWordsArray = byLinesArray[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // записываем оставшиеся данные в выходной массив переводя их в тип double
                for (int j = 0; j < byWordsArray.Length; j++)
                {
                    outputArray[i, j] = (Math.Round((double.Parse((byWordsArray[j]), new System.Globalization.CultureInfo("en-US"))), 2));
                }
            }

            string date = getTestDate(inputObject.filePath);

            RawData output = new RawData(outputArray, date);
            return output;
        }

        // Возвращает дату измерения (string)
        private string getTestDate(string filePath)
        {
            string[] byLinesArray = File.ReadAllLines(filePath, _defEncoding);
            string str = byLinesArray[0];
            string testDate = str.Substring(19, 16);
            return testDate;
        }
    }
}
