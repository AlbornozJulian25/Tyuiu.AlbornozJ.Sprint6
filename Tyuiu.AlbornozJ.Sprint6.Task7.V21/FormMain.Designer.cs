namespace Tyuiu.AlbornozJ.Sprint6.Task7.V21
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInPutData;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix;
        private System.Windows.Forms.ToolTip toolTipButton;
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInPutData = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix = new System.Windows.Forms.DataGridView();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).BeginInit();
            this.groupBoxOutPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            
            this.buttonOpenFile.BackColor = System.Drawing.Color.Gold;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(20, 70);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(40, 40);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "📁";
            this.toolTipButton.SetToolTip(this.buttonOpenFile, "Открыть файл");
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);

            
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
            this.toolTipButton.SetToolTip(this.buttonDone, "Выполнить");
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);

            
            this.buttonSaveFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile.ForeColor = System.Drawing.Color.White;
            this.buttonSaveFile.Location = new System.Drawing.Point(120, 70);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(40, 40);
            this.buttonSaveFile.TabIndex = 2;
            this.buttonSaveFile.Text = "💾";
            this.toolTipButton.SetToolTip(this.buttonSaveFile, "Сохранить в файл");
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            this.buttonSaveFile.MouseEnter += new System.EventHandler(this.buttonSaveFile_MouseEnter);

            
            this.buttonHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(720, 70);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(40, 40);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "?";
            this.toolTipButton.SetToolTip(this.buttonHelp, "Справка");
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            this.buttonHelp.MouseEnter += new System.EventHandler(this.buttonHelp_MouseEnter);

            
            this.openFileDialogTask.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.openFileDialogTask.Title = "Выберите файл InPutFileTask7V21.csv";

            
            this.saveFileDialogMatrix.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialogMatrix.Title = "Сохранить результат в файл";

            
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            this.splitContainer1.Name = "splitContainer1";

            
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInPutData);
            this.splitContainer1.Panel1MinSize = 300;

            
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutPutData);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(784, 321);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;

            
            this.groupBoxInPutData.Controls.Add(this.dataGridViewInMatrix);
            this.groupBoxInPutData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData.Name = "groupBoxInPutData";
            this.groupBoxInPutData.Size = new System.Drawing.Size(392, 321);
            this.groupBoxInPutData.TabIndex = 0;
            this.groupBoxInPutData.TabStop = false;
            this.groupBoxInPutData.Text = "Ввод:";

            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            this.dataGridViewInMatrix.ReadOnly = true;
            this.dataGridViewInMatrix.RowHeadersVisible = false;
            this.dataGridViewInMatrix.Size = new System.Drawing.Size(386, 302);
            this.dataGridViewInMatrix.TabIndex = 0;

            
            this.groupBoxOutPutData.Controls.Add(this.dataGridViewOutMatrix);
            this.groupBoxOutPutData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(387, 321);
            this.groupBoxOutPutData.TabIndex = 0;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод:";

            
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOutMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            this.dataGridViewOutMatrix.ReadOnly = true;
            this.dataGridViewOutMatrix.RowHeadersVisible = false;
            this.dataGridViewOutMatrix.Size = new System.Drawing.Size(381, 302);
            this.dataGridViewOutMatrix.TabIndex = 0;

            
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(784, 60);
            this.panelTop.TabIndex = 5;

            
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(784, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Спринт 6 | Task 7 | Вариант 21 | Альборноз Х.";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Task 7 | Вариант 21";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInPutData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).EndInit();
            this.groupBoxOutPutData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}