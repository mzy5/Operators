namespace Operators
{
    partial class Form1
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
            this.txtNumar1 = new System.Windows.Forms.TextBox();
            this.txtNumar2 = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtDiferenta = new System.Windows.Forms.TextBox();
            this.txtProdus = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.lblNr1 = new System.Windows.Forms.Label();
            this.lblNr2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblDiferenta = new System.Windows.Forms.Label();
            this.lblProdus = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumar1
            // 
            this.txtNumar1.Location = new System.Drawing.Point(49, 138);
            this.txtNumar1.Name = "txtNumar1";
            this.txtNumar1.Size = new System.Drawing.Size(100, 20);
            this.txtNumar1.TabIndex = 0;
            // 
            // txtNumar2
            // 
            this.txtNumar2.Location = new System.Drawing.Point(199, 138);
            this.txtNumar2.Name = "txtNumar2";
            this.txtNumar2.Size = new System.Drawing.Size(100, 20);
            this.txtNumar2.TabIndex = 1;
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(544, 31);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 3;
            // 
            // txtDiferenta
            // 
            this.txtDiferenta.Location = new System.Drawing.Point(544, 96);
            this.txtDiferenta.Name = "txtDiferenta";
            this.txtDiferenta.Size = new System.Drawing.Size(100, 20);
            this.txtDiferenta.TabIndex = 2;
            // 
            // txtProdus
            // 
            this.txtProdus.Location = new System.Drawing.Point(544, 185);
            this.txtProdus.Name = "txtProdus";
            this.txtProdus.Size = new System.Drawing.Size(100, 20);
            this.txtProdus.TabIndex = 5;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(544, 252);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 20);
            this.txtCat.TabIndex = 4;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(390, 135);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(75, 23);
            this.btnCalculeaza.TabIndex = 6;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // lblNr1
            // 
            this.lblNr1.AutoSize = true;
            this.lblNr1.Location = new System.Drawing.Point(46, 119);
            this.lblNr1.Name = "lblNr1";
            this.lblNr1.Size = new System.Drawing.Size(44, 13);
            this.lblNr1.TabIndex = 7;
            this.lblNr1.Text = "Numar1";
            // 
            // lblNr2
            // 
            this.lblNr2.AutoSize = true;
            this.lblNr2.Location = new System.Drawing.Point(196, 119);
            this.lblNr2.Name = "lblNr2";
            this.lblNr2.Size = new System.Drawing.Size(44, 13);
            this.lblNr2.TabIndex = 8;
            this.lblNr2.Text = "Numar2";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(541, 15);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(34, 13);
            this.lblSuma.TabIndex = 9;
            this.lblSuma.Text = "Suma";
            // 
            // lblDiferenta
            // 
            this.lblDiferenta.AutoSize = true;
            this.lblDiferenta.Location = new System.Drawing.Point(541, 80);
            this.lblDiferenta.Name = "lblDiferenta";
            this.lblDiferenta.Size = new System.Drawing.Size(50, 13);
            this.lblDiferenta.TabIndex = 10;
            this.lblDiferenta.Text = "Diferenta";
            // 
            // lblProdus
            // 
            this.lblProdus.AutoSize = true;
            this.lblProdus.Location = new System.Drawing.Point(541, 169);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(40, 13);
            this.lblProdus.TabIndex = 11;
            this.lblProdus.Text = "Produs";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(541, 236);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(23, 13);
            this.lblCat.TabIndex = 12;
            this.lblCat.Text = "Cat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 377);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblProdus);
            this.Controls.Add(this.lblDiferenta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblNr2);
            this.Controls.Add(this.lblNr1);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.txtProdus);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtDiferenta);
            this.Controls.Add(this.txtNumar2);
            this.Controls.Add(this.txtNumar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumar1;
        private System.Windows.Forms.TextBox txtNumar2;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtDiferenta;
        private System.Windows.Forms.TextBox txtProdus;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Label lblNr1;
        private System.Windows.Forms.Label lblNr2;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblDiferenta;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.Label lblCat;
    }
}

