using System;
using System.Windows.Forms;

using Tyuiu.AlbornozJ.Sprint6.Task5.V1.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V1.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 50;
            dataGridViewNums.Columns[1].Width = 120;
            dataGridViewNums.Columns[0].HeaderText = "Индекс";
            dataGridViewNums.Columns[1].HeaderText = "Значение";

            
            dataGridViewNums.Rows.Clear();
            chartDiag.Series[0].Points.Clear();

            
            this.chartDiag.ChartAreas[0].AxisX.Title = "Индекс";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Значение";
            chartDiag.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartDiag.Series[0].Color = System.Drawing.Color.SteelBlue;
            chartDiag.Series[0].Name = "Положительные значения";

            
            double[] numsMass = ds.LoadFromDataFile(path);

            
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(i, numsMass[i].ToString("F3"));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
                else
                {
                    MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-25-1 Альборноз Хулиан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


