namespace Prova.Views
{
    partial class PassagemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassagemView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpComprarPassagem = new System.Windows.Forms.TabPage();
            this.bttComprar = new System.Windows.Forms.Button();
            this.chcClasseEconomica = new System.Windows.Forms.CheckBox();
            this.chcPrimeiraClasse = new System.Windows.Forms.CheckBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.dttHoraVoo = new System.Windows.Forms.DateTimePicker();
            this.dttDataPassagem = new System.Windows.Forms.DateTimePicker();
            this.lblHoraVoo = new System.Windows.Forms.Label();
            this.lblDataPassagem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbpVerificarPassagem = new System.Windows.Forms.TabPage();
            this.lblDestinoPassagemDestacavel = new System.Windows.Forms.Label();
            this.lblDestinoPassagem = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblOrigemPassagem = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblHoraViagemPassagemDestacavel = new System.Windows.Forms.Label();
            this.lblDataViagemPassagemDestacavel = new System.Windows.Forms.Label();
            this.lblNomePassageiroViagemDestacavel = new System.Windows.Forms.Label();
            this.lblClasseViagemPassagemDestacavel = new System.Windows.Forms.Label();
            this.lblClasseViagemPassagem = new System.Windows.Forms.Label();
            this.lblNomePassageiroViagem = new System.Windows.Forms.Label();
            this.lblHoraViagemPassagem = new System.Windows.Forms.Label();
            this.lblDataViagemPassagem = new System.Windows.Forms.Label();
            this.pctPassagem = new System.Windows.Forms.PictureBox();
            this.bttPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbpComprarPassagem.SuspendLayout();
            this.tbpVerificarPassagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassagem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpComprarPassagem);
            this.tabControl1.Controls.Add(this.tbpVerificarPassagem);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 300);
            this.tabControl1.TabIndex = 6;
            // 
            // tbpComprarPassagem
            // 
            this.tbpComprarPassagem.Controls.Add(this.bttComprar);
            this.tbpComprarPassagem.Controls.Add(this.chcClasseEconomica);
            this.tbpComprarPassagem.Controls.Add(this.chcPrimeiraClasse);
            this.tbpComprarPassagem.Controls.Add(this.lblClasse);
            this.tbpComprarPassagem.Controls.Add(this.dttHoraVoo);
            this.tbpComprarPassagem.Controls.Add(this.dttDataPassagem);
            this.tbpComprarPassagem.Controls.Add(this.lblHoraVoo);
            this.tbpComprarPassagem.Controls.Add(this.lblDataPassagem);
            this.tbpComprarPassagem.Controls.Add(this.lblDestino);
            this.tbpComprarPassagem.Controls.Add(this.lblOrigem);
            this.tbpComprarPassagem.Controls.Add(this.lblNome);
            this.tbpComprarPassagem.Controls.Add(this.txtDestino);
            this.tbpComprarPassagem.Controls.Add(this.txtOrigem);
            this.tbpComprarPassagem.Controls.Add(this.txtNome);
            this.tbpComprarPassagem.Location = new System.Drawing.Point(4, 22);
            this.tbpComprarPassagem.Name = "tbpComprarPassagem";
            this.tbpComprarPassagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpComprarPassagem.Size = new System.Drawing.Size(642, 274);
            this.tbpComprarPassagem.TabIndex = 0;
            this.tbpComprarPassagem.Text = "Comprar Passagem";
            this.tbpComprarPassagem.UseVisualStyleBackColor = true;
            // 
            // bttComprar
            // 
            this.bttComprar.Location = new System.Drawing.Point(238, 185);
            this.bttComprar.Name = "bttComprar";
            this.bttComprar.Size = new System.Drawing.Size(75, 23);
            this.bttComprar.TabIndex = 19;
            this.bttComprar.Text = "Comprar";
            this.bttComprar.UseVisualStyleBackColor = true;
            this.bttComprar.Click += new System.EventHandler(this.bttComprar_Click);
            // 
            // chcClasseEconomica
            // 
            this.chcClasseEconomica.AutoSize = true;
            this.chcClasseEconomica.Location = new System.Drawing.Point(379, 153);
            this.chcClasseEconomica.Name = "chcClasseEconomica";
            this.chcClasseEconomica.Size = new System.Drawing.Size(113, 17);
            this.chcClasseEconomica.TabIndex = 17;
            this.chcClasseEconomica.Text = "Classe Economica";
            this.chcClasseEconomica.UseVisualStyleBackColor = true;
            this.chcClasseEconomica.CheckedChanged += new System.EventHandler(this.chcClasseEconomica_CheckedChanged);
            // 
            // chcPrimeiraClasse
            // 
            this.chcPrimeiraClasse.AutoSize = true;
            this.chcPrimeiraClasse.Location = new System.Drawing.Point(276, 153);
            this.chcPrimeiraClasse.Name = "chcPrimeiraClasse";
            this.chcPrimeiraClasse.Size = new System.Drawing.Size(97, 17);
            this.chcPrimeiraClasse.TabIndex = 18;
            this.chcPrimeiraClasse.Text = "Primeira Classe";
            this.chcPrimeiraClasse.UseVisualStyleBackColor = true;
            this.chcPrimeiraClasse.CheckedChanged += new System.EventHandler(this.chcPrimeiraClasse_CheckedChanged);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(229, 154);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(41, 13);
            this.lblClasse.TabIndex = 16;
            this.lblClasse.Text = "Classe:";
            // 
            // dttHoraVoo
            // 
            this.dttHoraVoo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttHoraVoo.Location = new System.Drawing.Point(276, 75);
            this.dttHoraVoo.Name = "dttHoraVoo";
            this.dttHoraVoo.Size = new System.Drawing.Size(82, 20);
            this.dttHoraVoo.TabIndex = 14;
            // 
            // dttDataPassagem
            // 
            this.dttDataPassagem.Location = new System.Drawing.Point(276, 49);
            this.dttDataPassagem.Name = "dttDataPassagem";
            this.dttDataPassagem.Size = new System.Drawing.Size(200, 20);
            this.dttDataPassagem.TabIndex = 15;
            // 
            // lblHoraVoo
            // 
            this.lblHoraVoo.AutoSize = true;
            this.lblHoraVoo.Location = new System.Drawing.Point(203, 75);
            this.lblHoraVoo.Name = "lblHoraVoo";
            this.lblHoraVoo.Size = new System.Drawing.Size(67, 13);
            this.lblHoraVoo.TabIndex = 9;
            this.lblHoraVoo.Text = "Hora do Voo";
            // 
            // lblDataPassagem
            // 
            this.lblDataPassagem.AutoSize = true;
            this.lblDataPassagem.Location = new System.Drawing.Point(173, 51);
            this.lblDataPassagem.Name = "lblDataPassagem";
            this.lblDataPassagem.Size = new System.Drawing.Size(97, 13);
            this.lblDataPassagem.TabIndex = 10;
            this.lblDataPassagem.Text = "Data da Passagem";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(176, 130);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(94, 13);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "Cidade de Destino";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(176, 104);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(94, 13);
            this.lblOrigem.TabIndex = 12;
            this.lblOrigem.Text = "Cidade de Origem:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(235, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(276, 127);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 6;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(276, 101);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(100, 20);
            this.txtOrigem.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(276, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // tbpVerificarPassagem
            // 
            this.tbpVerificarPassagem.Controls.Add(this.lblDestinoPassagemDestacavel);
            this.tbpVerificarPassagem.Controls.Add(this.lblDestinoPassagem);
            this.tbpVerificarPassagem.Controls.Add(this.lblPara);
            this.tbpVerificarPassagem.Controls.Add(this.lblOrigemPassagem);
            this.tbpVerificarPassagem.Controls.Add(this.lblDe);
            this.tbpVerificarPassagem.Controls.Add(this.lblHoraViagemPassagemDestacavel);
            this.tbpVerificarPassagem.Controls.Add(this.lblDataViagemPassagemDestacavel);
            this.tbpVerificarPassagem.Controls.Add(this.lblNomePassageiroViagemDestacavel);
            this.tbpVerificarPassagem.Controls.Add(this.lblClasseViagemPassagemDestacavel);
            this.tbpVerificarPassagem.Controls.Add(this.lblClasseViagemPassagem);
            this.tbpVerificarPassagem.Controls.Add(this.lblNomePassageiroViagem);
            this.tbpVerificarPassagem.Controls.Add(this.lblHoraViagemPassagem);
            this.tbpVerificarPassagem.Controls.Add(this.lblDataViagemPassagem);
            this.tbpVerificarPassagem.Controls.Add(this.bttPesquisar);
            this.tbpVerificarPassagem.Controls.Add(this.txtPesquisa);
            this.tbpVerificarPassagem.Controls.Add(this.pctPassagem);
            this.tbpVerificarPassagem.Location = new System.Drawing.Point(4, 22);
            this.tbpVerificarPassagem.Name = "tbpVerificarPassagem";
            this.tbpVerificarPassagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVerificarPassagem.Size = new System.Drawing.Size(642, 274);
            this.tbpVerificarPassagem.TabIndex = 1;
            this.tbpVerificarPassagem.Text = "Verificar Passagem";
            this.tbpVerificarPassagem.UseVisualStyleBackColor = true;
            // 
            // lblDestinoPassagemDestacavel
            // 
            this.lblDestinoPassagemDestacavel.AutoSize = true;
            this.lblDestinoPassagemDestacavel.Location = new System.Drawing.Point(459, 160);
            this.lblDestinoPassagemDestacavel.Name = "lblDestinoPassagemDestacavel";
            this.lblDestinoPassagemDestacavel.Size = new System.Drawing.Size(35, 13);
            this.lblDestinoPassagemDestacavel.TabIndex = 10;
            this.lblDestinoPassagemDestacavel.Text = "label1";
            this.lblDestinoPassagemDestacavel.Visible = false;
            // 
            // lblDestinoPassagem
            // 
            this.lblDestinoPassagem.AutoSize = true;
            this.lblDestinoPassagem.Location = new System.Drawing.Point(243, 160);
            this.lblDestinoPassagem.Name = "lblDestinoPassagem";
            this.lblDestinoPassagem.Size = new System.Drawing.Size(35, 13);
            this.lblDestinoPassagem.TabIndex = 10;
            this.lblDestinoPassagem.Text = "label1";
            this.lblDestinoPassagem.Visible = false;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(204, 160);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(32, 13);
            this.lblPara.TabIndex = 9;
            this.lblPara.Text = "Para:";
            this.lblPara.Visible = false;
            // 
            // lblOrigemPassagem
            // 
            this.lblOrigemPassagem.AutoSize = true;
            this.lblOrigemPassagem.Location = new System.Drawing.Point(75, 160);
            this.lblOrigemPassagem.Name = "lblOrigemPassagem";
            this.lblOrigemPassagem.Size = new System.Drawing.Size(35, 13);
            this.lblOrigemPassagem.TabIndex = 8;
            this.lblOrigemPassagem.Text = "label1";
            this.lblOrigemPassagem.Visible = false;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(45, 160);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 7;
            this.lblDe.Text = "De:";
            this.lblDe.Visible = false;
            // 
            // lblHoraViagemPassagemDestacavel
            // 
            this.lblHoraViagemPassagemDestacavel.AutoSize = true;
            this.lblHoraViagemPassagemDestacavel.Location = new System.Drawing.Point(459, 121);
            this.lblHoraViagemPassagemDestacavel.Name = "lblHoraViagemPassagemDestacavel";
            this.lblHoraViagemPassagemDestacavel.Size = new System.Drawing.Size(35, 13);
            this.lblHoraViagemPassagemDestacavel.TabIndex = 6;
            this.lblHoraViagemPassagemDestacavel.Text = "label1";
            this.lblHoraViagemPassagemDestacavel.Visible = false;
            // 
            // lblDataViagemPassagemDestacavel
            // 
            this.lblDataViagemPassagemDestacavel.AutoSize = true;
            this.lblDataViagemPassagemDestacavel.Location = new System.Drawing.Point(460, 101);
            this.lblDataViagemPassagemDestacavel.Name = "lblDataViagemPassagemDestacavel";
            this.lblDataViagemPassagemDestacavel.Size = new System.Drawing.Size(35, 13);
            this.lblDataViagemPassagemDestacavel.TabIndex = 6;
            this.lblDataViagemPassagemDestacavel.Text = "label1";
            this.lblDataViagemPassagemDestacavel.Visible = false;
            // 
            // lblNomePassageiroViagemDestacavel
            // 
            this.lblNomePassageiroViagemDestacavel.AutoSize = true;
            this.lblNomePassageiroViagemDestacavel.Location = new System.Drawing.Point(460, 80);
            this.lblNomePassageiroViagemDestacavel.Name = "lblNomePassageiroViagemDestacavel";
            this.lblNomePassageiroViagemDestacavel.Size = new System.Drawing.Size(35, 13);
            this.lblNomePassageiroViagemDestacavel.TabIndex = 6;
            this.lblNomePassageiroViagemDestacavel.Text = "label1";
            this.lblNomePassageiroViagemDestacavel.Visible = false;
            // 
            // lblClasseViagemPassagemDestacavel
            // 
            this.lblClasseViagemPassagemDestacavel.AutoSize = true;
            this.lblClasseViagemPassagemDestacavel.Location = new System.Drawing.Point(460, 141);
            this.lblClasseViagemPassagemDestacavel.Name = "lblClasseViagemPassagemDestacavel";
            this.lblClasseViagemPassagemDestacavel.Size = new System.Drawing.Size(35, 13);
            this.lblClasseViagemPassagemDestacavel.TabIndex = 6;
            this.lblClasseViagemPassagemDestacavel.Text = "label1";
            this.lblClasseViagemPassagemDestacavel.Visible = false;
            // 
            // lblClasseViagemPassagem
            // 
            this.lblClasseViagemPassagem.AutoSize = true;
            this.lblClasseViagemPassagem.Location = new System.Drawing.Point(146, 129);
            this.lblClasseViagemPassagem.Name = "lblClasseViagemPassagem";
            this.lblClasseViagemPassagem.Size = new System.Drawing.Size(35, 13);
            this.lblClasseViagemPassagem.TabIndex = 6;
            this.lblClasseViagemPassagem.Text = "label1";
            this.lblClasseViagemPassagem.Visible = false;
            // 
            // lblNomePassageiroViagem
            // 
            this.lblNomePassageiroViagem.AutoSize = true;
            this.lblNomePassageiroViagem.Location = new System.Drawing.Point(146, 101);
            this.lblNomePassageiroViagem.Name = "lblNomePassageiroViagem";
            this.lblNomePassageiroViagem.Size = new System.Drawing.Size(87, 13);
            this.lblNomePassageiroViagem.TabIndex = 5;
            this.lblNomePassageiroViagem.Text = "PassageiroNome";
            this.lblNomePassageiroViagem.Visible = false;
            // 
            // lblHoraViagemPassagem
            // 
            this.lblHoraViagemPassagem.AutoSize = true;
            this.lblHoraViagemPassagem.Location = new System.Drawing.Point(319, 201);
            this.lblHoraViagemPassagem.Name = "lblHoraViagemPassagem";
            this.lblHoraViagemPassagem.Size = new System.Drawing.Size(35, 13);
            this.lblHoraViagemPassagem.TabIndex = 4;
            this.lblHoraViagemPassagem.Text = "label1";
            this.lblHoraViagemPassagem.Visible = false;
            // 
            // lblDataViagemPassagem
            // 
            this.lblDataViagemPassagem.AutoSize = true;
            this.lblDataViagemPassagem.Location = new System.Drawing.Point(170, 201);
            this.lblDataViagemPassagem.Name = "lblDataViagemPassagem";
            this.lblDataViagemPassagem.Size = new System.Drawing.Size(70, 13);
            this.lblDataViagemPassagem.TabIndex = 3;
            this.lblDataViagemPassagem.Text = "datadatadata";
            this.lblDataViagemPassagem.Visible = false;
            // 
            // pctPassagem
            // 
            this.pctPassagem.Image = ((System.Drawing.Image)(resources.GetObject("pctPassagem.Image")));
            this.pctPassagem.Location = new System.Drawing.Point(6, 42);
            this.pctPassagem.Name = "pctPassagem";
            this.pctPassagem.Size = new System.Drawing.Size(631, 232);
            this.pctPassagem.TabIndex = 2;
            this.pctPassagem.TabStop = false;
            this.pctPassagem.Visible = false;
            // 
            // bttPesquisar
            // 
            this.bttPesquisar.Location = new System.Drawing.Point(340, 6);
            this.bttPesquisar.Name = "bttPesquisar";
            this.bttPesquisar.Size = new System.Drawing.Size(75, 23);
            this.bttPesquisar.TabIndex = 1;
            this.bttPesquisar.Text = "Pesquisar";
            this.bttPesquisar.UseVisualStyleBackColor = true;
            this.bttPesquisar.Click += new System.EventHandler(this.bttPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(234, 8);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // PassagemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 325);
            this.Controls.Add(this.tabControl1);
            this.Name = "PassagemView";
            this.Text = "PassagemView";
            this.tabControl1.ResumeLayout(false);
            this.tbpComprarPassagem.ResumeLayout(false);
            this.tbpComprarPassagem.PerformLayout();
            this.tbpVerificarPassagem.ResumeLayout(false);
            this.tbpVerificarPassagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpComprarPassagem;
        private System.Windows.Forms.Button bttComprar;
        private System.Windows.Forms.CheckBox chcClasseEconomica;
        private System.Windows.Forms.CheckBox chcPrimeiraClasse;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.DateTimePicker dttHoraVoo;
        private System.Windows.Forms.DateTimePicker dttDataPassagem;
        private System.Windows.Forms.Label lblHoraVoo;
        private System.Windows.Forms.Label lblDataPassagem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabPage tbpVerificarPassagem;
        private System.Windows.Forms.PictureBox pctPassagem;
        private System.Windows.Forms.Button bttPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblDestinoPassagemDestacavel;
        private System.Windows.Forms.Label lblDestinoPassagem;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblOrigemPassagem;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblHoraViagemPassagemDestacavel;
        private System.Windows.Forms.Label lblDataViagemPassagemDestacavel;
        private System.Windows.Forms.Label lblNomePassageiroViagemDestacavel;
        private System.Windows.Forms.Label lblClasseViagemPassagemDestacavel;
        private System.Windows.Forms.Label lblClasseViagemPassagem;
        private System.Windows.Forms.Label lblNomePassageiroViagem;
        private System.Windows.Forms.Label lblHoraViagemPassagem;
        private System.Windows.Forms.Label lblDataViagemPassagem;
    }
}