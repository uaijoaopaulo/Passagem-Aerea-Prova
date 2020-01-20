using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Prova.Model;
using Prova.Repository;

namespace Prova.Views
{
    public partial class PassagemView : Form
    {
        PassagemRepository PR = new PassagemRepository();
        public PassagemView()
        {
            InitializeComponent();
        }
        protected void limpaCompra(){
            txtNome.Text = "";
            txtOrigem.Text = "";
            txtDestino.Text = "";
            chcClasseEconomica.Checked = false;
            chcPrimeiraClasse.Checked = false;
        }
        private void bttComprar_Click(object sender, EventArgs e)
        {
            string classeEscolhida = "";
            if(chcPrimeiraClasse.Checked == true)
                classeEscolhida = "Primeira Classe";
            else if(chcClasseEconomica.Checked == true)
                classeEscolhida = "Classe Economica";
            else if(chcClasseEconomica.Checked == false && chcPrimeiraClasse.Checked == false){
                MessageBox.Show("Classe da viagem não escolhida");
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtOrigem.Text) || string.IsNullOrEmpty(txtDestino.Text) || dttDataPassagem.Value <= DateTime.Now || txtDestino.Text == txtOrigem.Text)
            {
                MessageBox.Show("Há erros em sua compra por favor verificar campos!");
                return;
            }
            Passagem passagem = new Passagem
            {
                nome_passageiro = txtNome.Text,
                data_passagem = DateTime.Parse(dttDataPassagem.Value.ToShortDateString()),
                hora_voo = TimeSpan.Parse(dttHoraVoo.Value.ToShortTimeString()),
                cidade_origem = txtOrigem.Text,
                cidade_destino = txtDestino.Text,
                classe = classeEscolhida
            };
            PR.Salvar(passagem);
            limpaCompra();
        }

        private void chcPrimeiraClasse_CheckedChanged(object sender, EventArgs e)
        {
            if(chcPrimeiraClasse.Checked == true)
                chcClasseEconomica.Checked = false;
        }

        private void chcClasseEconomica_CheckedChanged(object sender, EventArgs e)
        {
            if(chcClasseEconomica.Checked == true)
                chcPrimeiraClasse.Checked = false;
        }
        private void visualizaCampos()
        {
            pctPassagem.Visible = true;
            lblClasseViagemPassagem.Visible = true;
            lblClasseViagemPassagemDestacavel.Visible = true;
            lblNomePassageiroViagem.Visible = true;
            lblNomePassageiroViagemDestacavel.Visible = true;
            lblDataViagemPassagem.Visible = true;
            lblDataViagemPassagemDestacavel.Visible = true;
            lblHoraViagemPassagem.Visible = true;
            lblHoraViagemPassagemDestacavel.Visible = true;
            lblOrigemPassagem.Visible = true;
            lblDe.Visible = true;
            lblPara.Visible = true;
            lblDestinoPassagem.Visible = true;
            lblDestinoPassagemDestacavel.Visible = true;

        }
        private void desativaCampos()
        {
            pctPassagem.Visible = false;
            lblClasseViagemPassagem.Visible = false;
            lblClasseViagemPassagemDestacavel.Visible = false;
            lblNomePassageiroViagem.Visible = false;
            lblNomePassageiroViagemDestacavel.Visible = false;
            lblDataViagemPassagem.Visible = false;
            lblDataViagemPassagemDestacavel.Visible = false;
            lblHoraViagemPassagem.Visible = false;
            lblHoraViagemPassagemDestacavel.Visible = false;
            lblOrigemPassagem.Visible = false;
            lblDe.Visible = false;
            lblPara.Visible = false;
            lblDestinoPassagem.Visible = false;
            lblDestinoPassagemDestacavel.Visible = false;
        }
        private void bttPesquisar_Click(object sender, EventArgs e)
        {
            Passagem passagem = PR.GetOne(txtPesquisa.Text);
            if (passagem == null)
            {
                MessageBox.Show("Passagem não encontrada, Verifique o nome digitado");
                desativaCampos();
                return;
            }
            else
            {
                visualizaCampos();
                lblNomePassageiroViagem.Text = passagem.nome_passageiro;
                lblNomePassageiroViagemDestacavel.Text = passagem.nome_passageiro;
                lblClasseViagemPassagem.Text = passagem.classe;
                lblClasseViagemPassagemDestacavel.Text = passagem.classe;
                lblOrigemPassagem.Text = passagem.cidade_origem;
                lblDestinoPassagem.Text = passagem.cidade_destino;
                lblDestinoPassagemDestacavel.Text = passagem.cidade_destino;
                lblDataViagemPassagem.Text = passagem.data_passagem.ToShortDateString();
                lblDataViagemPassagemDestacavel.Text = passagem.data_passagem.ToShortDateString();
                lblHoraViagemPassagem.Text = passagem.hora_voo.ToString();
                lblHoraViagemPassagemDestacavel.Text = passagem.hora_voo.ToString();
            }
        }
    }
}
