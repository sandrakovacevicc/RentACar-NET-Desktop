using System.Windows.Forms;

namespace RentACar.Client.UserControls
{
    partial class UCPrikaziKlijente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPrikaziKlijente));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.btnIzmeniKlijenta = new System.Windows.Forms.Button();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(501, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretrazi klijente...";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.ForeColor = System.Drawing.Color.Black;
            this.txtPretraga.Location = new System.Drawing.Point(505, 82);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(207, 36);
            this.txtPretraga.TabIndex = 1;
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.GridColor = System.Drawing.Color.Linen;
            this.dgvKlijenti.Location = new System.Drawing.Point(52, 150);
            this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.RowHeadersWidth = 51;
            this.dgvKlijenti.RowTemplate.Height = 24;
            this.dgvKlijenti.Size = new System.Drawing.Size(660, 320);
            this.dgvKlijenti.TabIndex = 2;
            // 
            // btnIzmeniKlijenta
            // 
            this.btnIzmeniKlijenta.BackColor = System.Drawing.Color.Maroon;
            this.btnIzmeniKlijenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKlijenta.ForeColor = System.Drawing.Color.Linen;
            this.btnIzmeniKlijenta.Location = new System.Drawing.Point(285, 506);
            this.btnIzmeniKlijenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeniKlijenta.Name = "btnIzmeniKlijenta";
            this.btnIzmeniKlijenta.Size = new System.Drawing.Size(205, 42);
            this.btnIzmeniKlijenta.TabIndex = 3;
            this.btnIzmeniKlijenta.Text = "Izmeni klijenta";
            this.btnIzmeniKlijenta.UseVisualStyleBackColor = false;
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajKlijenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKlijenta.ForeColor = System.Drawing.Color.Linen;
            this.btnDodajKlijenta.Location = new System.Drawing.Point(52, 506);
            this.btnDodajKlijenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(216, 42);
            this.btnDodajKlijenta.TabIndex = 4;
            this.btnDodajKlijenta.Text = "Dodaj novog klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = false;
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.Maroon;
            this.btnDetalji.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.Linen;
            this.btnDetalji.Location = new System.Drawing.Point(515, 506);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(197, 42);
            this.btnDetalji.TabIndex = 5;
            this.btnDetalji.Text = "Detalij";
            this.btnDetalji.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 44);
            this.label5.TabIndex = 55;
            this.label5.Text = "Prikazi klijente";
            // 
            // UCPrikaziKlijente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnDodajKlijenta);
            this.Controls.Add(this.btnIzmeniKlijenta);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCPrikaziKlijente";
            this.Size = new System.Drawing.Size(830, 603);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button btnIzmeniKlijenta;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private Button btnDetalji;
        private Label label5;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public DataGridView DgvKlijenti { get => dgvKlijenti; set => dgvKlijenti = value; }
        public Button BtnIzmeniKlijenta { get => btnIzmeniKlijenta; set => btnIzmeniKlijenta = value; }
        public Button BtnDodajKlijenta { get => btnDodajKlijenta; set => btnDodajKlijenta = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
    }
}
