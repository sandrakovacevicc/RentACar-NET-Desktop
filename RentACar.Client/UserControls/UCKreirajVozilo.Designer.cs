using System.Windows.Forms;

namespace RentACar.Client.UserControls
{
    partial class UCKreirajVozilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKreirajVozilo));
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtRegBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKreirajVozilo = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipVozila = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGoriva = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.ForeColor = System.Drawing.Color.Black;
            this.txtModel.Location = new System.Drawing.Point(347, 283);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(279, 36);
            this.txtModel.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(223, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 45;
            this.label3.Text = "Gorivo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(155, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 44;
            this.label4.Text = "Model vozila :";
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.Color.White;
            this.txtMarka.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarka.ForeColor = System.Drawing.Color.Black;
            this.txtMarka.Location = new System.Drawing.Point(347, 198);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(279, 36);
            this.txtMarka.TabIndex = 43;
            // 
            // txtRegBroj
            // 
            this.txtRegBroj.BackColor = System.Drawing.Color.White;
            this.txtRegBroj.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegBroj.ForeColor = System.Drawing.Color.Black;
            this.txtRegBroj.Location = new System.Drawing.Point(347, 119);
            this.txtRegBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegBroj.Name = "txtRegBroj";
            this.txtRegBroj.Size = new System.Drawing.Size(279, 36);
            this.txtRegBroj.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(153, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Marka vozila :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(106, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Registracioni broj :";
            // 
            // btnKreirajVozilo
            // 
            this.btnKreirajVozilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajVozilo.BackColor = System.Drawing.Color.Maroon;
            this.btnKreirajVozilo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajVozilo.ForeColor = System.Drawing.Color.Linen;
            this.btnKreirajVozilo.Location = new System.Drawing.Point(255, 609);
            this.btnKreirajVozilo.Margin = new System.Windows.Forms.Padding(4);
            this.btnKreirajVozilo.Name = "btnKreirajVozilo";
            this.btnKreirajVozilo.Size = new System.Drawing.Size(284, 36);
            this.btnKreirajVozilo.TabIndex = 39;
            this.btnKreirajVozilo.Text = "Kreiraj vozilo";
            this.btnKreirajVozilo.UseVisualStyleBackColor = false;
            // 
            // txtCena
            // 
            this.txtCena.BackColor = System.Drawing.Color.White;
            this.txtCena.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.ForeColor = System.Drawing.Color.Black;
            this.txtCena.Location = new System.Drawing.Point(347, 444);
            this.txtCena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(279, 36);
            this.txtCena.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(237, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cena :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(194, 518);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 27);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tip vozila :";
            // 
            // cmbTipVozila
            // 
            this.cmbTipVozila.BackColor = System.Drawing.Color.White;
            this.cmbTipVozila.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipVozila.ForeColor = System.Drawing.Color.Black;
            this.cmbTipVozila.FormattingEnabled = true;
            this.cmbTipVozila.Location = new System.Drawing.Point(347, 518);
            this.cmbTipVozila.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipVozila.Name = "cmbTipVozila";
            this.cmbTipVozila.Size = new System.Drawing.Size(279, 35);
            this.cmbTipVozila.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 44);
            this.label7.TabIndex = 55;
            this.label7.Text = "Kreiraj vozilo";
            // 
            // cmbGoriva
            // 
            this.cmbGoriva.BackColor = System.Drawing.Color.White;
            this.cmbGoriva.ForeColor = System.Drawing.Color.Black;
            this.cmbGoriva.FormattingEnabled = true;
            this.cmbGoriva.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Gas"});
            this.cmbGoriva.Location = new System.Drawing.Point(347, 360);
            this.cmbGoriva.Name = "cmbGoriva";
            this.cmbGoriva.Size = new System.Drawing.Size(283, 30);
            this.cmbGoriva.TabIndex = 56;
            // 
            // UCKreirajVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cmbGoriva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipVozila);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtRegBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreirajVozilo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCKreirajVozilo";
            this.Size = new System.Drawing.Size(752, 715);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtRegBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreirajVozilo;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipVozila;
        private Label label7;
        private ComboBox cmbGoriva;

       
        public TextBox TxtModel { get => txtModel; set => txtModel = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtMarka { get => txtMarka; set => txtMarka = value; }
        public TextBox TxtRegBroj { get => txtRegBroj; set => txtRegBroj = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnKreirajVozilo { get => btnKreirajVozilo; set => btnKreirajVozilo = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public ComboBox CmbTipVozila { get => cmbTipVozila; set => cmbTipVozila = value; }
        public ComboBox CmbGoriva { get => cmbGoriva; set => cmbGoriva = value; }
        public Label Label7 { get => label7; set => label7 = value; }
    }
}
