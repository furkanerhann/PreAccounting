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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        int target = 0;

        private void btn_target_Click(object sender, EventArgs e)
        {
            if (target == 0)
            {
                string server = txtbox_server.Text;
                string database = txtbox_database.Text;
                string username = txtbox_username.Text;
                string password = txtbox_password.Text;
                if (server != "" && database != "" && username != "" && password != "")
                {
                    string constring = @"Data Source= " + server + "; Initial Catalog= " + database + "; User ID = " + username + "; Password = " + password + ";";
                    SqlConnection con = new SqlConnection(constring);
                    try
                    {
                        con.Open();
                        con.Close();
                        MainMenuForm f = new MainMenuForm();
                        f.constring = constring;
                        f.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Bağlantı Kurulamadı! Lütfen girdiğiniz bilgileri kontrol edin!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bütün bilgileri doldurunuz!");
                }
            }
            else if (target == 1)
            {
                string server = txtbox_server.Text;
                string database = txtbox_database.Text;
                string username = txtbox_username.Text;
                string password = txtbox_password.Text;
                if (server != "" && database != "" && username != "" && password != "")
                {
                    string constring1 = @"Data Source= " + server + "; Initial Catalog= master; User ID = " + username + "; Password = " + password + ";";
                    SqlConnection con1 = new SqlConnection(constring1);
                    string comstring1 = "CREATE DATABASE " + database + ";";
                    SqlCommand com1 = new SqlCommand(comstring1, con1);
                    string constring2 = @"Data Source= " + server + "; Initial Catalog= " + database + "; User ID = " + username + "; Password = " + password + ";";
                    SqlConnection con2 = new SqlConnection(constring2);
                    string comstring2 = "CREATE TABLE Customers(Müşteri_Numarası int IDENTITY(1000,1) PRIMARY KEY, Müşteri varchar(255) NOT NULL,Müşteri_Türü varchar(25) NOT NULL,Bakiye decimal(18, 2) NOT NULL, Bakiye_Türü varchar(255) NOT NULL);";
                    SqlCommand com2 = new SqlCommand(comstring2, con2);
                    string comstring3 = "CREATE TABLE Operations(İşlem_Numarası int IDENTITY(1000,1) PRIMARY KEY, Müşteri_Numarası int NOT NULL, Tarih varchar(255) NOT NULL, Ürün varchar(255), Birim varchar(255), Birim_Fiyat decimal(18,2) NOT NULL, Adet int NOT NULL, Bakiye decimal(18,2) NOT NULL, Ödeme decimal(18,2) NOT NULL, Genel_Toplam decimal(18,2) NOT NULL);";
                    SqlCommand com3 = new SqlCommand(comstring3, con2);
                    try
                    {
                        con1.Open();
                        com1.ExecuteNonQuery();
                        con1.Close();
                        con2.Open();
                        com2.ExecuteNonQuery();
                        com3.ExecuteNonQuery();
                        con2.Close();
                        MessageBox.Show("Veri Tabanınız başarı ile oluşturuldu!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri Tabanı Oluşturulamadı!\n" + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir veritabanı adı giriniz!");
                }
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (target == 0)
            {
                target = 1;
                btn_target.Text = "Oluştur";
                btn_change.Text = "Giriş Yap";
            }
            else if (target == 1)
            {
                target = 0;
                btn_target.Text = "Bağlantı Kur";
                btn_change.Text = "Yeni Veri Tabanı Oluştur";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_target.PerformClick();
            }
        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_target.PerformClick();
            }
        }

        private void txtbox_server_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_database.Focus();
            }
        }

        private void txtbox_database_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_username.Focus();
            }
        }

        private void txtbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbox_password.Focus();
            }
        }
    }
}
