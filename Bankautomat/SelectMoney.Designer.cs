namespace Bankautomat
{
    partial class SelectMoney
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbAccountBalance = new Label();
            btMinus5 = new Button();
            label2 = new Label();
            pMinus = new Panel();
            btMinus500 = new Button();
            btMinus200 = new Button();
            btMinus100 = new Button();
            btMinus50 = new Button();
            btMinus20 = new Button();
            btMinus10 = new Button();
            panel1 = new Panel();
            btPlus500 = new Button();
            btPlus200 = new Button();
            btPlus100 = new Button();
            btPlus50 = new Button();
            btPlus20 = new Button();
            btPlus10 = new Button();
            btPlus5 = new Button();
            lbMoneySum = new Label();
            panel2 = new Panel();
            tbNumber5 = new TextBox();
            tbNumber10 = new TextBox();
            tbNumber20 = new TextBox();
            tbNumber50 = new TextBox();
            tbNumber100 = new TextBox();
            tbNumber200 = new TextBox();
            tbNumber500 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pMinus.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(133, 21);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(92, 25);
            lbFirstName.TabIndex = 1;
            lbFirstName.Text = "FirstName";
            lbFirstName.Click += lbFirstName_Click;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(249, 21);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(90, 25);
            lbLastName.TabIndex = 2;
            lbLastName.Text = "LastName";
            // 
            // lbAccountBalance
            // 
            lbAccountBalance.AutoSize = true;
            lbAccountBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAccountBalance.Location = new Point(287, 56);
            lbAccountBalance.Name = "lbAccountBalance";
            lbAccountBalance.Size = new Size(180, 32);
            lbAccountBalance.TabIndex = 3;
            lbAccountBalance.Text = "accountBalance";
            // 
            // btMinus5
            // 
            btMinus5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus5.Location = new Point(19, 12);
            btMinus5.Name = "btMinus5";
            btMinus5.Size = new Size(56, 34);
            btMinus5.TabIndex = 4;
            btMinus5.Text = "-";
            btMinus5.UseVisualStyleBackColor = true;
            btMinus5.Click += btMinus5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 100);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 5;
            label2.Text = "select bills";
            // 
            // pMinus
            // 
            pMinus.Controls.Add(btMinus500);
            pMinus.Controls.Add(btMinus200);
            pMinus.Controls.Add(btMinus100);
            pMinus.Controls.Add(btMinus50);
            pMinus.Controls.Add(btMinus20);
            pMinus.Controls.Add(btMinus10);
            pMinus.Controls.Add(btMinus5);
            pMinus.Location = new Point(214, 181);
            pMinus.Name = "pMinus";
            pMinus.Size = new Size(97, 298);
            pMinus.TabIndex = 6;
            // 
            // btMinus500
            // 
            btMinus500.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus500.Location = new Point(19, 252);
            btMinus500.Name = "btMinus500";
            btMinus500.Size = new Size(56, 34);
            btMinus500.TabIndex = 10;
            btMinus500.Text = "-";
            btMinus500.UseVisualStyleBackColor = true;
            btMinus500.Click += btMinus500_Click;
            // 
            // btMinus200
            // 
            btMinus200.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus200.Location = new Point(19, 212);
            btMinus200.Name = "btMinus200";
            btMinus200.Size = new Size(56, 34);
            btMinus200.TabIndex = 9;
            btMinus200.Text = "-";
            btMinus200.UseVisualStyleBackColor = true;
            btMinus200.Click += btMinus200_Click;
            // 
            // btMinus100
            // 
            btMinus100.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus100.Location = new Point(19, 172);
            btMinus100.Name = "btMinus100";
            btMinus100.Size = new Size(56, 34);
            btMinus100.TabIndex = 8;
            btMinus100.Text = "-";
            btMinus100.UseVisualStyleBackColor = true;
            btMinus100.Click += btMinus100_Click;
            // 
            // btMinus50
            // 
            btMinus50.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus50.Location = new Point(19, 132);
            btMinus50.Name = "btMinus50";
            btMinus50.Size = new Size(56, 34);
            btMinus50.TabIndex = 7;
            btMinus50.Text = "-";
            btMinus50.UseVisualStyleBackColor = true;
            btMinus50.Click += btMinus50_Click;
            // 
            // btMinus20
            // 
            btMinus20.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus20.Location = new Point(19, 92);
            btMinus20.Name = "btMinus20";
            btMinus20.Size = new Size(56, 34);
            btMinus20.TabIndex = 6;
            btMinus20.Text = "-";
            btMinus20.UseVisualStyleBackColor = true;
            btMinus20.Click += btMinus20_Click;
            // 
            // btMinus10
            // 
            btMinus10.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMinus10.Location = new Point(19, 52);
            btMinus10.Name = "btMinus10";
            btMinus10.Size = new Size(56, 34);
            btMinus10.TabIndex = 5;
            btMinus10.Text = "-";
            btMinus10.UseVisualStyleBackColor = true;
            btMinus10.Click += btMinus10_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btPlus500);
            panel1.Controls.Add(btPlus200);
            panel1.Controls.Add(btPlus100);
            panel1.Controls.Add(btPlus50);
            panel1.Controls.Add(btPlus20);
            panel1.Controls.Add(btPlus10);
            panel1.Controls.Add(btPlus5);
            panel1.Location = new Point(505, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(97, 298);
            panel1.TabIndex = 11;
            // 
            // btPlus500
            // 
            btPlus500.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus500.Location = new Point(19, 252);
            btPlus500.Name = "btPlus500";
            btPlus500.Size = new Size(56, 34);
            btPlus500.TabIndex = 10;
            btPlus500.Text = "+";
            btPlus500.UseVisualStyleBackColor = true;
            btPlus500.Click += btPlus500_Click;
            // 
            // btPlus200
            // 
            btPlus200.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus200.Location = new Point(19, 212);
            btPlus200.Name = "btPlus200";
            btPlus200.Size = new Size(56, 34);
            btPlus200.TabIndex = 9;
            btPlus200.Text = "+";
            btPlus200.UseVisualStyleBackColor = true;
            btPlus200.Click += btPlus200_Click;
            // 
            // btPlus100
            // 
            btPlus100.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus100.Location = new Point(19, 172);
            btPlus100.Name = "btPlus100";
            btPlus100.Size = new Size(56, 34);
            btPlus100.TabIndex = 8;
            btPlus100.Text = "+";
            btPlus100.UseVisualStyleBackColor = true;
            btPlus100.Click += btPlus100_Click;
            // 
            // btPlus50
            // 
            btPlus50.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus50.Location = new Point(19, 132);
            btPlus50.Name = "btPlus50";
            btPlus50.Size = new Size(56, 34);
            btPlus50.TabIndex = 7;
            btPlus50.Text = "+";
            btPlus50.UseVisualStyleBackColor = true;
            btPlus50.Click += btPlus50_Click;
            // 
            // btPlus20
            // 
            btPlus20.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus20.Location = new Point(19, 92);
            btPlus20.Name = "btPlus20";
            btPlus20.Size = new Size(56, 34);
            btPlus20.TabIndex = 6;
            btPlus20.Text = "+";
            btPlus20.UseVisualStyleBackColor = true;
            btPlus20.Click += btPlus20_Click;
            // 
            // btPlus10
            // 
            btPlus10.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus10.Location = new Point(19, 52);
            btPlus10.Name = "btPlus10";
            btPlus10.Size = new Size(56, 34);
            btPlus10.TabIndex = 5;
            btPlus10.Text = "+";
            btPlus10.UseVisualStyleBackColor = true;
            btPlus10.Click += btPlus10_Click;
            // 
            // btPlus5
            // 
            btPlus5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus5.Location = new Point(19, 12);
            btPlus5.Name = "btPlus5";
            btPlus5.Size = new Size(56, 34);
            btPlus5.TabIndex = 4;
            btPlus5.Text = "+";
            btPlus5.UseVisualStyleBackColor = true;
            btPlus5.Click += btPlus5_Click;
            // 
            // lbMoneySum
            // 
            lbMoneySum.AutoSize = true;
            lbMoneySum.Location = new Point(354, 484);
            lbMoneySum.Name = "lbMoneySum";
            lbMoneySum.Size = new Size(103, 25);
            lbMoneySum.TabIndex = 12;
            lbMoneySum.Text = "MoneySum";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbNumber5);
            panel2.Controls.Add(tbNumber10);
            panel2.Controls.Add(tbNumber20);
            panel2.Controls.Add(tbNumber50);
            panel2.Controls.Add(tbNumber100);
            panel2.Controls.Add(tbNumber200);
            panel2.Controls.Add(tbNumber500);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(332, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 337);
            panel2.TabIndex = 13;
            // 
            // tbNumber5
            // 
            tbNumber5.Enabled = false;
            tbNumber5.Location = new Point(70, 51);
            tbNumber5.Name = "tbNumber5";
            tbNumber5.Size = new Size(67, 31);
            tbNumber5.TabIndex = 27;
            tbNumber5.TextChanged += tbNumber5_TextChanged;
            // 
            // tbNumber10
            // 
            tbNumber10.Enabled = false;
            tbNumber10.Location = new Point(70, 91);
            tbNumber10.Name = "tbNumber10";
            tbNumber10.Size = new Size(67, 31);
            tbNumber10.TabIndex = 26;
            tbNumber10.TextChanged += tbNumber10_TextChanged;
            // 
            // tbNumber20
            // 
            tbNumber20.Enabled = false;
            tbNumber20.Location = new Point(70, 131);
            tbNumber20.Name = "tbNumber20";
            tbNumber20.Size = new Size(67, 31);
            tbNumber20.TabIndex = 25;
            tbNumber20.TextChanged += tbNumber20_TextChanged;
            // 
            // tbNumber50
            // 
            tbNumber50.Enabled = false;
            tbNumber50.Location = new Point(70, 171);
            tbNumber50.Name = "tbNumber50";
            tbNumber50.Size = new Size(67, 31);
            tbNumber50.TabIndex = 24;
            tbNumber50.TextChanged += tbNumber50_TextChanged;
            // 
            // tbNumber100
            // 
            tbNumber100.Enabled = false;
            tbNumber100.Location = new Point(70, 211);
            tbNumber100.Name = "tbNumber100";
            tbNumber100.Size = new Size(67, 31);
            tbNumber100.TabIndex = 23;
            tbNumber100.TextChanged += tbNumber100_TextChanged;
            // 
            // tbNumber200
            // 
            tbNumber200.Enabled = false;
            tbNumber200.Location = new Point(70, 251);
            tbNumber200.Name = "tbNumber200";
            tbNumber200.Size = new Size(67, 31);
            tbNumber200.TabIndex = 22;
            tbNumber200.TextChanged += tbNumber200_TextChanged;
            // 
            // tbNumber500
            // 
            tbNumber500.Enabled = false;
            tbNumber500.Location = new Point(70, 291);
            tbNumber500.Name = "tbNumber500";
            tbNumber500.Size = new Size(67, 31);
            tbNumber500.TabIndex = 21;
            tbNumber500.TextChanged += tbNumber500_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 291);
            label10.Name = "label10";
            label10.Size = new Size(52, 25);
            label10.TabIndex = 20;
            label10.Text = "500€";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 251);
            label9.Name = "label9";
            label9.Size = new Size(52, 25);
            label9.TabIndex = 19;
            label9.Text = "200€";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 211);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 18;
            label8.Text = "100€";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 171);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 17;
            label7.Text = "50€";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 131);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 17;
            label6.Text = "20€";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 91);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 16;
            label5.Text = "10€";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 15;
            label4.Text = "5€";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 14;
            label3.Text = "number of:";
            // 
            // SelectMoney
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(panel2);
            Controls.Add(lbMoneySum);
            Controls.Add(panel1);
            Controls.Add(pMinus);
            Controls.Add(label2);
            Controls.Add(lbAccountBalance);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(label1);
            Name = "SelectMoney";
            Text = "SelectMoney";
            pMinus.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbAccountBalance;
        private Button btMinus5;
        private Label label2;
        private Panel pMinus;
        private Button btMinus500;
        private Button btMinus200;
        private Button btMinus100;
        private Button btMinus50;
        private Button btMinus20;
        private Button btMinus10;
        private Panel panel1;
        private Button btPlus500;
        private Button btPlus200;
        private Button btPlus100;
        private Button btPlus50;
        private Button btPlus20;
        private Button btPlus10;
        private Button btPlus5;
        private Label lbMoneySum;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbNumber5;
        private TextBox tbNumber10;
        private TextBox tbNumber20;
        private TextBox tbNumber50;
        private TextBox tbNumber100;
        private TextBox tbNumber200;
        private TextBox tbNumber500;
        private Label label10;
    }
}