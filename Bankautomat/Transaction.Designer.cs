﻿namespace Bankautomat
{
    partial class Transaction
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
            lbTransaction = new ListBox();
            SuspendLayout();
            // 
            // lbTransaction
            // 
            lbTransaction.FormattingEnabled = true;
            lbTransaction.ItemHeight = 25;
            lbTransaction.Location = new Point(12, 12);
            lbTransaction.Name = "lbTransaction";
            lbTransaction.Size = new Size(553, 229);
            lbTransaction.TabIndex = 0;
            lbTransaction.SelectedIndexChanged += lbTransaction_SelectedIndexChanged;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 260);
            Controls.Add(lbTransaction);
            Name = "Transaction";
            Text = "Transaction";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTransaction;
    }
}