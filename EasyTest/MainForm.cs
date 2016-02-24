using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EasyTest
{
    public interface IMainForm
    {
        string filePath { get; }
        string specialistName { get; }
        string headName { get; }
        string chamberName { get; }
        string reportDirectory { get; }

        double channelCount { get; }
        double checksCount { get; }
        double targetValue { get; }
        double dtNormal { get; }
        double tKT { get; }
        double tIU { get; }

        int[] chosenChannels { get; }
        int startIndex { get; }

        string textDisplay { get; set; }
        string statusDisplay { get; set; }

        event EventHandler fileImportClick;
        event EventHandler createReportClick;
        event EventHandler createDocumentClick;

        void fillDataGrid(double[,] array);
        double[,] getArrayFromGrid(int startIndex);
        void clearGrid();

        Color textDisplayColor { set; }
    }

    public partial class MainForm : Form, IMainForm
    {
        private bool isManual;

        private int[] getChannelArray() // возвращает массив помеченных каналов 
        {        
            List<int> list = new List<int>();


            if (checkCh1.Checked) list.Add(2);
            if (checkCh2.Checked) list.Add(3);
            if (checkCh3.Checked) list.Add(4);
            if (checkCh4.Checked) list.Add(5);
            if (checkCh5.Checked) list.Add(6);
            if (checkCh6.Checked) list.Add(7);
            if (checkCh7.Checked) list.Add(8);
            if (checkCh8.Checked) list.Add(9);

            list.Add(10); // КТ
            list.Add(11); // ИУ

            return list.ToArray();
        }

        private bool ifChannelsChecks()
        {
            bool result = false;

            if (checkCh1.Checked) result = true;
            if (checkCh2.Checked) result = true;
            if (checkCh3.Checked) result = true;
            if (checkCh4.Checked) result = true;
            if (checkCh5.Checked) result = true;
            if (checkCh6.Checked) result = true;
            if (checkCh7.Checked) result = true;
            if (checkCh8.Checked) result = true;

            return result;
        }

        private void fillKT()
        {
            int height = dataGridView1.RowCount;
            for (int i = 0; i < height; i++)
            {
                dataGridView1.Rows[i].Cells[10].Value = numericKT.Value.ToString("F2");
            }
        } // заполнить КТ

        private void fillIU()
        {
            int height = dataGridView1.RowCount;
            for (int i = 0; i < height; i++)
            {
                dataGridView1.Rows[i].Cells[11].Value = numericIU.Value.ToString("F2");
            }
        } // заполнить ИУ

        #region setters/getters

        public Color textDisplayColor
        {
            set { textBoxPreview.BackColor = value; }
        }

        public string textDisplay
        {
            set { textBoxPreview.Text = value; }
            get { return textBoxPreview.Text; }
        }

        public string statusDisplay
        {
            set { toolStripStatus.Text = value; }
            get { return toolStripStatus.Text; }
        }

        public string filePath
        {
            get { return textBoxFilePath.Text; }
        }

        public string reportDirectory
        {
            get { return textBoxReportPath.Text; }
        }

        public double channelCount 
        {
            get { return (double)getChannelArray().Length; }
        }

        public double checksCount
        {
            get { return (double)numericChecksCount.Value; }
        }

        public double targetValue
        {
            get { return (double)numericTargetValue.Value; }
        }

        public double dtNormal // заглушка (ГОСТ)
        {
            get { return (double)2; }
        }

        public double tKT
        {
            get { return (double)numericKT.Value; }
        }

        public double tIU
        {
            get { return (double)numericIU.Value; }
        }

        public string specialistName
        {
            get { return listBoxSpecialist.SelectedItem.ToString(); }
        }

        public string headName
        {
            get { return listBoxHeadName.SelectedItem.ToString(); }
        }

        public string chamberName
        {
            get { return listBoxChamber.SelectedItem.ToString(); }
        }

        public int[] chosenChannels
        {
            get { return getChannelArray(); }
        }

        public int startIndex
        {
            get { return ((int)numericStartRow.Value - 1); }
        }

        #endregion

        public event EventHandler fileImportClick;
        public event EventHandler createReportClick;
        public event EventHandler createDocumentClick;

        public void fillDataGrid(double[,] array) // заполняет datagrid из массива
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString("F0");
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString("F2");
                    }
                }
                fillKT();
                fillIU();
            }
            
        }

        public double[,] getArrayFromGrid(int startIndex) // получает финальный массив измерений double из dataGrid
        {
            int[] chArray = getChannelArray();

            int x = chArray.Length; 
            int y = (int)numericChecksCount.Value;

            double[,] output = new double[x, y];

            for (int i = 0; i < x; i++)
            {   
                for (int j = 0 + startIndex; j < y + startIndex; j++)
                {
                    output[i, j - startIndex] = Double.Parse(dataGridView1.Rows[j].Cells[chArray[i]].Value.ToString());
                }
            }
            return output;
        }

        public void clearGrid() // очищает grid
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
        }

        public MainForm()
        {
            InitializeComponent();
                        
            //режим ввода по умолчанию - АВТО
            isManual = false;
            buttonManualAuto.BackColor = Color.BlanchedAlmond;

            //предустановка listBox для корректной иниализации inputObject
            listBoxChamber.SelectedIndex = 0;
            listBoxGOST.SelectedIndex = 0;
            listBoxHeadName.SelectedIndex = 0;
            listBoxSpecialist.SelectedIndex = 0;

            //папка репортов по умолчанию
            textBoxReportPath.Text = System.AppDomain.CurrentDomain.BaseDirectory + "Протоколы";
            
            buttonBrowseFile.Click += new EventHandler(buttonBrowseFile_Click);
            buttonImportFile.Click += new EventHandler(buttonImportFile_Click);
            buttonCreateReport.Click += new EventHandler(buttonCreateReport_Click);
            buttonCreateDoc.Click += new EventHandler(buttonCreateDoc_Click);
            buttonBrowseDir.Click += new EventHandler(buttonBrowseDir_Click);
            numericKT.ValueChanged += new EventHandler(numericKT_ValueChanged);
            numericIU.ValueChanged+=  new EventHandler(numericIU_ValueChanged);
            buttonManualAuto.Click += new EventHandler(buttonManualAuto_Click);
            buttonAddRow.Click += new EventHandler(buttonAddRow_Click);
            buttonClearGrid.Click += new EventHandler(buttonClearGrid_Click);   
        }

        #region Проброс событий

        void buttonCreateDoc_Click(object sender, EventArgs e)
        {
            if (createDocumentClick != null) createDocumentClick(this, EventArgs.Empty);
        }

        void buttonCreateReport_Click(object sender, EventArgs e)
        {
            if (ifChannelsChecks())
            {
                if (createReportClick != null) createReportClick(this, EventArgs.Empty);
            }
            else
            {
                textBoxPreview.Text = "Каналы для обработки не выбраны!";
            }
        }

        void buttonImportFile_Click(object sender, EventArgs e)
        {
            if (fileImportClick != null) fileImportClick(this, EventArgs.Empty);
        }

        #endregion

        void buttonBrowseFile_Click(object sender, EventArgs e) //buttonBrowseFile handler
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = ("Текстовые файлы|*.txt|Все файлы|*.*");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = dlg.FileName;

                if (fileImportClick != null)                     
                    fileImportClick(this, EventArgs.Empty);

            }
        }

        void buttonBrowseDir_Click(object sender, EventArgs e) //buttonBrowseDir handler
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxReportPath.Text = dlg.SelectedPath;
            }
        }

        void numericKT_ValueChanged(object sender, EventArgs e) // изменилось КТср
        {
            fillKT();
        }

        void buttonClearGrid_Click(object sender, EventArgs e)
        {
            clearGrid();
            textBoxPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            textBoxPreview.Text = "Импортируйте файл для начала обработки или воспользуйтесь ручным вводом...";
        }

        void numericIU_ValueChanged(object sender, EventArgs e) // изменилось ИУср
        {
            fillIU();
        }

        void buttonAddRow_Click(object sender, EventArgs e) // добавить строку в грид
        {
            dataGridView1.Rows.Add();
        }

        void buttonManualAuto_Click(object sender, EventArgs e)
        {
            if (isManual == false)
            {
                isManual = true;
                buttonManualAuto.Text = "ПЕРЕЙТИ В АВТОМАТИЧЕСКИЙ РЕЖИМ";
                buttonManualAuto.BackColor = Color.LightGreen;
                labelHeader.Text = "Параметры и ход обработки (ручной режим)";

                numericIU.Enabled = false;
                numericKT.Enabled = false;

                buttonAddRow.Enabled = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                isManual = false;
                buttonManualAuto.Text = "ПЕРЕЙТИ В РУЧНОЙ РЕЖИМ";
                buttonManualAuto.BackColor = Color.BlanchedAlmond;
                labelHeader.Text = "Параметры и ход обработки (автоматический режим)";

                numericIU.Enabled = true;
                numericKT.Enabled = true;

                buttonAddRow.Enabled = false;
                dataGridView1.ReadOnly = true;
            }

        } // переключение режимов
    }
}
