
namespace STE
{
    partial class Form2
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
            this.btnDonateur = new System.Windows.Forms.Button();
            this.btnCommanditaire = new System.Windows.Forms.Button();
            this.labelInformationsDonateur = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelInformationsDon = new System.Windows.Forms.Label();
            this.labelIddon = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxMonatant = new System.Windows.Forms.TextBox();
            this.textBoxIdDon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnAMEX = new System.Windows.Forms.RadioButton();
            this.radioBtnMC = new System.Windows.Forms.RadioButton();
            this.radioBtnVisa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCarteDeCredit = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAfficherPrix = new System.Windows.Forms.Button();
            this.btnAjouterDonateur = new System.Windows.Forms.Button();
            this.buttonAjouterDon = new System.Windows.Forms.Button();
            this.btnAfficherDon = new System.Windows.Forms.Button();
            this.btnAfficherDonateur = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBoxCarteDeCredit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonateur
            // 
            this.btnDonateur.BackColor = System.Drawing.Color.Gold;
            this.btnDonateur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonateur.ForeColor = System.Drawing.Color.Black;
            this.btnDonateur.Location = new System.Drawing.Point(39, 32);
            this.btnDonateur.Name = "btnDonateur";
            this.btnDonateur.Size = new System.Drawing.Size(121, 31);
            this.btnDonateur.TabIndex = 1;
            this.btnDonateur.Text = "Donateur";
            this.btnDonateur.UseVisualStyleBackColor = false;
            // 
            // btnCommanditaire
            // 
            this.btnCommanditaire.BackColor = System.Drawing.Color.Gold;
            this.btnCommanditaire.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommanditaire.ForeColor = System.Drawing.Color.Black;
            this.btnCommanditaire.Location = new System.Drawing.Point(165, 32);
            this.btnCommanditaire.Name = "btnCommanditaire";
            this.btnCommanditaire.Size = new System.Drawing.Size(121, 31);
            this.btnCommanditaire.TabIndex = 2;
            this.btnCommanditaire.Text = "Commanditaire";
            this.btnCommanditaire.UseVisualStyleBackColor = false;
            this.btnCommanditaire.Click += new System.EventHandler(this.btnCommanditaire_Click);
            // 
            // labelInformationsDonateur
            // 
            this.labelInformationsDonateur.AutoSize = true;
            this.labelInformationsDonateur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInformationsDonateur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationsDonateur.ForeColor = System.Drawing.Color.Gold;
            this.labelInformationsDonateur.Location = new System.Drawing.Point(36, 73);
            this.labelInformationsDonateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInformationsDonateur.Name = "labelInformationsDonateur";
            this.labelInformationsDonateur.Size = new System.Drawing.Size(200, 21);
            this.labelInformationsDonateur.TabIndex = 3;
            this.labelInformationsDonateur.Text = "Informations Donateur";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Gold;
            this.labelID.Location = new System.Drawing.Point(49, 104);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 21);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.Gold;
            this.labelPrenom.Location = new System.Drawing.Point(49, 127);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(67, 21);
            this.labelPrenom.TabIndex = 5;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.Gold;
            this.labelNom.Location = new System.Drawing.Point(49, 149);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 21);
            this.labelNom.TabIndex = 6;
            this.labelNom.Text = "Nom";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.BackColor = System.Drawing.Color.Transparent;
            this.labelAdresse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.ForeColor = System.Drawing.Color.Gold;
            this.labelAdresse.Location = new System.Drawing.Point(49, 169);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(73, 21);
            this.labelAdresse.TabIndex = 7;
            this.labelAdresse.Text = "Adresse:";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.BackColor = System.Drawing.Color.Transparent;
            this.labelTelephone.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.ForeColor = System.Drawing.Color.Gold;
            this.labelTelephone.Location = new System.Drawing.Point(49, 194);
            this.labelTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(89, 21);
            this.labelTelephone.TabIndex = 8;
            this.labelTelephone.Text = "Téléphone:";
            // 
            // labelInformationsDon
            // 
            this.labelInformationsDon.AutoSize = true;
            this.labelInformationsDon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInformationsDon.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformationsDon.ForeColor = System.Drawing.Color.Gold;
            this.labelInformationsDon.Location = new System.Drawing.Point(36, 254);
            this.labelInformationsDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInformationsDon.Name = "labelInformationsDon";
            this.labelInformationsDon.Size = new System.Drawing.Size(155, 21);
            this.labelInformationsDon.TabIndex = 9;
            this.labelInformationsDon.Text = "Informations Don";
            // 
            // labelIddon
            // 
            this.labelIddon.AutoSize = true;
            this.labelIddon.BackColor = System.Drawing.Color.Transparent;
            this.labelIddon.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIddon.ForeColor = System.Drawing.Color.Gold;
            this.labelIddon.Location = new System.Drawing.Point(49, 281);
            this.labelIddon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIddon.Name = "labelIddon";
            this.labelIddon.Size = new System.Drawing.Size(66, 21);
            this.labelIddon.TabIndex = 10;
            this.labelIddon.Text = "ID don:";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.BackColor = System.Drawing.Color.Transparent;
            this.labelMontant.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.ForeColor = System.Drawing.Color.Gold;
            this.labelMontant.Location = new System.Drawing.Point(49, 307);
            this.labelMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(75, 21);
            this.labelMontant.TabIndex = 11;
            this.labelMontant.Text = "Monatnt";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(157, 107);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(131, 20);
            this.textBoxID.TabIndex = 12;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(157, 128);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(131, 20);
            this.textBoxPrenom.TabIndex = 13;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(157, 149);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(131, 20);
            this.textBoxNom.TabIndex = 14;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(157, 170);
            this.textBoxAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(131, 20);
            this.textBoxAdresse.TabIndex = 15;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(157, 198);
            this.textBoxTelephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(131, 20);
            this.textBoxTelephone.TabIndex = 16;
            // 
            // textBoxMonatant
            // 
            this.textBoxMonatant.Location = new System.Drawing.Point(158, 307);
            this.textBoxMonatant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMonatant.Name = "textBoxMonatant";
            this.textBoxMonatant.Size = new System.Drawing.Size(131, 20);
            this.textBoxMonatant.TabIndex = 17;
            // 
            // textBoxIdDon
            // 
            this.textBoxIdDon.Location = new System.Drawing.Point(158, 281);
            this.textBoxIdDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdDon.Name = "textBoxIdDon";
            this.textBoxIdDon.Size = new System.Drawing.Size(131, 20);
            this.textBoxIdDon.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnAMEX);
            this.groupBox2.Controls.Add(this.radioBtnMC);
            this.groupBox2.Controls.Add(this.radioBtnVisa);
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(293, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type de carte ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioBtnAMEX
            // 
            this.radioBtnAMEX.AutoSize = true;
            this.radioBtnAMEX.ForeColor = System.Drawing.Color.Gold;
            this.radioBtnAMEX.Location = new System.Drawing.Point(203, 29);
            this.radioBtnAMEX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnAMEX.Name = "radioBtnAMEX";
            this.radioBtnAMEX.Size = new System.Drawing.Size(75, 25);
            this.radioBtnAMEX.TabIndex = 2;
            this.radioBtnAMEX.TabStop = true;
            this.radioBtnAMEX.Text = "AMEX";
            this.radioBtnAMEX.UseVisualStyleBackColor = true;
            // 
            // radioBtnMC
            // 
            this.radioBtnMC.AutoSize = true;
            this.radioBtnMC.ForeColor = System.Drawing.Color.Gold;
            this.radioBtnMC.Location = new System.Drawing.Point(109, 32);
            this.radioBtnMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnMC.Name = "radioBtnMC";
            this.radioBtnMC.Size = new System.Drawing.Size(53, 25);
            this.radioBtnMC.TabIndex = 1;
            this.radioBtnMC.TabStop = true;
            this.radioBtnMC.Text = "MC";
            this.radioBtnMC.UseVisualStyleBackColor = true;
            // 
            // radioBtnVisa
            // 
            this.radioBtnVisa.AutoSize = true;
            this.radioBtnVisa.ForeColor = System.Drawing.Color.Gold;
            this.radioBtnVisa.Location = new System.Drawing.Point(4, 29);
            this.radioBtnVisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnVisa.Name = "radioBtnVisa";
            this.radioBtnVisa.Size = new System.Drawing.Size(57, 25);
            this.radioBtnVisa.TabIndex = 0;
            this.radioBtnVisa.TabStop = true;
            this.radioBtnVisa.Text = "Visa";
            this.radioBtnVisa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro:";
            // 
            // groupBoxCarteDeCredit
            // 
            this.groupBoxCarteDeCredit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCarteDeCredit.Controls.Add(this.richTextBox1);
            this.groupBoxCarteDeCredit.Controls.Add(this.label2);
            this.groupBoxCarteDeCredit.Controls.Add(this.textBoxNumero);
            this.groupBoxCarteDeCredit.Controls.Add(this.label1);
            this.groupBoxCarteDeCredit.Controls.Add(this.groupBox2);
            this.groupBoxCarteDeCredit.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCarteDeCredit.ForeColor = System.Drawing.Color.Black;
            this.groupBoxCarteDeCredit.Location = new System.Drawing.Point(559, 198);
            this.groupBoxCarteDeCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCarteDeCredit.Name = "groupBoxCarteDeCredit";
            this.groupBoxCarteDeCredit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCarteDeCredit.Size = new System.Drawing.Size(323, 180);
            this.groupBoxCarteDeCredit.TabIndex = 19;
            this.groupBoxCarteDeCredit.TabStop = false;
            this.groupBoxCarteDeCredit.Text = "Carte de crédit";
            this.groupBoxCarteDeCredit.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(175, 133);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(141, 36);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date d\'expiration:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(175, 91);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(141, 42);
            this.textBoxNumero.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnAfficherPrix);
            this.groupBox3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(230, 413);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(172, 126);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attribuer Prix";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(93, 77);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(73, 33);
            this.textBox9.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantité:";
            // 
            // btnAfficherPrix
            // 
            this.btnAfficherPrix.BackColor = System.Drawing.Color.Black;
            this.btnAfficherPrix.Location = new System.Drawing.Point(8, 32);
            this.btnAfficherPrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfficherPrix.Name = "btnAfficherPrix";
            this.btnAfficherPrix.Size = new System.Drawing.Size(160, 27);
            this.btnAfficherPrix.TabIndex = 0;
            this.btnAfficherPrix.Text = "Afficher Prix";
            this.btnAfficherPrix.UseVisualStyleBackColor = false;
            this.btnAfficherPrix.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjouterDonateur
            // 
            this.btnAjouterDonateur.BackColor = System.Drawing.Color.Black;
            this.btnAjouterDonateur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDonateur.ForeColor = System.Drawing.Color.Gold;
            this.btnAjouterDonateur.Location = new System.Drawing.Point(406, 478);
            this.btnAjouterDonateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouterDonateur.Name = "btnAjouterDonateur";
            this.btnAjouterDonateur.Size = new System.Drawing.Size(161, 29);
            this.btnAjouterDonateur.TabIndex = 21;
            this.btnAjouterDonateur.Text = "Ajouter Donateur";
            this.btnAjouterDonateur.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterDon
            // 
            this.buttonAjouterDon.BackColor = System.Drawing.Color.Black;
            this.buttonAjouterDon.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterDon.ForeColor = System.Drawing.Color.Gold;
            this.buttonAjouterDon.Location = new System.Drawing.Point(406, 413);
            this.buttonAjouterDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAjouterDon.Name = "buttonAjouterDon";
            this.buttonAjouterDon.Size = new System.Drawing.Size(161, 29);
            this.buttonAjouterDon.TabIndex = 22;
            this.buttonAjouterDon.Text = "Ajouter Don";
            this.buttonAjouterDon.UseVisualStyleBackColor = false;
            // 
            // btnAfficherDon
            // 
            this.btnAfficherDon.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAfficherDon.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherDon.ForeColor = System.Drawing.Color.Gold;
            this.btnAfficherDon.Location = new System.Drawing.Point(406, 445);
            this.btnAfficherDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfficherDon.Name = "btnAfficherDon";
            this.btnAfficherDon.Size = new System.Drawing.Size(161, 29);
            this.btnAfficherDon.TabIndex = 23;
            this.btnAfficherDon.Text = "Afficher Don";
            this.btnAfficherDon.UseVisualStyleBackColor = false;
            // 
            // btnAfficherDonateur
            // 
            this.btnAfficherDonateur.BackColor = System.Drawing.Color.Black;
            this.btnAfficherDonateur.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherDonateur.ForeColor = System.Drawing.Color.Gold;
            this.btnAfficherDonateur.Location = new System.Drawing.Point(406, 510);
            this.btnAfficherDonateur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfficherDonateur.Name = "btnAfficherDonateur";
            this.btnAfficherDonateur.Size = new System.Drawing.Size(161, 29);
            this.btnAfficherDonateur.TabIndex = 24;
            this.btnAfficherDonateur.Text = "Afficher Donateur";
            this.btnAfficherDonateur.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(721, 2);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 32);
            this.button6.TabIndex = 25;
            this.button6.Text = "Quitter";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(40, 543);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(795, 76);
            this.textBox10.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STE.Properties.Resources.parent_and_child_hands_handing_flowers_PWCMEY6_2_scaled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 653);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnAfficherDonateur);
            this.Controls.Add(this.btnAfficherDon);
            this.Controls.Add(this.buttonAjouterDon);
            this.Controls.Add(this.btnAjouterDonateur);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxCarteDeCredit);
            this.Controls.Add(this.textBoxIdDon);
            this.Controls.Add(this.textBoxMonatant);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelIddon);
            this.Controls.Add(this.labelInformationsDon);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelInformationsDonateur);
            this.Controls.Add(this.btnCommanditaire);
            this.Controls.Add(this.btnDonateur);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxCarteDeCredit.ResumeLayout(false);
            this.groupBoxCarteDeCredit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDonateur;
        private System.Windows.Forms.Button btnCommanditaire;
        private System.Windows.Forms.Label labelInformationsDonateur;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelInformationsDon;
        private System.Windows.Forms.Label labelIddon;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxMonatant;
        private System.Windows.Forms.TextBox textBoxIdDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnAMEX;
        private System.Windows.Forms.RadioButton radioBtnMC;
        private System.Windows.Forms.RadioButton radioBtnVisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCarteDeCredit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAfficherPrix;
        private System.Windows.Forms.Button btnAjouterDonateur;
        private System.Windows.Forms.Button buttonAjouterDon;
        private System.Windows.Forms.Button btnAfficherDon;
        private System.Windows.Forms.Button btnAfficherDonateur;
        private System.Windows.Forms.Button button6;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox10;
    }
}