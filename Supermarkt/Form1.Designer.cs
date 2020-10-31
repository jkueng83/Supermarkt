namespace Supermarkt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btRemoveProduct = new System.Windows.Forms.Button();
            this.lBoxShopingList = new System.Windows.Forms.ListBox();
            this.tbArticle = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAddProduct
            // 
            this.btAddProduct.AutoEllipsis = true;
            this.btAddProduct.Location = new System.Drawing.Point(374, 37);
            this.btAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(75, 24);
            this.btAddProduct.TabIndex = 0;
            this.btAddProduct.Text = "Hinzufügen";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btRemoveProduct
            // 
            this.btRemoveProduct.Location = new System.Drawing.Point(488, 37);
            this.btRemoveProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemoveProduct.Name = "btRemoveProduct";
            this.btRemoveProduct.Size = new System.Drawing.Size(75, 24);
            this.btRemoveProduct.TabIndex = 1;
            this.btRemoveProduct.Text = "Entfernen";
            this.btRemoveProduct.UseVisualStyleBackColor = true;
            this.btRemoveProduct.Click += new System.EventHandler(this.btRemoveProduct_Click);
            // 
            // lBoxShopingList
            // 
            this.lBoxShopingList.FormattingEnabled = true;
            this.lBoxShopingList.Location = new System.Drawing.Point(104, 196);
            this.lBoxShopingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBoxShopingList.Name = "lBoxShopingList";
            this.lBoxShopingList.Size = new System.Drawing.Size(278, 121);
            this.lBoxShopingList.TabIndex = 2;
            // 
            // tbArticle
            // 
            this.tbArticle.Location = new System.Drawing.Point(104, 37);
            this.tbArticle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(98, 20);
            this.tbArticle.TabIndex = 3;
            this.tbArticle.Text = "Artikel";
            this.tbArticle.Click += new System.EventHandler(this.tbArticle_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(252, 37);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(76, 20);
            this.tbQuantity.TabIndex = 4;
            this.tbQuantity.Text = "Anzahl";
            this.tbQuantity.Click += new System.EventHandler(this.tbQuantity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbArticle);
            this.Controls.Add(this.lBoxShopingList);
            this.Controls.Add(this.btRemoveProduct);
            this.Controls.Add(this.btAddProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btRemoveProduct;
        private System.Windows.Forms.ListBox lBoxShopingList;
        private System.Windows.Forms.TextBox tbArticle;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}

