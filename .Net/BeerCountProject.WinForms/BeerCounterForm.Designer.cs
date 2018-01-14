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
            this.betnAddNewBeer = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // betnAddNewBeer
            // 
            this.betnAddNewBeer.Location = new System.Drawing.Point(195, 9);
            this.betnAddNewBeer.Name = "betnAddNewBeer";
            this.betnAddNewBeer.Size = new System.Drawing.Size(110, 23);
            this.betnAddNewBeer.TabIndex = 0;
            this.betnAddNewBeer.Text = "Add new beer ";
            this.betnAddNewBeer.UseVisualStyleBackColor = true;
            this.betnAddNewBeer.Click += new System.EventHandler(this.betnAddNewBeer_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(69, 9);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.betnAddNewBeer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button betnAddNewBeer;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}

