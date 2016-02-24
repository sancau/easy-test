using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasyTest.BL;
using System.Drawing;

namespace EasyTest
{
    public class Presenter
    {
        IRawDataProcessor _rawProcessor;
        IReportCreator _reportCreator;
        IDocumentCreator _documentCreator;
        IMainForm _mainform;
        UserInput _inputObject;
        RawData _rawData;
        Report _report;

        public bool _docCreated;

        public Presenter(IRawDataProcessor rawProcessor, IReportCreator reportCreator,
            IDocumentCreator documentCreator, IMainForm mainform)
        {
            this._rawProcessor = rawProcessor;
            this._mainform = mainform;
            this._reportCreator = reportCreator;
            this._documentCreator = documentCreator;
            this._inputObject = new UserInput();
            this._report = new Report();

            _report.reportCreated = false; // флаг пустого объекта
           
            _mainform.fileImportClick += new EventHandler(mainform_fileImportClick);
            _mainform.createReportClick += new EventHandler(mainform_createReportClick);
            _mainform.createDocumentClick += new EventHandler(mainform_createDocumentClick);
        }

        private void refreshInput() // инициализатор inputObject
        {
            _inputObject.chamberName = _mainform.chamberName;
            _inputObject.channelCount = _mainform.channelCount;
            _inputObject.checksCount = _mainform.checksCount;
            _inputObject.chosenChannels = _mainform.chosenChannels;
            _inputObject.dtNormal = _mainform.dtNormal;
            _inputObject.tKT = _mainform.tKT;
            _inputObject.tIU = _mainform.tIU;
            _inputObject.targetValue = _mainform.targetValue;
            _inputObject.specialistName = _mainform.specialistName;
            _inputObject.headName = _mainform.headName;
            _inputObject.filePath = _mainform.filePath;
            _inputObject.reportDir = _mainform.reportDirectory;
            _inputObject.startIndex = _mainform.startIndex;
        }

        void mainform_createDocumentClick(object sender, EventArgs e) // СОБЫТИЕ СОЗДАНИЯ ДОК.
        {
            if (_report.reportCreated)
            {
                try
                {
                    refreshInput();

                    _docCreated = _documentCreator.createWordDocument(_report, _inputObject);

                    if (_docCreated)
                    {
                        _mainform.textDisplay = "Протокол успешно создан.";
                        _mainform.statusDisplay = "Обработка данных завершена. Протокол создан.";
                    }
                    else
                    {
                        _mainform.textDisplay = "Ошибка при создании документа!";
                    }
                }
                catch
                {
                    _mainform.textDisplay = "Ошибка при создании документа!";
                }
            }
            else
            {
                _mainform.textDisplay = "Отчет не создан или создан с ошибкой. Невозможно сформировать документ.";
            }
        }

        void mainform_createReportClick(object sender, EventArgs e) // СОБЫТИЕ СОЗДАНИЯ РЕПОРТА
        {
            try
            {
                refreshInput();

                _mainform.textDisplay = "go";

                _rawData.rawData = _mainform.getArrayFromGrid(_inputObject.startIndex);

                _mainform.textDisplay = "array from grid done";
                _report = _reportCreator.createReport(_rawData, _inputObject);
                _mainform.textDisplay = _report.summary;
                _mainform.textDisplay += _report.resolution;

                if (_report.resolution == "соответствует")
                {
                    _mainform.textDisplayColor = Color.LightGreen;
                }
                else
                {
                    _mainform.textDisplayColor = Color.Red;
                }

                _mainform.statusDisplay = "Ожидание команды на создание протокола...";
            }
            catch
            {
                _mainform.textDisplay += "Ошибка при создании отчета!";
                _mainform.textDisplay += _report.summary;
            }
        }

        void mainform_fileImportClick(object sender, EventArgs e) // СОБЫТИЕ ИМПОРТА
        {
            //TODO: проверка совместимости открываемого файла
            try
            {
                refreshInput();

                RawData rawData = _rawProcessor.getRawData(_inputObject);
                _rawData = rawData;

                _mainform.textDisplay = "Файл импортирован. Задайте параметры обработки." +
                    Environment.NewLine + Environment.NewLine;
                _mainform.textDisplay += _rawData.testDate; 
                _mainform.statusDisplay = "Ожидание ввода параметров обработки...";
                _mainform.textDisplayColor = Color.LightSkyBlue;

                _mainform.clearGrid();
                _mainform.fillDataGrid(_rawData.rawData);
            }
            catch
            {
            }
        }
    }
}
