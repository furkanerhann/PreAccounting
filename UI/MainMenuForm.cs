using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public string constring = "";
        public int customer_id = 0;
        public string customer_name = "";
        public string customer_type = "";
        public decimal customer_balance = 0;
        public string customer_currency = "";

        void getData(int type = 0, int currency = 0, int balance = 0, string search = "")
        {
            SqlConnection con = new SqlConnection(constring);
            string comstring = "SELECT * FROM Customers";
            if (type == 0 && currency == 0 && balance == 0 && search == "")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comstring, con);
                DataSet customerdata = new DataSet();
                da.Fill(customerdata, "Customers");
                dataview.DataSource = customerdata.Tables["Customers"];
                con.Close();
            }
            else
            {
                comstring += " WHERE ";
                int addand = 0;
                if (type != 0)
                {
                    if (type == 1)
                    {
                        comstring += "Müşteri_Türü = 'Müşteri'";
                    }
                    else if (type == 2)
                    {
                        comstring += "Müşteri_Türü = 'Tedarikçi'";
                    }
                    addand = 1;
                }
                if (currency != 0)
                {
                    if (addand == 1)
                    {
                        comstring += " AND ";
                    }
                    if (currency == 1)
                    {
                        comstring += "Bakiye_Türü = 'TL'";
                    }
                    else if (currency == 2)
                    {
                        comstring += "Bakiye_Türü = 'Dolar'";
                    }
                    else if (currency == 3)
                    {
                        comstring += "Bakiye_Türü = 'Euro'";
                    }
                    addand = 1;
                }
                if (balance != 0)
                {
                    if (addand == 1)
                    {
                        comstring += " AND ";
                    }
                    if (balance == 1)
                    {
                        comstring += "Bakiye > 0";
                    }
                    else if (balance == 2)
                    {
                        comstring += "Bakiye < 0";
                    }
                    addand = 1;
                }
                if (search != "")
                {
                    if (addand == 1)
                    {
                        comstring += " AND ";
                    }
                    comstring += "Müşteri LIKE '%" + search + "%'";
                }
                comstring += ";";
                con.Open();
                SqlCommand com = new SqlCommand(comstring, con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet customerdata = new DataSet();
                da.Fill(customerdata, "Customers");
                dataview.DataSource = customerdata.Tables["Customers"];
                con.Close();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            cb_balance.SelectedIndex = 0;
            cb_currency.SelectedIndex = 0;
            cb_type.SelectedIndex = 0;
            getData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int t = cb_type.SelectedIndex;
            int c = cb_currency.SelectedIndex;
            int b = cb_balance.SelectedIndex;
            string s = txtbox_search.Text;
            getData(type: t, currency: c, balance: b, search: s);
        }

        private void btn_operations_Click(object sender, EventArgs e)
        {
            if (customer_id != 0)
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
                MessageBox.Show("Lütfen öncelikle bir müşteri seçiniz!");
            }
        }

        private void btn_totalbalance_Click(object sender, EventArgs e)
        {
            int c = cb_currency.SelectedIndex;
            if (c == 0)
            {
                MessageBox.Show("Lütfen bir tane para birimi seçiniz!");
            }
            else
            {
                btn_search.PerformClick();
                int total = dataview.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));
                string currency = cb_currency.SelectedItem.ToString();
                string result = "Total Balance: " + currency + " " + total.ToString();
                MessageBox.Show(result);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddCustomerForm f = new AddCustomerForm();
            f.constring = constring;
            f.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (customer_id != 0)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    try
                    {
                        string comstring = "DELETE FROM Customers WHERE Müşteri_Numarası = " + customer_id + ";";
                        con.Open();
                        SqlCommand com = new SqlCommand(comstring, con);
                        com.ExecuteNonQuery();
                        btn_search.PerformClick();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata!\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir müşteri seçiniz!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                customer_id = Convert.ToInt32(dataview.CurrentRow.Cells[0].Value);
                customer_name = dataview.CurrentRow.Cells[1].Value.ToString();
                customer_type = dataview.CurrentRow.Cells[2].Value.ToString();
                customer_balance = Convert.ToDecimal(dataview.CurrentRow.Cells[3].Value);
                customer_currency = dataview.CurrentRow.Cells[4].Value.ToString();
                lbl_selected.Text = customer_id.ToString() + " - " + customer_name;
            }
            catch
            {
                MessageBox.Show("Müşteri Bulunamadı!");
            }
        }

        private void MainMenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void txtbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void cb_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void cb_currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void cb_balance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }
    }
}
