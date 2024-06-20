namespace Jogo_Sortear
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgER = new System.Windows.Forms.PictureBox();
            this.imgHK = new System.Windows.Forms.PictureBox();
            this.imgDS = new System.Windows.Forms.PictureBox();
            this.btnSortear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // imgER
            // 
            this.imgER.Image = global::Jogo_Sortear.Properties.Resources.elden_ring;
            this.imgER.Location = new System.Drawing.Point(319, 12);
            this.imgER.Name = "imgER";
            this.imgER.Size = new System.Drawing.Size(284, 160);
            this.imgER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgER.TabIndex = 2;
            this.imgER.TabStop = false;
            // 
            // imgHK
            // 
            this.imgHK.Image = global::Jogo_Sortear.Properties.Resources.hollow_knghit;
            this.imgHK.Location = new System.Drawing.Point(165, 178);
            this.imgHK.Name = "imgHK";
            this.imgHK.Size = new System.Drawing.Size(294, 160);
            this.imgHK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHK.TabIndex = 1;
            this.imgHK.TabStop = false;
            // 
            // imgDS
            // 
            this.imgDS.Image = global::Jogo_Sortear.Properties.Resources.death_stranding_wallpaper_3840x2160_by_erickcartman_dd82iu5_fullview;
            this.imgDS.Location = new System.Drawing.Point(12, 12);
            this.imgDS.Name = "imgDS";
            this.imgDS.Size = new System.Drawing.Size(284, 160);
            this.imgDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDS.TabIndex = 0;
            this.imgDS.TabStop = false;
            // 
            // btnSortear
            // 
            this.btnSortear.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSortear.Location = new System.Drawing.Point(258, 364);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(111, 42);
            this.btnSortear.TabIndex = 3;
            this.btnSortear.Text = "Sotear";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(620, 436);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.imgER);
            this.Controls.Add(this.imgHK);
            this.Controls.Add(this.imgDS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDS;
        private System.Windows.Forms.PictureBox imgHK;
        private System.Windows.Forms.PictureBox imgER;
        private System.Windows.Forms.Button btnSortear;
    }
}

