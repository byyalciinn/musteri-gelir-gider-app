using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusteritakipApp
{
    partial class CustomerDetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTransaction;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbDebit;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.ListView listViewTransactions;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotalDebit;
        private System.Windows.Forms.Label lblTotalCredit;
        private System.Windows.Forms.Label lblBalance;

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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbDebit = new System.Windows.Forms.RadioButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.listViewTransactions = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelTop.Size = new System.Drawing.Size(800, 74);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(275, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Müşteri Detayları";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnClose.Location = new System.Drawing.Point(747, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelTransaction
            // 
            this.panelTransaction.BackColor = System.Drawing.Color.White;
            this.panelTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransaction.Controls.Add(this.lblDate);
            this.panelTransaction.Controls.Add(this.dateTimePicker);
            this.panelTransaction.Controls.Add(this.lblAmount);
            this.panelTransaction.Controls.Add(this.txtAmount);
            this.panelTransaction.Controls.Add(this.rbCredit);
            this.panelTransaction.Controls.Add(this.rbDebit);
            this.panelTransaction.Controls.Add(this.lblDescription);
            this.panelTransaction.Controls.Add(this.txtDescription);
            this.panelTransaction.Controls.Add(this.btnAddTransaction);
            this.panelTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTransaction.Location = new System.Drawing.Point(0, 74);
            this.panelTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelTransaction.Size = new System.Drawing.Size(800, 222);
            this.panelTransaction.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDate.Location = new System.Drawing.Point(27, 25);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Tarih";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(27, 49);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(199, 32);
            this.dateTimePicker.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAmount.Location = new System.Drawing.Point(27, 98);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 23);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Tutar";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmount.Location = new System.Drawing.Point(27, 123);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(199, 32);
            this.txtAmount.TabIndex = 3;
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Checked = true;
            this.rbCredit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbCredit.Location = new System.Drawing.Point(240, 127);
            this.rbCredit.Margin = new System.Windows.Forms.Padding(4);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(80, 27);
            this.rbCredit.TabIndex = 4;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Alacak";
            // 
            // rbDebit
            // 
            this.rbDebit.AutoSize = true;
            this.rbDebit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rbDebit.Location = new System.Drawing.Point(347, 127);
            this.rbDebit.Margin = new System.Windows.Forms.Padding(4);
            this.rbDebit.Name = "rbDebit";
            this.rbDebit.Size = new System.Drawing.Size(65, 27);
            this.rbDebit.TabIndex = 5;
            this.rbDebit.Text = "Borç";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDescription.Location = new System.Drawing.Point(27, 172);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 23);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Açıklama";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.Location = new System.Drawing.Point(113, 166);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(505, 32);
            this.txtDescription.TabIndex = 7;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(633, 166);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(133, 33);
            this.btnAddTransaction.TabIndex = 8;
            this.btnAddTransaction.Text = "İŞLEM EKLE";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // listViewTransactions
            // 
            this.listViewTransactions.BackColor = System.Drawing.Color.White;
            this.listViewTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnAmount,
            this.columnDescription});
            this.listViewTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewTransactions.FullRowSelect = true;
            this.listViewTransactions.GridLines = true;
            this.listViewTransactions.HideSelection = false;
            this.listViewTransactions.Location = new System.Drawing.Point(0, 345);
            this.listViewTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTransactions.Name = "listViewTransactions";
            this.listViewTransactions.Size = new System.Drawing.Size(800, 270);
            this.listViewTransactions.TabIndex = 3;
            this.listViewTransactions.UseCompatibleStateImageBehavior = false;
            this.listViewTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Tarih";
            this.columnDate.Width = 100;
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Tutar";
            this.columnAmount.Width = 120;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Açıklama";
            this.columnDescription.Width = 360;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSummary.Controls.Add(this.lblTotalDebit);
            this.panelSummary.Controls.Add(this.lblTotalCredit);
            this.panelSummary.Controls.Add(this.lblBalance);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Location = new System.Drawing.Point(0, 296);
            this.panelSummary.Margin = new System.Windows.Forms.Padding(4);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(800, 49);
            this.panelSummary.TabIndex = 2;
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.AutoSize = true;
            this.lblTotalDebit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalDebit.Location = new System.Drawing.Point(27, 12);
            this.lblTotalDebit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(113, 23);
            this.lblTotalDebit.TabIndex = 0;
            this.lblTotalDebit.Text = "Toplam Borç: ";
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalCredit.Location = new System.Drawing.Point(267, 12);
            this.lblTotalCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(130, 23);
            this.lblTotalCredit.TabIndex = 1;
            this.lblTotalCredit.Text = "Toplam Alacak: ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(507, 12);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(69, 23);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Bakiye: ";
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.listViewTransactions);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelTransaction);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 615);
            this.Name = "CustomerDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Detayları";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelTransaction.ResumeLayout(false);
            this.panelTransaction.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}