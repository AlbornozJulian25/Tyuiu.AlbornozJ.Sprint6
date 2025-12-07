namespace Tyuiu.AlbornozJ.Sprint6.Task6.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxInPutData;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.TextBox textBoxLoadFromFile;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxInPutData = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxInPutData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // buttonOpenFile
            this.buttonOpenFile.BackColor = System.Drawing.Color.Gold;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(20, 70);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(40, 40);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "📁";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);

            // buttonDone
            this.buttonDone.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone.Enabled = false;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(70, 70);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(40, 40);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "▶";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);

            // buttonHelp
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(720, 70);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(40, 40);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // groupBoxInPutData
            this.groupBoxInPutData.Controls.Add(this.textBoxLoadFromFile);
            this.groupBoxInPutData.Location = new System.Drawing.Point(20, 120);
            this.groupBoxInPutData.Name = "groupBoxInPutData";
            this.groupBoxInPutData.Size = new System.Drawing.Size(360, 300);
            this.groupBoxInPutData.TabIndex = 3;
            this.groupBoxInPutData.TabStop = false;
            this.groupBoxInPutData.Text = "Ввод:";

            // textBoxLoadFromFile
            this.textBoxLoadFromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadFromFile.Multiline = true;
            this.textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            this.textBoxLoadFromFile.ReadOnly = true;
            this.textBoxLoadFromFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile.Size = new System.Drawing.Size(354, 281);
            this.textBoxLoadFromFile.TabIndex = 0;

            // groupBoxOutPutData
            this.groupBoxOutPutData.Controls.Add(this.textBoxResult);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(400, 120);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(360, 300);
            this.groupBoxOutPutData.TabIndex = 4;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод:";

            // textBoxResult
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(354, 281);
            this.textBoxResult.TabIndex = 0;

            // openFileDialogTask
            this.openFileDialogTask.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialogTask.Title = "Выберите файл для загрузки";

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(784, 60);
            this.panelTop.TabIndex = 5;

            // labelTitle
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(784, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Спринт 6 | Task 6 | Вариант 26 | Альборноз Х.";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FormMain
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.groupBoxOutPutData);
            this.Controls.Add(this.groupBoxInPutData);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonOpenFile);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Task 6 | Вариант 26";
            this.groupBoxInPutData.ResumeLayout(false);
            this.groupBoxInPutData.PerformLayout();
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}