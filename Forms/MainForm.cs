using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using MusteritakipApp.Models;

namespace MusteritakipApp
{
    public partial class MainForm : Form
    {
        private List<Customer> customers;

        public MainForm()
        {
            InitializeComponent();
            customers = new List<Customer>();
            RefreshCustomerList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var addCustomerForm = new AddCustomerForm())
            {
                if (addCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    customers.Add(addCustomerForm.Customer);
                    RefreshCustomerList();
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                var selectedCustomer = listViewCustomers.SelectedItems[0].Tag as Customer;
                if (selectedCustomer != null)
                {
                    var result = MessageBox.Show(
                        $"{selectedCustomer.Name} isimli müşteriyi silmek istediğinize emin misiniz?",
                        "Müşteri Silme",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        customers.Remove(selectedCustomer);
                        RefreshCustomerList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listViewCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                var selectedCustomer = listViewCustomers.SelectedItems[0].Tag as Customer;
                if (selectedCustomer != null)
                {
                    using (var detailForm = new CustomerDetailForm(selectedCustomer))
                    {
                        detailForm.ShowDialog();
                        RefreshCustomerList();
                    }
                }
            }
        }

        private void RefreshCustomerList()
        {
            listViewCustomers.Items.Clear();
            foreach (var customer in customers)
            {
                var item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.GetTotalDebit().ToString("C"));
                item.SubItems.Add(customer.GetTotalCredit().ToString("C"));
                item.SubItems.Add(customer.GetBalance().ToString("C"));
                item.Tag = customer;
                listViewCustomers.Items.Add(item);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Delete && listViewCustomers.Focused && listViewCustomers.SelectedItems.Count > 0)
            {
                btnDeleteCustomer_Click(this, EventArgs.Empty);
            }
        }
    }
}