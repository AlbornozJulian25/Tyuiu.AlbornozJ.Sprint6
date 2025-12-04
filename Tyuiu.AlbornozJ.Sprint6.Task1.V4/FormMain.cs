using System;
using System.Windows.Forms;


using Tyuiu.AlbornozJ.Sprint6.Task1.V4.Lib;


namespace Tyuiu.AlbornozJ.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            textBoxStart.Text = "-5";
            textBoxStop.Text = "5";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                
                dataGridViewFunction.Rows.Clear();
                textBoxResult.Clear();

                
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                
                if (startValue >= stopValue)
                {
                    MessageBox.Show("Начальное значение должно быть меньше конечного", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                DataService ds = new DataService();
                double[] values = ds.GetMassFunction(startValue, stopValue);

                
                for (int i = 0, x = startValue; x <= stopValue; i++, x++)
                {
                    dataGridViewFunction.Rows.Add(x.ToString(), values[i].ToString("F2"));
                }

                
                textBoxResult.AppendText($"Диапазон: [{startValue}; {stopValue}]\r\n");
                textBoxResult.AppendText($"Шаг: 1\r\n\r\n");
                textBoxResult.AppendText("Таблица значений:\r\n");
                textBoxResult.AppendText("x\t\tF(x)\r\n");
                textBoxResult.AppendText("-----------------------\r\n");

                for (int i = 0, x = startValue; x <= stopValue; i++, x++)
                {
                    textBoxResult.AppendText($"{x}\t\t{values[i]:F2}\r\n");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целые числа в поля диапазона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-25-1 Альборноз Хулиан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            
            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            
            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
