using System.Windows.Forms;

namespace RentACar.Client.UserControls
{
    partial class UCKreirajKlijenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKreirajKlijenta));
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKreirajKlijenta = new System.Windows.Forms.Button();
            this.btnIzmeniKlijenta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.LightYellow;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.Location = new System.Drawing.Point(208, 368);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(279, 36);
            this.txtMail.TabIndex = 38;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.LightYellow;
            this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.Color.Black;
            this.txtPrezime.Location = new System.Drawing.Point(208, 288);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(279, 36);
            this.txtPrezime.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(92, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(76, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Prezime :";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.LightYellow;
            this.txtIme.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.Black;
            this.txtIme.Location = new System.Drawing.Point(208, 210);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(279, 36);
            this.txtIme.TabIndex = 34;
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.Color.LightYellow;
            this.txtJMBG.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.ForeColor = System.Drawing.Color.Black;
            this.txtJMBG.Location = new System.Drawing.Point(208, 125);
            this.txtJMBG.Margin = new System.Windows.Forms.Padding(4);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(279, 36);
            this.txtJMBG.TabIndex = 33;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(114, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ime :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(94, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 31;
            this.label1.Text = "JMBG :";
            // 
            // btnKreirajKlijenta
            // 
            this.btnKreirajKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajKlijenta.BackColor = System.Drawing.Color.Linen;
            this.btnKreirajKlijenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajKlijenta.ForeColor = System.Drawing.Color.Maroon;
            this.btnKreirajKlijenta.Location = new System.Drawing.Point(208, 452);
            this.btnKreirajKlijenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreirajKlijenta.Name = "btnKreirajKlijenta";
            this.btnKreirajKlijenta.Size = new System.Drawing.Size(279, 36);
            this.btnKreirajKlijenta.TabIndex = 30;
            this.btnKreirajKlijenta.Text = "Kreiraj klijenta";
            this.btnKreirajKlijenta.UseVisualStyleBackColor = false;
           
            // 
            // btnIzmeniKlijenta
            // 
            this.btnIzmeniKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniKlijenta.BackColor = System.Drawing.Color.Linen;
            this.btnIzmeniKlijenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKlijenta.ForeColor = System.Drawing.Color.Maroon;
            this.btnIzmeniKlijenta.Location = new System.Drawing.Point(208, 516);
            this.btnIzmeniKlijenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniKlijenta.Name = "btnIzmeniKlijenta";
            this.btnIzmeniKlijenta.Size = new System.Drawing.Size(279, 36);
            this.btnIzmeniKlijenta.TabIndex = 53;
            this.btnIzmeniKlijenta.Text = "Izmeni klijenta";
            this.btnIzmeniKlijenta.UseVisualStyleBackColor = false;
          
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(47, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 44);
            this.label5.TabIndex = 54;
            this.label5.Text = "Kreiraj klijenta";
            // 
            // UCKreirajKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIzmeniKlijenta);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreirajKlijenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCKreirajKlijenta";
            this.Size = new System.Drawing.Size(724, 625);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreirajKlijenta;
        private Button btnIzmeniKlijenta;
        private Label label5;

        public TextBox TxtMail { get => txtMail; set => txtMail = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnKreirajKlijenta { get => btnKreirajKlijenta; set => btnKreirajKlijenta = value; }
        public Button BtnIzmeniKlijenta { get => btnIzmeniKlijenta; set => btnIzmeniKlijenta = value; }
        public Label Label5 { get => label5; set => label5 = value; }
    }
}
