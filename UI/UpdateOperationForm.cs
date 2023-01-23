using Core;
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
    public partial class UpdateOperationForm : Form
    {
        public UpdateOperationForm()
        {
            InitializeComponent();
        }
        public string constring = "";
        public int customer_id = 0;
        public string customer_name = "";
        public string customer_type = "";
        public decimal customer_balance = 0;
        public string customer_currency = "";
        public int op_id = 0;
        public string op_date = "";
        public string op_product = "";
        public string op_measure = "";
        public decimal op_price = 0;
        public int op_nop = 0;
        public decimal op_totalprice = 0;
        public decimal op_payment = 0;
        public decimal op_financalimpact = 0;

        private void UpdateOperationForm_Load(object sender, EventArgs e)
        {
            string day = op_date.Substring(0, 2);
            string month = op_date.Substring(3, 2);
            string year = op_date.Substring(6, 4);
            cb_day.SelectedIndex = Convert.ToInt32(day);
            cb_month.SelectedIndex = Convert.ToInt32(month);
            cb_year.SelectedIndex = (Convert.ToInt32(year) - 2019);
            txtbox_product.Text = op_product;
            txtbox_measure.Text = op_measure;
            txtbox_price.Text = op_price.ToString();
            txtbox_nop.Text = op_nop.ToString();
            txtbox_payment.Text = op_payment.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
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
                    string comstring = "UPDATE Operations SET Tarih = @d, Ürün = @prd, Birim = @m, Birim_Fiyat = @prc, Adet = @nop, Bakiye = @tp, Ödeme = @p, Genel_Toplam = @fi WHERE İşlem_Numarası = " + op_id + ";";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        try
                        {
                            con.Open();
                            using (SqlCommand com = new SqlCommand(comstring, con))
                            {
                                com.Parameters.Add("@d", SqlDbType.NVarChar).Value = date;
                                com.Parameters.Add("@prd", SqlDbType.NVarChar).Value = product;
                                com.Parameters.Add("@m", SqlDbType.NVarChar).Value = measure;
                                com.Parameters.Add("@prc", SqlDbType.Decimal).Value = price;
                                com.Parameters.Add("@nop", SqlDbType.Int).Value = nop;
                                com.Parameters.Add("@tp", SqlDbType.Decimal).Value = totalprice;
                                com.Parameters.Add("@p", SqlDbType.Decimal).Value = payment;
                                com.Parameters.Add("@fi", SqlDbType.Decimal).Value = financalimpact;
                                customer_balance = Convert.ToDecimal(OperationClass.updateBalance(constring, customer_id, financalimpact, old_balance: op_financalimpact, current_balance: customer_balance));
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
                btn_update.PerformClick();
            }
        }

        private void UpdateOperationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_update.PerformClick();
            }
        }
    }
}
