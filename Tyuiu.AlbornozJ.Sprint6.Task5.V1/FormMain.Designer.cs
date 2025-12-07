

namespace Tyuiu.AlbornozJ.Sprint6.Task5.V1
{
    partial class FormMain
    {
        
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            
            this.buttonDone.Location = new System.Drawing.Point(12, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(100, 30);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);

            
            this.buttonOpenFile.Location = new System.Drawing.Point(118, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);

            
            this.buttonHelp.Location = new System.Drawing.Point(224, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            
            this.dataGridViewNums.AllowUserToAddRows = false;
            this.dataGridViewNums.AllowUserToDeleteRows = false;
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.ReadOnly = true;
            this.dataGridViewNums.RowHeadersVisible = false;
            this.dataGridViewNums.Size = new System.Drawing.Size(194, 311);
            this.dataGridViewNums.TabIndex = 3;

            
            this.chartDiag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag.Legends.Add(legend1);
            this.chartDiag.Location = new System.Drawing.Point(6, 19);
            this.chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag.Series.Add(series1);
            this.chartDiag.Size = new System.Drawing.Size(488, 308);
            this.chartDiag.TabIndex = 4;
            this.chartDiag.Text = "chart1";

            
            this.groupBox1.Controls.Add(this.dataGridViewNums);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 330);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Положительные значения:";

            
            this.groupBox2.Controls.Add(this.chartDiag);
            this.groupBox2.Location = new System.Drawing.Point(218, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 330);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Диаграмма:";

            
            this.ClientSize = new System.Drawing.Size(730, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonDone);
            this.MinimumSize = new System.Drawing.Size(746, 429);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Task 5 | Вариант 1 | Альборноз Х.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}