using System;
using System.Drawing;
using System.Windows.Forms;
using MusteritakipApp.Models;

namespace MusteritakipApp
{
    public partial class AddCustomerForm : Form
    {
        public Customer Customer { get; private set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public AddCustomerForm()
        {
            InitializeComponent();
            this.panelTop.MouseDown += Panel_MouseDown;
            this.panelTop.MouseMove += Panel_MouseMove;
            this.panelTop.MouseUp += Panel_MouseUp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen müşteri adını giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer = new Customer
            {
                Name = txtName.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
    }
}