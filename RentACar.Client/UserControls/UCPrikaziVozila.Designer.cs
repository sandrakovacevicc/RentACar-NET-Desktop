using System.Windows.Forms;

namespace RentACar.Client.UserControls
{
    partial class UCPrikaziVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPrikaziVozila));
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.txtPretragaV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.Linen;
            this.btnDodajVozilo.Location = new System.Drawing.Point(65, 498);
            this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(205, 47);
            this.btnDodajVozilo.TabIndex = 9;
            this.btnDodajVozilo.Text = "Dodaj novo vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.BackColor = System.Drawing.Color.Maroon;
            this.btnObrisiVozilo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiVozilo.ForeColor = System.Drawing.Color.Linen;
            this.btnObrisiVozilo.Location = new System.Drawing.Point(300, 498);
            this.btnObrisiVozilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(205, 47);
            this.btnObrisiVozilo.TabIndex = 8;
            this.btnObrisiVozilo.Text = "Obriši vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = false;
            // 
            // dgvVozila
            // 
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(65, 143);
            this.dgvVozila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.Size = new System.Drawing.Size(660, 320);
            this.dgvVozila.TabIndex = 7;
            // 
            // txtPretragaV
            // 
            this.txtPretragaV.BackColor = System.Drawing.Color.White;
            this.txtPretragaV.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretragaV.Location = new System.Drawing.Point(517, 78);
            this.txtPretragaV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretragaV.Name = "txtPretragaV";
            this.txtPretragaV.Size = new System.Drawing.Size(207, 36);
            this.txtPretragaV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(513, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretrazi vozila...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 44);
            this.label5.TabIndex = 56;
            this.label5.Text = "Prikazi vozila";
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.Maroon;
            this.btnDetalji.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ForeColor = System.Drawing.Color.Linen;
            this.btnDetalji.Location = new System.Drawing.Point(520, 498);
            this.btnDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(205, 47);
            this.btnDetalji.TabIndex = 57;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = false;
            // 
            // UCPrikaziVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.dgvVozila);
            this.Controls.Add(this.txtPretragaV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCPrikaziVozila";
            this.Size = new System.Drawing.Size(793, 602);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.TextBox txtPretragaV;
        private System.Windows.Forms.Label label1;
        private Label label5;
        private Button btnDetalji;

        public Button BtnDodajVozilo { get => btnDodajVozilo; set => btnDodajVozilo = value; }
        public Button BtnObrisiVozilo { get => btnObrisiVozilo; set => btnObrisiVozilo = value; }
        public DataGridView DgvVozila { get => dgvVozila; set => dgvVozila = value; }
        public TextBox TxtPretragaV { get => txtPretragaV; set => txtPretragaV = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
    }
}
