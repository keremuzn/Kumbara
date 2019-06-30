namespace Kumbara
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
            this.btnParaAt = new System.Windows.Forms.Button();
            this.cmbParalar = new System.Windows.Forms.ComboBox();
            this.lstEkran = new System.Windows.Forms.ListBox();
            this.btnKatla = new System.Windows.Forms.Button();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParaAt
            // 
            this.btnParaAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaAt.Location = new System.Drawing.Point(542, 62);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(152, 65);
            this.btnParaAt.TabIndex = 2;
            this.btnParaAt.Text = "Kumbaraya AT";
            this.btnParaAt.UseVisualStyleBackColor = true;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // cmbParalar
            // 
            this.cmbParalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbParalar.FormattingEnabled = true;
            this.cmbParalar.Location = new System.Drawing.Point(542, 34);
            this.cmbParalar.Name = "cmbParalar";
            this.cmbParalar.Size = new System.Drawing.Size(152, 23);
            this.cmbParalar.TabIndex = 3;
            this.cmbParalar.Text = "cmbParaSec";
            this.cmbParalar.SelectedIndexChanged += new System.EventHandler(this.cmbParalar_SelectedIndexChanged);
            // 
            // lstEkran
            // 
            this.lstEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstEkran.FormattingEnabled = true;
            this.lstEkran.ItemHeight = 15;
            this.lstEkran.Location = new System.Drawing.Point(12, 27);
            this.lstEkran.Name = "lstEkran";
            this.lstEkran.Size = new System.Drawing.Size(488, 394);
            this.lstEkran.TabIndex = 4;
            // 
            // btnKatla
            // 
            this.btnKatla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKatla.Location = new System.Drawing.Point(542, 133);
            this.btnKatla.Name = "btnKatla";
            this.btnKatla.Size = new System.Drawing.Size(152, 65);
            this.btnKatla.TabIndex = 2;
            this.btnKatla.Text = "Katla";
            this.btnKatla.UseVisualStyleBackColor = true;
            this.btnKatla.Click += new System.EventHandler(this.btnKatla_Click);
            // 
            // btnSalla
            // 
            this.btnSalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalla.Location = new System.Drawing.Point(542, 206);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(152, 65);
            this.btnSalla.TabIndex = 2;
            this.btnSalla.Text = "Salla";
            this.btnSalla.UseVisualStyleBackColor = true;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnKir
            // 
            this.btnKir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKir.Location = new System.Drawing.Point(542, 277);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(152, 65);
            this.btnKir.TabIndex = 2;
            this.btnKir.Text = "Kumbarayı Kır";
            this.btnKir.UseVisualStyleBackColor = true;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(542, 348);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(152, 65);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "ListeTemizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstEkran);
            this.Controls.Add(this.cmbParalar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnKatla);
            this.Controls.Add(this.btnParaAt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.ComboBox cmbParalar;
        private System.Windows.Forms.ListBox lstEkran;
        private System.Windows.Forms.Button btnKatla;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.Button btnTemizle;
    }
}

