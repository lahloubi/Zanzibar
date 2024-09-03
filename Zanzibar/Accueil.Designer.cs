namespace Zanzibar
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelJ1 = new System.Windows.Forms.Label();
            this.textBoxJ1 = new System.Windows.Forms.TextBox();
            this.labelJ2 = new System.Windows.Forms.Label();
            this.textBoxJ2 = new System.Windows.Forms.TextBox();
            this.labelNomsJoueurs = new System.Windows.Forms.Label();
            this.buttonDemarrer = new System.Windows.Forms.Button();
            this.buttonMeilleursPointages = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.labelNbrJoueurs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxJ4 = new System.Windows.Forms.TextBox();
            this.labelJ4 = new System.Windows.Forms.Label();
            this.textBoxJ3 = new System.Windows.Forms.TextBox();
            this.labelJ3 = new System.Windows.Forms.Label();
            this.comboBoxNbJoueurs = new System.Windows.Forms.ComboBox();
            this.buttonReglement = new System.Windows.Forms.Button();
            this.errorProviderNbjoueurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNomsJoueurs = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBoxMeilleursPointages = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNbjoueurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomsJoueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(255, 27);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(251, 52);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Le zanzibar";
            // 
            // labelJ1
            // 
            this.labelJ1.AutoSize = true;
            this.labelJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ1.Location = new System.Drawing.Point(24, 227);
            this.labelJ1.Name = "labelJ1";
            this.labelJ1.Size = new System.Drawing.Size(33, 20);
            this.labelJ1.TabIndex = 1;
            this.labelJ1.Text = "J1:";
            // 
            // textBoxJ1
            // 
            this.textBoxJ1.Location = new System.Drawing.Point(63, 227);
            this.textBoxJ1.Name = "textBoxJ1";
            this.textBoxJ1.Size = new System.Drawing.Size(100, 20);
            this.textBoxJ1.TabIndex = 2;
            this.textBoxJ1.TextChanged += new System.EventHandler(this.textBoxJ1_TextChanged);
            this.textBoxJ1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJ1_KeyPress);
            // 
            // labelJ2
            // 
            this.labelJ2.AutoSize = true;
            this.labelJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ2.Location = new System.Drawing.Point(24, 257);
            this.labelJ2.Name = "labelJ2";
            this.labelJ2.Size = new System.Drawing.Size(33, 20);
            this.labelJ2.TabIndex = 3;
            this.labelJ2.Text = "J2:";
            // 
            // textBoxJ2
            // 
            this.textBoxJ2.Location = new System.Drawing.Point(63, 257);
            this.textBoxJ2.Name = "textBoxJ2";
            this.textBoxJ2.Size = new System.Drawing.Size(100, 20);
            this.textBoxJ2.TabIndex = 4;
            this.textBoxJ2.TextChanged += new System.EventHandler(this.textBoxJ2_TextChanged);
            this.textBoxJ2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJ2_KeyPress);
            // 
            // labelNomsJoueurs
            // 
            this.labelNomsJoueurs.AutoSize = true;
            this.labelNomsJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomsJoueurs.Location = new System.Drawing.Point(24, 195);
            this.labelNomsJoueurs.Name = "labelNomsJoueurs";
            this.labelNomsJoueurs.Size = new System.Drawing.Size(161, 20);
            this.labelNomsJoueurs.TabIndex = 5;
            this.labelNomsJoueurs.Text = "Noms des joueurs";
            // 
            // buttonDemarrer
            // 
            this.buttonDemarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemarrer.Location = new System.Drawing.Point(39, 397);
            this.buttonDemarrer.Name = "buttonDemarrer";
            this.buttonDemarrer.Size = new System.Drawing.Size(190, 31);
            this.buttonDemarrer.TabIndex = 6;
            this.buttonDemarrer.Text = "Démarrer";
            this.buttonDemarrer.UseVisualStyleBackColor = true;
            this.buttonDemarrer.Click += new System.EventHandler(this.buttonDemarrer_Click);
            // 
            // buttonMeilleursPointages
            // 
            this.buttonMeilleursPointages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeilleursPointages.Location = new System.Drawing.Point(305, 397);
            this.buttonMeilleursPointages.Name = "buttonMeilleursPointages";
            this.buttonMeilleursPointages.Size = new System.Drawing.Size(190, 31);
            this.buttonMeilleursPointages.TabIndex = 7;
            this.buttonMeilleursPointages.Text = "Meilleurs pointages";
            this.buttonMeilleursPointages.UseVisualStyleBackColor = true;
            this.buttonMeilleursPointages.Click += new System.EventHandler(this.buttonMeilleursPointages_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitter.Location = new System.Drawing.Point(573, 397);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(190, 31);
            this.buttonQuitter.TabIndex = 8;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // labelNbrJoueurs
            // 
            this.labelNbrJoueurs.AutoSize = true;
            this.labelNbrJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrJoueurs.Location = new System.Drawing.Point(24, 90);
            this.labelNbrJoueurs.Name = "labelNbrJoueurs";
            this.labelNbrJoueurs.Size = new System.Drawing.Size(168, 20);
            this.labelNbrJoueurs.TabIndex = 13;
            this.labelNbrJoueurs.Text = "Nombre de joueurs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxJ4
            // 
            this.textBoxJ4.Location = new System.Drawing.Point(63, 313);
            this.textBoxJ4.Name = "textBoxJ4";
            this.textBoxJ4.Size = new System.Drawing.Size(100, 20);
            this.textBoxJ4.TabIndex = 20;
            this.textBoxJ4.TextChanged += new System.EventHandler(this.textBoxJ4_TextChanged);
            this.textBoxJ4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJ4_KeyPress);
            // 
            // labelJ4
            // 
            this.labelJ4.AutoSize = true;
            this.labelJ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ4.Location = new System.Drawing.Point(24, 313);
            this.labelJ4.Name = "labelJ4";
            this.labelJ4.Size = new System.Drawing.Size(33, 20);
            this.labelJ4.TabIndex = 19;
            this.labelJ4.Text = "J4:";
            // 
            // textBoxJ3
            // 
            this.textBoxJ3.Location = new System.Drawing.Point(63, 283);
            this.textBoxJ3.Name = "textBoxJ3";
            this.textBoxJ3.Size = new System.Drawing.Size(100, 20);
            this.textBoxJ3.TabIndex = 18;
            this.textBoxJ3.TextChanged += new System.EventHandler(this.textBoxJ3_TextChanged);
            this.textBoxJ3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJ3_KeyPress);
            // 
            // labelJ3
            // 
            this.labelJ3.AutoSize = true;
            this.labelJ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ3.Location = new System.Drawing.Point(24, 283);
            this.labelJ3.Name = "labelJ3";
            this.labelJ3.Size = new System.Drawing.Size(33, 20);
            this.labelJ3.TabIndex = 17;
            this.labelJ3.Text = "J3:";
            // 
            // comboBoxNbJoueurs
            // 
            this.comboBoxNbJoueurs.FormattingEnabled = true;
            this.comboBoxNbJoueurs.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comboBoxNbJoueurs.Location = new System.Drawing.Point(28, 113);
            this.comboBoxNbJoueurs.Name = "comboBoxNbJoueurs";
            this.comboBoxNbJoueurs.Size = new System.Drawing.Size(164, 21);
            this.comboBoxNbJoueurs.TabIndex = 21;
            this.comboBoxNbJoueurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxNbJoueurs_SelectedIndexChanged);
            this.comboBoxNbJoueurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxNbJoueurs_KeyPress);
            // 
            // buttonReglement
            // 
            this.buttonReglement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReglement.Location = new System.Drawing.Point(573, 48);
            this.buttonReglement.Name = "buttonReglement";
            this.buttonReglement.Size = new System.Drawing.Size(190, 31);
            this.buttonReglement.TabIndex = 22;
            this.buttonReglement.Text = "Réglement";
            this.buttonReglement.UseVisualStyleBackColor = true;
            this.buttonReglement.Click += new System.EventHandler(this.buttonReglement_Click);
            // 
            // errorProviderNbjoueurs
            // 
            this.errorProviderNbjoueurs.ContainerControl = this;
            // 
            // errorProviderNomsJoueurs
            // 
            this.errorProviderNomsJoueurs.ContainerControl = this;
            // 
            // richTextBoxMeilleursPointages
            // 
            this.richTextBoxMeilleursPointages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMeilleursPointages.Location = new System.Drawing.Point(573, 111);
            this.richTextBoxMeilleursPointages.Name = "richTextBoxMeilleursPointages";
            this.richTextBoxMeilleursPointages.ReadOnly = true;
            this.richTextBoxMeilleursPointages.Size = new System.Drawing.Size(200, 246);
            this.richTextBoxMeilleursPointages.TabIndex = 10;
            this.richTextBoxMeilleursPointages.Text = "Meilleurs pointages précédents\n--------------------------";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReglement);
            this.Controls.Add(this.comboBoxNbJoueurs);
            this.Controls.Add(this.textBoxJ4);
            this.Controls.Add(this.labelJ4);
            this.Controls.Add(this.textBoxJ3);
            this.Controls.Add(this.labelJ3);
            this.Controls.Add(this.labelNbrJoueurs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxMeilleursPointages);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonMeilleursPointages);
            this.Controls.Add(this.buttonDemarrer);
            this.Controls.Add(this.labelNomsJoueurs);
            this.Controls.Add(this.textBoxJ2);
            this.Controls.Add(this.labelJ2);
            this.Controls.Add(this.textBoxJ1);
            this.Controls.Add(this.labelJ1);
            this.Controls.Add(this.labelTitre);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNbjoueurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNomsJoueurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelJ1;
        private System.Windows.Forms.TextBox textBoxJ1;
        private System.Windows.Forms.Label labelJ2;
        private System.Windows.Forms.TextBox textBoxJ2;
        private System.Windows.Forms.Label labelNomsJoueurs;
        private System.Windows.Forms.Button buttonDemarrer;
        private System.Windows.Forms.Button buttonMeilleursPointages;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label labelNbrJoueurs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxJ4;
        private System.Windows.Forms.Label labelJ4;
        private System.Windows.Forms.TextBox textBoxJ3;
        private System.Windows.Forms.Label labelJ3;
        private System.Windows.Forms.ComboBox comboBoxNbJoueurs;
        private System.Windows.Forms.Button buttonReglement;
        private System.Windows.Forms.ErrorProvider errorProviderNbjoueurs;
        private System.Windows.Forms.ErrorProvider errorProviderNomsJoueurs;
        private System.Windows.Forms.RichTextBox richTextBoxMeilleursPointages;
    }
}

