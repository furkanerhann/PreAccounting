using Core;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;

namespace UI
{
    public partial class CustomerMenuForm : Form
    {
        public CustomerMenuForm()
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

        void getData(int date = 0, int balance = 0)
        {
            SqlConnection con = new SqlConnection(constring);
            string comstring = "SELECT İşlem_Numarası, Tarih, Ürün, Birim, Birim_Fiyat, Adet, Bakiye, Ödeme, Genel_Toplam FROM Operations WHERE Müşteri_Numarası = " + customer_id;
            if (date == 0 && balance == 0)
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comstring, con);
                DataSet operationdata = new DataSet();
                da.Fill(operationdata, "Operations");
                dataview.DataSource = operationdata.Tables["Operations"];
                con.Close();
            }
            else
            {
                comstring += " AND ";
                int addand = 0;
                if (date != 0)
                {
                    comstring += "Tarih LIKE '%" + date + "%'";
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
                        comstring += "Genel_Toplam < 0";
                    }
                    else if (balance == 2)
                    {
                        comstring += "Genel_Toplam > 0";
                    }
                    addand = 1;
                }
                comstring += ";";
                con.Open();
                SqlCommand com = new SqlCommand(comstring, con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet operationdata = new DataSet();
                da.Fill(operationdata, "Operations");
                dataview.DataSource = operationdata.Tables["Operations"];
                con.Close();
            }
        }
        private void CustomerMenuForm_Load(object sender, EventArgs e)
        {
            cb_date.SelectedIndex = 0;
            cb_balance.SelectedIndex = 0;
            lbl_customer.Text = customer_name;
            lbl_balance.Text = customer_balance.ToString() + " " + customer_currency;
            getData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int d = cb_date.SelectedIndex;
            if (d != 0)
            {
                d = Convert.ToInt32(cb_date.Text);
            }
            int b = cb_balance.SelectedIndex;
            getData(date: d, balance: b);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            CustomerSettingsForm f = new CustomerSettingsForm();
            f.constring = constring;
            f.customer_id = customer_id;
            f.customer_name = customer_name;
            f.customer_type = customer_type;
            f.customer_balance = customer_balance;
            f.customer_currency = customer_currency;
            f.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddOperationForm f = new AddOperationForm();
            f.constring = constring;
            f.customer_id = customer_id;
            f.customer_name = customer_name;
            f.customer_type = customer_type;
            f.customer_balance = customer_balance;
            f.customer_currency = customer_currency;
            f.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (op_id != 0)
            {
                UpdateOperationForm f = new UpdateOperationForm();
                f.constring = constring;
                f.customer_id = customer_id;
                f.customer_name = customer_name;
                f.customer_type = customer_type;
                f.customer_balance = customer_balance;
                f.customer_currency = customer_currency;
                f.op_id = op_id;
                f.op_date = op_date;
                f.op_product = op_product;
                f.op_measure = op_measure;
                f.op_price = op_price;
                f.op_nop = op_nop;
                f.op_totalprice = op_totalprice;
                f.op_payment = op_payment;
                f.op_financalimpact = op_financalimpact;
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen öncelikle geçerli bir işlem seçiniz!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (op_id != 0)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    try
                    {
                        string comstring = "DELETE FROM Operations WHERE İşlem_Numarası = " + op_id + ";";
                        con.Open();
                        SqlCommand com = new SqlCommand(comstring, con);
                        com.ExecuteNonQuery();
                        lbl_balance.Text = OperationClass.updateBalance(constring, customer_id, (-1 * op_financalimpact), current_balance: customer_balance);
                        customer_balance = Convert.ToDecimal(lbl_balance.Text);
                        btn_search.PerformClick();
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
            MainMenuForm f = new MainMenuForm();
            f.constring = constring;
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
                op_id = Convert.ToInt32(dataview.CurrentRow.Cells[0].Value);
                op_date = dataview.CurrentRow.Cells[1].Value.ToString();
                op_product = dataview.CurrentRow.Cells[2].Value.ToString();
                op_measure = dataview.CurrentRow.Cells[3].Value.ToString();
                op_price = Convert.ToDecimal(dataview.CurrentRow.Cells[4].Value);
                op_nop = Convert.ToInt32(dataview.CurrentRow.Cells[5].Value);
                op_totalprice = Convert.ToDecimal(dataview.CurrentRow.Cells[6].Value);
                op_payment = Convert.ToDecimal(dataview.CurrentRow.Cells[7].Value);
                op_financalimpact = Convert.ToDecimal(dataview.CurrentRow.Cells[8].Value);
                lbl_selected.Text = "Seçili İşlem No: " + op_id.ToString();
            }
            catch
            {
                MessageBox.Show("İşlem Bulunamadı!");
            }
        }

        private void CustomerMenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void cb_date_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (dataview.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font1 = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font font3 = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font font4 = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Hata!\n" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataview.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataview.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText.Replace("_", " "), font3));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataview.Rows)
                            {
                                foreach (DataGridViewCell rowcell in row.Cells)
                                {
                                    if (rowcell.Value == null)
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(" ", font3));
                                        pdfTable.AddCell(cell);
                                    }
                                    else
                                    {
                                        PdfPCell cell = new PdfPCell(new Phrase(rowcell.Value.ToString(), font3));
                                        pdfTable.AddCell(cell);
                                    }
                                }
                            }
                            
                            Paragraph p0 = new Paragraph(new Chunk("          ", font3));
                            p0.Alignment = Element.ALIGN_CENTER;
                            Paragraph p1 = new Paragraph(new Chunk("Markam", font1));
                            p1.Alignment = Element.ALIGN_CENTER;
                            Paragraph p2 = new Paragraph(new Chunk("cari hesap ekstresi", font4));
                            p2.Alignment = Element.ALIGN_CENTER;
                            Paragraph p3 = new Paragraph(new Chunk("Tel: +90 500 000 00 00     -     Mail: markam@gmail.com     -     WebSite: markam.com", font3));
                            p3.Alignment = Element.ALIGN_CENTER;
                            Paragraph p4 = new Paragraph(new Chunk(customer_name, font2));
                            p4.Alignment = Element.ALIGN_LEFT;
                            Paragraph p5 = new Paragraph(new Chunk("Bakiye: " + customer_balance.ToString(), font2));
                            p5.Alignment = Element.ALIGN_RIGHT;
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(p1);
                                pdfDoc.Add(p2);
                                pdfDoc.Add(p3);
                                pdfDoc.Add(p4);
                                pdfDoc.Add(p0);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(p0);
                                pdfDoc.Add(p5);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dosya Başarı ile kaydedildi!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata!\n" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce işlem ekleyiniz", "Info");
            }
        }
    }
}
