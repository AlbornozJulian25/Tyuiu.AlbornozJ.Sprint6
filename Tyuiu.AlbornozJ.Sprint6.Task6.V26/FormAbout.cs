using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AlbornozJ.Sprint6.Task6.V26
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            labelDeveloper.Text = "Разработчик: Альборноз Хулиан";
            labelGroup.Text = "Группа: ИИПб-25-1";
            labelTask.Text = "Спринт 6 | Task 6 | Вариант 26";

            
            Label labelDescription = new Label();
            labelDescription.Location = new System.Drawing.Point(120, 125);
            labelDescription.Size = new System.Drawing.Size(300, 40);
            labelDescription.Text = "Программа разработана в рамках изучения языка C#";
            this.Controls.Add(labelDescription);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}