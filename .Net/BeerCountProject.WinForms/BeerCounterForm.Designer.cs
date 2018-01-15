namespace BeerCountProject.WinForms
{
    partial class BeerCountForm
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
            this.btnAddNewBeer = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbBeerCount = new System.Windows.Forms.Label();
            this.btnDrink = new System.Windows.Forms.Button();
            this.txtBeerCount = new System.Windows.Forms.Label();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNewBeer
            // 
            this.btnAddNewBeer.Location = new System.Drawing.Point(229, 9);
            this.btnAddNewBeer.Name = "btnAddNewBeer";
            this.btnAddNewBeer.Size = new System.Drawing.Size(120, 25);
            this.btnAddNewBeer.TabIndex = 0;
            this.btnAddNewBeer.Text = "Add new beer ";
            this.btnAddNewBeer.UseVisualStyleBackColor = true;
            this.btnAddNewBeer.Click += new System.EventHandler(this.betnAddNewBeer_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(94, 9);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 22);
            this.tbPrice.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(12, 9);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(40, 17);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // lbBeerCount
            // 
            this.lbBeerCount.AutoSize = true;
            this.lbBeerCount.Location = new System.Drawing.Point(13, 55);
            this.lbBeerCount.Name = "lbBeerCount";
            this.lbBeerCount.Size = new System.Drawing.Size(75, 17);
            this.lbBeerCount.TabIndex = 4;
            this.lbBeerCount.Text = "BeerCount";
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(229, 55);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(120, 25);
            this.btnDrink.TabIndex = 5;
            this.btnDrink.Text = "Drink ";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // txtBeerCount
            // 
            this.txtBeerCount.AutoSize = true;
            this.txtBeerCount.Location = new System.Drawing.Point(94, 55);
            this.txtBeerCount.Name = "txtBeerCount";
            this.txtBeerCount.Size = new System.Drawing.Size(0, 17);
            this.txtBeerCount.TabIndex = 6;
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Location = new System.Drawing.Point(13, 91);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(62, 17);
            this.lbTotalBill.TabIndex = 7;
            this.lbTotalBill.Text = "Total Bill";
            // 
            // txtBill
            // 
            this.txtBill.AutoSize = true;
            this.txtBill.Location = new System.Drawing.Point(94, 91);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(0, 17);
            this.txtBill.TabIndex = 8;
            // 
            // BeerCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 141);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lbTotalBill);
            this.Controls.Add(this.txtBeerCount);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.lbBeerCount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnAddNewBeer);
            this.Name = "BeerCountForm";
            this.Text = "BeerCountProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBeer;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbBeerCount;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Label txtBeerCount;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.Label txtBill;
    }
}

