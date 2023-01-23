using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerSettingsForm : Form
    {
        public CustomerSettingsForm()
        {
            InitializeComponent();
        }
        public string constring = "";
        public int customer_id = 0;
        public string customer_name = "";
        public string customer_type = "";
        public decimal customer_balance = 0;
        public string customer_currency = "";
        private void CustomerSettingsForm_Load(object sender, EventArgs e)
        {
            txtbox_customer.Text = customer_name;
            if(customer_type == "Müşteri")
            {
                cb_type.SelectedIndex = 0;
            }
            else if(customer_type == "Tedarikçi")
            {
                cb_type.SelectedIndex = 1;
            }
            if(customer_currency == "TL")
            {
                cb_currency.SelectedIndex = 0;
            }
            else if (customer_currency == "Dolar")
            {
                cb_currency.SelectedIndex = 1;
            }
            else if (customer_currency == "Euro")
            {
                cb_currency.SelectedIndex = 2;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = txtbox_customer.Text;
                string t = cb_type.Text;
                string cr = cb_currency.Text;
                if (cs != "")
                {
                    string comstring = "UPDATE Customers SET Müşteri = @cs, Müşteri_Türü = @t, Bakiye_Türü = @cr WHERE Müşteri_Numarası = " + customer_id + ";";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            using (SqlCommand com = new SqlCommand(comstring, con))
                            {
                                com.Parameters.Add("@cs", SqlDbType.NVarChar).Value = cs;
                                com.Parameters.Add("@t", SqlDbType.NVarChar).Value = t;
                                com.Parameters.Add("@cr", SqlDbType.NVarChar).Value = cr;
                                int rowsAdded = com.ExecuteNonQuery();
                                if (rowsAdded > 0)
                                {
                                    CustomerMenuForm f = new CustomerMenuForm();
                                    f.constring = constring;
                                    f.customer_id = customer_id;
                                    f.customer_name = cs;
                                    f.customer_type = t;
                                    f.customer_balance = customer_balance;
                                    f.customer_currency = cr;
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
                    MessageBox.Show("Lütfen geçerli bir tarih seçiniz!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı Girdi:\n" + ex);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CustomerMenuForm f = new CustomerMenuForm();
            f.constring = constring;
            f.customer_id = customer_id;
            f.customer_name = customer_name;
            f.customer_type = customer_type;
            f.customer_balance = customer_balance;
            f.customer_currency = customer_currency;
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
                btn_save.PerformClick();
            }
        }
    }
}
