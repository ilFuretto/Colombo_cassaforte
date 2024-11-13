namespace Colombo_cassaforte
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cassaforte = new Label();
            label1 = new Label();
            stato = new Label();
            InserisciUtente = new TextBox();
            codeUtente = new Label();
            label2 = new Label();
            inserisciSblocco = new TextBox();
            inviaUtente = new Button();
            inviaSblocco = new Button();
            label3 = new Label();
            tentativi = new Label();
            impostaUtente = new TextBox();
            label4 = new Label();
            inviaImpostaUtente = new Button();
            label5 = new Label();
            inviaChiudi = new Button();
            label6 = new Label();
            label7 = new Label();
            impostaData = new TextBox();
            inviaImpostaData = new Button();
            inserisciData = new TextBox();
            inviaInserisciData = new Button();
            SuspendLayout();
            // 
            // cassaforte
            // 
            cassaforte.AutoSize = true;
            cassaforte.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            cassaforte.Location = new Point(512, 191);
            cassaforte.Name = "cassaforte";
            cassaforte.Size = new Size(194, 40);
            cassaforte.TabIndex = 0;
            cassaforte.Text = "CASSAFORTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(536, 171);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "STATO:";
            // 
            // stato
            // 
            stato.AutoSize = true;
            stato.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            stato.ForeColor = SystemColors.HotTrack;
            stato.Location = new Point(596, 163);
            stato.Name = "stato";
            stato.Size = new Size(72, 30);
            stato.TabIndex = 2;
            stato.Text = "label2";
            // 
            // InserisciUtente
            // 
            InserisciUtente.Location = new Point(82, 98);
            InserisciUtente.Name = "InserisciUtente";
            InserisciUtente.Size = new Size(178, 23);
            InserisciUtente.TabIndex = 3;
            // 
            // codeUtente
            // 
            codeUtente.AutoSize = true;
            codeUtente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            codeUtente.Location = new Point(73, 58);
            codeUtente.Name = "codeUtente";
            codeUtente.Size = new Size(250, 25);
            codeUtente.TabIndex = 4;
            codeUtente.Text = "INSERISCI CODICE UTENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 345);
            label2.Name = "label2";
            label2.Size = new Size(407, 25);
            label2.TabIndex = 5;
            label2.Text = "INSERISCI CODICE DI SBLOCCO UNIVERSALE";
            // 
            // inserisciSblocco
            // 
            inserisciSblocco.Location = new Point(96, 391);
            inserisciSblocco.Name = "inserisciSblocco";
            inserisciSblocco.Size = new Size(178, 23);
            inserisciSblocco.TabIndex = 6;
            // 
            // inviaUtente
            // 
            inviaUtente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inviaUtente.Location = new Point(320, 80);
            inviaUtente.Name = "inviaUtente";
            inviaUtente.Size = new Size(65, 54);
            inviaUtente.TabIndex = 7;
            inviaUtente.Text = "INVIA";
            inviaUtente.UseVisualStyleBackColor = true;
            inviaUtente.Click += inviaUtente_Click;
            // 
            // inviaSblocco
            // 
            inviaSblocco.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inviaSblocco.Location = new Point(299, 373);
            inviaSblocco.Name = "inviaSblocco";
            inviaSblocco.Size = new Size(65, 54);
            inviaSblocco.TabIndex = 8;
            inviaSblocco.Text = "INVIA";
            inviaSblocco.UseVisualStyleBackColor = true;
            inviaSblocco.Click += inviaSblocco_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(536, 80);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "TENTATIVI:";
            // 
            // tentativi
            // 
            tentativi.AutoSize = true;
            tentativi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tentativi.ForeColor = Color.Red;
            tentativi.Location = new Point(617, 80);
            tentativi.Name = "tentativi";
            tentativi.Size = new Size(51, 20);
            tentativi.TabIndex = 10;
            tentativi.Text = "label4";
            // 
            // impostaUtente
            // 
            impostaUtente.Location = new Point(536, 391);
            impostaUtente.Name = "impostaUtente";
            impostaUtente.Size = new Size(178, 23);
            impostaUtente.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(522, 345);
            label4.Name = "label4";
            label4.Size = new Size(266, 25);
            label4.TabIndex = 12;
            label4.Text = "IMPOSTA IL CODICE UTENTE";
            // 
            // inviaImpostaUtente
            // 
            inviaImpostaUtente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inviaImpostaUtente.Location = new Point(723, 373);
            inviaImpostaUtente.Name = "inviaImpostaUtente";
            inviaImpostaUtente.Size = new Size(65, 54);
            inviaImpostaUtente.TabIndex = 13;
            inviaImpostaUtente.Text = "INVIA";
            inviaImpostaUtente.UseVisualStyleBackColor = true;
            inviaImpostaUtente.Click += inviaImpostaUtente_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(49, 276);
            label5.Name = "label5";
            label5.Size = new Size(201, 25);
            label5.TabIndex = 14;
            label5.Text = "CHIUDI CASSAFORTE";
            // 
            // inviaChiudi
            // 
            inviaChiudi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inviaChiudi.Location = new Point(256, 263);
            inviaChiudi.Name = "inviaChiudi";
            inviaChiudi.Size = new Size(79, 54);
            inviaChiudi.TabIndex = 16;
            inviaChiudi.Text = "CHIUDI";
            inviaChiudi.UseVisualStyleBackColor = true;
            inviaChiudi.Click += inviaChiudi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(82, 163);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 17;
            label6.Text = "INSERISCI DATA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(522, 263);
            label7.Name = "label7";
            label7.Size = new Size(238, 25);
            label7.TabIndex = 18;
            label7.Text = "IMPOSTA DATA( es. 13/9)";
            // 
            // impostaData
            // 
            impostaData.Location = new Point(536, 304);
            impostaData.Name = "impostaData";
            impostaData.Size = new Size(178, 23);
            impostaData.TabIndex = 19;
            // 
            // inviaImpostaData
            // 
            inviaImpostaData.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inviaImpostaData.Location = new Point(720, 288);
            inviaImpostaData.Name = "inviaImpostaData";
            inviaImpostaData.Size = new Size(65, 54);
            inviaImpostaData.TabIndex = 20;
            inviaImpostaData.Text = "INVIA";
            inviaImpostaData.UseVisualStyleBackColor = true;
            // 
            // inserisciData
            // 
            inserisciData.Location = new Point(82, 191);
            inserisciData.Name = "inserisciData";
            inserisciData.Size = new Size(178, 23);
            inserisciData.TabIndex = 21;
            // 
            // inviaInserisciData
            // 
            inviaInserisciData.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            inviaInserisciData.Location = new Point(320, 177);
            inviaInserisciData.Name = "inviaInserisciData";
            inviaInserisciData.Size = new Size(65, 54);
            inviaInserisciData.TabIndex = 22;
            inviaInserisciData.Text = "INVIA";
            inviaInserisciData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inviaInserisciData);
            Controls.Add(inserisciData);
            Controls.Add(inviaImpostaData);
            Controls.Add(impostaData);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(inviaChiudi);
            Controls.Add(label5);
            Controls.Add(inviaImpostaUtente);
            Controls.Add(label4);
            Controls.Add(impostaUtente);
            Controls.Add(tentativi);
            Controls.Add(label3);
            Controls.Add(inviaSblocco);
            Controls.Add(inviaUtente);
            Controls.Add(inserisciSblocco);
            Controls.Add(label2);
            Controls.Add(codeUtente);
            Controls.Add(InserisciUtente);
            Controls.Add(stato);
            Controls.Add(label1);
            Controls.Add(cassaforte);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cassaforte;
        private Label label1;
        private Label stato;
        private TextBox InserisciUtente;
        private Label codeUtente;
        private Label label2;
        private TextBox inserisciSblocco;
        private Button inviaUtente;
        private Button inviaSblocco;
        private Label label3;
        private Label tentativi;
        private TextBox impostaUtente;
        private Label label4;
        private Button inviaImpostaUtente;
        private Label label5;
        private Button inviaChiudi;
        private Label label6;
        private Label label7;
        private TextBox impostaData;
        private Button inviaImpostaData;
        private TextBox inserisciData;
        private Button inviaInserisciData;
    }
}