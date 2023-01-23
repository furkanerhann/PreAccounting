using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddOperationForm : Form
    {
        public AddOperationForm()
        {
            InitializeComponent();
        }
        public string constring = "";
        public int customer_id = 0;
        public string customer_name = "";
        public string customer_type = "";
        public decimal customer_balance = 0;
        public string customer_currency = "";
        private void AddOperationForm_Load(object sender, EventArgs e)
        {
            cb_day.SelectedIndex = 0;
            cb_month.SelectedIndex = 0;
            cb_year.SelectedIndex = 0;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try{
                string day = cb_day.Text;
                string month = cb_month.Text;
                string year = cb_year.Text;
                string product = txtbox_product.Text;
                string measure = txtbox_measure.Text;
                decimal price = Convert.ToDecimal(txtbox_price.Text.Replace(".", ","));
                int nop = Convert.ToInt32(txtbox_nop.Text);
                decimal totalprice = price * nop;
                decimal payment = Convert.ToDecimal(txtbox_payment.Text.Replace(".", ","));
                decimal financalimpact = payment - totalprice;
                if (customer_type == "Tedarikci")
                {
                    financalimpact *= -1;
                }
                if (day != "Gün" && month != "Ay" && year != "Yıl")
                {
                    string date = day + "." + month + "." + year;
                    string comstring = "INSERT INTO Operations (Müşteri_Numarası, Tarih, Ürün, Birim, Birim_Fiyat, Adet, Bakiye, Ödeme, Genel_Toplam) VALUES(@cid, @d, @pr, @prt, @prp, @nop, @tp, @p, @fi)";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            using (SqlCommand com = new SqlCommand(comstring, con))
                            {
                                com.Parameters.Add("@cid", SqlDbType.Int).Value = customer_id;
                                com.Parameters.Add("@d", SqlDbType.NVarChar).Value = date;
                                com.Parameters.Add("@pr", SqlDbType.NVarChar).Value = product;
                                com.Parameters.Add("@prt", SqlDbType.NVarChar).Value = measure;
                                com.Parameters.Add("@prp", SqlDbType.Decimal).Value = price;
                                com.Parameters.Add("@nop", SqlDbType.Int).Value = nop;
                                com.Parameters.Add("@tp", SqlDbType.Decimal).Value = totalprice;
                                com.Parameters.Add("@p", SqlDbType.Decimal).Value = payment;
                                com.Parameters.Add("@fi", SqlDbType.Decimal).Value = financalimpact;
                                customer_balance = Convert.ToDecimal(OperationClass.updateBalance(constring, customer_id, financalimpact, current_balance: customer_balance));
                                int rowsAdded = com.ExecuteNonQuery();
                                if (rowsAdded > 0)
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

        private void cb_day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_month.Focus();
            }
        }

        private void cb_month_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cb_year.Focus();
            }
        }

        private void cb_year_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_product.Focus();
            }
        }

        private void txtbox_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_measure.Focus();
            }
        }

        private void txtbox_measure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_price.Focus();
            }
        }

        private void txtbox_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_nop.Focus();
            }
        }

        private void txtbox_nop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_payment.Focus();
            }
        }

        private void txtbox_payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
            }
        }

        private void AddOperationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.PerformClick();
            }
        }
    }
}
