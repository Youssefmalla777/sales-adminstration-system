using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoice_programm
{
    public partial class frminvoice : Form
    {
        public frminvoice()
        {
            InitializeComponent();
        }

        private void frminvoice_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("hi there it is good to see you", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                this.Show();
            else
                this.Close();
            // this code explains how to show the date and the time into the txtdate..
            txtdate.Text = DateTime.Now.ToString();
            // here we explians how the form loads the items and its price by takin values..
            // the double for the price and the string for the item name.. 
            Dictionary<double, string> items = new Dictionary<double, string>();
            // add the items to combobox..
            
            items.Add(20, "ماوس عادس");
            items.Add(30, "ماوس gaming");
            items.Add(40, "كيبورد سلكي");
            items.Add(46, "كيبورد لاسلكي");
            items.Add(60, "هارد ssd 128");
            items.Add(70, "هارد ssd 256");
            items.Add(80, "هارد sdd 512");
            items.Add(100, "هارد ssd 1 TB");
            items.Add(45, "هارد hdd 128");
            items.Add(50, "هارد hdd 256");
            items.Add(65, "هارد hdd 512");
            items.Add(69, "هارد hdd 1 TB");
            items.Add(71.3, "سماعات wirless");
            items.Add(10, "سماعات سلكية");
            items.Add(5, "سماعات akj");
            items.Add(3.5, "لصقة كيبورد");
            items.Add(2000, "لابتوب dell");
            items.Add(1500, "لابتوب hp");
            items.Add(1000, "لابتوب asus");
            items.Add(1300, "لابتوب lenovo");
            items.Add(900, "لابتوب toshipa");
            items.Add(500, "لابتوب samsung");
            items.Add(90, "power pank");
            items.Add(2500, "لابتوب iphone");
            items.Add(300, "كاميرات مراقبة");
            items.Add(4000, "طابعة ايزرية");
            items.Add(30.2, "حقائب لابتوب");
            items.Add(1200, "طابعة ليزرية");
            items.Add(900.10, "طابعة حبر");
            items.Add(10.2, "كفرات حمابة");
            items.Add(6.9, "لصقات حماية");
            items.Add(50.2, "wifi power");
            items.Add(20.22, "بطارية لابتوب");
            items.Add(4.5, "قاعدة لابتوب");
            items.Add(400.20, "mother bord");
            items.Add(30.4, "سواقة خارجية");
            items.Add(55.4, "RAM 4GB");
            items.Add(58, "RAM 8GB");
            items.Add(60.6, "RAM 16GB");
            items.Add(68, "RAM 32GB");
            items.Add(12.3,"هارديسك خارجي");
            
            //showin the item name and its price..
            // one into the textbox and the other into the combobox
            // the datasource means the name of the item and its price..
            cbxtype.DataSource = new BindingSource(items, null);
            // showin the item name 
            cbxtype.DisplayMember = "value";
            // showin the item price..
            cbxtype.ValueMember = "key";
            // the next code explains when we run the programm .. the firts item showin like an array
            // the price and the name both of them..
            // so we put it here to avoid that ..so when we run the programm the form starts loadin so the first item isi not gonna show like that..
            txtprice.Text = cbxtype.SelectedValue.ToString();

            foreach(DataGridViewColumn d in dataGridView1.Columns)
            {
                dataGridView1.DefaultCellStyle.ForeColor = Color.Navy;
            }

            foreach(DataGridViewColumn f in dataGridView1.Columns)
            {
                dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Red;
                dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Red;
            }

            // when we get inside the programm get the textbox of the name and sign on it..
            //txtinvoice.SelectAll();  `  
            txtinvoice.Select();
            txtinvoice.Focus();
        }

        private void txtdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this code explains to not playing with the date and the time and edit it..
            e.Handled = true;
        }

        private void txtdate_MouseDown(object sender, MouseEventArgs e)
        {
            // this code expalins to not showin the contextmenustrip for pasting and coping the date and the time..
            // the event is about the right mouseclick by clickin it and not showin the contextmenustrip..
            if(e.Button == MouseButtons.Right)
            {
                txtdate.ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttotal_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                txttotal.ContextMenuStrip = new ContextMenuStrip();
            }
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            // this code explains how we get down step by step to textboxses..
            if(e.KeyData == Keys.Enter)
            {
                cbxtype.Focus();
            }
        }

        private void cbxtype_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtprice.Focus();
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtmount.Focus();
            }
        }

        private void txtmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txttotal.Focus();
            }
        }

        private void txttotal_KeyDown(object sender, KeyEventArgs e)
        {
            // this code explains how we excuate the printin order from add button..
            // after clickin at the enter button at the last one.. 
            if(e.KeyData == Keys.Enter)
            {
                btnadd.PerformClick();
                txtinvoice.Focus();
            }
        }

        private void txtmount_KeyUp(object sender, KeyEventArgs e)
        {
            // this code explains how we get above to the textboxses one by one..
            if(e.KeyData == Keys.Up)
            {
                txtprice.Focus();
            }
        }

        private void txtprice_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                cbxtype.Focus();
            }
        }

        private void cbxtype_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up)
            {
                txtname.Focus();
            }

        }

        private void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            // for showin the price inside the textbox of the price 
            // when we select the item .. it is gonna show with the name and the price..
            txtprice.Text = cbxtype.SelectedValue.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            foreach(Control s in this.Controls)
            {
                if(s is TextBox)
                {
                    if(s.Text == "")
                    {
                        MessageBox.Show("fill the textboxses first!!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            // this code explains if the combobox does not contain any one of the items that we alraedy add it..
            // so in this way get out of this condition..and do not excuate it.. 
            if (cbxtype.SelectedIndex <= -1)
            {
                MessageBox.Show("some thing going wrong!!..please try again","erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // define a variables form ddeffirent types ..
            string invoice = txtinvoice.Text;
            string name = txtname.Text;
            string type = cbxtype.Text;
            int mount = Convert.ToInt32(txtmount.Text);
            double price = Convert.ToDouble(txtprice.Text);
            // this code of the total event says the price multiplication the mount..
            double total = mount * price;
            // defien all the variables inside an array form type object call it data..
            object[] data = { invoice, name, type, mount, price, total };
            MessageBox.Show("the items are added!!", "invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // add all the data inside the array to the datagridview
            // and each one of it takes it place inside the datagridview..
            dataGridView1.Rows.Add(data);
            // this code explains how we count the total of the price and the mount 
            // and plus it together and show inside the textbox of the total
            // here where we can see the total sum of the items..
            txttotal.Text = Convert.ToDouble(txttotal.Text) + total + "";
            // this code is gonna show the data into the file of data.txt ..
            StreamWriter sr = new StreamWriter("data.txt",true);
            string strdata = txtinvoice.Text + "- "
                + txtdate.Text + "- "
                + txtname.Text + "- "
                + cbxtype.Text + "- "
                + txtprice.Text + "- "
                + txtmount.Text;
            sr.WriteLine(strdata);
            sr.Close();

        }

        private void txtinvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txtname.Focus();
            }
        }

        private void txtmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this code explains how we if log the letters and the spaces inside the mount textbox
            // in this way the fowlloing code is not gonna excute
            // is digit means loging the letters insted of numbers
            // iscontrol means loging the spaces inside the textbox..
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // this value from type string and it takes the value of the mount insdie the datagridview
        // and store it inside this variable 
        // define a variable from type string and it name is old .. 
        string old = "";
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // this condition says if the we edit the mount at the datagridview..
            // bring the last value back ..which means if we wrote anohter value except the numbers..
            // like the letters and anything else..
            if (dataGridView1.SelectedCells.Count > 0)
            {
                old = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // this event is after editing..
            if (dataGridView1.CurrentRow != null)
            {
                // take the new value that we add it and store it inside this variable
                string newm = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string newp = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                // thid code says if the inputing value inside the mount column was string or another thing 
                // in this way do not excute or bring the last value back
                if (!Regex.IsMatch(newm, "^\\d+$"))
                {
                    // bring the last value back inside the mount column..
                    dataGridView1.CurrentRow.Cells[3].Value = old;
                }
                else
                {
                    // if the first condition did not work go to this one 
                    // this code says if we edit the mount ..
                    // edit the total price automaticaly
                    // take the value inside the price column and convert it

                    // then take the value inside the mount column that we defined it inside the newm variable..the new value..
                    double p = Convert.ToDouble(newp);
                    double q = Convert.ToDouble(newm);
                    // then multiblict them and store the result inside the total column..
                    dataGridView1.CurrentRow.Cells[5].Value = (q*p);

                    // define a new variable from type int nad it equals 0..the first value..
                    double newtotal = 0;
                    // make a foreach loop for roundin around the datagridview1 into the rows 
                    // and sum the new value with the totalvalue inside the total column
                    // and store it into the txttotal textbox..to show all the total results..
                    foreach(DataGridViewRow d in dataGridView1.Rows)
                    {
                        newtotal += Convert.ToDouble(d.Cells[5].Value);
                        txttotal.Text = newtotal.ToString();
                    }
                    // this is gonna edit the value inside the txtmount textbox to the new one
                    txtmount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                }

            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // this code says if we had a character as letters or spaces..
            // in this way do not get it inside the textbox of the mount
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                txtinvoice.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // this code means if we edit the data inside the textboxese
            // in this way edit the data and store it inside the datagridview
            if (dataGridView1.SelectedCells.Count > 0)
            {
                MessageBox.Show("your data has been edited..", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.CurrentRow.Cells[0].Value = txtinvoice.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtname.Text;
                dataGridView1.CurrentRow.Cells[2].Value = cbxtype.Text;
                dataGridView1.CurrentRow.Cells[3].Value = txtmount.Text;
                dataGridView1.CurrentRow.Cells[4].Value = txtprice.Text;
                dataGridView1.CurrentRow.Cells[5].Value = txttotal.Text;
                // and after the storage we should edit the price and the mounts some times 
                // so we defined a variables from type double .. for the price and the mount 
                // and multiplicate them and store it inside the datagridview the total..
                double m = Convert.ToDouble(txtmount.Text);
                double p = Convert.ToDouble(txtprice.Text);
                dataGridView1.CurrentRow.Cells[5].Value = (p * m);

                // and every time we edit the price and the mount ..should we edit the total 
                // and store it indside the totals cell..
                double ntotal = 0;
                foreach (DataGridViewRow d in dataGridView1.Rows)
                {
                    ntotal += Convert.ToDouble(d.Cells[5].Value);
                    txttotal.Text = ntotal.ToString();
                }
                // empty the tetxboxses form all the data..
                txtinvoice.Text = "";
                txtname.Text = "";
                txtprice.Text = "";
                txtmount.Text = "";
                cbxtype.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // deletein the data that we wanna delete
            // by sign on the row that we wanna delete it ..
            // and after deletein the data..we should edit the total so it becomes less value..
            int mount = 0;
            for (int x=0;x<=dataGridView1.SelectedRows.Count;x++)
            {
                
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    foreach(DataGridViewRow d in dataGridView1.Rows)
                    {
                        mount = Convert.ToInt32(d.Cells[5].Value);
                        txttotal.Text = mount.ToString();
                    }
                }
            }

            txtinvoice.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtmount.Text = "";
            cbxtype.Text = "";
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            // this code means if we pointed at one of the data ..show it all inside the textboxses
            if (dataGridView1.SelectedCells.Count > 0)
                txtinvoice.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxtype.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmount.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void txtname_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                txtname.ContextMenu = new ContextMenu();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            // this code for printin the file that we wanna print..like the price and the mount and totalprice..
            // the other codes for takin the properities of the main form and do it here..
            // like the icon and topmost and the other thing..
            ((Form)printPreviewDialog1).AutoSize = true;
            ((Form)printPreviewDialog1).AutoScroll = true;
            ((Form)printPreviewDialog1).Icon = this.Icon;
            ((Form)printPreviewDialog1).TopMost = true;
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // thIs code for dropin the image inside the project..the far of the x and y and the width and the height
            e.Graphics.DrawImage(Properties.Resources.pexels_life_of_pix_7974, 5, 5, 300, 200);
            // define a variable from type int for controlin in the exstinsions of the columns and the texts..
            int margin = 40;
            // this code for contrloin in the senteances by it is color and size
            Font f = new Font("arial", 17, FontStyle.Bold);
            // define a variable from type string and it takes the strinvoice value..
            string strinvoice = "#ON " + txtinvoice.Text;
            // like the last code but it takes another value .. the date value.. 
            string strdate = "التاريخ: " + txtdate.Text;
            // like the last code but it takes the name value..
            string strname = "المطلوب من السيد/ة: " + txtname.Text;

            // this code explians how we control in the size of the variable ..the invoice number size
            SizeF fontinvoice = e.Graphics.MeasureString(strinvoice, f);
            // this code explains how we control in the size of the varibale ..the date size..
            SizeF fontdate = e.Graphics.MeasureString(strdate, f);
            // this code explains how we control in the size of the varibale.. the name size..
            SizeF fontname = e.Graphics.MeasureString(strname, f);


            // printin the strinvoice in the middle by subtarcting the width of the printpreviewdialog(pagepound)
            // with the strinvoice and devided on 2 .. and it is height equlas the margin subtaract 30
            // to be written Under the top of the pagepound..
            e.Graphics.DrawString(strinvoice, f, Brushes.Red, (e.PageBounds.Width - fontinvoice.Width) / 2, margin-30);
            // this code says write the date of the bill and location it 
            // the width of the page multiblict the width of the strdate ..and for the height..
            // put the strdate under the strinvoice..plusing the margin to the fontinvoice for the height..
            e.Graphics.DrawString(strdate, f, Brushes.Black, e.PageBounds.Width - fontdate.Width+44 , margin + fontinvoice.Height);
            // the same last code for the next one with more heights ..
            e.Graphics.DrawString(strname, f, Brushes.Black, e.PageBounds.Width - fontname.Width+5, margin + fontinvoice.Height + fontdate.Height);

            // define a variable from type float and it equals the last all heights..
            float preheights = margin + fontinvoice.Height + fontdate.Height + fontname.Height;
            // drawin the whole rectengle of the box that we wanna add the materials inside it..
            e.Graphics.DrawRectangle(Pens.Black, margin, preheights+100, e.PageBounds.Width - margin *2, e.PageBounds.Height - margin - preheights-80);
            float colheight = 150;
            // the width size of each one of the columns
            float col1width = 200;
            // the second column equals the first one add to 125..for the far between the columns.. 
            float col2width = 125 + col1width;
            // like the last code.. 
            float col3width = 125 + col2width;
            float col4width = 125 + col3width;
            // drawin the line between the material names and the other of it..
            e.Graphics.DrawLine(Pens.Black, margin, preheights + colheight, e.PageBounds.Width - margin, preheights + colheight);

            e.Graphics.DrawString("الصنف", f, Brushes.Black, e.PageBounds.Width - margin*2  - col1width+100, preheights+115);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preheights+100, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin+20);

            e.Graphics.DrawString("الكمية", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width+40, preheights + 115);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preheights + 100, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin + 20);

            e.Graphics.DrawString("السعر", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width+40, preheights + 115);
            e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preheights + 100, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin+20);

            e.Graphics.DrawString("الأجمالي الفرعي", f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width-75, preheights + 115);

            float rowheight = 60;

            for(int d=0;d<dataGridView1.Rows.Count;d+=1)
            {
                e.Graphics.DrawString(dataGridView1.Rows[d].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin*2-115 , preheights + rowheight + 95);
                e.Graphics.DrawString(dataGridView1.Rows[d].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - 265, preheights + rowheight + 95);
                e.Graphics.DrawString(dataGridView1.Rows[d].Cells[4].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - 395, preheights + rowheight + 95);
                e.Graphics.DrawString(dataGridView1.Rows[d].Cells[5].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - 610, preheights + rowheight + 95);

                e.Graphics.DrawLine(Pens.Black, margin, preheights + rowheight + colheight-20, e.PageBounds.Width - margin, preheights + rowheight + colheight-20);
                rowheight += 60;
            }
        }
    }
}
