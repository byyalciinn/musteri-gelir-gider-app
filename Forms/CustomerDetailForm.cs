using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using MusteritakipApp.Models;

namespace MusteritakipApp
{
    public partial class CustomerDetailForm : Form
    {
        private Customer customer;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public CustomerDetailForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.lblTitle.Text = $"Müşteri Detayları - {customer.Name}";
            this.panelTop.MouseDown += Panel_MouseDown;
            this.panelTop.MouseMove += Panel_MouseMove;
            this.panelTop.MouseUp += Panel_MouseUp;
            RefreshTransactionList();
            UpdateSummary();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbDebit.Checked) amount *= -1;

            var transaction = new Transaction
            {
                Date = dateTimePicker.Value,
                Amount = amount,
                Description = txtDescription.Text.Trim()
            };

            customer.Transactions.Add(transaction);
            RefreshTransactionList();
            UpdateSummary();
            ClearInputs();
        }

        private void RefreshTransactionList()
        {
            listViewTransactions.Items.Clear();
            foreach (var transaction in customer.Transactions.OrderByDescending(t => t.Date))
            {
                var item = new ListViewItem(transaction.Date.ToShortDateString());
                item.SubItems.Add(transaction.Amount.ToString("C"));
                item.SubItems.Add(transaction.Description);
                listViewTransactions.Items.Add(item);
            }
        }

        private void UpdateSummary()
        {
            lblTotalDebit.Text = $"Toplam Borç: {customer.GetTotalDebit():C}";
            lblTotalCredit.Text = $"Toplam Alacak: {customer.GetTotalCredit():C}";
            lblBalance.Text = $"Bakiye: {customer.GetBalance():C}";
        }

        private void ClearInputs()
        {
            txtAmount.Clear();
            txtDescription.Clear();
            dateTimePicker.Value = DateTime.Now;
            rbCredit.Checked = true;
            txtAmount.Focus();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private System.Windows.Forms.Button btnClose;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}