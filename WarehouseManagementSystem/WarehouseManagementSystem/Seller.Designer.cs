namespace WarehouseManagementSystem
{
    partial class Seller
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

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.btnDelSel = new MaterialSkin.Controls.MaterialButton();
            this.btnEditSel = new MaterialSkin.Controls.MaterialButton();
            this.btnAddSel = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSellerPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSellerAge = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSellerName = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSellerId = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSellerPass = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lbSellerPass);
            this.panel1.Controls.Add(this.dgvSeller);
            this.panel1.Controls.Add(this.btnDelSel);
            this.panel1.Controls.Add(this.btnEditSel);
            this.panel1.Controls.Add(this.btnAddSel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbSellerPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbSellerAge);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbSellerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbSellerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 500);
            this.panel1.TabIndex = 0;
            // 
            // dgvSeller
            // 
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Location = new System.Drawing.Point(317, 47);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.RowHeadersWidth = 51;
            this.dgvSeller.RowTemplate.Height = 24;
            this.dgvSeller.Size = new System.Drawing.Size(530, 388);
            this.dgvSeller.TabIndex = 25;
            this.dgvSeller.SelectionChanged += new System.EventHandler(this.dgvSeller_SelectionChanged);
            // 
            // btnDelSel
            // 
            this.btnDelSel.AutoSize = false;
            this.btnDelSel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelSel.Depth = 0;
            this.btnDelSel.DrawShadows = true;
            this.btnDelSel.HighEmphasis = true;
            this.btnDelSel.Icon = null;
            this.btnDelSel.Location = new System.Drawing.Point(229, 330);
            this.btnDelSel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelSel.Name = "btnDelSel";
            this.btnDelSel.Size = new System.Drawing.Size(69, 37);
            this.btnDelSel.TabIndex = 24;
            this.btnDelSel.Text = "DELETE";
            this.btnDelSel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelSel.UseAccentColor = false;
            this.btnDelSel.UseVisualStyleBackColor = true;
            this.btnDelSel.Click += new System.EventHandler(this.btnDelSel_Click);
            // 
            // btnEditSel
            // 
            this.btnEditSel.AutoSize = false;
            this.btnEditSel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditSel.Depth = 0;
            this.btnEditSel.DrawShadows = true;
            this.btnEditSel.HighEmphasis = true;
            this.btnEditSel.Icon = null;
            this.btnEditSel.Location = new System.Drawing.Point(129, 330);
            this.btnEditSel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditSel.Name = "btnEditSel";
            this.btnEditSel.Size = new System.Drawing.Size(69, 37);
            this.btnEditSel.TabIndex = 23;
            this.btnEditSel.Text = "EDIT";
            this.btnEditSel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditSel.UseAccentColor = false;
            this.btnEditSel.UseVisualStyleBackColor = true;
            this.btnEditSel.Click += new System.EventHandler(this.btnEditSel_Click);
            // 
            // btnAddSel
            // 
            this.btnAddSel.AutoSize = false;
            this.btnAddSel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddSel.Depth = 0;
            this.btnAddSel.DrawShadows = true;
            this.btnAddSel.HighEmphasis = true;
            this.btnAddSel.Icon = null;
            this.btnAddSel.Location = new System.Drawing.Point(23, 330);
            this.btnAddSel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddSel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSel.Name = "btnAddSel";
            this.btnAddSel.Size = new System.Drawing.Size(69, 37);
            this.btnAddSel.TabIndex = 22;
            this.btnAddSel.Text = "ADD";
            this.btnAddSel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddSel.UseAccentColor = false;
            this.btnAddSel.UseVisualStyleBackColor = true;
            this.btnAddSel.Click += new System.EventHandler(this.btnAddSel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "PHONE";
            // 
            // lbSellerPhone
            // 
            this.lbSellerPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSellerPhone.Depth = 0;
            this.lbSellerPhone.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbSellerPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerPhone.Location = new System.Drawing.Point(129, 215);
            this.lbSellerPhone.MaxLength = 50;
            this.lbSellerPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.lbSellerPhone.Multiline = false;
            this.lbSellerPhone.Name = "lbSellerPhone";
            this.lbSellerPhone.Size = new System.Drawing.Size(169, 50);
            this.lbSellerPhone.TabIndex = 16;
            this.lbSellerPhone.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "AGE";
            // 
            // lbSellerAge
            // 
            this.lbSellerAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSellerAge.Depth = 0;
            this.lbSellerAge.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbSellerAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerAge.Location = new System.Drawing.Point(129, 159);
            this.lbSellerAge.MaxLength = 50;
            this.lbSellerAge.MouseState = MaterialSkin.MouseState.OUT;
            this.lbSellerAge.Multiline = false;
            this.lbSellerAge.Name = "lbSellerAge";
            this.lbSellerAge.Size = new System.Drawing.Size(169, 50);
            this.lbSellerAge.TabIndex = 15;
            this.lbSellerAge.Text = "";
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
            // lbSellerName
            // 
            this.lbSellerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSellerName.Depth = 0;
            this.lbSellerName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbSellerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerName.Location = new System.Drawing.Point(129, 103);
            this.lbSellerName.MaxLength = 50;
            this.lbSellerName.MouseState = MaterialSkin.MouseState.OUT;
            this.lbSellerName.Multiline = false;
            this.lbSellerName.Name = "lbSellerName";
            this.lbSellerName.Size = new System.Drawing.Size(169, 50);
            this.lbSellerName.TabIndex = 14;
            this.lbSellerName.Text = "";
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
            // lbSellerId
            // 
            this.lbSellerId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSellerId.Depth = 0;
            this.lbSellerId.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbSellerId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerId.Location = new System.Drawing.Point(129, 47);
            this.lbSellerId.MaxLength = 50;
            this.lbSellerId.MouseState = MaterialSkin.MouseState.OUT;
            this.lbSellerId.Multiline = false;
            this.lbSellerId.Name = "lbSellerId";
            this.lbSellerId.Size = new System.Drawing.Size(169, 50);
            this.lbSellerId.TabIndex = 13;
            this.lbSellerId.Text = "";
            this.lbSellerId.TextChanged += new System.EventHandler(this.lbSellerId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "SELLER MANAGEMENT";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(13, 128);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "PRODUCTS";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(13, 207);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Category";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(13, 255);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(158, 36);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.Text = "SELLING";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
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
            // lbSellerPass
            // 
            this.lbSellerPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSellerPass.Depth = 0;
            this.lbSellerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSellerPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSellerPass.Location = new System.Drawing.Point(129, 271);
            this.lbSellerPass.MaxLength = 50;
            this.lbSellerPass.MouseState = MaterialSkin.MouseState.OUT;
            this.lbSellerPass.Multiline = false;
            this.lbSellerPass.Name = "lbSellerPass";
            this.lbSellerPass.Size = new System.Drawing.Size(169, 50);
            this.lbSellerPass.TabIndex = 17;
            this.lbSellerPass.Text = "";
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Seller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox lbSellerPhone;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox lbSellerAge;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox lbSellerName;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox lbSellerId;
        private System.Windows.Forms.DataGridView dgvSeller;
        private MaterialSkin.Controls.MaterialButton btnDelSel;
        private MaterialSkin.Controls.MaterialButton btnEditSel;
        private MaterialSkin.Controls.MaterialButton btnAddSel;
        private MaterialSkin.Controls.MaterialTextBox lbSellerPass;
    }
}