using System;
using System.Drawing;
using System.Windows.Forms;

using Tyuiu.AlbornozJ.Sprint6.Task3.V9.Lib;

namespace Tyuiu.AlbornozJ.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        
        int[,] matrix = new int[5, 5] {
            { -14, 25, 26, 18, 17 },
            { 28, 10, 6, -2, 4 },
            { 30, 25, -3, 11, -10 },
            { 11, 32, -5, -20, 25 },
            { 2, -18, 11, 8, -20 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowMatrix(matrix, dataGridViewOriginal_AJ, "Исходная матрица");
        }

        private void ShowMatrix(int[,] matrix, DataGridView dgv, string title)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dgv.ColumnCount = columns;
            dgv.RowCount = rows;

            
            for (int i = 0; i < columns; i++)
            {
                dgv.Columns[i].Width = 45;
                dgv.Columns[i].HeaderText = $"Столбец {i + 1}";
            }

            
            for (int i = 0; i < rows; i++)
            {
                dgv.Rows[i].HeaderCell.Value = $"Строка {i + 1}";
                for (int j = 0; j < columns; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }

        private void buttonHelp_AJ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-25-1 Альборноз Х.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_AJ_Click(object sender, EventArgs e)
        {
            try
            {
                
                int[,] sortedMatrix = ds.Calculate(matrix);

                
                ShowMatrix(sortedMatrix, dataGridViewResult_AJ, "Отсортированная матрица");

                
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewResult_AJ.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                    dataGridViewResult_AJ.Rows[i].Cells[4].Style.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
