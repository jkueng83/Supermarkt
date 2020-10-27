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
            this.btAddProduct.Location = new System.Drawing.Point(498, 45);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btAddProduct.TabIndex = 0;
            this.btAddProduct.Text = "Hinzufügen";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btRemoveProduct
            // 
            this.btRemoveProduct.Location = new System.Drawing.Point(651, 45);
            this.btRemoveProduct.Name = "btRemoveProduct";
            this.btRemoveProduct.Size = new System.Drawing.Size(100, 30);
            this.btRemoveProduct.TabIndex = 1;
            this.btRemoveProduct.Text = "Entfernen";
            this.btRemoveProduct.UseVisualStyleBackColor = true;
            this.btRemoveProduct.Click += new System.EventHandler(this.btRemoveProduct_Click);
            // 
            // lBoxShopingList
            // 
            this.lBoxShopingList.FormattingEnabled = true;
            this.lBoxShopingList.ItemHeight = 16;
            this.lBoxShopingList.Location = new System.Drawing.Point(138, 241);
            this.lBoxShopingList.Name = "lBoxShopingList";
            this.lBoxShopingList.Size = new System.Drawing.Size(370, 148);
            this.lBoxShopingList.TabIndex = 2;
            // 
            // tbArticle
            // 
            this.tbArticle.Location = new System.Drawing.Point(138, 45);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(130, 22);
            this.tbArticle.TabIndex = 3;
            this.tbArticle.Text = "Artikel";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(336, 45);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 22);
            this.tbQuantity.TabIndex = 4;
            this.tbQuantity.Text = "Anzahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbArticle);
            this.Controls.Add(this.lBoxShopingList);
            this.Controls.Add(this.btRemoveProduct);
            this.Controls.Add(this.btAddProduct);
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

