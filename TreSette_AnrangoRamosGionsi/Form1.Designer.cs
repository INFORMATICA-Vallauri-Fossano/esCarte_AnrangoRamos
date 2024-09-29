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
            this.dgvMazzoCarte.Location = new System.Drawing.Point(488, 46);
            this.dgvMazzoCarte.Name = "dgvMazzoCarte";
            this.dgvMazzoCarte.RowHeadersVisible = false;
            this.dgvMazzoCarte.RowHeadersWidth = 51;
            this.dgvMazzoCarte.RowTemplate.Height = 24;
            this.dgvMazzoCarte.Size = new System.Drawing.Size(300, 392);
            this.dgvMazzoCarte.TabIndex = 0;
            // 
            // grbInputCarta
            // 
            this.grbInputCarta.Controls.Add(this.label2);
            this.grbInputCarta.Controls.Add(this.txtSemeCarta);
            this.grbInputCarta.Controls.Add(this.label1);
            this.grbInputCarta.Controls.Add(this.txtValoreCarta);
            this.grbInputCarta.Controls.Add(this.btnCreaCartaConParametri);
            this.grbInputCarta.Location = new System.Drawing.Point(12, 12);
            this.grbInputCarta.Name = "grbInputCarta";
            this.grbInputCarta.Size = new System.Drawing.Size(209, 205);
            this.grbInputCarta.TabIndex = 1;
            this.grbInputCarta.TabStop = false;
            this.grbInputCarta.Text = "Creazione carta con Parametri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seme";
            // 
            // txtSemeCarta
            // 
            this.txtSemeCarta.Location = new System.Drawing.Point(7, 118);
            this.txtSemeCarta.Name = "txtSemeCarta";
            this.txtSemeCarta.Size = new System.Drawing.Size(184, 22);
            this.txtSemeCarta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valore";
            // 
            // txtValoreCarta
            // 
            this.txtValoreCarta.Location = new System.Drawing.Point(7, 53);
            this.txtValoreCarta.Name = "txtValoreCarta";
            this.txtValoreCarta.Size = new System.Drawing.Size(100, 22);
            this.txtValoreCarta.TabIndex = 1;
            // 
            // btnCreaCartaConParametri
            // 
            this.btnCreaCartaConParametri.Location = new System.Drawing.Point(60, 157);
            this.btnCreaCartaConParametri.Name = "btnCreaCartaConParametri";
            this.btnCreaCartaConParametri.Size = new System.Drawing.Size(88, 29);
            this.btnCreaCartaConParametri.TabIndex = 0;
            this.btnCreaCartaConParametri.Text = "Crea Carta";
            this.btnCreaCartaConParametri.UseVisualStyleBackColor = true;
            this.btnCreaCartaConParametri.Click += new System.EventHandler(this.btnCreaCartaConParametri_Click);
            // 
            // btnCreaCartaCasuale
            // 
            this.btnCreaCartaCasuale.Location = new System.Drawing.Point(12, 239);
            this.btnCreaCartaCasuale.Name = "btnCreaCartaCasuale";
            this.btnCreaCartaCasuale.Size = new System.Drawing.Size(148, 29);
            this.btnCreaCartaCasuale.TabIndex = 2;
            this.btnCreaCartaCasuale.Text = "Crea Carta Casuale";
            this.btnCreaCartaCasuale.UseVisualStyleBackColor = true;
            this.btnCreaCartaCasuale.Click += new System.EventHandler(this.btnCreaCartaCasuale_Click);
            // 
            // btnInserireCartaNelMazzo
            // 
            this.btnInserireCartaNelMazzo.Location = new System.Drawing.Point(280, 239);
            this.btnInserireCartaNelMazzo.Name = "btnInserireCartaNelMazzo";
            this.btnInserireCartaNelMazzo.Size = new System.Drawing.Size(164, 29);
            this.btnInserireCartaNelMazzo.TabIndex = 4;
            this.btnInserireCartaNelMazzo.Text = "Inserisci nel Mazzo";
            this.btnInserireCartaNelMazzo.UseVisualStyleBackColor = true;
            this.btnInserireCartaNelMazzo.Click += new System.EventHandler(this.btnInserireCartaNelMazzo_Click);
            // 
            // grbCartaAttuale
            // 
            this.grbCartaAttuale.Controls.Add(this.lblSemeCartaAttuale);
            this.grbCartaAttuale.Controls.Add(this.lblValoreCartaAttuale);
            this.grbCartaAttuale.Location = new System.Drawing.Point(280, 17);
            this.grbCartaAttuale.Name = "grbCartaAttuale";
            this.grbCartaAttuale.Size = new System.Drawing.Size(164, 200);
            this.grbCartaAttuale.TabIndex = 6;
            this.grbCartaAttuale.TabStop = false;
            this.grbCartaAttuale.Text = "Carta Attuale o Cercata";
            // 
            // lblSemeCartaAttuale
            // 
            this.lblSemeCartaAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemeCartaAttuale.Location = new System.Drawing.Point(11, 116);
            this.lblSemeCartaAttuale.Name = "lblSemeCartaAttuale";
            this.lblSemeCartaAttuale.Size = new System.Drawing.Size(147, 25);
            this.lblSemeCartaAttuale.TabIndex = 1;
            this.lblSemeCartaAttuale.Text = "XXX";
            this.lblSemeCartaAttuale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValoreCartaAttuale
            // 
            this.lblValoreCartaAttuale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoreCartaAttuale.Location = new System.Drawing.Point(6, 54);
            this.lblValoreCartaAttuale.Name = "lblValoreCartaAttuale";
            this.lblValoreCartaAttuale.Size = new System.Drawing.Size(152, 25);
            this.lblValoreCartaAttuale.TabIndex = 0;
            this.lblValoreCartaAttuale.Text = "XXX";
            this.lblValoreCartaAttuale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProponiCarta
            // 
            this.btnProponiCarta.Location = new System.Drawing.Point(12, 277);
            this.btnProponiCarta.Name = "btnProponiCarta";
            this.btnProponiCarta.Size = new System.Drawing.Size(107, 23);
            this.btnProponiCarta.TabIndex = 2;
            this.btnProponiCarta.Text = "Proponi Carta";
            this.btnProponiCarta.UseVisualStyleBackColor = true;
            this.btnProponiCarta.Click += new System.EventHandler(this.btnProponiCarta_Click);
            // 
            // btnMescolaMazzo
            // 
            this.btnMescolaMazzo.Location = new System.Drawing.Point(488, 17);
            this.btnMescolaMazzo.Name = "btnMescolaMazzo";
            this.btnMescolaMazzo.Size = new System.Drawing.Size(113, 23);
            this.btnMescolaMazzo.TabIndex = 7;
            this.btnMescolaMazzo.Text = "Mescola Mazzo";
            this.btnMescolaMazzo.UseVisualStyleBackColor = true;
            this.btnMescolaMazzo.Click += new System.EventHandler(this.btnMescolaMazzo_Click);
            // 
            // btnCercaCarta
            // 
            this.btnCercaCarta.Location = new System.Drawing.Point(280, 274);
            this.btnCercaCarta.Name = "btnCercaCarta";
            this.btnCercaCarta.Size = new System.Drawing.Size(164, 29);
            this.btnCercaCarta.TabIndex = 8;
            this.btnCercaCarta.Text = "Cerca Carta del Mazzo";
            this.btnCercaCarta.UseVisualStyleBackColor = true;
            this.btnCercaCarta.Click += new System.EventHandler(this.btnCercaCarta_Click);
            // 
            // btnVisualizzaTotali
            // 
            this.btnVisualizzaTotali.Location = new System.Drawing.Point(607, 17);
            this.btnVisualizzaTotali.Name = "btnVisualizzaTotali";
            this.btnVisualizzaTotali.Size = new System.Drawing.Size(181, 23);
            this.btnVisualizzaTotali.TabIndex = 5;
            this.btnVisualizzaTotali.Text = "Numero Carte per Seme";
            this.btnVisualizzaTotali.UseVisualStyleBackColor = true;
            this.btnVisualizzaTotali.Click += new System.EventHandler(this.btnVisualizzaTotali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizzaTotali);
            this.Controls.Add(this.btnCercaCarta);
            this.Controls.Add(this.btnMescolaMazzo);
            this.Controls.Add(this.btnProponiCarta);
            this.Controls.Add(this.grbCartaAttuale);
            this.Controls.Add(this.btnInserireCartaNelMazzo);
            this.Controls.Add(this.btnCreaCartaCasuale);
            this.Controls.Add(this.grbInputCarta);
            this.Controls.Add(this.dgvMazzoCarte);
            this.Name = "Form1";
            this.Text = "Form1";
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

