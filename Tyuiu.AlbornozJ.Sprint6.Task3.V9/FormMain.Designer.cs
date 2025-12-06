namespace Tyuiu.AlbornozJ.Sprint6.Task3.V9
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTaskInfo_AJ = new System.Windows.Forms.GroupBox();
            this.labelTaskInfo_AJ = new System.Windows.Forms.Label();
            this.groupBoxInPut_AJ = new System.Windows.Forms.GroupBox();
            this.dataGridViewOriginal_AJ = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_AJ = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_AJ = new System.Windows.Forms.DataGridView();
            this.labelResult_AJ = new System.Windows.Forms.Label();
            this.buttonHelp_AJ = new System.Windows.Forms.Button();
            this.buttonDone_AJ = new System.Windows.Forms.Button();
            this.groupBoxTaskInfo_AJ.SuspendLayout();
            this.groupBoxInPut_AJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal_AJ)).BeginInit();
            this.groupBoxOutPut_AJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AJ)).BeginInit();
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
            
            this.groupBoxInPut_AJ.Controls.Add(this.dataGridViewOriginal_AJ);
            this.groupBoxInPut_AJ.Location = new System.Drawing.Point(15, 327);
            this.groupBoxInPut_AJ.Name = "groupBoxInPut_AJ";
            this.groupBoxInPut_AJ.Size = new System.Drawing.Size(494, 200);
            this.groupBoxInPut_AJ.TabIndex = 1;
            this.groupBoxInPut_AJ.TabStop = false;
            this.groupBoxInPut_AJ.Text = "Исходные данные:";
            
            this.dataGridViewOriginal_AJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOriginal_AJ.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewOriginal_AJ.Name = "dataGridViewOriginal_AJ";
            this.dataGridViewOriginal_AJ.RowHeadersWidth = 51;
            this.dataGridViewOriginal_AJ.Size = new System.Drawing.Size(482, 168);
            this.dataGridViewOriginal_AJ.TabIndex = 0;
            
            this.groupBoxOutPut_AJ.Controls.Add(this.dataGridViewResult_AJ);
            this.groupBoxOutPut_AJ.Controls.Add(this.labelResult_AJ);
            this.groupBoxOutPut_AJ.Location = new System.Drawing.Point(515, 16);
            this.groupBoxOutPut_AJ.Name = "groupBoxOutPut_AJ";
            this.groupBoxOutPut_AJ.Size = new System.Drawing.Size(590, 511);
            this.groupBoxOutPut_AJ.TabIndex = 2;
            this.groupBoxOutPut_AJ.TabStop = false;
            this.groupBoxOutPut_AJ.Text = "Вывод данных:";
           
            this.dataGridViewResult_AJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AJ.Location = new System.Drawing.Point(14, 59);
            this.dataGridViewResult_AJ.Name = "dataGridViewResult_AJ";
            this.dataGridViewResult_AJ.RowHeadersWidth = 51;
            this.dataGridViewResult_AJ.Size = new System.Drawing.Size(570, 446);
            this.dataGridViewResult_AJ.TabIndex = 1;
            
            this.labelResult_AJ.AutoSize = true;
            this.labelResult_AJ.Location = new System.Drawing.Point(14, 36);
            this.labelResult_AJ.Name = "labelResult_AJ";
            this.labelResult_AJ.Size = new System.Drawing.Size(99, 20);
            this.labelResult_AJ.TabIndex = 0;
            this.labelResult_AJ.Text = "Результат:";
            
            this.buttonHelp_AJ.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_AJ.Location = new System.Drawing.Point(325, 533);
            this.buttonHelp_AJ.Name = "buttonHelp_AJ";
            this.buttonHelp_AJ.Size = new System.Drawing.Size(85, 65);
            this.buttonHelp_AJ.TabIndex = 3;
            this.buttonHelp_AJ.Text = "Справка";
            this.buttonHelp_AJ.UseVisualStyleBackColor = false;
            this.buttonHelp_AJ.Click += new System.EventHandler(this.buttonHelp_AJ_Click);
            
            this.buttonDone_AJ.BackColor = System.Drawing.Color.Green;
            this.buttonDone_AJ.Location = new System.Drawing.Point(408, 533);
            this.buttonDone_AJ.Name = "buttonDone_AJ";
            this.buttonDone_AJ.Size = new System.Drawing.Size(101, 65);
            this.buttonDone_AJ.TabIndex = 4;
            this.buttonDone_AJ.Text = "Выполнить";
            this.buttonDone_AJ.UseVisualStyleBackColor = false;
            this.buttonDone_AJ.Click += new System.EventHandler(this.buttonDone_AJ_Click);
            this.buttonDone_AJ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_AJ_MouseDown);
            this.buttonDone_AJ.MouseEnter += new System.EventHandler(this.buttonDone_AJ_MouseEnter);
            this.buttonDone_AJ.MouseLeave += new System.EventHandler(this.buttonDone_AJ_MouseLeave);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 610);
            this.Controls.Add(this.buttonDone_AJ);
            this.Controls.Add(this.buttonHelp_AJ);
            this.Controls.Add(this.groupBoxOutPut_AJ);
            this.Controls.Add(this.groupBoxInPut_AJ);
            this.Controls.Add(this.groupBoxTaskInfo_AJ);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #6 | Таск 3 | Вариант 9 | Альборноз Х.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTaskInfo_AJ.ResumeLayout(false);
            this.groupBoxTaskInfo_AJ.PerformLayout();
            this.groupBoxInPut_AJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginal_AJ)).EndInit();
            this.groupBoxOutPut_AJ.ResumeLayout(false);
            this.groupBoxOutPut_AJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskInfo_AJ;
        private System.Windows.Forms.GroupBox groupBoxInPut_AJ;
        private System.Windows.Forms.GroupBox groupBoxOutPut_AJ;
        private System.Windows.Forms.Button buttonHelp_AJ;
        private System.Windows.Forms.Button buttonDone_AJ;
        private System.Windows.Forms.Label labelTaskInfo_AJ;
        private System.Windows.Forms.DataGridView dataGridViewOriginal_AJ;
        private System.Windows.Forms.DataGridView dataGridViewResult_AJ;
        private System.Windows.Forms.Label labelResult_AJ;
    }
}
