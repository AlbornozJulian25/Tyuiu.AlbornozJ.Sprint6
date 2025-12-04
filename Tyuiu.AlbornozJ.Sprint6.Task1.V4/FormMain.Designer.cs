namespace Tyuiu.AlbornozJ.Sprint6.Task1.V4
{
    partial class FormMain
    {
        
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.Label labelTable;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFx;

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
            labelTitle = new Label();
            labelCondition = new Label();
            labelFunction = new Label();
            labelRange = new Label();
            labelStart = new Label();
            labelStop = new Label();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            buttonExecute = new Button();
            buttonHelp = new Button();
            textBoxResult = new TextBox();
            labelResult = new Label();
            dataGridViewFunction = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFx = new DataGridViewTextBoxColumn();
            labelTable = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();

            
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(297, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Спринт 6 | Таск 1 | Вариант 4";

            
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCondition.Location = new Point(30, 60);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(82, 23);
            labelCondition.TabIndex = 1;
            labelCondition.Text = "Условие:";

            
            labelFunction.AutoSize = true;
            labelFunction.Font = new Font("Segoe UI", 9F);
            labelFunction.Location = new Point(30, 85);
            labelFunction.Name = "labelFunction";
            labelFunction.Size = new Size(350, 20);
            labelFunction.TabIndex = 2;
            labelFunction.Text = "F(x) = sin(x)/(x+1.2) - sin(x)*2 - 2x, диапазон [-5; 5]";

            
            labelRange.AutoSize = true;
            labelRange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRange.Location = new Point(30, 120);
            labelRange.Name = "labelRange";
            labelRange.Size = new Size(150, 23);
            labelRange.TabIndex = 3;
            labelRange.Text = "Диапазон табуляции:";

            
            labelStart.AutoSize = true;
            labelStart.Location = new Point(50, 150);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(101, 20);
            labelStart.TabIndex = 4;
            labelStart.Text = "Начальное x:";

            
            labelStop.AutoSize = true;
            labelStop.Location = new Point(250, 150);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(93, 20);
            labelStop.TabIndex = 5;
            labelStop.Text = "Конечное x:";

            
            textBoxStart.Location = new Point(155, 147);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(80, 27);
            textBoxStart.TabIndex = 6;
            textBoxStart.Text = "-5";
            textBoxStart.KeyPress += textBoxStart_KeyPress;

            
            textBoxStop.Location = new Point(350, 147);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(80, 27);
            textBoxStop.TabIndex = 7;
            textBoxStop.Text = "5";
            textBoxStop.KeyPress += textBoxStop_KeyPress;

            
            buttonExecute.Location = new Point(450, 145);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(120, 30);
            buttonExecute.TabIndex = 8;
            buttonExecute.Text = "Табулировать";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;

            
            buttonHelp.Location = new Point(580, 145);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(40, 30);
            buttonHelp.TabIndex = 9;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;

            
            labelTable.AutoSize = true;
            labelTable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTable.Location = new Point(30, 190);
            labelTable.Name = "labelTable";
            labelTable.Size = new Size(174, 23);
            labelTable.TabIndex = 10;
            labelTable.Text = "Таблица значений:";

            
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
            dataGridViewFunction.Location = new Point(30, 220);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.ReadOnly = true;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(300, 250);
            dataGridViewFunction.TabIndex = 11;

            
            ColumnX.HeaderText = "x";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            ColumnX.Width = 125;

            
            ColumnFx.HeaderText = "F(x)";
            ColumnFx.MinimumWidth = 6;
            ColumnFx.Name = "ColumnFx";
            ColumnFx.ReadOnly = true;
            ColumnFx.Width = 125;

            
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelResult.Location = new Point(350, 190);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(139, 23);
            labelResult.TabIndex = 12;
            labelResult.Text = "Вывод данных:";

            
            textBoxResult.Location = new Point(350, 220);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(270, 250);
            textBoxResult.TabIndex = 13;

            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 500);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(dataGridViewFunction);
            Controls.Add(labelTable);
            Controls.Add(buttonHelp);
            Controls.Add(buttonExecute);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(labelStop);
            Controls.Add(labelStart);
            Controls.Add(labelRange);
            Controls.Add(labelFunction);
            Controls.Add(labelCondition);
            Controls.Add(labelTitle);
            Name = "FormMain";
            Text = "Табулирование функции";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}