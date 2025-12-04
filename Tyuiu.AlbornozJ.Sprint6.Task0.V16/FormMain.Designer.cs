namespace Tyuiu.AlbornozJ.Sprint6.Task0.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxVarX;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.Label labelResult;

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
            textBoxVarX = new TextBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            labelTitle = new Label();
            labelCondition = new Label();
            labelFormula = new Label();
            labelInput = new Label();
            labelOutput = new Label();
            labelVarX = new Label();
            labelResult = new Label();
            SuspendLayout();

            
            textBoxVarX.Location = new Point(200, 150);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 27);
            textBoxVarX.TabIndex = 0;
            textBoxVarX.Text = "";
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;

            
            textBoxResult.Location = new Point(200, 200);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 27);
            textBoxResult.TabIndex = 1;

            
            buttonDone.Location = new Point(200, 250);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 30);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;

            
            buttonHelp.Location = new Point(320, 250);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(30, 30);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;

            
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(50, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(297, 28);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Спринт 6 | Таск 0 | Вариант 0";

            
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCondition.Location = new Point(50, 70);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(82, 23);
            labelCondition.TabIndex = 5;
            labelCondition.Text = "Условие:";

            
            labelFormula.AutoSize = true;
            labelFormula.Font = new Font("Segoe UI", 10F);
            labelFormula.Location = new Point(50, 95);
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(180, 23);
            labelFormula.TabIndex = 6;
            labelFormula.Text = "y(x) = (1 + x³) / x²";

            
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelInput.Location = new Point(50, 130);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(125, 23);
            labelInput.TabIndex = 7;
            labelInput.Text = "Ввод данных:";

            
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOutput.Location = new Point(50, 180);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(139, 23);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "Вывод данных:";

            
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(70, 153);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(84, 20);
            labelVarX.TabIndex = 9;
            labelVarX.Text = "Значение x:";

            
            labelResult.AutoSize = true;
            labelResult.Location = new Point(70, 203);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 10;
            labelResult.Text = "Результат:";

            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(labelResult);
            Controls.Add(labelVarX);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(labelFormula);
            Controls.Add(labelCondition);
            Controls.Add(labelTitle);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxVarX);
            Name = "FormMain";
            Text = "Калькулятор";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}