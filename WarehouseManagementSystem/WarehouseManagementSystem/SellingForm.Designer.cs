namespace WarehouseManagementSystem
{
    partial class SellingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRecordIndex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddProdTemp = new MaterialSkin.Controls.MaterialButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTempOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbSellerName = new System.Windows.Forms.Label();
            this.dgvProdWarehouse = new System.Windows.Forms.DataGridView();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.dgvSO = new System.Windows.Forms.DataGridView();
            this.btnDelBill = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintBill = new MaterialSkin.Controls.MaterialButton();
            this.btnAddBill = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lable6 = new System.Windows.Forms.Label();
            this.lbProdPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProdQty = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProdName = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbRecordIndex);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAddProdTemp);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dgvTempOrder);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbSellerName);
            this.panel1.Controls.Add(this.dgvProdWarehouse);
            this.panel1.Controls.Add(this.materialButton7);
            this.panel1.Controls.Add(this.dgvSO);
            this.panel1.Controls.Add(this.btnDelBill);
            this.panel1.Controls.Add(this.btnPrintBill);
            this.panel1.Controls.Add(this.btnAddBill);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lable6);
            this.panel1.Controls.Add(this.lbProdPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbProdQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbProdName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(106, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 656);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbRecordIndex
            // 
            this.lbRecordIndex.AutoSize = true;
            this.lbRecordIndex.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordIndex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRecordIndex.Location = new System.Drawing.Point(862, 614);
            this.lbRecordIndex.Name = "lbRecordIndex";
            this.lbRecordIndex.Size = new System.Drawing.Size(174, 24);
            this.lbRecordIndex.TabIndex = 38;
            this.lbRecordIndex.Text = "Choosing Record";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(695, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "VND";
            // 
            // btnAddProdTemp
            // 
            this.btnAddProdTemp.AutoSize = false;
            this.btnAddProdTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProdTemp.Depth = 0;
            this.btnAddProdTemp.DrawShadows = true;
            this.btnAddProdTemp.HighEmphasis = true;
            this.btnAddProdTemp.Icon = null;
            this.btnAddProdTemp.Location = new System.Drawing.Point(25, 306);
            this.btnAddProdTemp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProdTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProdTemp.Name = "btnAddProdTemp";
            this.btnAddProdTemp.Size = new System.Drawing.Size(267, 37);
            this.btnAddProdTemp.TabIndex = 36;
            this.btnAddProdTemp.Text = "ADD PRODUCT";
            this.btnAddProdTemp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProdTemp.UseAccentColor = false;
            this.btnAddProdTemp.UseVisualStyleBackColor = true;
            this.btnAddProdTemp.Click += new System.EventHandler(this.btnAddProdTemp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(617, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "SALES ORDER";
            // 
            // dgvTempOrder
            // 
            this.dgvTempOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTempOrder.Location = new System.Drawing.Point(373, 81);
            this.dgvTempOrder.Name = "dgvTempOrder";
            this.dgvTempOrder.RowHeadersWidth = 51;
            this.dgvTempOrder.RowTemplate.Height = 24;
            this.dgvTempOrder.Size = new System.Drawing.Size(693, 191);
            this.dgvTempOrder.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ProductName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "UnitPrice";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Totals";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SO_ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalPrice.Location = new System.Drawing.Point(757, 275);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(21, 24);
            this.lbTotalPrice.TabIndex = 33;
            this.lbTotalPrice.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(554, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Amount";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDate.Location = new System.Drawing.Point(701, 33);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(45, 19);
            this.lbDate.TabIndex = 31;
            this.lbDate.Text = "Date";
            // 
            // lbSellerName
            // 
            this.lbSellerName.AutoSize = true;
            this.lbSellerName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbSellerName.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerName.Location = new System.Drawing.Point(19, 81);
            this.lbSellerName.Name = "lbSellerName";
            this.lbSellerName.Size = new System.Drawing.Size(113, 32);
            this.lbSellerName.TabIndex = 30;
            this.lbSellerName.Text = "SELLER";
            // 
            // dgvProdWarehouse
            // 
            this.dgvProdWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdWarehouse.Location = new System.Drawing.Point(25, 396);
            this.dgvProdWarehouse.Name = "dgvProdWarehouse";
            this.dgvProdWarehouse.RowHeadersWidth = 51;
            this.dgvProdWarehouse.RowTemplate.Height = 24;
            this.dgvProdWarehouse.Size = new System.Drawing.Size(267, 257);
            this.dgvProdWarehouse.TabIndex = 28;
            this.dgvProdWarehouse.SelectionChanged += new System.EventHandler(this.dgvProdWarehouse_SelectionChanged);
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSize = false;
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(201, 358);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(91, 29);
            this.materialButton7.TabIndex = 27;
            this.materialButton7.Text = "Ref";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // dgvSO
            // 
            this.dgvSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSO.Location = new System.Drawing.Point(373, 358);
            this.dgvSO.Name = "dgvSO";
            this.dgvSO.RowHeadersWidth = 51;
            this.dgvSO.RowTemplate.Height = 24;
            this.dgvSO.Size = new System.Drawing.Size(693, 234);
            this.dgvSO.TabIndex = 25;
            this.dgvSO.SelectionChanged += new System.EventHandler(this.dgvSO_SelectionChanged);
            // 
            // btnDelBill
            // 
            this.btnDelBill.AutoSize = false;
            this.btnDelBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelBill.Depth = 0;
            this.btnDelBill.DrawShadows = true;
            this.btnDelBill.HighEmphasis = true;
            this.btnDelBill.Icon = null;
            this.btnDelBill.Location = new System.Drawing.Point(647, 601);
            this.btnDelBill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelBill.Name = "btnDelBill";
            this.btnDelBill.Size = new System.Drawing.Size(208, 37);
            this.btnDelBill.TabIndex = 24;
            this.btnDelBill.Text = "DELETE";
            this.btnDelBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelBill.UseAccentColor = false;
            this.btnDelBill.UseVisualStyleBackColor = true;
            this.btnDelBill.Click += new System.EventHandler(this.btnDelBill_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.AutoSize = false;
            this.btnPrintBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintBill.Depth = 0;
            this.btnPrintBill.DrawShadows = true;
            this.btnPrintBill.HighEmphasis = true;
            this.btnPrintBill.Icon = null;
            this.btnPrintBill.Location = new System.Drawing.Point(997, 320);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(69, 37);
            this.btnPrintBill.TabIndex = 23;
            this.btnPrintBill.Text = "PRINT";
            this.btnPrintBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintBill.UseAccentColor = false;
            this.btnPrintBill.UseVisualStyleBackColor = true;
            // 
            // btnAddBill
            // 
            this.btnAddBill.AutoSize = false;
            this.btnAddBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBill.Depth = 0;
            this.btnAddBill.DrawShadows = true;
            this.btnAddBill.HighEmphasis = true;
            this.btnAddBill.Icon = null;
            this.btnAddBill.Location = new System.Drawing.Point(373, 601);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(208, 37);
            this.btnAddBill.TabIndex = 22;
            this.btnAddBill.Text = "ADD";
            this.btnAddBill.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddBill.UseAccentColor = false;
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 358);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 29);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.BackColor = System.Drawing.SystemColors.Highlight;
            this.lable6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lable6.Location = new System.Drawing.Point(22, 267);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(46, 16);
            this.lable6.TabIndex = 20;
            this.lable6.Text = "PRICE";
            // 
            // lbProdPrice
            // 
            this.lbProdPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProdPrice.Depth = 0;
            this.lbProdPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbProdPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdPrice.Location = new System.Drawing.Point(102, 249);
            this.lbProdPrice.MaxLength = 50;
            this.lbProdPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdPrice.Multiline = false;
            this.lbProdPrice.Name = "lbProdPrice";
            this.lbProdPrice.Size = new System.Drawing.Size(190, 50);
            this.lbProdPrice.TabIndex = 16;
            this.lbProdPrice.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "QTY";
            // 
            // lbProdQty
            // 
            this.lbProdQty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProdQty.Depth = 0;
            this.lbProdQty.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbProdQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdQty.Location = new System.Drawing.Point(102, 193);
            this.lbProdQty.MaxLength = 50;
            this.lbProdQty.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdQty.Multiline = false;
            this.lbProdQty.Name = "lbProdQty";
            this.lbProdQty.Size = new System.Drawing.Size(190, 50);
            this.lbProdQty.TabIndex = 15;
            this.lbProdQty.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "PRODUCT";
            // 
            // lbProdName
            // 
            this.lbProdName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProdName.Depth = 0;
            this.lbProdName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbProdName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdName.Location = new System.Drawing.Point(102, 137);
            this.lbProdName.MaxLength = 50;
            this.lbProdName.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdName.Multiline = false;
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(190, 50);
            this.lbProdName.TabIndex = 14;
            this.lbProdName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(479, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "SELLING";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1150, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 677);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "LogOut";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 713);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private System.Windows.Forms.DataGridView dgvSO;
        private MaterialSkin.Controls.MaterialButton btnDelBill;
        private MaterialSkin.Controls.MaterialButton btnPrintBill;
        private MaterialSkin.Controls.MaterialButton btnAddBill;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lable6;
        private MaterialSkin.Controls.MaterialTextBox lbProdPrice;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox lbProdQty;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox lbProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProdWarehouse;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton btnAddProdTemp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvTempOrder;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbSellerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbRecordIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}