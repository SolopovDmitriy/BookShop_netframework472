
namespace BookShop_netframework472
{
    partial class BuyBookForm
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
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.buttonFindByGenre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewBooks = new System.Windows.Forms.Button();
            this.buttonBasket = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonFindByBookName = new System.Windows.Forms.Button();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.buttonFindByAuthor = new System.Windows.Forms.Button();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(18, 14);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGenre.TabIndex = 1;
            // 
            // buttonFindByGenre
            // 
            this.buttonFindByGenre.Location = new System.Drawing.Point(18, 54);
            this.buttonFindByGenre.Name = "buttonFindByGenre";
            this.buttonFindByGenre.Size = new System.Drawing.Size(121, 38);
            this.buttonFindByGenre.TabIndex = 2;
            this.buttonFindByGenre.Text = "Find by Genre";
            this.buttonFindByGenre.UseVisualStyleBackColor = true;
            this.buttonFindByGenre.Click += new System.EventHandler(this.buttonFindByGenre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNewBooks);
            this.panel1.Controls.Add(this.buttonBasket);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.buttonFindByBookName);
            this.panel1.Controls.Add(this.textBoxBookName);
            this.panel1.Controls.Add(this.buttonFindByAuthor);
            this.panel1.Controls.Add(this.comboBoxAuthor);
            this.panel1.Controls.Add(this.comboBoxGenre);
            this.panel1.Controls.Add(this.buttonFindByGenre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 135);
            this.panel1.TabIndex = 3;
            // 
            // buttonNewBooks
            // 
            this.buttonNewBooks.Location = new System.Drawing.Point(724, 13);
            this.buttonNewBooks.Name = "buttonNewBooks";
            this.buttonNewBooks.Size = new System.Drawing.Size(119, 80);
            this.buttonNewBooks.TabIndex = 9;
            this.buttonNewBooks.Text = "New books";
            this.buttonNewBooks.UseVisualStyleBackColor = true;
            this.buttonNewBooks.Click += new System.EventHandler(this.buttonNewBooks_Click);
            // 
            // buttonBasket
            // 
            this.buttonBasket.Location = new System.Drawing.Point(1071, 14);
            this.buttonBasket.Name = "buttonBasket";
            this.buttonBasket.Size = new System.Drawing.Size(144, 79);
            this.buttonBasket.TabIndex = 8;
            this.buttonBasket.Text = "Shopping basket";
            this.buttonBasket.UseVisualStyleBackColor = true;
            this.buttonBasket.Click += new System.EventHandler(this.buttonBasket_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(884, 14);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(151, 78);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonFindByBookName
            // 
            this.buttonFindByBookName.Location = new System.Drawing.Point(527, 54);
            this.buttonFindByBookName.Name = "buttonFindByBookName";
            this.buttonFindByBookName.Size = new System.Drawing.Size(176, 38);
            this.buttonFindByBookName.TabIndex = 6;
            this.buttonFindByBookName.Text = "Find By Book Name";
            this.buttonFindByBookName.UseVisualStyleBackColor = true;
            this.buttonFindByBookName.Click += new System.EventHandler(this.buttonFindByBookName_Click);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(527, 13);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(176, 22);
            this.textBoxBookName.TabIndex = 5;
            // 
            // buttonFindByAuthor
            // 
            this.buttonFindByAuthor.Location = new System.Drawing.Point(247, 54);
            this.buttonFindByAuthor.Name = "buttonFindByAuthor";
            this.buttonFindByAuthor.Size = new System.Drawing.Size(151, 38);
            this.buttonFindByAuthor.TabIndex = 4;
            this.buttonFindByAuthor.Text = "Find by author";
            this.buttonFindByAuthor.UseVisualStyleBackColor = true;
            this.buttonFindByAuthor.Click += new System.EventHandler(this.buttonFindByAuthor_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(247, 13);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(151, 24);
            this.comboBoxAuthor.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewBooks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 616);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1272, 616);
            this.dataGridViewBooks.TabIndex = 1;
            // 
            // BuyBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 751);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BuyBookForm";
            this.Text = "Buy Book Form";
            this.Load += new System.EventHandler(this.FindBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonFindByGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonFindByBookName;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button buttonFindByAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonBasket;
        private System.Windows.Forms.Button buttonNewBooks;
    }
}