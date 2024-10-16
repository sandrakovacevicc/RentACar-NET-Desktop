using System.Windows.Forms;

namespace RentACar.Client.UserControls
{
    partial class UCZakazivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCZakazivanje));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.checkedListVozila = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajVozila = new System.Windows.Forms.Button();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.txtZakazivanje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zakazivanje";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.BackColor = System.Drawing.Color.White;
            this.cmbKlijent.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(595, 124);
            this.cmbKlijent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(279, 35);
            this.cmbKlijent.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightYellow;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(467, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 62;
            this.label6.Text = "Klijent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(61, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 64;
            this.label2.Text = "Od :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(159, 201);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 65;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(595, 204);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightYellow;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(523, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 27);
            this.label3.TabIndex = 67;
            this.label3.Text = "Do :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightYellow;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(589, 524);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 68;
            this.label4.Text = "Iznos :";
            // 
            // txtIznos
            // 
            this.txtIznos.BackColor = System.Drawing.Color.White;
            this.txtIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznos.Location = new System.Drawing.Point(708, 523);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(148, 28);
            this.txtIznos.TabIndex = 69;
            // 
            // checkedListVozila
            // 
            this.checkedListVozila.FormattingEnabled = true;
            this.checkedListVozila.Location = new System.Drawing.Point(92, 85);
            this.checkedListVozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListVozila.Name = "checkedListVozila";
            this.checkedListVozila.Size = new System.Drawing.Size(347, 157);
            this.checkedListVozila.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 27);
            this.label5.TabIndex = 71;
            this.label5.Text = "Izaberi vozila :";
            // 
            // btnDodajVozila
            // 
            this.btnDodajVozila.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozila.Location = new System.Drawing.Point(31, 276);
            this.btnDodajVozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajVozila.Name = "btnDodajVozila";
            this.btnDodajVozila.Size = new System.Drawing.Size(147, 42);
            this.btnDodajVozila.TabIndex = 72;
            this.btnDodajVozila.Text = "Dodaj vozila";
            this.btnDodajVozila.UseVisualStyleBackColor = true;
            // 
            // btnZakazi
            // 
            this.btnZakazi.BackColor = System.Drawing.Color.Maroon;
            this.btnZakazi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.ForeColor = System.Drawing.Color.Linen;
            this.btnZakazi.Location = new System.Drawing.Point(708, 656);
            this.btnZakazi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(148, 42);
            this.btnZakazi.TabIndex = 75;
            this.btnZakazi.Text = "Zakazi";
            this.btnZakazi.UseVisualStyleBackColor = false;
            // 
            // txtZakazivanje
            // 
            this.txtZakazivanje.BackColor = System.Drawing.Color.White;
            this.txtZakazivanje.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZakazivanje.Location = new System.Drawing.Point(595, 69);
            this.txtZakazivanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZakazivanje.Name = "txtZakazivanje";
            this.txtZakazivanje.Size = new System.Drawing.Size(247, 36);
            this.txtZakazivanje.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightYellow;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(427, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 27);
            this.label7.TabIndex = 76;
            this.label7.Text = "Zaposleni :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.btnDodajVozila);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkedListVozila);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(67, 438);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(493, 336);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vozila";
            // 
            // UCZakazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtZakazivanje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCZakazivanje";
            this.Size = new System.Drawing.Size(915, 775);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.CheckedListBox checkedListVozila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajVozila;
        private System.Windows.Forms.Button btnZakazi;
        private TextBox txtZakazivanje;
        private Label label7;
        private GroupBox groupBox1;

        public Label Label1 { get => label1; set => label1 = value; }
        public ComboBox CmbKlijent { get => cmbKlijent; set => cmbKlijent = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public MonthCalendar MonthCalendar1 { get => monthCalendar1; set => monthCalendar1 = value; }
        public MonthCalendar MonthCalendar2 { get => monthCalendar2; set => monthCalendar2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public CheckedListBox CheckedListVozila { get => checkedListVozila; set => checkedListVozila = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnDodajVozila { get => btnDodajVozila; set => btnDodajVozila = value; }
        public Button BtnZakazi { get => btnZakazi; set => btnZakazi = value; }
        public TextBox TxtZakazivanje { get => txtZakazivanje; set => txtZakazivanje = value; }
        public Label Label7 { get => label7; set => label7 = value; }
       
    }
}
