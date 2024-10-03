namespace TreSette_AnrangoRamosGionsi
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
            this.dgvMazzoCarte = new System.Windows.Forms.DataGridView();
            this.grbInputCarta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSemeCarta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValoreCarta = new System.Windows.Forms.TextBox();
            this.btnCreaCartaConParametri = new System.Windows.Forms.Button();
            this.btnCreaCartaCasuale = new System.Windows.Forms.Button();
            this.btnInserireCartaNelMazzo = new System.Windows.Forms.Button();
            this.grbCartaAttuale = new System.Windows.Forms.GroupBox();
            this.lblSemeCartaAttuale = new System.Windows.Forms.Label();
            this.lblValoreCartaAttuale = new System.Windows.Forms.Label();
            this.btnProponiCarta = new System.Windows.Forms.Button();
            this.btnMescolaMazzo = new System.Windows.Forms.Button();
            this.btnCercaCarta = new System.Windows.Forms.Button();
            this.btnVisualizzaTotali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazzoCarte)).BeginInit();
            this.grbInputCarta.SuspendLayout();
            this.grbCartaAttuale.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMazzoCarte
            // 
            this.dgvMazzoCarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMazzoCarte.Location = new System.Drawing.Point(366, 37);
            this.dgvMazzoCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMazzoCarte.Name = "dgvMazzoCarte";
            this.dgvMazzoCarte.RowHeadersVisible = false;
            this.dgvMazzoCarte.RowHeadersWidth = 51;
            this.dgvMazzoCarte.RowTemplate.Height = 24;
            this.dgvMazzoCarte.Size = new System.Drawing.Size(225, 318);
            this.dgvMazzoCarte.TabIndex = 0;
            // 
            // grbInputCarta
            // 
            this.grbInputCarta.Controls.Add(this.label2);
            this.grbInputCarta.Controls.Add(this.txtSemeCarta);
            this.grbInputCarta.Controls.Add(this.label1);
            this.grbInputCarta.Controls.Add(this.txtValoreCarta);
            this.grbInputCarta.Controls.Add(this.btnCreaCartaConParametri);
            this.grbInputCarta.Location = new System.Drawing.Point(9, 10);
            this.grbInputCarta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInputCarta.Name = "grbInputCarta";
            this.grbInputCarta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInputCarta.Size = new System.Drawing.Size(157, 167);
            this.grbInputCarta.TabIndex = 1;
            this.grbInputCarta.TabStop = false;
            this.grbInputCarta.Text = "Creazione carta con Parametri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seme";
            // 
            // txtSemeCarta
            // 
            this.txtSemeCarta.Location = new System.Drawing.Point(5, 96);
            this.txtSemeCarta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSemeCarta.Name = "txtSemeCarta";
            this.txtSemeCarta.Size = new System.Drawing.Size(139, 20);
            this.txtSemeCarta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valore";
            // 
            // txtValoreCarta
            // 
            this.txtValoreCarta.Location = new System.Drawing.Point(5, 43);
            this.txtValoreCarta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValoreCarta.Name = "txtValoreCarta";
            this.txtValoreCarta.Size = new System.Drawing.Size(76, 20);
            this.txtValoreCarta.TabIndex = 1;
            // 
            // btnCreaCartaConParametri
            // 
            this.btnCreaCartaConParametri.Location = new System.Drawing.Point(45, 128);
            this.btnCreaCartaConParametri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreaCartaConParametri.Name = "btnCreaCartaConParametri";
            this.btnCreaCartaConParametri.Size = new System.Drawing.Size(66, 24);
            this.btnCreaCartaConParametri.TabIndex = 0;
            this.btnCreaCartaConParametri.Text = "Crea Carta";
            this.btnCreaCartaConParametri.UseVisualStyleBackColor = true;
            this.btnCreaCartaConParametri.Click += new System.EventHandler(this.btnCreaCartaConParametri_Click);
            // 
            // btnCreaCartaCasuale
            // 
            this.btnCreaCartaCasuale.Location = new System.Drawing.Point(9, 194);
            this.btnCreaCartaCasuale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreaCartaCasuale.Name = "btnCreaCartaCasuale";
            this.btnCreaCartaCasuale.Size = new System.Drawing.Size(111, 24);
            this.btnCreaCartaCasuale.TabIndex = 2;
            this.btnCreaCartaCasuale.Text = "Crea Carta Casuale";
            this.btnCreaCartaCasuale.UseVisualStyleBackColor = true;
            this.btnCreaCartaCasuale.Click += new System.EventHandler(this.btnCreaCartaCasuale_Click);
            // 
            // btnInserireCartaNelMazzo
            // 
            this.btnInserireCartaNelMazzo.Location = new System.Drawing.Point(210, 194);
            this.btnInserireCartaNelMazzo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInserireCartaNelMazzo.Name = "btnInserireCartaNelMazzo";
            this.btnInserireCartaNelMazzo.Size = new System.Drawing.Size(123, 24);
            this.btnInserireCartaNelMazzo.TabIndex = 4;
            this.btnInserireCartaNelMazzo.Text = "Inserisci nel Mazzo";
            this.btnInserireCartaNelMazzo.UseVisualStyleBackColor = true;
            this.btnInserireCartaNelMazzo.Click += new System.EventHandler(this.btnInserireCartaNelMazzo_Click);
            // 
            // grbCartaAttuale
            // 
            this.grbCartaAttuale.BackColor = System.Drawing.Color.White;
            this.grbCartaAttuale.Controls.Add(this.lblSemeCartaAttuale);
            this.grbCartaAttuale.Controls.Add(this.lblValoreCartaAttuale);
            this.grbCartaAttuale.Location = new System.Drawing.Point(210, 14);
            this.grbCartaAttuale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCartaAttuale.Name = "grbCartaAttuale";
            this.grbCartaAttuale.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCartaAttuale.Size = new System.Drawing.Size(123, 162);
            this.grbCartaAttuale.TabIndex = 6;
            this.grbCartaAttuale.TabStop = false;
            this.grbCartaAttuale.Text = "Carta Attuale o Cercata";
            // 
            // lblSemeCartaAttuale
            // 
            this.lblSemeCartaAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemeCartaAttuale.Location = new System.Drawing.Point(8, 94);
            this.lblSemeCartaAttuale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemeCartaAttuale.Name = "lblSemeCartaAttuale";
            this.lblSemeCartaAttuale.Size = new System.Drawing.Size(110, 20);
            this.lblSemeCartaAttuale.TabIndex = 1;
            this.lblSemeCartaAttuale.Text = "XXX";
            this.lblSemeCartaAttuale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValoreCartaAttuale
            // 
            this.lblValoreCartaAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoreCartaAttuale.Location = new System.Drawing.Point(4, 44);
            this.lblValoreCartaAttuale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValoreCartaAttuale.Name = "lblValoreCartaAttuale";
            this.lblValoreCartaAttuale.Size = new System.Drawing.Size(114, 20);
            this.lblValoreCartaAttuale.TabIndex = 0;
            this.lblValoreCartaAttuale.Text = "XXX";
            this.lblValoreCartaAttuale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProponiCarta
            // 
            this.btnProponiCarta.Location = new System.Drawing.Point(9, 225);
            this.btnProponiCarta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProponiCarta.Name = "btnProponiCarta";
            this.btnProponiCarta.Size = new System.Drawing.Size(80, 19);
            this.btnProponiCarta.TabIndex = 2;
            this.btnProponiCarta.Text = "Proponi Carta";
            this.btnProponiCarta.UseVisualStyleBackColor = true;
            this.btnProponiCarta.Click += new System.EventHandler(this.btnProponiCarta_Click);
            // 
            // btnMescolaMazzo
            // 
            this.btnMescolaMazzo.Location = new System.Drawing.Point(366, 14);
            this.btnMescolaMazzo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMescolaMazzo.Name = "btnMescolaMazzo";
            this.btnMescolaMazzo.Size = new System.Drawing.Size(85, 19);
            this.btnMescolaMazzo.TabIndex = 7;
            this.btnMescolaMazzo.Text = "Mescola Mazzo";
            this.btnMescolaMazzo.UseVisualStyleBackColor = true;
            this.btnMescolaMazzo.Click += new System.EventHandler(this.btnMescolaMazzo_Click);
            // 
            // btnCercaCarta
            // 
            this.btnCercaCarta.Location = new System.Drawing.Point(210, 223);
            this.btnCercaCarta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCercaCarta.Name = "btnCercaCarta";
            this.btnCercaCarta.Size = new System.Drawing.Size(123, 24);
            this.btnCercaCarta.TabIndex = 8;
            this.btnCercaCarta.Text = "Cerca Carta del Mazzo";
            this.btnCercaCarta.UseVisualStyleBackColor = true;
            this.btnCercaCarta.Click += new System.EventHandler(this.btnCercaCarta_Click);
            // 
            // btnVisualizzaTotali
            // 
            this.btnVisualizzaTotali.Location = new System.Drawing.Point(455, 14);
            this.btnVisualizzaTotali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisualizzaTotali.Name = "btnVisualizzaTotali";
            this.btnVisualizzaTotali.Size = new System.Drawing.Size(136, 19);
            this.btnVisualizzaTotali.TabIndex = 5;
            this.btnVisualizzaTotali.Text = "Numero Carte per Seme";
            this.btnVisualizzaTotali.UseVisualStyleBackColor = true;
            this.btnVisualizzaTotali.Click += new System.EventHandler(this.btnVisualizzaTotali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnVisualizzaTotali);
            this.Controls.Add(this.btnCercaCarta);
            this.Controls.Add(this.btnMescolaMazzo);
            this.Controls.Add(this.btnProponiCarta);
            this.Controls.Add(this.grbCartaAttuale);
            this.Controls.Add(this.btnInserireCartaNelMazzo);
            this.Controls.Add(this.btnCreaCartaCasuale);
            this.Controls.Add(this.grbInputCarta);
            this.Controls.Add(this.dgvMazzoCarte);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Carte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMazzoCarte)).EndInit();
            this.grbInputCarta.ResumeLayout(false);
            this.grbInputCarta.PerformLayout();
            this.grbCartaAttuale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMazzoCarte;
        private System.Windows.Forms.GroupBox grbInputCarta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSemeCarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValoreCarta;
        private System.Windows.Forms.Button btnCreaCartaConParametri;
        private System.Windows.Forms.Button btnCreaCartaCasuale;
        private System.Windows.Forms.Button btnInserireCartaNelMazzo;
        private System.Windows.Forms.GroupBox grbCartaAttuale;
        private System.Windows.Forms.Label lblSemeCartaAttuale;
        private System.Windows.Forms.Label lblValoreCartaAttuale;
        private System.Windows.Forms.Button btnProponiCarta;
        private System.Windows.Forms.Button btnMescolaMazzo;
        private System.Windows.Forms.Button btnCercaCarta;
        private System.Windows.Forms.Button btnVisualizzaTotali;
    }
}

