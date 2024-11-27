namespace TAN.ComparePopulation.UI
{
    partial class frmComparePopulation
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
            label1 = new Label();
            label2 = new Label();
            txtCity = new TextBox();
            txtState = new TextBox();
            groupBox1 = new GroupBox();
            lblPercentDecrease = new Label();
            lblPercentIncrease = new Label();
            label4 = new Label();
            label3 = new Label();
            txtStartingPop = new TextBox();
            txtEndingPop = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 43);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 43);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "State";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(40, 61);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(181, 23);
            txtCity.TabIndex = 2;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // txtState
            // 
            txtState.CharacterCasing = CharacterCasing.Upper;
            txtState.Location = new Point(240, 61);
            txtState.Name = "txtState";
            txtState.Size = new Size(51, 23);
            txtState.TabIndex = 3;
            txtState.TextChanged += txtState_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(lblPercentDecrease);
            groupBox1.Controls.Add(lblPercentIncrease);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(166, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 165);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Percent Change";
            // 
            // lblPercentDecrease
            // 
            lblPercentDecrease.BorderStyle = BorderStyle.Fixed3D;
            lblPercentDecrease.Location = new Point(37, 116);
            lblPercentDecrease.Name = "lblPercentDecrease";
            lblPercentDecrease.Size = new Size(100, 23);
            lblPercentDecrease.TabIndex = 3;
            lblPercentDecrease.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPercentIncrease
            // 
            lblPercentIncrease.BorderStyle = BorderStyle.Fixed3D;
            lblPercentIncrease.Location = new Point(37, 54);
            lblPercentIncrease.Name = "lblPercentIncrease";
            lblPercentIncrease.Size = new Size(100, 23);
            lblPercentIncrease.TabIndex = 1;
            lblPercentIncrease.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 92);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 2;
            label4.Text = "Percent Decrease";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 30);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 0;
            label3.Text = "Percent Increase";
            // 
            // txtStartingPop
            // 
            txtStartingPop.Location = new Point(40, 161);
            txtStartingPop.Name = "txtStartingPop";
            txtStartingPop.Size = new Size(100, 23);
            txtStartingPop.TabIndex = 4;
            txtStartingPop.TextAlign = HorizontalAlignment.Right;
            txtStartingPop.TextChanged += txtStartingPop_TextChanged;
            // 
            // txtEndingPop
            // 
            txtEndingPop.Location = new Point(40, 223);
            txtEndingPop.Name = "txtEndingPop";
            txtEndingPop.Size = new Size(100, 23);
            txtEndingPop.TabIndex = 5;
            txtEndingPop.TextAlign = HorizontalAlignment.Right;
            txtEndingPop.TextChanged += txtEndingPop_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(64, 312);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(166, 312);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(268, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 136);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 10;
            label5.Text = "Starting Population";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 198);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 11;
            label6.Text = "Ending Population";
            // 
            // frmComparePopulation
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(407, 369);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtEndingPop);
            Controls.Add(txtStartingPop);
            Controls.Add(groupBox1);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmComparePopulation";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCity;
        private TextBox txtState;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label lblPercentDecrease;
        private Label lblPercentIncrease;
        private TextBox txtStartingPop;
        private TextBox txtEndingPop;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label5;
        private Label label6;
    }
}