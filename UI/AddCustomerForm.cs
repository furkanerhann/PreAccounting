using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        public string constring = "";

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            cb_currency.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string n = txtbox_customer.Text;
            string t = cb_type.SelectedItem.ToString();
            string c = cb_currency.SelectedItem.ToString();
            if (n != "" && t != "" && c != "")
            {
                string comstring = "INSERT INTO Customers (Müşteri, Müşteri_Türü, Bakiye, Bakiye_Türü) VALUES(@m, @mt, @b, @bt)";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand com = new SqlCommand(comstring, con))
                        {
                            com.Parameters.Add("@m", SqlDbType.NVarChar).Value = n;
                            com.Parameters.Add("@mt", SqlDbType.NVarChar).Value = t;
                            com.Parameters.Add("@b", SqlDbType.Decimal).Value = 0;
                            com.Parameters.Add("@bt", SqlDbType.NVarChar).Value = c;
                            int rowsAdded = com.ExecuteNonQuery();
                            if (rowsAdded > 0)
                            {
                                MainMenuForm f = new MainMenuForm();
                                f.constring = constring;
                                f.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hata!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata!\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenuForm f = new MainMenuForm();
            f.constring = constring;
            f.Show();
            this.Hide();
        }

        private void txtbox_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_type.Focus();
            }
        }

        private void cb_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_currency.Focus();
            }
        }

        private void cb_currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
            }
        }

        private void AddCustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
            }
        }
    }
}
