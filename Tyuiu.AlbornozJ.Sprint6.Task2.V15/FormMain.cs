using System;
using System.Drawing;
using System.Windows.Forms;



using Tyuiu.AlbornozJ.Sprint6.Task2.V15.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task2.V15
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
            MessageBox.Show("Задание 2 выполнил студент группы ИИПБ-25-1 Альборноз Хулиан", "Справка");
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
                dataGridViewOutPutResult_AJ.Rows.Clear();

                this.chartOutPutResult_AJ.Titles.Clear();
                this.chartOutPutResult_AJ.Titles.Add("График функции f(x)");
                this.chartOutPutResult_AJ.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOutPutResult_AJ.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOutPutResult_AJ.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartOutPutResult_AJ.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
