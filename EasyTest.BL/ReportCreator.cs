using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyTest.BL
{
    public interface IReportCreator
    {
        Report createReport(RawData rawData, UserInput inputObject);
    }

    public class ReportCreator : IReportCreator
    {
        private UserInput inputObject;
        private double[,] _cuttedArray;

        private readonly int _paramsCount = 5; //количество параметров для канала
        
        public Report createReport(RawData rawData, UserInput inputObject)
        {
            this.inputObject = inputObject;

            Report report = new Report();

            report.dtNormal = inputObject.dtNormal;
            report.targetValue = inputObject.targetValue;
            report.summary = "1. Объект отчета создан -> ";
            report.date = rawData.testDate; // TODO сделать парсер даты
            report.specialistName = inputObject.specialistName;
            report.headName = inputObject.headName;
            report.chamberName = inputObject.chamberName;
            report.resolution = "Обработка не завершена.";
            report.testPassed = false;

            try
            {
                _cuttedArray = rawData.rawData;  // 

                report.reportArray = getFinalArray(_cuttedArray); // обсчитываем данные, сводим в массив

                report.summary += "2. Получен результирующий массив -> ";

                report.maxAmp = getMaxAmplitude(report.reportArray); // получаем максимальную амплитуту
               
                if (report.maxAmp < 0.5) // считаем по средним
                {
                    report.summary += "3. Максимальная амплитуда < 0.5  -> " + Environment.NewLine;

                    report.avgArray = getAvgArray(report.reportArray); // получаем массив по средним
                    report.summary += "4. Создан массив по средним -> ";

                    // обсчет средних ГОСТ 25051.2-82
                    report.dT1 = Math.Abs(report.avgArray[0] - inputObject.targetValue);

                    report.dT2 = inputObject.targetValue - report.avgArray[1];
                    if (report.dT2 < 0)
                    {
                        report.dT2 = 0;
                    }
                    else
                    {
                        report.dT2 = Math.Abs(report.dT2);
                    }
                    
                    report.dIU = Math.Abs(inputObject.tIU - inputObject.tKT);
                    report.tNer = (report.avgArray[0] - report.avgArray[1]);
                    report.summary += "5. Обработка средних завершена -> ";


                    // проверяем на соответсвие требованиям аттестации ГОСТ 25051.2-82
                    report.delta = inputObject.dtNormal - report.dIU;
                    if ((report.delta >= report.dT1) && (report.delta >= report.dT2))
                    {
                        report.testPassed = true;
                        report.resolution = "соответствует";
                     
                    }
                    else
                    {
                        report.testPassed = false;
                        report.resolution = "не соответствует";
                    }

                    report.summary += "6. Отчет сформирован" + Environment.NewLine;
                    report.reportCreated = true;

                    return report;
                }
                else
                    report.summary += "3. Максимальная амплитуда > 0.5. Отчет не может быть сформирован." + Environment.NewLine;
                    return report;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); // TODO - > Message Service
            }
        }

        // возвращает массив данных вычислений по заданому каналу (ГОСТ 25051.2-82)
        private double[] calcChannel(double[,] cuttedDataArray, int collumn)
        {
            // массив начинается с 0

            // получаем одномерный массив данных канала chNum
            double[] channelArray = new double[(int)inputObject.checksCount];
            for (int i = 0; i < channelArray.Length; i++)
            {
                channelArray[i] = cuttedDataArray[collumn, i];
            }

            // создаем возвращаемый массив
            double[] output = new double[(channelArray.Length + _paramsCount)];
            for (int i = 0; i < channelArray.Length; i++)
            {
                output[i] = channelArray[i];
            }

            // добавляем результаты вычисления 
            double avg = getAvg(channelArray);
            double max = getMax(channelArray);
            double min = getMin(channelArray);

            output[(int)inputObject.checksCount] = avg;
            output[(int)inputObject.checksCount + 1] = max;
            output[(int)inputObject.checksCount + 2] = min;
            output[(int)inputObject.checksCount + 3] = max - avg;
            output[(int)inputObject.checksCount + 4] = avg - min;

            return output;
        }

        // возвращает массив данных по выбранным каналам
        
        private double[,] getFinalArray(double[,] cuttedArray)
        {
            int x = cuttedArray.GetLength(1)+5;
            int y = cuttedArray.GetLength(0);

            double[,] output = new double[x, y];

                                     
            for (int i = 0; i < y ; i++)
            {
                double[] tempArray = calcChannel(cuttedArray, i);
                for (int j = 0; j < tempArray.Length; j++)
                {
                    output[j, i] = tempArray[j];
                }
            }

            return output;
        }

        // возвращает максимальную амплитуду колебаний в сводном массиве
        private double getMaxAmplitude(double[,] calculatedArray)
        {
            int firstAmpRaw = calculatedArray.GetLength(0) - 2;
            int secondAmpRaw = calculatedArray.GetLength(0) - 1;
            double maxAmp = 0;

            for (int i = firstAmpRaw; i < secondAmpRaw; i++)
            {
                for (int j = 0; j < calculatedArray.GetLength(1); j++)
                {
                    if (calculatedArray[i, j] > maxAmp)
                    {
                        maxAmp = calculatedArray[i, j];
                    }
                }
            }
            return maxAmp;
        }

        // возвращает вектор средних значений для обработки "по средним" (ГОСТ 25051.2-82)
        private double[] getAvgArray(double[,] finalArray)
        {
            //размер выходного на 2 меньше чем finalArray (т.к. нет КТ и ИУ)
            double[] output = new double[4];

            int indexOfAvg = finalArray.GetLength(0) - 5; // индекс строки со средними

            double[] tempArray = new double[finalArray.GetLength(1) - 2];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = finalArray[indexOfAvg, i];
            }

            output[0] = getMax(tempArray);
            output[1] = getMin(tempArray);
            output[2] = inputObject.tIU;
            output[3] = inputObject.tKT;

            return output;
        }

        // подсчет среднего значения элементов в массиве
        private double getAvg(double[] inputArray)
        {
            double arrayAvg = 0;
            double arraySum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                arraySum += inputArray[i];
            }
            arrayAvg = arraySum / (double)inputArray.Length;
            return arrayAvg;
        }

        // минимальный элемент массива
        private double getMin(double[] inputArray)
        {
            double arrayMin = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (arrayMin > inputArray[i])
                {
                    arrayMin = inputArray[i];
                }
            }
            return arrayMin;
        }

        // максимальный элемент массива
        private double getMax(double[] inputArray)
        {
            double arrayMax = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (arrayMax < inputArray[i])
                {
                    arrayMax = inputArray[i];
                }
            }
            return arrayMax;
        }
    }
}
