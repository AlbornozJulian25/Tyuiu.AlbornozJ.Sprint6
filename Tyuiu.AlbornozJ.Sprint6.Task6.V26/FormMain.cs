using System;
using System.Windows.Forms;
using System.IO;


using Tyuiu.AlbornozJ.Sprint6.Task6.V26.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialogTask.Title = "Выберите файл InPutFileTask6V26.txt";

                if (openFileDialogTask.ShowDialog() == DialogResult.OK)
                {
                    openFilePath = openFileDialogTask.FileName;

                    
                    textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);

                    
                    groupBoxInPutData.Text = "Ввод: " + Path.GetFileName(openFilePath);

                    
                    buttonDone.Enabled = true;

                    
                    textBoxResult.Clear();
                    groupBoxOutPutData.Text = "Вывод:";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(openFilePath) || !File.Exists(openFilePath))
                {
                    MessageBox.Show("Файл не выбран или не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                string result = ds.CollectTextFromFile(openFilePath);

                
                textBoxResult.Text = result;
                groupBoxOutPutData.Text = "Вывод: " + Path.GetFileName(openFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении задачи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
