namespace WinCalc
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            txtDisplay = new TextBox();
            lblFormula = new Label();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDiv = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMult = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSub = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnSign = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnBackspace = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.White;
            txtDisplay.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(14, 40);
            txtDisplay.Margin = new Padding(4, 3, 4, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(303, 38);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // lblFormula
            // 
            lblFormula.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormula.ForeColor = Color.DimGray;
            lblFormula.Location = new Point(14, 10);
            lblFormula.Margin = new Padding(4, 0, 4, 0);
            lblFormula.Name = "lblFormula";
            lblFormula.Size = new Size(303, 27);
            lblFormula.TabIndex = 1;
            lblFormula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn7
            // 
            btn7.Location = new Point(14, 150);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 46);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.Click += Digit_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(90, 150);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 46);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.Click += Digit_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(166, 150);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 46);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.Click += Digit_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(241, 98);
            btnDiv.Margin = new Padding(4, 3, 4, 3);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(70, 46);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.Click += Operator_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(14, 202);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 46);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.Click += Digit_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(90, 202);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 46);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.Click += Digit_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(166, 202);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 46);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.Click += Digit_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(241, 150);
            btnMult.Margin = new Padding(4, 3, 4, 3);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(70, 46);
            btnMult.TabIndex = 9;
            btnMult.Text = "*";
            btnMult.Click += Operator_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(14, 254);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 46);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.Click += Digit_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(90, 254);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 46);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.Click += Digit_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(166, 254);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 46);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.Click += Digit_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(241, 202);
            btnSub.Margin = new Padding(4, 3, 4, 3);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(70, 46);
            btnSub.TabIndex = 13;
            btnSub.Text = "-";
            btnSub.Click += Operator_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(90, 306);
            btn0.Margin = new Padding(4, 3, 4, 3);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 46);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.Click += Digit_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(14, 306);
            btnDot.Margin = new Padding(4, 3, 4, 3);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(70, 46);
            btnDot.TabIndex = 19;
            btnDot.Text = ".";
            btnDot.Click += btnDot_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(166, 306);
            btnSign.Margin = new Padding(4, 3, 4, 3);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(70, 46);
            btnSign.TabIndex = 20;
            btnSign.Text = "+/-";
            btnSign.Click += btnSign_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(241, 254);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 46);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.Click += Operator_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.LightBlue;
            btnEquals.Location = new Point(241, 306);
            btnEquals.Margin = new Padding(4, 3, 4, 3);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(70, 46);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(14, 98);
            btnC.Margin = new Padding(4, 3, 4, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(70, 46);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(90, 98);
            btnCE.Margin = new Padding(4, 3, 4, 3);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(70, 46);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.Click += btnCE_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(166, 98);
            btnBackspace.Margin = new Padding(4, 3, 4, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(70, 46);
            btnBackspace.TabIndex = 4;
            btnBackspace.Text = "←";
            btnBackspace.Click += btnBackspace_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 369);
            Controls.Add(lblFormula);
            Controls.Add(txtDisplay);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(btnDiv);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMult);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnSub);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btnDot);
            Controls.Add(btnSign);
            Controls.Add(btnEquals);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CalculatorForm";
            Text = "WinCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Button btn7, btn8, btn9, btnDiv;
        private System.Windows.Forms.Button btn4, btn5, btn6, btnMult;
        private System.Windows.Forms.Button btn1, btn2, btn3, btnSub;
        private System.Windows.Forms.Button btn0, btnDot, btnSign, btnAdd;
        private System.Windows.Forms.Button btnEquals, btnC, btnCE, btnBackspace;
    }
}
