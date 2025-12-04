using System;
using System.Windows.Forms;
using Tyuiu.AlbornozJ.Sprint6.Task0.V16.Lib;


namespace Tyuiu.AlbornozJ.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = Convert.ToInt32(textBoxVarX.Text);

                
                if (x == 0)
                {
                    MessageBox.Show("x не может быть равен 0 (деление на ноль)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = ds.Calculate(x);
                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите целое число в поле x", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-25-1 Альборноз Хулиан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}