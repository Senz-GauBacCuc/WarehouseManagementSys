namespace WarehouseManagementSystem
{
    partial class Category
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
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnDelCat = new MaterialSkin.Controls.MaterialButton();
            this.btnEditCat = new MaterialSkin.Controls.MaterialButton();
            this.btnAddCat = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCatDes = new MaterialSkin.Controls.MaterialTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCatName = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCatID = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.dgvCategory);
            this.panel1.Controls.Add(this.btnDelCat);
            this.panel1.Controls.Add(this.btnEditCat);
            this.panel1.Controls.Add(this.btnAddCat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbCatDes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbCatName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbCatID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 500);
            this.panel1.TabIndex = 1;
            // 
            // dgvCategory
            // 
            this.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategory.Location = new System.Drawing.Point(469, 42);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(417, 339);
            this.dgvCategory.TabIndex = 25;
            this.dgvCategory.SelectionChanged += new System.EventHandler(this.dgvCategory_SelectionChanged);
            // 
            // btnDelCat
            // 
            this.btnDelCat.AutoSize = false;
            this.btnDelCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelCat.Depth = 0;
            this.btnDelCat.DrawShadows = true;
            this.btnDelCat.HighEmphasis = true;
            this.btnDelCat.Icon = null;
            this.btnDelCat.Location = new System.Drawing.Point(355, 231);
            this.btnDelCat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelCat.Name = "btnDelCat";
            this.btnDelCat.Size = new System.Drawing.Size(92, 36);
            this.btnDelCat.TabIndex = 24;
            this.btnDelCat.Text = "DELETE";
            this.btnDelCat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelCat.UseAccentColor = false;
            this.btnDelCat.UseVisualStyleBackColor = true;
            this.btnDelCat.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.AutoSize = false;
            this.btnEditCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditCat.Depth = 0;
            this.btnEditCat.DrawShadows = true;
            this.btnEditCat.HighEmphasis = true;
            this.btnEditCat.Icon = null;
            this.btnEditCat.Location = new System.Drawing.Point(255, 231);
            this.btnEditCat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(92, 36);
            this.btnEditCat.TabIndex = 23;
            this.btnEditCat.Text = "EDIT";
            this.btnEditCat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditCat.UseAccentColor = false;
            this.btnEditCat.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.AutoSize = false;
            this.btnAddCat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCat.Depth = 0;
            this.btnAddCat.DrawShadows = true;
            this.btnAddCat.HighEmphasis = true;
            this.btnAddCat.Icon = null;
            this.btnAddCat.Location = new System.Drawing.Point(155, 231);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(92, 36);
            this.btnAddCat.TabIndex = 22;
            this.btnAddCat.Text = "ADD";
            this.btnAddCat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCat.UseAccentColor = false;
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "DESCRIPTION";
            // 
            // lbCatDes
            // 
            this.lbCatDes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCatDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCatDes.Depth = 0;
            this.lbCatDes.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbCatDes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCatDes.Location = new System.Drawing.Point(159, 154);
            this.lbCatDes.MaxLength = 50;
            this.lbCatDes.MouseState = MaterialSkin.MouseState.OUT;
            this.lbCatDes.Multiline = false;
            this.lbCatDes.Name = "lbCatDes";
            this.lbCatDes.Size = new System.Drawing.Size(288, 50);
            this.lbCatDes.TabIndex = 15;
            this.lbCatDes.Text = "";
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
            // lbCatName
            // 
            this.lbCatName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCatName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCatName.Depth = 0;
            this.lbCatName.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbCatName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCatName.Location = new System.Drawing.Point(159, 98);
            this.lbCatName.MaxLength = 50;
            this.lbCatName.MouseState = MaterialSkin.MouseState.OUT;
            this.lbCatName.Multiline = false;
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(288, 50);
            this.lbCatName.TabIndex = 14;
            this.lbCatName.Text = "";
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
            // lbCatID
            // 
            this.lbCatID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCatID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCatID.Depth = 0;
            this.lbCatID.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbCatID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCatID.Location = new System.Drawing.Point(159, 42);
            this.lbCatID.MaxLength = 50;
            this.lbCatID.MouseState = MaterialSkin.MouseState.OUT;
            this.lbCatID.Multiline = false;
            this.lbCatID.Name = "lbCatID";
            this.lbCatID.Size = new System.Drawing.Size(288, 50);
            this.lbCatID.TabIndex = 13;
            this.lbCatID.Text = "";
            this.lbCatID.TextChanged += new System.EventHandler(this.lbCatID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "CATEGORY MANAGEMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(1047, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 33);
            this.label4.TabIndex = 26;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.materialButton3.TabIndex = 29;
            this.materialButton3.Text = "SELLING";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
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
            this.materialButton2.TabIndex = 28;
            this.materialButton2.Text = "PRODUCT";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
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
            this.materialButton1.TabIndex = 27;
            this.materialButton1.Text = "SELLERS";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.UseWaitCursor = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 579);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCategory;
        private MaterialSkin.Controls.MaterialButton btnDelCat;
        private MaterialSkin.Controls.MaterialButton btnEditCat;
        private MaterialSkin.Controls.MaterialButton btnAddCat;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox lbCatDes;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox lbCatName;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox lbCatID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}