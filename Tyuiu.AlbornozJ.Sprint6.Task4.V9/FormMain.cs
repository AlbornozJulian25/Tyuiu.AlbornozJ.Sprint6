using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Tyuiu.AlbornozJ.Sprint6.Task4.V9.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_AJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-25-1 Альборноз Х.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_AJ_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_AJ.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_AJ.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                
                chartOutPutResult_AJ.Series[0].Points.Clear();
                textBoxOutPutResult_AJ.Clear();

                this.chartOutPutResult_AJ.Titles.Clear();
                this.chartOutPutResult_AJ.Titles.Add("График функции f(x)");
                this.chartOutPutResult_AJ.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOutPutResult_AJ.ChartAreas[0].AxisY.Title = "Ось Y";

                
                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxOutPutResult_AJ.AppendText($"{valueArray[i]}{Environment.NewLine}");
                    this.chartOutPutResult_AJ.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_AJ_Click(object sender, EventArgs e)
        {
            try
            {
                
                int startStep = Convert.ToInt32(textBoxStartValue_AJ.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_AJ.Text);
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V9.txt";

                
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine("Результаты табулирования функции:");
                    writer.WriteLine("F(x) = (2x - 3) / (cos(x) - 2x) + 5x - sin(x)");
                    writer.WriteLine($"Диапазон: от {startStep} до {stopStep}");
                    writer.WriteLine("================================");

                    for (int i = 0; i < valueArray.Length; i++)
                    {
                        writer.WriteLine($"F({startStep + i}) = {valueArray[i]}");
                    }
                }

                MessageBox.Show($"Данные сохранены в файл: {path}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_AJ_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_AJ.BackColor = Color.Red;
        }

        private void buttonDone_AJ_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_AJ.BackColor = Color.Green;
        }

        private void buttonDone_AJ_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_AJ.BackColor = Color.Blue;
        }

        private void textBoxStartValue_AJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopValue_AJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
