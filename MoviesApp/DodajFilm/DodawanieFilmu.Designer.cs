namespace MoviesApp
{
    partial class DodawanieFilmu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblIDFilmu = new System.Windows.Forms.Label();
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblGatunek = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();
            this.txtIDFilmu = new System.Windows.Forms.TextBox();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.txtGatunek = new System.Windows.Forms.TextBox();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.btnDodajFilm = new System.Windows.Forms.Button();
            this.dgvFilmy = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDFilmu
            // 
            this.lblIDFilmu.AutoSize = true;
            this.lblIDFilmu.Location = new System.Drawing.Point(16, 20);
            this.lblIDFilmu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIDFilmu.Name = "lblIDFilmu";
            this.lblIDFilmu.Size = new System.Drawing.Size(51, 15);
            this.lblIDFilmu.TabIndex = 0;
            this.lblIDFilmu.Text = "ID Filmu";
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Location = new System.Drawing.Point(16, 54);
            this.lblTytul.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(32, 15);
            this.lblTytul.TabIndex = 1;
            this.lblTytul.Text = "Tytuł";
            // 
            // lblGatunek
            // 
            this.lblGatunek.AutoSize = true;
            this.lblGatunek.Location = new System.Drawing.Point(16, 89);
            this.lblGatunek.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGatunek.Name = "lblGatunek";
            this.lblGatunek.Size = new System.Drawing.Size(51, 15);
            this.lblGatunek.TabIndex = 2;
            this.lblGatunek.Text = "Gatunek";
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Location = new System.Drawing.Point(16, 123);
            this.lblRok.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(27, 15);
            this.lblRok.TabIndex = 3;
            this.lblRok.Text = "Rok";
            // 
            // txtIDFilmu
            // 
            this.txtIDFilmu.Location = new System.Drawing.Point(115, 16);
            this.txtIDFilmu.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIDFilmu.Name = "txtIDFilmu";
            this.txtIDFilmu.Size = new System.Drawing.Size(135, 23);
            this.txtIDFilmu.TabIndex = 4;
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new System.Drawing.Point(115, 51);
            this.txtTytul.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(135, 23);
            this.txtTytul.TabIndex = 5;
            // 
            // txtGatunek
            // 
            this.txtGatunek.Location = new System.Drawing.Point(115, 85);
            this.txtGatunek.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtGatunek.Name = "txtGatunek";
            this.txtGatunek.Size = new System.Drawing.Size(135, 23);
            this.txtGatunek.TabIndex = 6;
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(115, 120);
            this.txtRok.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(135, 23);
            this.txtRok.TabIndex = 7;
            // 
            // btnDodajFilm
            // 
            this.btnDodajFilm.Location = new System.Drawing.Point(307, 16);
            this.btnDodajFilm.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDodajFilm.Name = "btnDodajFilm";
            this.btnDodajFilm.Size = new System.Drawing.Size(136, 31);
            this.btnDodajFilm.TabIndex = 8;
            this.btnDodajFilm.Text = "Dodaj Film";
            this.btnDodajFilm.UseVisualStyleBackColor = true;
            this.btnDodajFilm.Click += new System.EventHandler(this.DodajFilm_Click);
            // 
            // dgvFilmy
            // 
            this.dgvFilmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmy.Location = new System.Drawing.Point(14, 160);
            this.dgvFilmy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvFilmy.Name = "dgvFilmy";
            this.dgvFilmy.RowTemplate.Height = 25;
            this.dgvFilmy.Size = new System.Drawing.Size(572, 256);
            this.dgvFilmy.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Usuń wiersz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Odśwież";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 71);
            this.button3.TabIndex = 12;
            this.button3.Text = "Wyjdz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Close_Click);
            // 
            // DodawanieFilmuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 429);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFilmy);
            this.Controls.Add(this.btnDodajFilm);
            this.Controls.Add(this.txtRok);
            this.Controls.Add(this.txtGatunek);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.txtIDFilmu);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.lblGatunek);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.lblIDFilmu);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "DodawanieFilmuForm";
            this.Text = "Dodawanie Filmu";
            this.Load += new System.EventHandler(this.DodajDoGridu);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblIDFilmu;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblGatunek;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.TextBox txtIDFilmu;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.TextBox txtGatunek;
        private System.Windows.Forms.TextBox txtRok;
        private System.Windows.Forms.Button btnDodajFilm;
        private DataGridView dgvFilmy;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
