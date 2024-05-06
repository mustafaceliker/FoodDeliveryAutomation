namespace FoodDeliveryAutomation
{
    partial class FiveGuysEditPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiveGuysEditPage));
            this.label1 = new System.Windows.Forms.Label();
            this.fiveguyseditpageDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productHeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFiveGuysDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemeksepetiAutomation1DataSet = new FoodDeliveryAutomation.YemeksepetiAutomation1DataSet();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiveguyseditpageType = new System.Windows.Forms.Label();
            this.fiveguyseditpageDescription = new System.Windows.Forms.TextBox();
            this.fiveguyseditpageStock = new System.Windows.Forms.TextBox();
            this.fiveguyseditpagePrice = new System.Windows.Forms.TextBox();
            this.fiveguyseditpageContent = new System.Windows.Forms.TextBox();
            this.fiveguyseditpageHC = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbl_FiveGuysDatabaseTableAdapter = new FoodDeliveryAutomation.YemeksepetiAutomation1DataSetTableAdapters.tbl_FiveGuysDatabaseTableAdapter();
            this.fiveguyseditpageName = new System.Windows.Forms.TextBox();
            this.fiveguyseditpageType1 = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fiveguyseditpageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFiveGuysDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemeksepetiAutomation1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTORAN ÜRÜN DÜZENLEME/GÜNCELLEME SAYFASI";
            // 
            // fiveguyseditpageDataGridView
            // 
            this.fiveguyseditpageDataGridView.AutoGenerateColumns = false;
            this.fiveguyseditpageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fiveguyseditpageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productHeatDataGridViewTextBoxColumn,
            this.productContentDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productStockDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn});
            this.fiveguyseditpageDataGridView.DataSource = this.tblFiveGuysDatabaseBindingSource;
            this.fiveguyseditpageDataGridView.Location = new System.Drawing.Point(3, 456);
            this.fiveguyseditpageDataGridView.Name = "fiveguyseditpageDataGridView";
            this.fiveguyseditpageDataGridView.Size = new System.Drawing.Size(1328, 329);
            this.fiveguyseditpageDataGridView.TabIndex = 9;
            this.fiveguyseditpageDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fiveguyseditpageDataGridView_CellContentClick);
            this.fiveguyseditpageDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fiveguyseditpageDataGridView_CellContentDoubleClick);
            this.fiveguyseditpageDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fiveguyseditpageDataGridView_CellMouseDoubleClick);
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
            // tblFiveGuysDatabaseBindingSource
            // 
            this.tblFiveGuysDatabaseBindingSource.DataMember = "tbl_FiveGuysDatabase";
            this.tblFiveGuysDatabaseBindingSource.DataSource = this.yemeksepetiAutomation1DataSet;
            // 
            // yemeksepetiAutomation1DataSet
            // 
            this.yemeksepetiAutomation1DataSet.DataSetName = "YemeksepetiAutomation1DataSet";
            this.yemeksepetiAutomation1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1136, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 82);
            this.button8.TabIndex = 17;
            this.button8.Text = "VERİ TEMİZLE";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1136, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 82);
            this.button7.TabIndex = 16;
            this.button7.Text = "ÜRÜN GÜNCELLE";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1136, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 82);
            this.button6.TabIndex = 15;
            this.button6.Text = "ÜRÜN EKLE";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1136, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 82);
            this.button5.TabIndex = 14;
            this.button5.Text = "ÜRÜN SİL";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(957, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 82);
            this.button4.TabIndex = 13;
            this.button4.Text = "İÇECEK LİSTELE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(957, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 82);
            this.button3.TabIndex = 12;
            this.button3.Text = "KIZARTMA LİSTELE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(957, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 82);
            this.button2.TabIndex = 11;
            this.button2.Text = "SANDVİÇ LİSTELE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(957, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 82);
            this.button1.TabIndex = 10;
            this.button1.Text = "HAMBURGER LİSTELE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodDeliveryAutomation.Properties.Resources.fiveguyslogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(387, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "Ürün Açıklaması";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(387, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ürün Stoğu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(387, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(387, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ürün İçeriği:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(386, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ürün Sıcak/Soğuk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(387, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ürün İsmi";
            // 
            // fiveguyseditpageType
            // 
            this.fiveguyseditpageType.AutoSize = true;
            this.fiveguyseditpageType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fiveguyseditpageType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiveguyseditpageType.Location = new System.Drawing.Point(387, 107);
            this.fiveguyseditpageType.Name = "fiveguyseditpageType";
            this.fiveguyseditpageType.Size = new System.Drawing.Size(76, 18);
            this.fiveguyseditpageType.TabIndex = 51;
            this.fiveguyseditpageType.Text = "Ürün Tipi:";
            // 
            // fiveguyseditpageDescription
            // 
            this.fiveguyseditpageDescription.Location = new System.Drawing.Point(531, 335);
            this.fiveguyseditpageDescription.Name = "fiveguyseditpageDescription";
            this.fiveguyseditpageDescription.Size = new System.Drawing.Size(317, 20);
            this.fiveguyseditpageDescription.TabIndex = 50;
            // 
            // fiveguyseditpageStock
            // 
            this.fiveguyseditpageStock.Location = new System.Drawing.Point(531, 296);
            this.fiveguyseditpageStock.Name = "fiveguyseditpageStock";
            this.fiveguyseditpageStock.Size = new System.Drawing.Size(195, 20);
            this.fiveguyseditpageStock.TabIndex = 49;
            // 
            // fiveguyseditpagePrice
            // 
            this.fiveguyseditpagePrice.Location = new System.Drawing.Point(531, 256);
            this.fiveguyseditpagePrice.Name = "fiveguyseditpagePrice";
            this.fiveguyseditpagePrice.Size = new System.Drawing.Size(195, 20);
            this.fiveguyseditpagePrice.TabIndex = 47;
            // 
            // fiveguyseditpageContent
            // 
            this.fiveguyseditpageContent.Location = new System.Drawing.Point(531, 216);
            this.fiveguyseditpageContent.Name = "fiveguyseditpageContent";
            this.fiveguyseditpageContent.Size = new System.Drawing.Size(195, 20);
            this.fiveguyseditpageContent.TabIndex = 46;
            // 
            // fiveguyseditpageHC
            // 
            this.fiveguyseditpageHC.Location = new System.Drawing.Point(531, 174);
            this.fiveguyseditpageHC.Name = "fiveguyseditpageHC";
            this.fiveguyseditpageHC.Size = new System.Drawing.Size(195, 20);
            this.fiveguyseditpageHC.TabIndex = 45;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FoodDeliveryAutomation.Properties.Resources.fivedrinks;
            this.pictureBox5.Location = new System.Drawing.Point(854, 361);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FoodDeliveryAutomation.Properties.Resources.fiveburger;
            this.pictureBox4.Location = new System.Drawing.Point(855, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FoodDeliveryAutomation.Properties.Resources.fivefries;
            this.pictureBox3.Location = new System.Drawing.Point(855, 265);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(97, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoodDeliveryAutomation.Properties.Resources.fivesandwiches;
            this.pictureBox2.Location = new System.Drawing.Point(855, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // tbl_FiveGuysDatabaseTableAdapter
            // 
            this.tbl_FiveGuysDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // fiveguyseditpageName
            // 
            this.fiveguyseditpageName.Location = new System.Drawing.Point(531, 140);
            this.fiveguyseditpageName.Name = "fiveguyseditpageName";
            this.fiveguyseditpageName.Size = new System.Drawing.Size(195, 20);
            this.fiveguyseditpageName.TabIndex = 62;
            // 
            // fiveguyseditpageType1
            // 
            this.fiveguyseditpageType1.Location = new System.Drawing.Point(531, 105);
            this.fiveguyseditpageType1.Name = "fiveguyseditpageType1";
            this.fiveguyseditpageType1.Size = new System.Drawing.Size(195, 20);
            this.fiveguyseditpageType1.TabIndex = 63;
            // 
            // ProductID
            // 
            this.ProductID.Enabled = false;
            this.ProductID.Location = new System.Drawing.Point(531, 67);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(195, 20);
            this.ProductID.TabIndex = 64;
            this.ProductID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(386, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Ürün ID:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1043, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(173, 82);
            this.button9.TabIndex = 66;
            this.button9.Text = "TÜM ÜRÜNLERİ LİSTELE";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FiveGuysEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1334, 788);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.fiveguyseditpageType1);
            this.Controls.Add(this.fiveguyseditpageName);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fiveguyseditpageType);
            this.Controls.Add(this.fiveguyseditpageDescription);
            this.Controls.Add(this.fiveguyseditpageStock);
            this.Controls.Add(this.fiveguyseditpagePrice);
            this.Controls.Add(this.fiveguyseditpageContent);
            this.Controls.Add(this.fiveguyseditpageHC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiveguyseditpageDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "FiveGuysEditPage";
            this.Text = "FiveGuysEditPage";
            this.Load += new System.EventHandler(this.FiveGuysEditPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiveguyseditpageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFiveGuysDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemeksepetiAutomation1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView fiveguyseditpageDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fiveguyseditpageType;
        private System.Windows.Forms.TextBox fiveguyseditpageDescription;
        private System.Windows.Forms.TextBox fiveguyseditpageStock;
        private System.Windows.Forms.TextBox fiveguyseditpagePrice;
        private System.Windows.Forms.TextBox fiveguyseditpageContent;
        private System.Windows.Forms.TextBox fiveguyseditpageHC;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private YemeksepetiAutomation1DataSet yemeksepetiAutomation1DataSet;
        private System.Windows.Forms.BindingSource tblFiveGuysDatabaseBindingSource;
        private YemeksepetiAutomation1DataSetTableAdapters.tbl_FiveGuysDatabaseTableAdapter tbl_FiveGuysDatabaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productHeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox fiveguyseditpageName;
        private System.Windows.Forms.TextBox fiveguyseditpageType1;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
    }
}