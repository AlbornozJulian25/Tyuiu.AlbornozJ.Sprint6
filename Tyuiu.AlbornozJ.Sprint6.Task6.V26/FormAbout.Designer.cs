namespace Tyuiu.AlbornozJ.Sprint6.Task6.V26
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelProgramInfo;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelUniversity;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelInternalName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTop;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelProgramInfo = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelUniversity = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelInternalName = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();

            
            this.labelProgramInfo.AutoSize = true;
            this.labelProgramInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgramInfo.Location = new System.Drawing.Point(120, 20);
            this.labelProgramInfo.Name = "labelProgramInfo";
            this.labelProgramInfo.Size = new System.Drawing.Size(270, 20);
            this.labelProgramInfo.TabIndex = 0;
            this.labelProgramInfo.Text = "О программе";

            
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(120, 50);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(180, 16);
            this.labelDeveloper.TabIndex = 1;
            this.labelDeveloper.Text = "Разработчик: Альборноз Х.";

            
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(120, 75);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(120, 16);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Группа: ИИПб-25-1";

            
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(120, 100);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(230, 16);
            this.labelTask.TabIndex = 3;
            this.labelTask.Text = "Спринт 6 | Task 6 | Вариант 26";

            
            this.labelUniversity.AutoSize = true;
            this.labelUniversity.Location = new System.Drawing.Point(30, 180);
            this.labelUniversity.Name = "labelUniversity";
            this.labelUniversity.Size = new System.Drawing.Size(340, 16);
            this.labelUniversity.TabIndex = 4;
            this.labelUniversity.Text = "Тюменский индустриальный университет (с) 2024";

            
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(30, 205);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(360, 16);
            this.labelDepartment.TabIndex = 5;
            this.labelDepartment.Text = "Высшая школа цифровых технологий (с) 2024";

            
            this.labelInternalName.AutoSize = true;
            this.labelInternalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInternalName.Location = new System.Drawing.Point(30, 240);
            this.labelInternalName.Name = "labelInternalName";
            this.labelInternalName.Size = new System.Drawing.Size(250, 17);
            this.labelInternalName.TabIndex = 6;
            this.labelInternalName.Text = "Внутреннее имя: Tyuiu.AlbornozJ.Sprint6.Task6.V26";

            
            this.buttonOK.Location = new System.Drawing.Point(320, 270);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

            
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;

            
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(450, 5);
            this.panelTop.TabIndex = 9;

            
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelInternalName);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelUniversity);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.labelProgramInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}