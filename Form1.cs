using POS_system.dbConnection;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using Timer = System.Windows.Forms.Timer;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System.Globalization;
using CSharpPrinting;

namespace POS_system

{


    public partial class Form1 : Form
    {
        string StoreName = "සෙනෙවිරත්න සුපර් සිද්දමුල්ල";
        string StoreAddress = "60/18, සිද්දමුල්ල, පිලියන්දල.\r\nඇමතුම් : 0112 701 056 / 0714 420 368";
        //  Image Img = Image.FromFile(@"c:\logo.jpg");
        string TransNo = "TCN10-20191204-001";
        string TransDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        //for item sales | untuk item penjualan
        DataTable dtItem;
        int[] arrWidth;
        StringFormat[] arrFormat;

        //'declaring printing format class
        PrintingFormat c = new PrintingFormat();

        //for subtotal & qty total
        double dblSubtotal = 0;
        double dblQty = 0;
        double dblPayment = 50000;
        public void Data_Load()
        {
            dtItem = new DataTable();
            {
                var withBlock = dtItem.Columns;
                withBlock.Add("itemname", Type.GetType("System.String"));
                withBlock.Add("qty", Type.GetType("System.String"));
                withBlock.Add("price", Type.GetType("System.String"));
            }

            DataRow ItemRow;

            ItemRow = dtItem.NewRow();
            ItemRow["itemname"] = "Taro Snack";
            ItemRow["qty"] = "1";
            ItemRow["price"] = "5000";
            dtItem.Rows.Add(ItemRow);

        }


        DBConnection db = new DBConnection();
        public Form1()
        {
            InitializeComponent();
            Fillcombobox();
            LoadData();
            FillcomboboxBill();
            LoadDataInventoryTable();
            // Form1_Load();
            GetSelectedData();
            LoadBillNo();





            txt_date_time.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_loose_date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_inventory_date.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_barcpde_scanned.Select();
            txt_barcpde_scanned.Focus();
            Loose_Items_panel.Visible = false;
            Inventory_panel.Visible = false;
            Bill_panel.Visible = true;
            txt_loose_avail_qty.ReadOnly = true;
            txt_avail_qty.ReadOnly = true;
            txt_unit_price.ReadOnly = true;
            txt_loose_avail_qty.ReadOnly = true;
            txt_loose_unit_price.ReadOnly = true;
            btn_normal_items.Visible = false;
            btn_loose_items.Visible = false;
            txt_discount.Text = "0";
            txt_loose_unit_dis.Text = "0";
            // InitTimer();
        }
        decimal payable = 0;//this is the total amount to be payed
        decimal tendered = 0;// this is the ammount presented to the cashier
        decimal balance = 0;// this is the change to be offerd to customer


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validte()
        {
            bool validte = true;
            return validte;
        }
        public void InitTimer()
        {

            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDataInventoryTable();
        }

        void Fillcombobox()
        {
            SqlConnection con = db.createConnection();

            con.Open();
            SqlCommand myCommand = new SqlCommand("select distinct Name From LooseItemNames", con);
            SqlDataReader Sdr = myCommand.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmb_name_main.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();


        }
        void LoadBillNo()
        {

            SqlConnection con = db.createConnection();
            con.Open();
            SqlCommand myCommand = new SqlCommand("select * from Bill ORDER BY BillNo ASC", con);
            SqlDataReader reader = myCommand.ExecuteReader();


            while (reader.Read())
            {
                // string result = Convert.ToString(reader.GetString(0));
                //txt_bill_no.Text = reader.GetString(0);
                string result = reader["BillNo"].ToString();
                int billno = Convert.ToInt32(result);
                int current_bill_no = billno + 1;
                string bill_no = Convert.ToString(current_bill_no);
                txt_bill_no.Text = bill_no;
            }


            reader.Close();
        }


        void FillcomboboxBill()
        {
            SqlConnection con = db.createConnection();

            con.Open();
            SqlCommand myCommand = new SqlCommand("select distinct Name_main From LooseItems", con);
            SqlDataReader Sdr = myCommand.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmb_search_loose_items.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();


        }
        void FillcomboboxStockId()
        {
            SqlConnection con = db.createConnection();

            con.Open();
            SqlCommand myCommand = new SqlCommand("select  stockId From Inventory where Name=@Name", con);
            myCommand.Parameters.AddWithValue("@Name", cmb_search_items.Text.ToString());
            SqlDataReader Sdr = myCommand.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmb_stock_id.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();


        }
        private void Form1_Load()
        {
            SqlConnection con = db.createConnection();
            con.Open();

            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Name_main,id FROM LooseItems", con))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Loop through the DataTable.
                foreach (DataRow row in dt.Rows)
                {
                    //Add Item to ListView.
                    ListViewItem item = new ListViewItem(row["Name_main"].ToString());
                    ListViewItem item2 = new ListViewItem(row["id"].ToString());

                    item.SubItems.Add(row["id"].ToString());
                    itemview.Items.Add(item);
                    itemview.Items.Add(item2);
                }

                itemview.View = View.List;
            }

        }

        private void LoadData()
        {
            SqlConnection con = db.createConnection();
            //con.Open();

            // MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=salesdb;sslMode=none");
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;


            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM LooseItems";
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["Name_main"].ToString());
                    listitem.SubItems.Add(dr["Name_category"].ToString());
                    listitem.SubItems.Add(dr["Barcode"].ToString());
                    listitem.SubItems.Add(dr["BuyingPrice"].ToString());

                    listitem.SubItems.Add(dr["SellingPrice"].ToString());
                    listitem.SubItems.Add(dr["discount"].ToString());

                    itemview.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void LoadDataInventoryTable()
        {
            listView2.Items.Clear();

            SqlConnection con = db.createConnection();
            //con.Open();

            // MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=salesdb;sslMode=none");
            SqlCommand cmd;
            SqlDataAdapter da;
            DataTable dt;


            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM Inventory";
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["id"].ToString());
                    listitem.SubItems.Add(dr["Name"].ToString());
                    listitem.SubItems.Add(dr["Barcode"].ToString());
                    listitem.SubItems.Add(dr["stockId"].ToString());
                    listitem.SubItems.Add(dr["BuyingPrice"].ToString());
                    listitem.SubItems.Add(dr["SellingPrice"].ToString());
                    listitem.SubItems.Add(dr["discount"].ToString());
                    listitem.SubItems.Add(dr["Quantity"].ToString());

                    listView2.Items.Add(listitem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void GetSelectedData()
        {
            SqlConnection con = db.createConnection();
            string sql = "SELECT * FROM Inventory";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_search_items.Items.Add(dr["Name"].ToString());
            }
            con.Close();



        }
        private void addItem()
        {
            lbl_warning_name.Visible = false;
            lbl_warning_barcode.Visible = false;


            if (validte() == true)
            {
                SqlConnection con = db.createConnection();
                con.Open();
                string query = "insert into Inventory(Name,stockId,Barcode,discount,BuyingPrice,SellingPrice,Quantity,Date) ";
                query += "values(@Name,@stockId,@Barcode,@discount,@BuyingPrice,@SellingPrice,@Quantity,@Date)";

                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@Name", txt_name.Text.ToString());
                myCommand.Parameters.AddWithValue("@stockId", txt_stock_id.Text.ToString());
                myCommand.Parameters.AddWithValue("@Barcode", txt_barcode.Text.ToString());
                myCommand.Parameters.AddWithValue("@discount", Convert.ToInt32(txt_inventory_discount.Text.ToString()));
                myCommand.Parameters.AddWithValue("@BuyingPrice", Convert.ToInt32(txt_buying_price.Text.ToString()));
                myCommand.Parameters.AddWithValue("@SellingPrice", Convert.ToInt32(txt_selling_price.Text.ToString()));
                myCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_quantity.Text.ToString()));
                myCommand.Parameters.AddWithValue("@Date", txt_date_time.Text.ToString());

                // ... other parameters
                int result = myCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Error While Inserting Data");
                }
                else
                {
                    MessageBox.Show("Successfully Added to stock!");
                }
                con.Close();



            }

        }
        private void AddItems()
        {
            if (validte() == true)
            {
                SqlConnection con = db.createConnection();
                con.Open();
                // string query = "INSERT INTO  LooseItems  Name_category=@Name_category,SKU=@SKU,Barcode=@Barcode,BuyingPrice=@BuyingPrice,SellingPrice=@SellingPrice,Quantity=@Quantity,Date=@Date WHERE Name_main=@Name_main ";
                string query = "insert into LooseItems(Name_main,Name_category,Barcode,BuyingPrice,SellingPrice,Quantity,Date,discount)";
                query += "values(@Name_main,@Name_category,@Barcode,@BuyingPrice,@SellingPrice,@Quantity,@Date,@discount)";


                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@Name_main", cmb_name_main.Text.ToString());
                myCommand.Parameters.AddWithValue("@Name_category", txt_category_name.Text.ToString());
                myCommand.Parameters.AddWithValue("@Barcode", txt_loose_barcode.Text.ToString());
                myCommand.Parameters.AddWithValue("@BuyingPrice", Convert.ToInt32(txt_loose_buying.Text.ToString()));
                myCommand.Parameters.AddWithValue("@SellingPrice", Convert.ToInt32(txt_loose_selling.Text.ToString()));
                myCommand.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_loose_qty.Text.ToString()));
                myCommand.Parameters.AddWithValue("@Date", txt_loose_date.Text.ToString());
                myCommand.Parameters.AddWithValue("@discount", txt_loose_disc.Text.ToString());
                // ... other parameters
                int result = myCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Error While Inserting Data");
                }
                else
                {
                    MessageBox.Show("Successfully Added to stock!");
                }
                con.Close();
                cmb_name_main.SelectedIndex = -1;
                txt_category_name.Clear();
                txt_loose_barcode.Clear();
                txt_loose_buying.Clear();
                txt_loose_selling.Clear();
                txt_loose_qty.Clear();
                txt_loose_disc.Clear();

            }
        }
        private void addLooseItems()
        {
            if (validte() == true)
            {
                SqlConnection con = db.createConnection();
                con.Open();
                string query = "insert into LooseItemNames(Name)";
                query += "values(@Name)";

                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@Name", txt_name_main.Text.ToString());

                // ... other parameters
                int result = myCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Error While Inserting Data");
                }
                else
                {
                    MessageBox.Show("Successfully Added to stock!");
                }
                con.Close();

            }
        }

        private void addBill()
        {
            if (validte() == true)
            {

                decimal tot_sel_price = 0;
                decimal tot_our_price = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    tot_sel_price += decimal.Parse(lstItem.SubItems[2].Text);
                    tot_our_price += decimal.Parse(lstItem.SubItems[3].Text);
                }
                decimal tot_profit = tot_sel_price - tot_our_price;

                SqlConnection con = db.createConnection();
                con.Open();
                String query = "insert into Bill (Total,Paid,Balance,Date_issued,tot_profit_customer)";
                query += "values (@Total,@Paid,@Balance,@Date_issued,@tot_profit_customer)";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.Parameters.AddWithValue("@Total", txt_tot.Text.ToString());
                myCommand.Parameters.AddWithValue("@Paid", txt_paid.Text.ToString());
                myCommand.Parameters.AddWithValue("@Balance", txt_balance.Text.ToString());
                myCommand.Parameters.AddWithValue("@Date_issued", txt_date_time.Text.ToString());
                myCommand.Parameters.AddWithValue("@tot_profit_customer", tot_profit.ToString());
                int result = myCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Error While Inserting Data");
                }
                else
                {
                    MessageBox.Show("Successfull!");
                }
                con.Close();



            }
        }


        public void GetTotDiscount()
        {

            decimal gottotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gottotal += decimal.Parse(lstItem.SubItems[4].Text);
            }

            txt_tot.Text = Convert.ToString(gottotal);
            // txt_tot.Text = sum.ToString();*/
        }
        private void checkduplicatesbarcode()
        {

        }

        private void changeColorOnbuttonClick(Button button3, Button button4)
        {

            button3.BackColor = Color.FromArgb(128, 128, 128);
            button4.BackColor = Color.FromArgb(30, 144, 255);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            changeColorOnbuttonClick(Inventory, Bill);
            Inventory_panel.Visible = true;
            Bill_panel.Visible = false;
            Loose_Items_panel.Visible = false;
            btn_normal_items.Visible = true;
            btn_loose_items.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeColorOnbuttonClick(Bill, Inventory);
            Inventory_panel.Visible = false;
            Bill_panel.Visible = true;
            Loose_Items_panel.Visible = false;
            btn_normal_items.Visible = false;
            btn_loose_items.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {





        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Bill_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            int sell_price = int.Parse(txt_selling_price.Text);
            int buy_price = int.Parse(txt_buying_price.Text);
            if (String.IsNullOrEmpty(txt_name.Text) || String.IsNullOrEmpty(txt_stock_id.Text) || String.IsNullOrEmpty(txt_barcode.Text) || String.IsNullOrEmpty(txt_inventory_discount.Text) || String.IsNullOrEmpty(txt_buying_price.Text) || String.IsNullOrEmpty(txt_selling_price.Text) || String.IsNullOrEmpty(txt_quantity.Text))
            {
                MessageBox.Show("PLEASE FILL ALL THE DETAILS!!!", "ERROR!!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sell_price < buy_price)
            {
                MessageBox.Show("SELLING PRICE SHOULD BE BIGGER THAN BUYING PRICE!!!", "ERROR!!",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = db.createConnection();
                con.Open();
                // lbl_warning_name.Visible = true;

                using (var sqlCommand = new SqlCommand("SELECT * FROM Inventory WHERE Name = '" + txt_name.Text + "'", con))
                {

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        lbl_warning_name.Visible = true;

                    }
                    else
                    {
                        check_barcode();


                    }

                    reader.Close();
                    reader.Dispose();
                }

                con.Close();
            }
        }

        private void check_barcode()
        {


            SqlConnection con = db.createConnection();
            con.Open();
            using (var sqlCommand = new SqlCommand("SELECT * FROM Inventory WHERE Barcode = '" + txt_barcode.Text + "'", con))
            {

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    lbl_warning_barcode.Visible = true;

                }
                else
                {
                    addItem();
                }

                reader.Close();
                reader.Dispose();
            }

            con.Close();




        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];
                txt_name.Text = item.SubItems[1].Text;
                txt_barcode.Text = item.SubItems[2].Text;
                txt_stock_id.Text = item.SubItems[3].Text;
                txt_buying_price.Text = item.SubItems[4].Text;
                txt_selling_price.Text = item.SubItems[5].Text;
                txt_quantity.Text = item.SubItems[6].Text;
                txt_inventory_discount.Text = item.SubItems[7].Text;
            }
            else
            {
                //EmpIDtextBox.Text = string.Empty;
                //EmpNametextBox.Text = string.Empty;
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Loose_Items_panel.Visible = true;
            Inventory_panel.Visible = false;
        }

        private void btn_normal_items_Click(object sender, EventArgs e)
        {
            Loose_Items_panel.Visible = false;
            Inventory_panel.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            addLooseItems();
            cmb_name_main.Items.Clear();
            Fillcombobox();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            int b_price = Convert.ToInt32(txt_loose_buying.Text);
            int s_price = Convert.ToInt32(txt_loose_selling.Text);

            if (cmb_name_main.SelectedIndex == -1 || String.IsNullOrEmpty(txt_category_name.Text) || String.IsNullOrEmpty(txt_loose_buying.Text) || String.IsNullOrEmpty(txt_loose_selling.Text) || String.IsNullOrEmpty(txt_loose_disc.Text))
            {
                MessageBox.Show("FIELDS CANNOT BE EMPTY", "WARNING",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (b_price > s_price)
                {
                    MessageBox.Show("SELLING PRICE SHOULD BE GREATER THAN BUYING PRICE", "WARNING",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    AddItems();
                }
            }



        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_item_id_TextChanged(object sender, EventArgs e)
        {
            txt_qty.Select();
            txt_qty.Focus();
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qtyOnEnter(Object sender, EventArgs eventArgs)
        {

        }
        private void txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                if (string.IsNullOrEmpty(cmb_search_items.Text) || string.IsNullOrEmpty(cmb_stock_id.Text) || string.IsNullOrEmpty(txt_avail_qty.Text) || string.IsNullOrEmpty(txt_unit_price.Text) || string.IsNullOrEmpty(txt_discount_default.Text) || string.IsNullOrEmpty(txt_discount.Text) || string.IsNullOrEmpty(txt_qty.Text))
                {

                    MessageBox.Show("FILL DETAILS!", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int avail_qty = Convert.ToInt32(txt_avail_qty.Text);
                    int qty = Convert.ToInt32(txt_qty.Text);
                    if (string.IsNullOrEmpty(txt_qty.Text))
                    {
                        MessageBox.Show("QUANTITY CANNOT BE EMPTY", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (qty > avail_qty)
                    {
                        MessageBox.Show("NOT ENOUGH ITEMS IN STOCK", "WARNING",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txt_discount.Select();
                        txt_discount.Focus();
                    }
                }

            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(cmb_search_items.Text) || string.IsNullOrEmpty(cmb_stock_id.Text) || string.IsNullOrEmpty(txt_avail_qty.Text) || string.IsNullOrEmpty(txt_unit_price.Text) || string.IsNullOrEmpty(txt_discount_default.Text) || string.IsNullOrEmpty(txt_discount.Text))
                {


                    MessageBox.Show("SELECT ITEM!", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int avail_qty = Convert.ToInt32(txt_avail_qty.Text);
                    int qty1 = Convert.ToInt32(txt_qty.Text);
                    if (string.IsNullOrEmpty(txt_qty.Text))
                    {
                        MessageBox.Show("QUANTITY CANNOT BE EMPTY", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (qty1 > avail_qty)
                    {
                        MessageBox.Show("NOT ENOUGH ITEMS IN STOCK", "WARNING",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double qty = double.Parse(txt_qty.Text);
                        double unitprice = double.Parse(txt_unit_price.Text);
                        double unit_dis = double.Parse(txt_discount.Text);
                        double dis_default = double.Parse(txt_discount_default.Text);

                        double tot_dis = unit_dis + dis_default;
                        double subtot = (unitprice - tot_dis) * qty;
                        txt_sub_tot.Text = subtot.ToString();
                        txt_sub_tot.Focus();
                        txt_sub_tot.Select();
                        GetSum();
                    }
                }
            }
        }
        public void GetSum()
        {

            decimal gottotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gottotal += decimal.Parse(lstItem.SubItems[4].Text);
            }

            txt_tot.Text = Convert.ToString(gottotal);
            // txt_tot.Text = sum.ToString();*/
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_date_time_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label38_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Data_Load();

            SendPrint.NewPrint();

            // SendPrint.Print(Img, 100, 50);

            //Setting Font
            SendPrint.SetFont("Courier New", 12, FontStyle.Bold);
       
            SendPrint.Print(StoreName); //Store Name | Nama Toko

            //Setting Font
            SendPrint.SetFont("Courier New", 9, FontStyle.Bold);
            //Store Address | Alamat Toko
            SendPrint.Print(StoreAddress + ";", new int[] { 280 }, 0);

            //spacing
            SendPrint.Print(" ");

            SendPrint.Print("බිල් අංකය : " + txt_bill_no.Text.ToString()); // Transaction No | Nomor transaksi
            SendPrint.Print("දිනය / වේලාව :" + TransDate); // Trans Date | Tanggal transaksi

            SendPrint.Print(" "); //spacing
            //Setting Font
            SendPrint.SetFont("Courier New", 11, FontStyle.Bold);
            //array for column width | array untuk lebar kolom
            arrWidth = new int[] { 90, 40, 50, 70 };
            //array alignment 
            arrFormat = new StringFormat[] { c.MidLeft, c.MidRight,
                                             c.MidRight, c.MidRight };

            //column header split by ; | nama kolom dipisah dengan ;
            SendPrint.Print("item;qty;price;subtotal", arrWidth, arrFormat);
            //Setting Font
            SendPrint.SetFont("Courier New", 11, FontStyle.Bold);
            SendPrint.Print("------------------------------------"); //line

            dblSubtotal = 0;
            dblQty = 0;
            //looping item sales | loop item penjualan
            for (int r = 0; r <= dtItem.Rows.Count - 1; r++)
            {
                SendPrint.Print(dtItem.Rows[r]["itemname"].ToString() +
                     ";" + dtItem.Rows[r]["qty"] + ";" +
                     dtItem.Rows[r]["price"] + ";" +
                     (double.Parse(dtItem.Rows[r]["qty"].ToString()) *
                      double.Parse(dtItem.Rows[r]["price"].ToString())),
                      arrWidth, arrFormat);
                dblQty = dblQty +
                         double.Parse(dtItem.Rows[r]["qty"].ToString());
                dblSubtotal = dblSubtotal +
                       (double.Parse(dtItem.Rows[r]["qty"].ToString())
                        * double.Parse(dtItem.Rows[r]["price"].ToString()
                        ));
            }

            SendPrint.Print("------------------------------------");
            arrWidth = new int[] { 130, 120 };
            //array for column width | array untuk lebar kolom
            arrFormat = new StringFormat[] { c.MidLeft, c.MidRight };
            //array alignment 

            SendPrint.Print("Total;" + dblSubtotal, arrWidth, arrFormat);
            SendPrint.Print("Payment;" + dblPayment, arrWidth, arrFormat);
            SendPrint.Print("------------------------------------");
            SendPrint.Print("Change;" +
                            (dblPayment - dblSubtotal).ToString(),
                            arrWidth, arrFormat);
            SendPrint.Print(" ");
            SendPrint.Print("Item Qty;" + dblQty, arrWidth, arrFormat);

            //Release the job for actual printing
            SendPrint.DoPrint();
        }





        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_search_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_stock_id.Items.Clear();
            cmb_stock_id.ResetText();
            FillcomboboxStockId();

        }

        public void loadDataInventory()
        {
            SqlConnection con = db.createConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE Name=@Name AND stockId = @stockId", con);
            cmd.Parameters.AddWithValue("@Name", cmb_search_items.Text);
            cmd.Parameters.AddWithValue("@stockId", cmb_stock_id.Text.ToString());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string unit_price = dr["SellingPrice"].ToString();
                string qty = dr["Quantity"].ToString();

                txt_avail_qty.Text = qty;
                txt_unit_price.Text = unit_price;
            }
            con.Close();

            txt_qty.Select();
            txt_qty.Focus();
        }

        private void txt_sub_tot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] row = { cmb_search_items.Text, txt_qty.Text, txt_unit_price.Text, };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                cmb_search_items.SelectedIndex = -1;
                cmb_search_items.Focus();
                cmb_search_items.Select();
                txt_avail_qty.Clear();
                txt_unit_price.Clear();
                txt_qty.Clear();
                txt_discount.Clear();

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_category.Items.Clear();
            SqlConnection con = db.createConnection();

            con.Open();
            SqlCommand myCommand = new SqlCommand("select distinct Name_category From LooseItems where Name_main=@Name_main", con);

            myCommand.Parameters.AddWithValue("@Name_main", cmb_search_loose_items.Text.ToString());
            SqlDataReader Sdr = myCommand.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmb_category.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            bill_loose_item_select();
        }

        public void bill_loose_item_select()
        {
            SqlConnection con = db.createConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LooseItems WHERE Name_main=@Name_main AND Name_category=@Name_category", con);
            cmd.Parameters.AddWithValue("@Name_main", cmb_search_loose_items.Text);
            cmd.Parameters.AddWithValue("@Name_category", cmb_category.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string unit_price = dr["SellingPrice"].ToString();
                string qty = dr["Quantity"].ToString();
                string disc = dr["discount"].ToString();

                txt_loose_avail_qty.Text = qty;
                txt_loose_unit_price.Text = unit_price;
                txt_loose_default_discount.Text = disc;
            }
            con.Close();

            txt_loos_qty.Select();
            txt_loos_qty.Focus();
        }


        private void button6_Click_2(object sender, EventArgs e)
        {
            LoadDataInventoryTable();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void cmb_stock_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            bill_inventory_add_item();
        }

        private void cmb_search_items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_stock_id.Focus();
                cmb_stock_id.Select();
            }
        }

        private void cmb_stock_id_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                bill_inventory_add_item();
            }
        }

        public void bill_inventory_add_item()
        {

            SqlConnection con = db.createConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE Name=@Name AND stockId=@stockId", con);
            cmd.Parameters.AddWithValue("@Name", cmb_search_items.Text);
            cmd.Parameters.AddWithValue("@stockId", cmb_stock_id.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string unit_price = dr["SellingPrice"].ToString();
                string qty = dr["Quantity"].ToString();
                string system_discount = dr["discount"].ToString();

                txt_avail_qty.Text = qty;
                txt_unit_price.Text = unit_price;
                txt_discount_default.Text = system_discount;
            }
            con.Close();
            txt_qty.Select();
            txt_qty.Focus();
        }

        private void txt_sub_tot_KeyDown_1(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(cmb_search_items.Text) || string.IsNullOrEmpty(cmb_stock_id.Text) || string.IsNullOrEmpty(txt_avail_qty.Text) || string.IsNullOrEmpty(txt_unit_price.Text) || string.IsNullOrEmpty(txt_discount_default.Text) || string.IsNullOrEmpty(txt_discount.Text) || string.IsNullOrEmpty(txt_qty.Text) || string.IsNullOrEmpty(txt_sub_tot.Text))
                {

                    MessageBox.Show("SELECT ITEM!", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int avail_qty1 = Convert.ToInt32(txt_avail_qty.Text);
                    int qty1 = Convert.ToInt32(txt_qty.Text);
                    if (string.IsNullOrEmpty(txt_qty.Text))
                    {
                        MessageBox.Show("QUANTITY CANNOT BE EMPTY", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (qty1 > avail_qty1)
                    {
                        MessageBox.Show("NOT ENOUGH ITEMS IN STOCK", "WARNING",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        int qty = Convert.ToInt32(txt_qty.Text);
                        int unitprice = Convert.ToInt32(txt_unit_price.Text);
                        int unit_dis = Convert.ToInt32(txt_discount.Text);
                        int dis_default = Convert.ToInt32(txt_discount_default.Text);
                        int avail_qty = Convert.ToInt32(txt_avail_qty.Text);
                        int updated_stock = avail_qty - qty;
                        int tot_dis = unit_dis - dis_default;
                        int our_price = unitprice - tot_dis;





                        SqlConnection con = db.createConnection();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Inventory SET Quantity=@Quantity  WHERE Name=@Name AND stockId =@stockId", con);
                        cmd.Parameters.AddWithValue("@Quantity", updated_stock.ToString());

                        cmd.Parameters.AddWithValue("@Name", cmb_search_items.Text);
                        cmd.Parameters.AddWithValue("@stockId", cmb_stock_id.Text);


                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Database Error!!");
                        }
                        else
                        {


                            string[] row = { cmb_search_items.Text, txt_qty.Text, txt_unit_price.Text, our_price.ToString(), txt_sub_tot.Text };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                            cmb_search_items.ResetText();
                            cmb_search_items.Focus();
                            cmb_search_items.Select();
                            cmb_stock_id.ResetText();
                            txt_avail_qty.Clear();
                            txt_unit_price.Clear();
                            txt_qty.Clear();
                            txt_sub_tot.Clear();
                            txt_discount.Text = "0";
                            txt_discount_default.Clear();
                            GetSum();
                        }


                        con.Close();
                    }
                }

            }
        }

        private void txt_loos_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                if (string.IsNullOrEmpty(cmb_search_loose_items.Text) || string.IsNullOrEmpty(cmb_category.Text) || string.IsNullOrEmpty(txt_loose_avail_qty.Text) || string.IsNullOrEmpty(txt_loose_unit_price.Text) || string.IsNullOrEmpty(txt_loose_default_discount.Text) || string.IsNullOrEmpty(txt_loose_unit_dis.Text) || string.IsNullOrEmpty(txt_loos_qty.Text))
                {

                    MessageBox.Show("SELECT ITEM!", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int avail_qty = Convert.ToInt32(txt_loose_avail_qty.Text);
                    int qty = Convert.ToInt32(txt_loos_qty.Text);
                    if (string.IsNullOrEmpty(txt_loos_qty.Text))
                    {
                        MessageBox.Show("QUANTITY CANNOT BE EMPTY", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (avail_qty < qty)
                    {
                        MessageBox.Show("NOT ENOUGH ITEMS ON THE STOCK!!", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txt_loose_unit_dis.Select();
                        txt_loose_unit_dis.Focus();
                    }
                }
            }
        }

        private void txt_loos_qty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_loose_unit_dis_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_loose_unit_dis_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_search_loose_items.Text) || string.IsNullOrEmpty(cmb_category.Text) || string.IsNullOrEmpty(txt_loose_avail_qty.Text) || string.IsNullOrEmpty(txt_loose_unit_price.Text) || string.IsNullOrEmpty(txt_loose_default_discount.Text))
            {

                MessageBox.Show("SELECT ITEM!", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    double qty = double.Parse(txt_loos_qty.Text);
                    double unitprice = double.Parse(txt_loose_unit_price.Text);
                    double unit_dis = double.Parse(txt_loose_unit_dis.Text);
                    double default_disc = double.Parse(txt_loose_default_discount.Text);

                    double disc_tot = unit_dis + default_disc;

                    double subtot = (unitprice - disc_tot) * qty;
                    txt_looseitems_sub_tot.Text = subtot.ToString();
                    txt_looseitems_sub_tot.Focus();
                    txt_looseitems_sub_tot.Select();

                }
            }
        }

        private void txt_looseitems_sub_tot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(cmb_search_loose_items.Text) || string.IsNullOrEmpty(cmb_category.Text) || string.IsNullOrEmpty(txt_loose_avail_qty.Text) || string.IsNullOrEmpty(txt_loose_unit_price.Text) || string.IsNullOrEmpty(txt_loose_default_discount.Text) || string.IsNullOrEmpty(txt_loose_unit_dis.Text) || string.IsNullOrEmpty(txt_loos_qty.Text) || string.IsNullOrEmpty(txt_looseitems_sub_tot.Text))
                {

                    MessageBox.Show("SELECT ITEM!", "WARNING",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int avail_qty1 = Convert.ToInt32(txt_loose_avail_qty.Text);
                    int qty1 = Convert.ToInt32(txt_loos_qty.Text); ;
                    if (string.IsNullOrEmpty(txt_loos_qty.Text))
                    {
                        MessageBox.Show("QUANTITY CANNOT BE EMPTY", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (qty1 > avail_qty1)
                    {
                        MessageBox.Show("NOT ENOUGH ITEMS IN STOCK", "WARNING",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        double qty = double.Parse(txt_loos_qty.Text);
                        double unitprice = double.Parse(txt_loose_unit_price.Text);
                        double unit_dis = double.Parse(txt_loose_unit_dis.Text);
                        double default_dis = double.Parse(txt_loose_default_discount.Text);
                        double avail_qty = double.Parse(txt_loose_avail_qty.Text);
                        double updated_stock = avail_qty - qty;
                        double tot_dis = default_dis + unit_dis;

                        double our_price = unitprice - tot_dis;
                        double subtot = (unitprice - tot_dis) * qty;


                        SqlConnection con = db.createConnection();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE LooseItems SET Quantity=@Quantity  WHERE Name_main=@Name_main AND Name_category =@Name_category", con);
                        cmd.Parameters.AddWithValue("@Quantity", updated_stock.ToString());

                        cmd.Parameters.AddWithValue("@Name_main", cmb_search_loose_items.Text);
                        cmd.Parameters.AddWithValue("@Name_category", cmb_category.Text);


                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Error While Inserting Data");
                        }
                        else
                        {

                            string[] row = { cmb_search_loose_items.Text, txt_loos_qty.Text, txt_loose_unit_price.Text, our_price.ToString(), txt_looseitems_sub_tot.Text };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                            cmb_search_loose_items.ResetText();
                            cmb_category.ResetText();
                            cmb_search_loose_items.Focus();
                            cmb_search_loose_items.Select();
                            txt_loose_avail_qty.Clear();
                            txt_loose_default_discount.Clear();
                            txt_loose_unit_dis.Clear();
                            txt_loos_qty.Clear();
                            txt_loose_unit_price.Clear();
                            txt_looseitems_sub_tot.Clear();
                            // cmb_category.SelectedIndex = -1;
                            txt_sub_tot.Clear();
                            txt_discount.Clear();
                            GetSum();
                        }
                        con.Close();
                    }
                }
            }
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            itemview.Items.Clear();
            LoadData();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }

        private void cmb_search_loose_items_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmb_category_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void cmb_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bill_loose_item_select();
            }
        }

        private void Inventory_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_barcode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_inventory_search.Text != "")
            {
                for (int i = listView2.Items.Count - 1; i >= 0; i--)
                {

                    var item = listView2.Items[i];
                    // if (item.Text.ToLower().Contains(txt_inventory_search.Text.ToLower()))
                    if (item.SubItems[1].Text.ToLower().Contains(txt_inventory_search.Text.ToLower()))
                    {
                        /* item.BackColor = SystemColors.Highlight;
                         item.ForeColor = SystemColors.HighlightText;*/
                    }
                    else
                    {
                        listView2.Items.Remove(item);
                    }
                }
                if (listView2.SelectedItems.Count == 1)
                {
                    listView2.Focus();
                }
            }
            else
            {
                LoadDataInventoryTable();
            }

        }

        private void btn_delete_item_Click(object sender, EventArgs e)
        {

            foreach (int i in listView2.SelectedIndices)
            {
                string test = listView2.Items[i].Text;
                listView2.Items.Remove(listView2.Items[i]);
                SqlCommand conn = new SqlCommand();
                conn.Connection = db.createConnection();
                string del = "delete from Inventory where id='" + test + "'";
                // int result = db.ExecuteAndReturn(del);
            }

        }

        private void txt_buying_price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_selling_price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_inventory_discount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                double tot = double.Parse(txt_tot.Text);
                double paid = double.Parse(txt_paid.Text);

                if (String.IsNullOrEmpty(txt_tot.Text))

                {
                    MessageBox.Show("PLEASE ADD ITEMS FIRST", "WARNING",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrEmpty(txt_paid.Text))
                {

                    MessageBox.Show("PLEASE ADD PAID AMOUNT", "WARNING",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double balance = paid - tot;
                    txt_balance.Text = balance.ToString();

                    addBill();
                    addBillItem();
                }

            }
        }
        private void addBillItem()
        {
            try
            {


                foreach (ListViewItem item in listView1.Items)
                {
                    SqlConnection con = db.createConnection();


                    SqlCommand myCommand = new SqlCommand("INSERT INTO Bill_Items (Item,Items_quantity,Total) VALUES (@Item,@Items_quantity,@Total)", con);

                    myCommand.Parameters.AddWithValue("@Item", item.SubItems[0].Text);
                    myCommand.Parameters.AddWithValue("@Items_quantity", item.SubItems[1].Text.Trim());
                    myCommand.Parameters.AddWithValue("@Total", item.SubItems[3].Text.Trim());
                    con.Open();
                    myCommand.ExecuteNonQuery();
                    con.Close();
                }

                // MessageBox.Show("success!!!");


                //   MessageBox.Show("Successfull!");

                listView1.Items.Clear();

                txt_tot.ResetText();
                txt_paid.ResetText();
                txt_balance.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_loose_unit_dis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_loos_qty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_sub_tot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        private void txt_looseitems_sub_tot_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            SqlConnection con = db.createConnection();

            con.Open();
            SqlCommand myCommand = new SqlCommand("select  stockId,Name From Inventory where Barcode=@Barcode", con);
            myCommand.Parameters.AddWithValue("@Barcode", txt_barcpde_scanned.Text.ToString());
            SqlDataReader Sdr = myCommand.ExecuteReader();
            while (Sdr.Read())
            {

                string Name = Sdr["Name"].ToString();



                cmb_search_items.Text = Name;
                cmb_stock_id.Focus();
                cmb_stock_id.Select();
                /*
                                   for (int i = 0;i< Sdr.FieldCount; i++)
                                    {
                                        cmb_stock_id.Items.Add(Sdr.GetString(i));
                                    }*/



            }
            con.Close();
        }

        private void txt_barcpde_scanned_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("welcome to senevirathne", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
    }
}

