using System.Windows.Forms;

namespace RentACar.Client.UserControls
{
    partial class UCZakazivanjePrikaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCZakazivanjePrikaz));
            this.btnDodajZakazivanje = new System.Windows.Forms.Button();
            this.btnIzmeniZakazivanje = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajZakazivanje
            // 
            this.btnDodajZakazivanje.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajZakazivanje.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZakazivanje.ForeColor = System.Drawing.Color.Linen;
            this.btnDodajZakazivanje.Location = new System.Drawing.Point(45, 534);
            this.btnDodajZakazivanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajZakazivanje.Name = "btnDodajZakazivanje";
            this.btnDodajZakazivanje.Size = new System.Drawing.Size(205, 36);
            this.btnDodajZakazivanje.TabIndex = 9;
            this.btnDodajZakazivanje.Text = "Dodaj";
            this.btnDodajZakazivanje.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniZakazivanje
            // 
            this.btnIzmeniZakazivanje.BackColor = System.Drawing.Color.Maroon;
            this.btnIzmeniZakazivanje.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniZakazivanje.ForeColor = System.Drawing.Color.Linen;
            this.btnIzmeniZakazivanje.Location = new System.Drawing.Point(293, 534);
            this.btnIzmeniZakazivanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeniZakazivanje.Name = "btnIzmeniZakazivanje";
            this.btnIzmeniZakazivanje.Size = new System.Drawing.Size(205, 36);
            this.btnIzmeniZakazivanje.TabIndex = 8;
            this.btnIzmeniZakazivanje.Text = "Izmeni";
            this.btnIzmeniZakazivanje.UseVisualStyleBackColor = false;
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(44, 189);
            this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(660, 320);
            this.dgvKlijenti.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prikaz svih zakazanih vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pretrazi...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 135);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(452, 36);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "pretrazi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.BackColor = System.Drawing.Color.Maroon;
            this.btnUcitaj.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitaj.ForeColor = System.Drawing.Color.Linen;
            this.btnUcitaj.Location = new System.Drawing.Point(528, 534);
            this.btnUcitaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(205, 36);
            this.btnUcitaj.TabIndex = 14;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = false;
            // 
            // UCZakazivanjePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajZakazivanje);
            this.Controls.Add(this.btnIzmeniZakazivanje);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCZakazivanjePrikaz";
            this.Size = new System.Drawing.Size(996, 606);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajZakazivanje;
        private System.Windows.Forms.Button btnIzmeniZakazivanje;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button btnUcitaj;

        public Button BtnDodajZakazivanje { get => btnDodajZakazivanje; set => btnDodajZakazivanje = value; }
        public Button BtnIzmeniZakazivanje { get => btnIzmeniZakazivanje; set => btnIzmeniZakazivanje = value; }
        public DataGridView DgvKlijenti { get => dgvKlijenti; set => dgvKlijenti = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public Button BtnUcitaj { get => btnUcitaj; set => btnUcitaj = value; }
        
    }
}
