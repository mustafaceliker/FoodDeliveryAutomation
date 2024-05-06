namespace FoodDeliveryAutomation
{
    partial class StarbucksEditPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarbucksEditPage));
            this.starbuckseditpageDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productHeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStarbucksDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemeksepetiAutomation1DataSet1 = new FoodDeliveryAutomation.YemeksepetiAutomation1DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stareditpageType = new System.Windows.Forms.TextBox();
            this.stareditpageName = new System.Windows.Forms.TextBox();
            this.stareditpageHC = new System.Windows.Forms.TextBox();
            this.stareditpageContent = new System.Windows.Forms.TextBox();
            this.stareditpagePrice = new System.Windows.Forms.TextBox();
            this.stareditpageStock = new System.Windows.Forms.TextBox();
            this.stareditpageDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.tbl_StarbucksDatabaseTableAdapter = new FoodDeliveryAutomation.YemeksepetiAutomation1DataSet1TableAdapters.tbl_StarbucksDatabaseTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.starbuckseditpageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStarbucksDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemeksepetiAutomation1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // starbuckseditpageDataGridView
            // 
            this.starbuckseditpageDataGridView.AutoGenerateColumns = false;
            this.starbuckseditpageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.starbuckseditpageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productHeatDataGridViewTextBoxColumn,
            this.productContentDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productStockDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn});
            this.starbuckseditpageDataGridView.DataSource = this.tblStarbucksDatabaseBindingSource;
            this.starbuckseditpageDataGridView.Location = new System.Drawing.Point(2, 526);
            this.starbuckseditpageDataGridView.Name = "starbuckseditpageDataGridView";
            this.starbuckseditpageDataGridView.Size = new System.Drawing.Size(1443, 288);
            this.starbuckseditpageDataGridView.TabIndex = 0;
            this.starbuckseditpageDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.starbuckseditpageDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productHeatDataGridViewTextBoxColumn
            // 
            this.productHeatDataGridViewTextBoxColumn.DataPropertyName = "ProductHeat";
            this.productHeatDataGridViewTextBoxColumn.HeaderText = "ProductHeat";
            this.productHeatDataGridViewTextBoxColumn.Name = "productHeatDataGridViewTextBoxColumn";
            // 
            // productContentDataGridViewTextBoxColumn
            // 
            this.productContentDataGridViewTextBoxColumn.DataPropertyName = "ProductContent";
            this.productContentDataGridViewTextBoxColumn.HeaderText = "ProductContent";
            this.productContentDataGridViewTextBoxColumn.Name = "productContentDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productStockDataGridViewTextBoxColumn
            // 
            this.productStockDataGridViewTextBoxColumn.DataPropertyName = "ProductStock";
            this.productStockDataGridViewTextBoxColumn.HeaderText = "ProductStock";
            this.productStockDataGridViewTextBoxColumn.Name = "productStockDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // tblStarbucksDatabaseBindingSource
            // 
            this.tblStarbucksDatabaseBindingSource.DataMember = "tbl_StarbucksDatabase";
            this.tblStarbucksDatabaseBindingSource.DataSource = this.yemeksepetiAutomation1DataSet1;
            // 
            // yemeksepetiAutomation1DataSet1
            // 
            this.yemeksepetiAutomation1DataSet1.DataSetName = "YemeksepetiAutomation1DataSet1";
            this.yemeksepetiAutomation1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodDeliveryAutomation.Properties.Resources.star___Kopya;
            this.pictureBox1.Location = new System.Drawing.Point(402, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1160, 452);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 53);
            this.button8.TabIndex = 25;
            this.button8.Text = "VERİ TEMİZLE";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.YellowGreen;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1160, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 53);
            this.button7.TabIndex = 24;
            this.button7.Text = "ÜRÜN GÜNCELLE";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.YellowGreen;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1160, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 53);
            this.button6.TabIndex = 23;
            this.button6.Text = "ÜRÜN EKLE";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1160, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 53);
            this.button5.TabIndex = 22;
            this.button5.Text = "ÜRÜN SİL";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(996, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 53);
            this.button4.TabIndex = 21;
            this.button4.Text = "TATLI LİSTELE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(996, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 53);
            this.button3.TabIndex = 20;
            this.button3.Text = "ATIŞTIRMALIK LİSTELE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(996, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 53);
            this.button2.TabIndex = 19;
            this.button2.Text = "KAHVESİZ İÇECEK LİSTELE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(996, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "KAHVELİ İÇECEK LİSTELE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FoodDeliveryAutomation.Properties.Resources.startatli;
            this.pictureBox5.Location = new System.Drawing.Point(925, 441);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 82);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FoodDeliveryAutomation.Properties.Resources.staratistirmalik;
            this.pictureBox4.Location = new System.Drawing.Point(925, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FoodDeliveryAutomation.Properties.Resources.starkahvesiz;
            this.pictureBox3.Location = new System.Drawing.Point(925, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoodDeliveryAutomation.Properties.Resources.starkahveli;
            this.pictureBox2.Location = new System.Drawing.Point(925, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // stareditpageType
            // 
            this.stareditpageType.Location = new System.Drawing.Point(323, 198);
            this.stareditpageType.Name = "stareditpageType";
            this.stareditpageType.Size = new System.Drawing.Size(195, 20);
            this.stareditpageType.TabIndex = 30;
            // 
            // stareditpageName
            // 
            this.stareditpageName.Location = new System.Drawing.Point(323, 235);
            this.stareditpageName.Name = "stareditpageName";
            this.stareditpageName.Size = new System.Drawing.Size(195, 20);
            this.stareditpageName.TabIndex = 31;
            // 
            // stareditpageHC
            // 
            this.stareditpageHC.Location = new System.Drawing.Point(323, 269);
            this.stareditpageHC.Name = "stareditpageHC";
            this.stareditpageHC.Size = new System.Drawing.Size(195, 20);
            this.stareditpageHC.TabIndex = 32;
            // 
            // stareditpageContent
            // 
            this.stareditpageContent.Location = new System.Drawing.Point(323, 310);
            this.stareditpageContent.Name = "stareditpageContent";
            this.stareditpageContent.Size = new System.Drawing.Size(195, 20);
            this.stareditpageContent.TabIndex = 33;
            // 
            // stareditpagePrice
            // 
            this.stareditpagePrice.Location = new System.Drawing.Point(323, 350);
            this.stareditpagePrice.Name = "stareditpagePrice";
            this.stareditpagePrice.Size = new System.Drawing.Size(195, 20);
            this.stareditpagePrice.TabIndex = 34;
            // 
            // stareditpageStock
            // 
            this.stareditpageStock.Location = new System.Drawing.Point(323, 389);
            this.stareditpageStock.Name = "stareditpageStock";
            this.stareditpageStock.Size = new System.Drawing.Size(195, 20);
            this.stareditpageStock.TabIndex = 35;
            // 
            // stareditpageDescription
            // 
            this.stareditpageDescription.Location = new System.Drawing.Point(323, 429);
            this.stareditpageDescription.Name = "stareditpageDescription";
            this.stareditpageDescription.Size = new System.Drawing.Size(195, 20);
            this.stareditpageDescription.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ürün Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ürün İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(178, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ürün Sıcak/Soğuk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(179, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ürün İçeriği:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(179, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(179, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ürün Stoğu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(179, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Ürün Açıklaması";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(176, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(556, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "RESTORAN ÜRÜN DÜZENLEME/GÜNCELLEME SAYFASI";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.YellowGreen;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1066, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(158, 53);
            this.button9.TabIndex = 45;
            this.button9.Text = "TÜM ÜRÜNLERİ LİSTELE";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tbl_StarbucksDatabaseTableAdapter
            // 
            this.tbl_StarbucksDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(179, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Ürün ID:";
            // 
            // ProductID
            // 
            this.ProductID.Enabled = false;
            this.ProductID.Location = new System.Drawing.Point(323, 165);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(195, 20);
            this.ProductID.TabIndex = 47;
            // 
            // StarbucksEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::FoodDeliveryAutomation.Properties.Resources.star;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1447, 814);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stareditpageDescription);
            this.Controls.Add(this.stareditpageStock);
            this.Controls.Add(this.stareditpagePrice);
            this.Controls.Add(this.stareditpageContent);
            this.Controls.Add(this.stareditpageHC);
            this.Controls.Add(this.stareditpageName);
            this.Controls.Add(this.stareditpageType);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.starbuckseditpageDataGridView);
            this.Name = "StarbucksEditPage";
            this.Text = "StarbucksEditPage";
            this.Load += new System.EventHandler(this.StarbucksEditPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.starbuckseditpageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStarbucksDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemeksepetiAutomation1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView starbuckseditpageDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox stareditpageType;
        private System.Windows.Forms.TextBox stareditpageName;
        private System.Windows.Forms.TextBox stareditpageHC;
        private System.Windows.Forms.TextBox stareditpageContent;
        private System.Windows.Forms.TextBox stareditpagePrice;
        private System.Windows.Forms.TextBox stareditpageStock;
        private System.Windows.Forms.TextBox stareditpageDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private YemeksepetiAutomation1DataSet1 yemeksepetiAutomation1DataSet1;
        private System.Windows.Forms.BindingSource tblStarbucksDatabaseBindingSource;
        private YemeksepetiAutomation1DataSet1TableAdapters.tbl_StarbucksDatabaseTableAdapter tbl_StarbucksDatabaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productHeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProductID;
    }
}