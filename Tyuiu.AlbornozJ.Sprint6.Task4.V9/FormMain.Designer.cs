using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace Tyuiu.AlbornozJ.Sprint6.Task4.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTaskInfo_AJ = new System.Windows.Forms.GroupBox();
            this.labelTaskInfo_AJ = new System.Windows.Forms.Label();
            this.groupBoxInPutVars_AJ = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_AJ = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_AJ = new System.Windows.Forms.TextBox();
            this.labelVarStopValue_AJ = new System.Windows.Forms.Label();
            this.labelVarStartValue_AJ = new System.Windows.Forms.Label();
            this.groupBoxOutPut_AJ = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutResult_AJ = new System.Windows.Forms.TextBox();
            this.chartOutPutResult_AJ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelOutPutResult_AJ = new System.Windows.Forms.Label();
            this.buttonHelp_AJ = new System.Windows.Forms.Button();
            this.buttonDone_AJ = new System.Windows.Forms.Button();
            this.buttonSaveFile_AJ = new System.Windows.Forms.Button();
            this.groupBoxTaskInfo_AJ.SuspendLayout();
            this.groupBoxInPutVars_AJ.SuspendLayout();
            this.groupBoxOutPut_AJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPutResult_AJ)).BeginInit();
            this.SuspendLayout();
            
            this.groupBoxTaskInfo_AJ.Controls.Add(this.labelTaskInfo_AJ);
            this.groupBoxTaskInfo_AJ.Location = new System.Drawing.Point(11, 16);
            this.groupBoxTaskInfo_AJ.Name = "groupBoxTaskInfo_AJ";
            this.groupBoxTaskInfo_AJ.Size = new System.Drawing.Size(498, 305);
            this.groupBoxTaskInfo_AJ.TabIndex = 0;
            this.groupBoxTaskInfo_AJ.TabStop = false;
            this.groupBoxTaskInfo_AJ.Text = "Условие";
          
            this.labelTaskInfo_AJ.AutoSize = true;
            this.labelTaskInfo_AJ.Location = new System.Drawing.Point(10, 23);
            this.labelTaskInfo_AJ.Name = "labelTaskInfo_AJ";
            this.labelTaskInfo_AJ.Size = new System.Drawing.Size(482, 260);
            this.labelTaskInfo_AJ.TabIndex = 0;
            this.labelTaskInfo_AJ.Text = resources.GetString("labelTaskInfo_AJ.Text");
            
            this.groupBoxInPutVars_AJ.Controls.Add(this.textBoxStopValue_AJ);
            this.groupBoxInPutVars_AJ.Controls.Add(this.textBoxStartValue_AJ);
            this.groupBoxInPutVars_AJ.Controls.Add(this.labelVarStopValue_AJ);
            this.groupBoxInPutVars_AJ.Controls.Add(this.labelVarStartValue_AJ);
            this.groupBoxInPutVars_AJ.Location = new System.Drawing.Point(15, 327);
            this.groupBoxInPutVars_AJ.Name = "groupBoxInPutVars_AJ";
            this.groupBoxInPutVars_AJ.Size = new System.Drawing.Size(304, 96);
            this.groupBoxInPutVars_AJ.TabIndex = 1;
            this.groupBoxInPutVars_AJ.TabStop = false;
            this.groupBoxInPutVars_AJ.Text = "Ввод данных:";
            
            this.textBoxStopValue_AJ.Location = new System.Drawing.Point(137, 54);
            this.textBoxStopValue_AJ.Name = "textBoxStopValue_AJ";
            this.textBoxStopValue_AJ.Size = new System.Drawing.Size(125, 27);
            this.textBoxStopValue_AJ.TabIndex = 5;
            this.textBoxStopValue_AJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopValue_AJ_KeyPress);
             
            this.textBoxStartValue_AJ.Location = new System.Drawing.Point(6, 54);
            this.textBoxStartValue_AJ.Name = "textBoxStartValue_AJ";
            this.textBoxStartValue_AJ.Size = new System.Drawing.Size(125, 27);
            this.textBoxStartValue_AJ.TabIndex = 4;
            this.textBoxStartValue_AJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartValue_AJ_KeyPress);
             
            this.labelVarStopValue_AJ.AutoSize = true;
            this.labelVarStopValue_AJ.Location = new System.Drawing.Point(137, 31);
            this.labelVarStopValue_AJ.Name = "labelVarStopValue_AJ";
            this.labelVarStopValue_AJ.Size = new System.Drawing.Size(108, 20);
            this.labelVarStopValue_AJ.TabIndex = 3;
            this.labelVarStopValue_AJ.Text = "Конец шага:";
            
            this.labelVarStartValue_AJ.AutoSize = true;
            this.labelVarStartValue_AJ.Location = new System.Drawing.Point(6, 31);
            this.labelVarStartValue_AJ.Name = "labelVarStartValue_AJ";
            this.labelVarStartValue_AJ.Size = new System.Drawing.Size(108, 20);
            this.labelVarStartValue_AJ.TabIndex = 2;
            this.labelVarStartValue_AJ.Text = "Старт шага:";
             
            this.groupBoxOutPut_AJ.Controls.Add(this.textBoxOutPutResult_AJ);
            this.groupBoxOutPut_AJ.Controls.Add(this.chartOutPutResult_AJ);
            this.groupBoxOutPut_AJ.Controls.Add(this.labelOutPutResult_AJ);
            this.groupBoxOutPut_AJ.Location = new System.Drawing.Point(515, 16);
            this.groupBoxOutPut_AJ.Name = "groupBoxOutPut_AJ";
            this.groupBoxOutPut_AJ.Size = new System.Drawing.Size(590, 511);
            this.groupBoxOutPut_AJ.TabIndex = 2;
            this.groupBoxOutPut_AJ.TabStop = false;
            this.groupBoxOutPut_AJ.Text = "Вывод данных:";
             
            this.textBoxOutPutResult_AJ.Location = new System.Drawing.Point(14, 59);
            this.textBoxOutPutResult_AJ.Multiline = true;
            this.textBoxOutPutResult_AJ.Name = "textBoxOutPutResult_AJ";
            this.textBoxOutPutResult_AJ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutResult_AJ.Size = new System.Drawing.Size(168, 446);
            this.textBoxOutPutResult_AJ.TabIndex = 3;
            
            chartArea1.Name = "ChartArea1";
            this.chartOutPutResult_AJ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOutPutResult_AJ.Legends.Add(legend1);
            this.chartOutPutResult_AJ.Location = new System.Drawing.Point(196, 59);
            this.chartOutPutResult_AJ.Name = "chartOutPutResult_AJ";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOutPutResult_AJ.Series.Add(series1);
            this.chartOutPutResult_AJ.Size = new System.Drawing.Size(388, 446);
            this.chartOutPutResult_AJ.TabIndex = 2;
            this.chartOutPutResult_AJ.Text = "chart1";
            
            this.labelOutPutResult_AJ.AutoSize = true;
            this.labelOutPutResult_AJ.Location = new System.Drawing.Point(14, 36);
            this.labelOutPutResult_AJ.Name = "labelOutPutResult_AJ";
            this.labelOutPutResult_AJ.Size = new System.Drawing.Size(99, 20);
            this.labelOutPutResult_AJ.TabIndex = 1;
            this.labelOutPutResult_AJ.Text = "Результат:";
            
            this.buttonHelp_AJ.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_AJ.Location = new System.Drawing.Point(325, 343);
            this.buttonHelp_AJ.Name = "buttonHelp_AJ";
            this.buttonHelp_AJ.Size = new System.Drawing.Size(85, 65);
            this.buttonHelp_AJ.TabIndex = 3;
            this.buttonHelp_AJ.Text = "Справка";
            this.buttonHelp_AJ.UseVisualStyleBackColor = false;
            this.buttonHelp_AJ.Click += new System.EventHandler(this.buttonHelp_AJ_Click);
            
            this.buttonDone_AJ.BackColor = System.Drawing.Color.Green;
            this.buttonDone_AJ.Location = new System.Drawing.Point(408, 343);
            this.buttonDone_AJ.Name = "buttonDone_AJ";
            this.buttonDone_AJ.Size = new System.Drawing.Size(101, 65);
            this.buttonDone_AJ.TabIndex = 4;
            this.buttonDone_AJ.Text = "Выполнить";
            this.buttonDone_AJ.UseVisualStyleBackColor = false;
            this.buttonDone_AJ.Click += new System.EventHandler(this.buttonDone_AJ_Click);
            this.buttonDone_AJ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_AJ_MouseDown);
            this.buttonDone_AJ.MouseEnter += new System.EventHandler(this.buttonDone_AJ_MouseEnter);
            this.buttonDone_AJ.MouseLeave += new System.EventHandler(this.buttonDone_AJ_MouseLeave);
             
            this.buttonSaveFile_AJ.BackColor = System.Drawing.Color.Orange;
            this.buttonSaveFile_AJ.Location = new System.Drawing.Point(325, 414);
            this.buttonSaveFile_AJ.Name = "buttonSaveFile_AJ";
            this.buttonSaveFile_AJ.Size = new System.Drawing.Size(184, 65);
            this.buttonSaveFile_AJ.TabIndex = 5;
            this.buttonSaveFile_AJ.Text = "Сохранить в файл";
            this.buttonSaveFile_AJ.UseVisualStyleBackColor = false;
            this.buttonSaveFile_AJ.Click += new System.EventHandler(this.buttonSaveFile_AJ_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 539);
            this.Controls.Add(this.buttonSaveFile_AJ);
            this.Controls.Add(this.buttonDone_AJ);
            this.Controls.Add(this.buttonHelp_AJ);
            this.Controls.Add(this.groupBoxOutPut_AJ);
            this.Controls.Add(this.groupBoxInPutVars_AJ);
            this.Controls.Add(this.groupBoxTaskInfo_AJ);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Таск 4 | Вариант 9 | Альборноз Х.";
            this.groupBoxTaskInfo_AJ.ResumeLayout(false);
            this.groupBoxTaskInfo_AJ.PerformLayout();
            this.groupBoxInPutVars_AJ.ResumeLayout(false);
            this.groupBoxInPutVars_AJ.PerformLayout();
            this.groupBoxOutPut_AJ.ResumeLayout(false);
            this.groupBoxOutPut_AJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPutResult_AJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskInfo_AJ;
        private System.Windows.Forms.GroupBox groupBoxInPutVars_AJ;
        private System.Windows.Forms.GroupBox groupBoxOutPut_AJ;
        private System.Windows.Forms.Button buttonHelp_AJ;
        private System.Windows.Forms.Button buttonDone_AJ;
        private System.Windows.Forms.Label labelTaskInfo_AJ;
        private System.Windows.Forms.Label labelVarStopValue_AJ;
        private System.Windows.Forms.Label labelVarStartValue_AJ;
        private System.Windows.Forms.Label labelOutPutResult_AJ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPutResult_AJ;
        private System.Windows.Forms.TextBox textBoxStopValue_AJ;
        private System.Windows.Forms.TextBox textBoxStartValue_AJ;
        private System.Windows.Forms.TextBox textBoxOutPutResult_AJ;
        private System.Windows.Forms.Button buttonSaveFile_AJ;
    }
}
