namespace POS_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SidePanel = new Panel();
            label1 = new Label();
            Bill = new Button();
            Inventory = new Button();
            Close = new Button();
            Inventory_panel = new Panel();
            txt_inventory_search = new TextBox();
            panel3 = new Panel();
            label45 = new Label();
            txt_name = new TextBox();
            lbl_warning_barcode = new Label();
            label30 = new Label();
            label14 = new Label();
            txt_inventory_discount = new TextBox();
            lbl_warning_name = new Label();
            txt_stock_id = new TextBox();
            label15 = new Label();
            txt_barcode = new TextBox();
            label16 = new Label();
            txt_quantity = new TextBox();
            label18 = new Label();
            txt_buying_price = new TextBox();
            txt_selling_price = new TextBox();
            label17 = new Label();
            label19 = new Label();
            button7 = new Button();
            button6 = new Button();
            label22 = new Label();
            btn_update_item = new Button();
            btn_delete_item = new Button();
            btn_add_item = new Button();
            label21 = new Label();
            listView2 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            label20 = new Label();
            txt_inventory_date = new TextBox();
            Loose_Items_panel = new Panel();
            label48 = new Label();
            txt_loose_disc = new TextBox();
            button4 = new Button();
            cmb_name_main = new ComboBox();
            label33 = new Label();
            button5 = new Button();
            label23 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label24 = new Label();
            itemview = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Category = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            label25 = new Label();
            txt_loose_date = new TextBox();
            label26 = new Label();
            txt_loose_qty = new TextBox();
            label27 = new Label();
            txt_loose_selling = new TextBox();
            label28 = new Label();
            txt_loose_buying = new TextBox();
            label29 = new Label();
            txt_loose_barcode = new TextBox();
            label31 = new Label();
            txt_category_name = new TextBox();
            label32 = new Label();
            txt_name_main = new TextBox();
            Bill_panel = new Panel();
            txt_barcpde_scanned = new TextBox();
            txt_discount_default = new TextBox();
            label46 = new Label();
            txt_sub_tot = new TextBox();
            cmb_stock_id = new ComboBox();
            label13 = new Label();
            txt_avail_qty = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label47 = new Label();
            txt_loose_default_discount = new TextBox();
            txt_looseitems_sub_tot = new TextBox();
            cmb_category = new ComboBox();
            label44 = new Label();
            txt_loose_avail_qty = new TextBox();
            cmb_search_loose_items = new ComboBox();
            label43 = new Label();
            label42 = new Label();
            label39 = new Label();
            label36 = new Label();
            label41 = new Label();
            txt_loose_unit_price = new TextBox();
            txt_loos_qty = new TextBox();
            label37 = new Label();
            label40 = new Label();
            txt_loose_unit_dis = new TextBox();
            label35 = new Label();
            txt_unit_price = new TextBox();
            label34 = new Label();
            label38 = new Label();
            cmb_search_items = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            txt_balance = new TextBox();
            label12 = new Label();
            txt_paid = new TextBox();
            label11 = new Label();
            txt_tot = new TextBox();
            label10 = new Label();
            button2 = new Button();
            label9 = new Label();
            listView1 = new ListView();
            Item = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            txt_discount = new TextBox();
            label8 = new Label();
            txt_qty = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txt_date_time = new TextBox();
            label4 = new Label();
            txt_bill_no = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btn_loose_items = new Button();
            btn_normal_items = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            SidePanel.SuspendLayout();
            Inventory_panel.SuspendLayout();
            panel3.SuspendLayout();
            Loose_Items_panel.SuspendLayout();
            Bill_panel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.DodgerBlue;
            SidePanel.Controls.Add(label1);
            SidePanel.Controls.Add(Bill);
            SidePanel.Controls.Add(Inventory);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(238, 775);
            SidePanel.TabIndex = 0;
            SidePanel.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(209, 56);
            label1.TabIndex = 6;
            label1.Text = "සෙනෙවිරත්න සුපර්\r\nසිද්දමුල්ල";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Bill
            // 
            Bill.FlatAppearance.BorderSize = 0;
            Bill.FlatStyle = FlatStyle.Flat;
            Bill.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Bill.ForeColor = Color.White;
            Bill.Image = Properties.Resources.icons8_cash_register_50;
            Bill.ImageAlign = ContentAlignment.MiddleLeft;
            Bill.Location = new Point(0, 395);
            Bill.Name = "Bill";
            Bill.Size = new Size(238, 65);
            Bill.TabIndex = 5;
            Bill.Text = "BILL";
            Bill.TextImageRelation = TextImageRelation.ImageBeforeText;
            Bill.UseVisualStyleBackColor = true;
            Bill.Click += button4_Click;
            // 
            // Inventory
            // 
            Inventory.FlatAppearance.BorderSize = 0;
            Inventory.FlatStyle = FlatStyle.Flat;
            Inventory.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Inventory.ForeColor = Color.White;
            Inventory.Image = Properties.Resources.icons8_inventory_50;
            Inventory.ImageAlign = ContentAlignment.MiddleLeft;
            Inventory.Location = new Point(0, 306);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(238, 59);
            Inventory.TabIndex = 4;
            Inventory.Text = "INVENTORY";
            Inventory.TextAlign = ContentAlignment.MiddleRight;
            Inventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += button3_Click;
            // 
            // Close
            // 
            Close.FlatAppearance.BorderSize = 0;
            Close.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Close.Location = new Point(1399, 3);
            Close.Name = "Close";
            Close.Size = new Size(24, 24);
            Close.TabIndex = 3;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = true;
            Close.Click += button2_Click_2;
            // 
            // Inventory_panel
            // 
            Inventory_panel.BackColor = Color.Gray;
            Inventory_panel.Controls.Add(txt_inventory_search);
            Inventory_panel.Controls.Add(panel3);
            Inventory_panel.Controls.Add(button7);
            Inventory_panel.Controls.Add(button6);
            Inventory_panel.Controls.Add(label22);
            Inventory_panel.Controls.Add(btn_update_item);
            Inventory_panel.Controls.Add(btn_delete_item);
            Inventory_panel.Controls.Add(btn_add_item);
            Inventory_panel.Controls.Add(label21);
            Inventory_panel.Controls.Add(listView2);
            Inventory_panel.Controls.Add(label20);
            Inventory_panel.Controls.Add(txt_inventory_date);
            Inventory_panel.Location = new Point(244, 30);
            Inventory_panel.Name = "Inventory_panel";
            Inventory_panel.Size = new Size(1166, 727);
            Inventory_panel.TabIndex = 4;
            Inventory_panel.Paint += Inventory_panel_Paint;
            // 
            // txt_inventory_search
            // 
            txt_inventory_search.Location = new Point(192, 249);
            txt_inventory_search.Name = "txt_inventory_search";
            txt_inventory_search.Size = new Size(204, 23);
            txt_inventory_search.TabIndex = 54;
            txt_inventory_search.TextChanged += textBox1_TextChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label45);
            panel3.Controls.Add(txt_name);
            panel3.Controls.Add(lbl_warning_barcode);
            panel3.Controls.Add(label30);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txt_inventory_discount);
            panel3.Controls.Add(lbl_warning_name);
            panel3.Controls.Add(txt_stock_id);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txt_barcode);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txt_quantity);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(txt_buying_price);
            panel3.Controls.Add(txt_selling_price);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label19);
            panel3.Location = new Point(2, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(1163, 172);
            panel3.TabIndex = 53;
            panel3.Paint += panel3_Paint;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(36, 150);
            label45.Name = "label45";
            label45.Size = new Size(64, 15);
            label45.TabIndex = 53;
            label45.Text = "(PER ITEM)";
            label45.Click += label45_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(156, 11);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(210, 23);
            txt_name.TabIndex = 25;
            // 
            // lbl_warning_barcode
            // 
            lbl_warning_barcode.AutoSize = true;
            lbl_warning_barcode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_warning_barcode.ForeColor = Color.Red;
            lbl_warning_barcode.Location = new Point(940, 34);
            lbl_warning_barcode.Name = "lbl_warning_barcode";
            lbl_warning_barcode.Size = new Size(145, 17);
            lbl_warning_barcode.TabIndex = 52;
            lbl_warning_barcode.Text = "Barcode Already Exists";
            lbl_warning_barcode.Visible = false;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = SystemColors.ActiveCaptionText;
            label30.Location = new Point(8, 129);
            label30.Name = "label30";
            label30.Size = new Size(139, 21);
            label30.TabIndex = 49;
            label30.Text = "DISCOUNT AMT.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(8, 9);
            label14.Name = "label14";
            label14.Size = new Size(59, 21);
            label14.TabIndex = 26;
            label14.Text = "NAME";
            // 
            // txt_inventory_discount
            // 
            txt_inventory_discount.Location = new Point(156, 131);
            txt_inventory_discount.Name = "txt_inventory_discount";
            txt_inventory_discount.Size = new Size(210, 23);
            txt_inventory_discount.TabIndex = 48;
            txt_inventory_discount.TextAlign = HorizontalAlignment.Right;
            txt_inventory_discount.KeyPress += txt_inventory_discount_KeyPress;
            // 
            // lbl_warning_name
            // 
            lbl_warning_name.AutoSize = true;
            lbl_warning_name.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_warning_name.ForeColor = Color.Red;
            lbl_warning_name.Location = new Point(156, 34);
            lbl_warning_name.Name = "lbl_warning_name";
            lbl_warning_name.Size = new Size(132, 17);
            lbl_warning_name.TabIndex = 51;
            lbl_warning_name.Text = "Name Already Exists";
            lbl_warning_name.Visible = false;
            // 
            // txt_stock_id
            // 
            txt_stock_id.Location = new Point(550, 9);
            txt_stock_id.Name = "txt_stock_id";
            txt_stock_id.Size = new Size(210, 23);
            txt_stock_id.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(402, 7);
            label15.Name = "label15";
            label15.Size = new Size(87, 21);
            label15.TabIndex = 28;
            label15.Text = "STOCK ID";
            // 
            // txt_barcode
            // 
            txt_barcode.Location = new Point(940, 10);
            txt_barcode.Name = "txt_barcode";
            txt_barcode.Size = new Size(210, 23);
            txt_barcode.TabIndex = 29;
            txt_barcode.KeyDown += txt_barcode_KeyDown;
            txt_barcode.KeyPress += txt_barcode_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(792, 9);
            label16.Name = "label16";
            label16.Size = new Size(88, 21);
            label16.TabIndex = 30;
            label16.Text = "BARCODE";
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(940, 70);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(210, 23);
            txt_quantity.TabIndex = 35;
            txt_quantity.TextAlign = HorizontalAlignment.Right;
            txt_quantity.KeyPress += txt_quantity_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(402, 69);
            label18.Name = "label18";
            label18.Size = new Size(128, 21);
            label18.TabIndex = 34;
            label18.Text = "SELLING PRICE";
            // 
            // txt_buying_price
            // 
            txt_buying_price.Location = new Point(156, 70);
            txt_buying_price.Name = "txt_buying_price";
            txt_buying_price.Size = new Size(212, 23);
            txt_buying_price.TabIndex = 31;
            txt_buying_price.TextAlign = HorizontalAlignment.Right;
            txt_buying_price.KeyPress += txt_buying_price_KeyPress;
            // 
            // txt_selling_price
            // 
            txt_selling_price.Location = new Point(550, 69);
            txt_selling_price.Name = "txt_selling_price";
            txt_selling_price.Size = new Size(210, 23);
            txt_selling_price.TabIndex = 33;
            txt_selling_price.TextAlign = HorizontalAlignment.Right;
            txt_selling_price.KeyPress += txt_selling_price_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(5, 68);
            label17.Name = "label17";
            label17.Size = new Size(124, 21);
            label17.TabIndex = 32;
            label17.Text = "BUYING PRICE";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(792, 68);
            label19.Name = "label19";
            label19.Size = new Size(96, 21);
            label19.TabIndex = 36;
            label19.Text = "QUANTITY";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(937, 651);
            button7.Name = "button7";
            button7.Size = new Size(160, 53);
            button7.TabIndex = 50;
            button7.Text = "ADD NEW STOCK";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = Properties.Resources.icons8_refresh_30;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(505, 549);
            button6.Name = "button6";
            button6.Size = new Size(118, 38);
            button6.TabIndex = 47;
            button6.Text = "REFRESH";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(151, 32);
            label22.TabIndex = 44;
            label22.Text = "INVENTORY";
            label22.Click += label22_Click;
            // 
            // btn_update_item
            // 
            btn_update_item.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update_item.Image = (Image)resources.GetObject("btn_update_item.Image");
            btn_update_item.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update_item.Location = new Point(675, 650);
            btn_update_item.Name = "btn_update_item";
            btn_update_item.Size = new Size(160, 53);
            btn_update_item.TabIndex = 43;
            btn_update_item.Text = "UPDATE ITEM";
            btn_update_item.TextAlign = ContentAlignment.MiddleRight;
            btn_update_item.UseVisualStyleBackColor = true;
            // 
            // btn_delete_item
            // 
            btn_delete_item.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete_item.Image = (Image)resources.GetObject("btn_delete_item.Image");
            btn_delete_item.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete_item.Location = new Point(428, 650);
            btn_delete_item.Name = "btn_delete_item";
            btn_delete_item.Size = new Size(151, 53);
            btn_delete_item.TabIndex = 42;
            btn_delete_item.Text = "DELETE ITEM";
            btn_delete_item.TextAlign = ContentAlignment.MiddleRight;
            btn_delete_item.UseVisualStyleBackColor = true;
            btn_delete_item.Click += btn_delete_item_Click;
            // 
            // btn_add_item
            // 
            btn_add_item.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add_item.Image = Properties.Resources.icons8_add_30;
            btn_add_item.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add_item.Location = new Point(177, 650);
            btn_add_item.Name = "btn_add_item";
            btn_add_item.Size = new Size(136, 53);
            btn_add_item.TabIndex = 41;
            btn_add_item.Text = "ADD ITEM";
            btn_add_item.TextAlign = ContentAlignment.MiddleRight;
            btn_add_item.UseVisualStyleBackColor = true;
            btn_add_item.Click += btn_add_item_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.HighlightText;
            label21.Location = new Point(8, 248);
            label21.Name = "label21";
            label21.Size = new Size(178, 25);
            label21.TabIndex = 40;
            label21.Text = "SEARCH ITEM LIST";
            label21.Click += label21_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader9, columnHeader10, columnHeader15, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(8, 276);
            listView2.Name = "listView2";
            listView2.Size = new Size(1142, 267);
            listView2.TabIndex = 39;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ITEM";
            columnHeader9.Width = 250;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "BARCODE";
            columnHeader10.Width = 150;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "STOCK ID";
            columnHeader15.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "BUYING PRICE";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "SELLING PRICE";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "QUANTITY";
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "DISCOUNT";
            columnHeader14.Width = 120;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.HighlightText;
            label20.Location = new Point(800, 12);
            label20.Name = "label20";
            label20.Size = new Size(59, 25);
            label20.TabIndex = 38;
            label20.Text = "DATE";
            // 
            // txt_inventory_date
            // 
            txt_inventory_date.Location = new Point(937, 14);
            txt_inventory_date.Name = "txt_inventory_date";
            txt_inventory_date.Size = new Size(223, 23);
            txt_inventory_date.TabIndex = 37;
            txt_inventory_date.TextChanged += textBox11_TextChanged;
            // 
            // Loose_Items_panel
            // 
            Loose_Items_panel.BackColor = Color.Gray;
            Loose_Items_panel.Controls.Add(label48);
            Loose_Items_panel.Controls.Add(txt_loose_disc);
            Loose_Items_panel.Controls.Add(button4);
            Loose_Items_panel.Controls.Add(cmb_name_main);
            Loose_Items_panel.Controls.Add(label33);
            Loose_Items_panel.Controls.Add(button5);
            Loose_Items_panel.Controls.Add(label23);
            Loose_Items_panel.Controls.Add(button8);
            Loose_Items_panel.Controls.Add(button9);
            Loose_Items_panel.Controls.Add(button10);
            Loose_Items_panel.Controls.Add(label24);
            Loose_Items_panel.Controls.Add(itemview);
            Loose_Items_panel.Controls.Add(label25);
            Loose_Items_panel.Controls.Add(txt_loose_date);
            Loose_Items_panel.Controls.Add(label26);
            Loose_Items_panel.Controls.Add(txt_loose_qty);
            Loose_Items_panel.Controls.Add(label27);
            Loose_Items_panel.Controls.Add(txt_loose_selling);
            Loose_Items_panel.Controls.Add(label28);
            Loose_Items_panel.Controls.Add(txt_loose_buying);
            Loose_Items_panel.Controls.Add(label29);
            Loose_Items_panel.Controls.Add(txt_loose_barcode);
            Loose_Items_panel.Controls.Add(label31);
            Loose_Items_panel.Controls.Add(txt_category_name);
            Loose_Items_panel.Controls.Add(label32);
            Loose_Items_panel.Controls.Add(txt_name_main);
            Loose_Items_panel.Location = new Point(241, 30);
            Loose_Items_panel.Name = "Loose_Items_panel";
            Loose_Items_panel.Size = new Size(1166, 733);
            Loose_Items_panel.TabIndex = 47;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.BackColor = Color.Transparent;
            label48.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label48.ForeColor = Color.White;
            label48.Location = new Point(360, 209);
            label48.Name = "label48";
            label48.Size = new Size(121, 36);
            label48.TabIndex = 53;
            label48.Text = "DISCOUNT AMT.\r\n(Per kg)";
            label48.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_loose_disc
            // 
            txt_loose_disc.Location = new Point(541, 217);
            txt_loose_disc.Name = "txt_loose_disc";
            txt_loose_disc.Size = new Size(246, 23);
            txt_loose_disc.TabIndex = 52;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources.icons8_refresh_30;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(477, 605);
            button4.Name = "button4";
            button4.Size = new Size(124, 47);
            button4.TabIndex = 51;
            button4.Text = "REFRESH";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_3;
            // 
            // cmb_name_main
            // 
            cmb_name_main.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_name_main.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_name_main.FormattingEnabled = true;
            cmb_name_main.Location = new Point(143, 105);
            cmb_name_main.Name = "cmb_name_main";
            cmb_name_main.Size = new Size(197, 23);
            cmb_name_main.TabIndex = 50;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Transparent;
            label33.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.White;
            label33.Location = new Point(12, 104);
            label33.Name = "label33";
            label33.Size = new Size(92, 18);
            label33.TabIndex = 49;
            label33.Text = "NAME MAIN";
            // 
            // button5
            // 
            button5.Location = new Point(714, 43);
            button5.Name = "button5";
            button5.Size = new Size(75, 24);
            button5.TabIndex = 47;
            button5.Text = "ADD";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.ButtonHighlight;
            label23.Location = new Point(0, 3);
            label23.Name = "label23";
            label23.Size = new Size(165, 32);
            label23.TabIndex = 44;
            label23.Text = "LOOSE ITEMS";
            label23.Click += label23_Click_1;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(815, 676);
            button8.Name = "button8";
            button8.Size = new Size(160, 53);
            button8.TabIndex = 43;
            button8.Text = "UPDATE ITEM";
            button8.TextAlign = ContentAlignment.MiddleRight;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(515, 676);
            button9.Name = "button9";
            button9.Size = new Size(151, 53);
            button9.TabIndex = 42;
            button9.Text = "DELETE ITEM";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Image = Properties.Resources.icons8_add_30;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(200, 676);
            button10.Name = "button10";
            button10.Size = new Size(136, 53);
            button10.TabIndex = 41;
            button10.Text = "ADD ITEM";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.ActiveCaptionText;
            label24.Location = new Point(0, 576);
            label24.Name = "label24";
            label24.Size = new Size(100, 25);
            label24.TabIndex = 40;
            label24.Text = "LIST ITEM";
            label24.Click += label24_Click;
            // 
            // itemview
            // 
            itemview.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, Category, columnHeader3, columnHeader4, columnHeader17, columnHeader18 });
            itemview.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemview.ForeColor = SystemColors.MenuText;
            itemview.FullRowSelect = true;
            itemview.GridLines = true;
            itemview.Location = new Point(14, 272);
            itemview.Name = "itemview";
            itemview.Size = new Size(1145, 298);
            itemview.TabIndex = 39;
            itemview.UseCompatibleStateImageBehavior = false;
            itemview.View = View.Details;
            itemview.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ITEM";
            columnHeader2.Width = 250;
            // 
            // Category
            // 
            Category.Text = "CATEGORY";
            Category.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "BARCODE";
            columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "BUYING PRICE";
            columnHeader4.Width = 150;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "SELLING PRICE";
            columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "DISCOUNT";
            columnHeader18.Width = 90;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(851, 9);
            label25.Name = "label25";
            label25.Size = new Size(59, 25);
            label25.TabIndex = 38;
            label25.Text = "DATE";
            // 
            // txt_loose_date
            // 
            txt_loose_date.Location = new Point(940, 9);
            txt_loose_date.Name = "txt_loose_date";
            txt_loose_date.Size = new Size(223, 23);
            txt_loose_date.TabIndex = 37;
            txt_loose_date.TextChanged += textBox4_TextChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.White;
            label26.Location = new Point(803, 161);
            label26.Name = "label26";
            label26.Size = new Size(106, 18);
            label26.TabIndex = 36;
            label26.Text = "QUANTITY(kg)";
            // 
            // txt_loose_qty
            // 
            txt_loose_qty.Location = new Point(907, 160);
            txt_loose_qty.Name = "txt_loose_qty";
            txt_loose_qty.Size = new Size(246, 23);
            txt_loose_qty.TabIndex = 35;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.White;
            label27.Location = new Point(369, 161);
            label27.Name = "label27";
            label27.Size = new Size(140, 18);
            label27.TabIndex = 34;
            label27.Text = "SELLING PRICE(1kg)";
            // 
            // txt_loose_selling
            // 
            txt_loose_selling.Location = new Point(541, 161);
            txt_loose_selling.Name = "txt_loose_selling";
            txt_loose_selling.Size = new Size(246, 23);
            txt_loose_selling.TabIndex = 33;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.White;
            label28.Location = new Point(12, 161);
            label28.Name = "label28";
            label28.Size = new Size(130, 17);
            label28.TabIndex = 32;
            label28.Text = "BUYING PRICE(1 kg)";
            // 
            // txt_loose_buying
            // 
            txt_loose_buying.Location = new Point(143, 161);
            txt_loose_buying.Name = "txt_loose_buying";
            txt_loose_buying.Size = new Size(197, 23);
            txt_loose_buying.TabIndex = 31;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.White;
            label29.Location = new Point(801, 107);
            label29.Name = "label29";
            label29.Size = new Size(75, 18);
            label29.TabIndex = 30;
            label29.Text = "BARCODE";
            label29.Click += label29_Click;
            // 
            // txt_loose_barcode
            // 
            txt_loose_barcode.Location = new Point(907, 103);
            txt_loose_barcode.Name = "txt_loose_barcode";
            txt_loose_barcode.Size = new Size(246, 23);
            txt_loose_barcode.TabIndex = 29;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.White;
            label31.Location = new Point(365, 107);
            label31.Name = "label31";
            label31.Size = new Size(128, 18);
            label31.TabIndex = 26;
            label31.Text = "CATEGORY NAME";
            // 
            // txt_category_name
            // 
            txt_category_name.Location = new Point(541, 103);
            txt_category_name.Name = "txt_category_name";
            txt_category_name.Size = new Size(246, 23);
            txt_category_name.TabIndex = 25;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Transparent;
            label32.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = SystemColors.ButtonHighlight;
            label32.Location = new Point(298, 43);
            label32.Name = "label32";
            label32.Size = new Size(125, 26);
            label32.TabIndex = 24;
            label32.Text = "MAIN ITEM";
            // 
            // txt_name_main
            // 
            txt_name_main.Location = new Point(460, 43);
            txt_name_main.Name = "txt_name_main";
            txt_name_main.Size = new Size(246, 23);
            txt_name_main.TabIndex = 23;
            // 
            // Bill_panel
            // 
            Bill_panel.BackColor = Color.DimGray;
            Bill_panel.Controls.Add(txt_barcpde_scanned);
            Bill_panel.Controls.Add(txt_discount_default);
            Bill_panel.Controls.Add(label46);
            Bill_panel.Controls.Add(txt_sub_tot);
            Bill_panel.Controls.Add(cmb_stock_id);
            Bill_panel.Controls.Add(label13);
            Bill_panel.Controls.Add(txt_avail_qty);
            Bill_panel.Controls.Add(label5);
            Bill_panel.Controls.Add(panel2);
            Bill_panel.Controls.Add(label35);
            Bill_panel.Controls.Add(txt_unit_price);
            Bill_panel.Controls.Add(label34);
            Bill_panel.Controls.Add(label38);
            Bill_panel.Controls.Add(cmb_search_items);
            Bill_panel.Controls.Add(button1);
            Bill_panel.Controls.Add(button3);
            Bill_panel.Controls.Add(txt_balance);
            Bill_panel.Controls.Add(label12);
            Bill_panel.Controls.Add(txt_paid);
            Bill_panel.Controls.Add(label11);
            Bill_panel.Controls.Add(txt_tot);
            Bill_panel.Controls.Add(label10);
            Bill_panel.Controls.Add(button2);
            Bill_panel.Controls.Add(label9);
            Bill_panel.Controls.Add(listView1);
            Bill_panel.Controls.Add(txt_discount);
            Bill_panel.Controls.Add(label8);
            Bill_panel.Controls.Add(txt_qty);
            Bill_panel.Controls.Add(label7);
            Bill_panel.Controls.Add(label6);
            Bill_panel.Controls.Add(txt_date_time);
            Bill_panel.Controls.Add(label4);
            Bill_panel.Controls.Add(txt_bill_no);
            Bill_panel.Controls.Add(label3);
            Bill_panel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Bill_panel.Location = new Point(241, 30);
            Bill_panel.Name = "Bill_panel";
            Bill_panel.Size = new Size(1182, 733);
            Bill_panel.TabIndex = 5;
            Bill_panel.Paint += Bill_panel_Paint;
            // 
            // txt_barcpde_scanned
            // 
            txt_barcpde_scanned.Location = new Point(378, 10);
            txt_barcpde_scanned.Name = "txt_barcpde_scanned";
            txt_barcpde_scanned.Size = new Size(248, 29);
            txt_barcpde_scanned.TabIndex = 56;
            txt_barcpde_scanned.KeyDown += textBox1_KeyDown;
            // 
            // txt_discount_default
            // 
            txt_discount_default.Location = new Point(667, 66);
            txt_discount_default.Name = "txt_discount_default";
            txt_discount_default.Size = new Size(195, 29);
            txt_discount_default.TabIndex = 55;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = Color.Transparent;
            label46.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label46.ForeColor = SystemColors.ButtonHighlight;
            label46.Location = new Point(587, 63);
            label46.Name = "label46";
            label46.Size = new Size(74, 34);
            label46.TabIndex = 54;
            label46.Text = "DISCOUNT\r\n(DEFAULT)";
            // 
            // txt_sub_tot
            // 
            txt_sub_tot.Location = new Point(966, 128);
            txt_sub_tot.Name = "txt_sub_tot";
            txt_sub_tot.Size = new Size(196, 29);
            txt_sub_tot.TabIndex = 53;
            txt_sub_tot.KeyDown += txt_sub_tot_KeyDown_1;
            txt_sub_tot.KeyPress += txt_sub_tot_KeyPress;
            // 
            // cmb_stock_id
            // 
            cmb_stock_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_stock_id.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_stock_id.FormattingEnabled = true;
            cmb_stock_id.Location = new Point(71, 129);
            cmb_stock_id.Name = "cmb_stock_id";
            cmb_stock_id.Size = new Size(222, 29);
            cmb_stock_id.TabIndex = 52;
            cmb_stock_id.SelectedIndexChanged += cmb_stock_id_SelectedIndexChanged;
            cmb_stock_id.KeyDown += cmb_stock_id_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(7, 133);
            label13.Name = "label13";
            label13.Size = new Size(67, 17);
            label13.TabIndex = 51;
            label13.Text = "STOCK ID";
            label13.Click += label13_Click;
            // 
            // txt_avail_qty
            // 
            txt_avail_qty.Location = new Point(396, 68);
            txt_avail_qty.Name = "txt_avail_qty";
            txt_avail_qty.Size = new Size(164, 29);
            txt_avail_qty.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(308, 63);
            label5.Name = "label5";
            label5.Size = new Size(75, 34);
            label5.TabIndex = 49;
            label5.Text = "AVAILABLE\r\nQTY";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label47);
            panel2.Controls.Add(txt_loose_default_discount);
            panel2.Controls.Add(txt_looseitems_sub_tot);
            panel2.Controls.Add(cmb_category);
            panel2.Controls.Add(label44);
            panel2.Controls.Add(txt_loose_avail_qty);
            panel2.Controls.Add(cmb_search_loose_items);
            panel2.Controls.Add(label43);
            panel2.Controls.Add(label42);
            panel2.Controls.Add(label39);
            panel2.Controls.Add(label36);
            panel2.Controls.Add(label41);
            panel2.Controls.Add(txt_loose_unit_price);
            panel2.Controls.Add(txt_loos_qty);
            panel2.Controls.Add(label37);
            panel2.Controls.Add(label40);
            panel2.Controls.Add(txt_loose_unit_dis);
            panel2.Location = new Point(0, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 125);
            panel2.TabIndex = 48;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = Color.Transparent;
            label47.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label47.ForeColor = SystemColors.ActiveCaptionText;
            label47.Location = new Point(582, 32);
            label47.Name = "label47";
            label47.Size = new Size(74, 17);
            label47.TabIndex = 56;
            label47.Text = "DISCOUNT";
            // 
            // txt_loose_default_discount
            // 
            txt_loose_default_discount.Location = new Point(667, 30);
            txt_loose_default_discount.Name = "txt_loose_default_discount";
            txt_loose_default_discount.Size = new Size(194, 29);
            txt_loose_default_discount.TabIndex = 57;
            // 
            // txt_looseitems_sub_tot
            // 
            txt_looseitems_sub_tot.Location = new Point(966, 82);
            txt_looseitems_sub_tot.Name = "txt_looseitems_sub_tot";
            txt_looseitems_sub_tot.Size = new Size(196, 29);
            txt_looseitems_sub_tot.TabIndex = 54;
            txt_looseitems_sub_tot.KeyDown += txt_looseitems_sub_tot_KeyDown;
            txt_looseitems_sub_tot.KeyPress += txt_looseitems_sub_tot_KeyPress;
            // 
            // cmb_category
            // 
            cmb_category.FormattingEnabled = true;
            cmb_category.Location = new Point(70, 85);
            cmb_category.Name = "cmb_category";
            cmb_category.Size = new Size(222, 29);
            cmb_category.TabIndex = 54;
            cmb_category.SelectedIndexChanged += cmb_category_SelectedIndexChanged;
            cmb_category.RightToLeftChanged += cmb_category_RightToLeftChanged;
            cmb_category.KeyDown += cmb_category_KeyDown;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = Color.Transparent;
            label44.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label44.ForeColor = SystemColors.ActiveCaptionText;
            label44.Location = new Point(311, 32);
            label44.Name = "label44";
            label44.Size = new Size(75, 34);
            label44.TabIndex = 52;
            label44.Text = "AVAILABLE\r\nQTY\r\n";
            label44.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_loose_avail_qty
            // 
            txt_loose_avail_qty.Location = new Point(397, 30);
            txt_loose_avail_qty.Name = "txt_loose_avail_qty";
            txt_loose_avail_qty.Size = new Size(163, 29);
            txt_loose_avail_qty.TabIndex = 53;
            // 
            // cmb_search_loose_items
            // 
            cmb_search_loose_items.FormattingEnabled = true;
            cmb_search_loose_items.Location = new Point(71, 35);
            cmb_search_loose_items.Name = "cmb_search_loose_items";
            cmb_search_loose_items.Size = new Size(222, 29);
            cmb_search_loose_items.TabIndex = 49;
            cmb_search_loose_items.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            cmb_search_loose_items.KeyDown += cmb_search_loose_items_KeyDown;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BackColor = Color.Transparent;
            label43.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label43.ForeColor = SystemColors.ActiveCaptionText;
            label43.Location = new Point(3, 91);
            label43.Name = "label43";
            label43.Size = new Size(67, 15);
            label43.TabIndex = 51;
            label43.Text = "CATEGORY";
            label43.Click += label43_Click;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = Color.Transparent;
            label42.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label42.ForeColor = SystemColors.ActiveCaptionText;
            label42.Location = new Point(6, 36);
            label42.Name = "label42";
            label42.Size = new Size(39, 17);
            label42.TabIndex = 49;
            label42.Text = "ITEM";
            label42.Click += label42_Click;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label39.ForeColor = SystemColors.ActiveCaptionText;
            label39.Location = new Point(10, 7);
            label39.Name = "label39";
            label39.Size = new Size(111, 21);
            label39.TabIndex = 43;
            label39.Text = "LOOSE ITEMS";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = Color.Transparent;
            label36.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label36.ForeColor = SystemColors.ActiveCaptionText;
            label36.Location = new Point(882, 87);
            label36.Name = "label36";
            label36.Size = new Size(48, 17);
            label36.TabIndex = 46;
            label36.Text = "TOTAL";
            label36.Click += label36_Click;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BackColor = Color.Transparent;
            label41.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label41.ForeColor = SystemColors.ActiveCaptionText;
            label41.Location = new Point(875, 35);
            label41.Name = "label41";
            label41.Size = new Size(74, 17);
            label41.TabIndex = 39;
            label41.Text = "QUANTITY";
            // 
            // txt_loose_unit_price
            // 
            txt_loose_unit_price.Location = new Point(396, 82);
            txt_loose_unit_price.Name = "txt_loose_unit_price";
            txt_loose_unit_price.Size = new Size(163, 29);
            txt_loose_unit_price.TabIndex = 45;
            // 
            // txt_loos_qty
            // 
            txt_loos_qty.Location = new Point(966, 30);
            txt_loos_qty.Name = "txt_loos_qty";
            txt_loos_qty.Size = new Size(196, 29);
            txt_loos_qty.TabIndex = 55;
            txt_loos_qty.KeyDown += txt_loos_qty_KeyDown;
            txt_loos_qty.KeyPress += txt_loos_qty_KeyPress_1;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.Transparent;
            label37.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label37.ForeColor = SystemColors.ActiveCaptionText;
            label37.Location = new Point(322, 74);
            label37.Name = "label37";
            label37.Size = new Size(49, 34);
            label37.TabIndex = 44;
            label37.Text = "UNNIT\r\nPRICE";
            label37.TextAlign = ContentAlignment.TopCenter;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = Color.Transparent;
            label40.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label40.ForeColor = SystemColors.ActiveCaptionText;
            label40.Location = new Point(582, 74);
            label40.Name = "label40";
            label40.Size = new Size(74, 34);
            label40.TabIndex = 41;
            label40.Text = "ADDED\r\nDISCOUNT";
            label40.TextAlign = ContentAlignment.TopCenter;
            label40.Click += label40_Click;
            // 
            // txt_loose_unit_dis
            // 
            txt_loose_unit_dis.Location = new Point(668, 82);
            txt_loose_unit_dis.Name = "txt_loose_unit_dis";
            txt_loose_unit_dis.Size = new Size(194, 29);
            txt_loose_unit_dis.TabIndex = 42;
            txt_loose_unit_dis.TextChanged += textBox8_TextChanged;
            txt_loose_unit_dis.KeyDown += txt_loose_unit_dis_KeyDown_1;
            txt_loose_unit_dis.KeyPress += txt_loose_unit_dis_KeyPress;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Transparent;
            label35.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label35.ForeColor = SystemColors.ButtonHighlight;
            label35.Location = new Point(889, 134);
            label35.Name = "label35";
            label35.Size = new Size(48, 17);
            label35.TabIndex = 36;
            label35.Text = "TOTAL";
            // 
            // txt_unit_price
            // 
            txt_unit_price.Location = new Point(395, 130);
            txt_unit_price.Name = "txt_unit_price";
            txt_unit_price.Size = new Size(164, 29);
            txt_unit_price.TabIndex = 35;
            txt_unit_price.TextChanged += textBox4_TextChanged_1;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.Transparent;
            label34.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label34.ForeColor = SystemColors.ButtonHighlight;
            label34.Location = new Point(311, 133);
            label34.Name = "label34";
            label34.Size = new Size(78, 17);
            label34.TabIndex = 34;
            label34.Text = "UNIT PRICE\r\n";
            label34.Click += label34_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label38.ForeColor = Color.White;
            label38.Location = new Point(5, 41);
            label38.Name = "label38";
            label38.Size = new Size(130, 21);
            label38.TabIndex = 33;
            label38.Text = "NORMAL ITEMS";
            label38.Click += label38_Click;
            // 
            // cmb_search_items
            // 
            cmb_search_items.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmb_search_items.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_search_items.FormattingEnabled = true;
            cmb_search_items.Location = new Point(71, 69);
            cmb_search_items.Name = "cmb_search_items";
            cmb_search_items.Size = new Size(222, 29);
            cmb_search_items.TabIndex = 25;
            cmb_search_items.SelectedIndexChanged += cmb_search_items_SelectedIndexChanged;
            cmb_search_items.KeyDown += cmb_search_items_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1070, 365);
            button1.Name = "button1";
            button1.Size = new Size(93, 44);
            button1.TabIndex = 24;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_3;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(493, 672);
            button3.Name = "button3";
            button3.Size = new Size(133, 52);
            button3.TabIndex = 23;
            button3.Text = "PRINT";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_2;
            // 
            // txt_balance
            // 
            txt_balance.Enabled = false;
            txt_balance.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_balance.Location = new Point(922, 578);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(168, 43);
            txt_balance.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe MDL2 Assets", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(756, 575);
            label12.Name = "label12";
            label12.Size = new Size(142, 35);
            label12.TabIndex = 21;
            label12.Text = "BALANCE";
            // 
            // txt_paid
            // 
            txt_paid.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_paid.Location = new Point(555, 578);
            txt_paid.Name = "txt_paid";
            txt_paid.Size = new Size(168, 43);
            txt_paid.TabIndex = 20;
            txt_paid.KeyDown += textBox2_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe MDL2 Assets", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(430, 572);
            label11.Name = "label11";
            label11.Size = new Size(78, 35);
            label11.TabIndex = 19;
            label11.Text = "PAID";
            // 
            // txt_tot
            // 
            txt_tot.Enabled = false;
            txt_tot.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_tot.Location = new Point(174, 578);
            txt_tot.Name = "txt_tot";
            txt_tot.Size = new Size(168, 43);
            txt_tot.TabIndex = 18;
            txt_tot.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe MDL2 Assets", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(49, 572);
            label10.Name = "label10";
            label10.Size = new Size(103, 35);
            label10.TabIndex = 17;
            label10.Text = "TOTAL";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HighlightText;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1070, 429);
            button2.Name = "button2";
            button2.Size = new Size(93, 44);
            button2.TabIndex = 16;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(6, 294);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 14;
            label9.Text = "ITEM LIST";
            label9.Click += label9_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Item, columnHeader6, columnHeader7, columnHeader16, columnHeader8 });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(6, 325);
            listView1.Name = "listView1";
            listView1.RightToLeftLayout = true;
            listView1.Size = new Size(1044, 200);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Item
            // 
            Item.Text = "NAME";
            Item.Width = 300;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "QUANTITY";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "UNIT PRICE";
            columnHeader7.Width = 180;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "OUR PRICE";
            columnHeader16.Width = 160;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "SUM";
            columnHeader8.Width = 300;
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(666, 128);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(195, 29);
            txt_discount.TabIndex = 12;
            txt_discount.KeyDown += txt_discount_KeyDown;
            txt_discount.KeyPress += txt_discount_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(586, 122);
            label8.Name = "label8";
            label8.Size = new Size(74, 34);
            label8.TabIndex = 11;
            label8.Text = "ADDED\r\nDISCOUNT";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Click += label8_Click;
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(967, 63);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(196, 29);
            txt_qty.TabIndex = 10;
            txt_qty.TextChanged += txt_qty_TextChanged;
            txt_qty.KeyDown += txt_qty_KeyDown;
            txt_qty.KeyPress += txt_qty_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(890, 69);
            label7.Name = "label7";
            label7.Size = new Size(33, 17);
            label7.TabIndex = 9;
            label7.Text = "QTY";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(8, 74);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 7;
            label6.Text = "ITEM";
            label6.Click += label6_Click;
            // 
            // txt_date_time
            // 
            txt_date_time.Enabled = false;
            txt_date_time.Location = new Point(957, 6);
            txt_date_time.Name = "txt_date_time";
            txt_date_time.Size = new Size(222, 29);
            txt_date_time.TabIndex = 3;
            txt_date_time.TextChanged += txt_date_time_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(865, 11);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 2;
            label4.Text = "DATE / TIME";
            label4.Click += label4_Click;
            // 
            // txt_bill_no
            // 
            txt_bill_no.Enabled = false;
            txt_bill_no.Location = new Point(71, 6);
            txt_bill_no.Name = "txt_bill_no";
            txt_bill_no.Size = new Size(100, 29);
            txt_bill_no.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 10);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 0;
            label3.Text = "BILL NO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_loose_items);
            panel1.Controls.Add(btn_normal_items);
            panel1.Location = new Point(238, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 27);
            panel1.TabIndex = 6;
            // 
            // btn_loose_items
            // 
            btn_loose_items.BackColor = Color.DodgerBlue;
            btn_loose_items.FlatAppearance.BorderSize = 0;
            btn_loose_items.FlatStyle = FlatStyle.Flat;
            btn_loose_items.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_loose_items.ForeColor = Color.White;
            btn_loose_items.Location = new Point(556, 0);
            btn_loose_items.Name = "btn_loose_items";
            btn_loose_items.Size = new Size(599, 27);
            btn_loose_items.TabIndex = 9;
            btn_loose_items.Text = "LOOSE ITEM";
            btn_loose_items.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_loose_items.UseVisualStyleBackColor = false;
            btn_loose_items.Click += button6_Click_1;
            // 
            // btn_normal_items
            // 
            btn_normal_items.BackColor = Color.DodgerBlue;
            btn_normal_items.FlatAppearance.BorderSize = 0;
            btn_normal_items.FlatStyle = FlatStyle.Flat;
            btn_normal_items.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_normal_items.ForeColor = Color.White;
            btn_normal_items.Location = new Point(6, 0);
            btn_normal_items.Name = "btn_normal_items";
            btn_normal_items.Size = new Size(544, 27);
            btn_normal_items.TabIndex = 8;
            btn_normal_items.Text = "NORMAL";
            btn_normal_items.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_normal_items.UseVisualStyleBackColor = false;
            btn_normal_items.Click += btn_normal_items_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1425, 775);
            Controls.Add(Bill_panel);
            Controls.Add(Loose_Items_panel);
            Controls.Add(Inventory_panel);
            Controls.Add(panel1);
            Controls.Add(Close);
            Controls.Add(SidePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            Inventory_panel.ResumeLayout(false);
            Inventory_panel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Loose_Items_panel.ResumeLayout(false);
            Loose_Items_panel.PerformLayout();
            Bill_panel.ResumeLayout(false);
            Bill_panel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Button Bill;
        private Button Inventory;
        private Label label1;
        private Button Close;
        private Panel Inventory_panel;
        private Panel Bill_panel;
        private Label label3;
        private TextBox txt_date_time;
        private Label label4;
        private TextBox txt_bill_no;
        private TextBox txt_qty;
        private Label label7;
        private Label label6;
        private TextBox txt_discount;
        private Label label8;
        private Label label9;
        private ListView listView1;
        private Button button2;
        private TextBox txt_paid;
        private Label label11;
        private TextBox txt_tot;
        private Label label10;
        private TextBox txt_balance;
        private Label label12;
        private Button button3;
        private Button button1;
        private Label label18;
        private TextBox txt_selling_price;
        private Label label17;
        private TextBox txt_buying_price;
        private Label label16;
        private TextBox txt_barcode;
        private Label label14;
        private TextBox txt_name;
        private Label label20;
        private TextBox txt_inventory_date;
        private Label label19;
        private TextBox txt_quantity;
        private Button btn_add_item;
        private Label label21;
        private ListView listView2;
        private Button btn_delete_item;
        private Label label22;
        private Button btn_update_item;
        private Panel panel1;
        private Button btn_normal_items;
        private Button btn_loose_items;
        private Panel Loose_Items_panel;
        private Label label23;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label24;
        private ListView itemview;
        private Label label25;
        private TextBox txt_loose_date;
        private Label label26;
        private TextBox txt_loose_qty;
        private Label label27;
        private TextBox txt_loose_selling;
        private Label label28;
        private TextBox txt_loose_buying;
        private Label label29;
        private TextBox txt_loose_barcode;
        private Label label31;
        private TextBox txt_category_name;
        private Label label32;
        private TextBox txt_name_main;
        private Label label33;
        private Button button5;
        private ComboBox cmb_name_main;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox cmb_search_items;
        private ColumnHeader Item;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label38;
        private TextBox txt_unit_price;
        private Label label34;
        private TextBox txt_loose_sub_tot;
        private Label label35;
        //private TextBox txt_loose_sub_tot;
        private Label label36;
        private TextBox txt_loose_unit_price;
        private Label label37;
        private Label label39;
        private TextBox txt_loose_unit_dis;
        private Label label40;
        private TextBox txt_loos_qty;
        private Label label41;
        private Panel panel2;
        private Label label42;
        private Label label43;
        private ComboBox cmb_search_loose_items;
        private TextBox txt_avail_qty;
        private Label label5;
        private ComboBox cmb_category;
        private Label label44;
        private TextBox txt_loose_avail_qty;
        private ColumnHeader Category;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Button button6;
        private Label label15;
        private TextBox txt_stock_id;
        private ComboBox cmb_stock_id;
        private Label label13;
        private TextBox txt_sub_tot;
        private TextBox txt_loose_subtot;
        private TextBox txt_looseitems_sub_tot;
        private Button button4;
        private Label label30;
        private TextBox txt_inventory_discount;
        private ColumnHeader columnHeader14;
        private Button button7;
        private Label lbl_warning_name;
        private Label lbl_warning_barcode;
        private ColumnHeader columnHeader15;
        private Panel panel3;
        private Label label45;
        private TextBox txt_inventory_search;
        private TextBox txt_discount_default;
        private Label label46;
        private ColumnHeader columnHeader16;
        private Label label47;
        private TextBox txt_loose_default_discount;
        private Label label48;
        private TextBox txt_loose_disc;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private TextBox txt_barcpde_scanned;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}