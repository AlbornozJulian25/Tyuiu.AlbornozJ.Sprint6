using System;
using System.Windows.Forms;
using System.IO;


using Tyuiu.AlbornozJ.Sprint6.Task7.V21.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        private int rows;
        private int columns;
        private string openFilePath;
        private DataService ds = new DataService();
        private int[,] inputMatrix;
        private int[,] outputMatrix;

        public FormMain()

        {
            InitializeComponent();
        }
        private int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogTask.ShowDialog() == DialogResult.OK)
                {
                    openFilePath = openFileDialogTask.FileName;

                    
                    inputMatrix = LoadFromFileData(openFilePath);

                    
                    dataGridViewInMatrix.ColumnCount = columns;
                    dataGridViewInMatrix.RowCount = rows;

                    
                    dataGridViewOutMatrix.ColumnCount = columns;
                    dataGridViewOutMatrix.RowCount = rows;

                    
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewInMatrix.Columns[i].Width = 40;
                        dataGridViewOutMatrix.Columns[i].Width = 40;
                    }

                    
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewInMatrix.Rows[r].Cells[c].Value = inputMatrix[r, c];
                        }
                    }

                    
                    groupBoxInPutData.Text = "Ввод: " + Path.GetFileName(openFilePath);
                    groupBoxOutPutData.Text = "Вывод:";

                    
                    buttonDone.Enabled = true;
                    buttonSaveFile.Enabled = false;

                    
                    dataGridViewOutMatrix.Rows.Clear();
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

                
                outputMatrix = ds.GetMatrix(openFilePath);

                
                int outRows = outputMatrix.GetLength(0);
                int outColumns = outputMatrix.GetLength(1);

                
                dataGridViewOutMatrix.Rows.Clear();

                
                while (dataGridViewOutMatrix.RowCount < outRows)
                {
                    dataGridViewOutMatrix.Rows.Add();
                }

                
                for (int r = 0; r < outRows; r++)
                {
                    for (int c = 0; c < outColumns; c++)
                    {
                        dataGridViewOutMatrix.Rows[r].Cells[c].Value = outputMatrix[r, c];
                    }
                }

                
                groupBoxOutPutData.Text = "Вывод: " + Path.GetFileName(openFilePath);

                
                buttonSaveFile.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении задачи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMatrix.FileName = "OutPutFileTask7V21.csv";
                saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialogMatrix.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialogMatrix.FileName;

                    
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    
                    string str = "";
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (j != columns - 1)
                            {
                                str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                            }
                            else
                            {
                                str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;
                            }
                        }
                        File.AppendAllText(path, str + Environment.NewLine);
                        str = "";
                    }

                    MessageBox.Show("Данные успешно сохранены в файл: " + path, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            dataGridViewInMatrix.ColumnCount = 50;
            dataGridViewOutMatrix.ColumnCount = 50;

            
            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 40;
                dataGridViewOutMatrix.Columns[i].Width = 40;
            }
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }
    }
}
