namespace GradeCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            label1=new Label();
            label2=new Label();
            txtLetterGrade=new TextBox();
            txtNumberGrade=new TextBox();
            btnCalculate=new Button();
            btnExit=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(23, 15);
            label1.Name="label1";
            label1.Size=new Size(88, 15);
            label1.TabIndex=0;
            label1.Text="&Number Grade:";
            label1.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AllowDrop=true;
            label2.AutoSize=true;
            label2.Location=new Point(37, 47);
            label2.Name="label2";
            label2.Size=new Size(74, 15);
            label2.TabIndex=1;
            label2.Text="Letter Grade:";
            label2.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.Location=new Point(117, 44);
            txtLetterGrade.Name="txtLetterGrade";
            txtLetterGrade.ReadOnly=true;
            txtLetterGrade.Size=new Size(100, 23);
            txtLetterGrade.TabIndex=2;
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.Location=new Point(117, 15);
            txtNumberGrade.Name="txtNumberGrade";
            txtNumberGrade.Size=new Size(100, 23);
            txtNumberGrade.TabIndex=1;
            txtNumberGrade.TextChanged+=txtNumberGrade_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location=new Point(23, 92);
            btnCalculate.Name="btnCalculate";
            btnCalculate.Size=new Size(75, 23);
            btnCalculate.TabIndex=2;
            btnCalculate.Text="&Calculate";
            btnCalculate.UseVisualStyleBackColor=true;
            btnCalculate.Click+=btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location=new Point(142, 92);
            btnExit.Name="btnExit";
            btnExit.Size=new Size(75, 23);
            btnExit.TabIndex=3;
            btnExit.Text="E&xit";
            btnExit.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(248, 168);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumberGrade);
            Controls.Add(txtLetterGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="Letter Grade Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLetterGrade;
        private TextBox txtNumberGrade;
        private Button btnCalculate;
        private Button btnExit;
    }
}