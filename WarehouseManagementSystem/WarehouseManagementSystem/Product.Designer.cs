namespace WarehouseManagementSystem
{
    partial class Product
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
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnDelProd = new MaterialSkin.Controls.MaterialButton();
            this.btnEditProd = new MaterialSkin.Controls.MaterialButton();
            this.btnAddProd = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbProdPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProdQty = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProdName = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProdId = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.btnProdMoves = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.materialButton7);
            this.panel1.Controls.Add(this.cbSearch);
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Controls.Add(this.btnDelProd);
            this.panel1.Controls.Add(this.btnEditProd);
            this.panel1.Controls.Add(this.btnAddProd);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbProdPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbProdQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbProdName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbProdId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 500);
            this.panel1.TabIndex = 0;
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSize = false;
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(774, 68);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(69, 30);
            this.materialButton7.TabIndex = 27;
            this.materialButton7.Text = "REFRESH";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            this.materialButton7.Click += new System.EventHandler(this.materialButton7_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.cbSearch.Location = new System.Drawing.Point(319, 68);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(169, 29);
            this.cbSearch.TabIndex = 26;
            this.cbSearch.Text = "Select Category";
            this.cbSearch.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(319, 103);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(524, 305);
            this.dgvProduct.TabIndex = 25;
            this.dgvProduct.SelectionChanged += new System.EventHandler(this.dgvProduct_SelectionChanged);
            // 
            // btnDelProd
            // 
            this.btnDelProd.AutoSize = false;
            this.btnDelProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelProd.Depth = 0;
            this.btnDelProd.DrawShadows = true;
            this.btnDelProd.HighEmphasis = true;
            this.btnDelProd.Icon = null;
            this.btnDelProd.Location = new System.Drawing.Point(229, 315);
            this.btnDelProd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(69, 37);
            this.btnDelProd.TabIndex = 24;
            this.btnDelProd.Text = "DELETE";
            this.btnDelProd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelProd.UseAccentColor = false;
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.AutoSize = false;
            this.btnEditProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditProd.Depth = 0;
            this.btnEditProd.DrawShadows = true;
            this.btnEditProd.HighEmphasis = true;
            this.btnEditProd.Icon = null;
            this.btnEditProd.Location = new System.Drawing.Point(129, 315);
            this.btnEditProd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(69, 37);
            this.btnEditProd.TabIndex = 23;
            this.btnEditProd.Text = "EDIT";
            this.btnEditProd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditProd.UseAccentColor = false;
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.AutoSize = false;
            this.btnAddProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProd.Depth = 0;
            this.btnAddProd.DrawShadows = true;
            this.btnAddProd.HighEmphasis = true;
            this.btnAddProd.Icon = null;
            this.btnAddProd.Location = new System.Drawing.Point(23, 315);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(69, 37);
            this.btnAddProd.TabIndex = 22;
            this.btnAddProd.Text = "ADD";
            this.btnAddProd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProd.UseAccentColor = false;
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 29);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Select Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "CATEGORY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "PRICE";
            // 
            // lbProdPrice
            // 
            this.lbProdPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProdPrice.Depth = 0;
            this.lbProdPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbProdPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdPrice.Location = new System.Drawing.Point(129, 215);
            this.lbProdPrice.MaxLength = 50;
            this.lbProdPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdPrice.Multiline = false;
            this.lbProdPrice.Name = "lbProdPrice";
            this.lbProdPrice.Size = new System.Drawing.Size(169, 50);
            this.lbProdPrice.TabIndex = 16;
            this.lbProdPrice.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
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
            this.lbProdQty.Location = new System.Drawing.Point(129, 159);
            this.lbProdQty.MaxLength = 50;
            this.lbProdQty.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdQty.Multiline = false;
            this.lbProdQty.Name = "lbProdQty";
            this.lbProdQty.Size = new System.Drawing.Size(169, 50);
            this.lbProdQty.TabIndex = 15;
            this.lbProdQty.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "NAME";
            // 
            // lbProdName
            // 
            this.lbProdName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProdName.Depth = 0;
            this.lbProdName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbProdName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdName.Location = new System.Drawing.Point(129, 103);
            this.lbProdName.MaxLength = 50;
            this.lbProdName.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdName.Multiline = false;
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(169, 50);
            this.lbProdName.TabIndex = 14;
            this.lbProdName.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // lbProdId
            // 
            this.lbProdId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProdId.Depth = 0;
            this.lbProdId.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbProdId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProdId.Location = new System.Drawing.Point(129, 47);
            this.lbProdId.MaxLength = 50;
            this.lbProdId.MouseState = MaterialSkin.MouseState.OUT;
            this.lbProdId.Multiline = false;
            this.lbProdId.Name = "lbProdId";
            this.lbProdId.Size = new System.Drawing.Size(169, 50);
            this.lbProdId.TabIndex = 13;
            this.lbProdId.Text = "";
            this.lbProdId.TextChanged += new System.EventHandler(this.lbProdId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCT MANAGEMENT";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(13, 123);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Seller";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(13, 255);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Category";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(13, 351);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.Text = "SELLING";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1047, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(13, 207);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(158, 36);
            this.materialButton4.TabIndex = 12;
            this.materialButton4.Text = "CREATE PO";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click_1);
            // 
            // btnProdMoves
            // 
            this.btnProdMoves.AutoSize = false;
            this.btnProdMoves.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProdMoves.Depth = 0;
            this.btnProdMoves.DrawShadows = true;
            this.btnProdMoves.HighEmphasis = true;
            this.btnProdMoves.Icon = null;
            this.btnProdMoves.Location = new System.Drawing.Point(13, 303);
            this.btnProdMoves.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProdMoves.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProdMoves.Name = "btnProdMoves";
            this.btnProdMoves.Size = new System.Drawing.Size(158, 36);
            this.btnProdMoves.TabIndex = 13;
            this.btnProdMoves.Text = "PO/SO REPORT";
            this.btnProdMoves.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnProdMoves.UseAccentColor = false;
            this.btnProdMoves.UseVisualStyleBackColor = true;
            this.btnProdMoves.Click += new System.EventHandler(this.btnProdMoves_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 579);
            this.Controls.Add(this.btnProdMoves);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox lbProdPrice;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox lbProdQty;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox lbProdName;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox lbProdId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.DataGridView dgvProduct;
        private MaterialSkin.Controls.MaterialButton btnDelProd;
        private MaterialSkin.Controls.MaterialButton btnEditProd;
        private MaterialSkin.Controls.MaterialButton btnAddProd;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton btnProdMoves;
    }
}