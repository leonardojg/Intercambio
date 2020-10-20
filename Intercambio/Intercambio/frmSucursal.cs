using Intercambio.Domain.EntitiesViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intercambio
{
    public partial class frmSucursal : Form
    {
        public frmSucursal()
        {
            InitializeComponent();
        }
        #region Metodos
        private void PrencherPais()
        {
            List<Pais> lstPais = new List<Pais>();

            Pais pais = new Pais();
            pais.Id = 1;
            pais.Descricao = "Brasil";
            lstPais.Add(pais);

            pais = new Pais();
            pais.Id =  2;
            pais.Descricao = "Argentina";
            lstPais.Add(pais);

            pais = new Pais();
            pais.Id = 3;
            pais.Descricao = "Peru";
            lstPais.Add(pais);

            pais = new Pais();
            pais.Id = 4;
            pais.Descricao = "Chile";
            lstPais.Add(pais);



            cmbPais.DataSource = lstPais;
            cmbPais.Items.Insert(0, "Selecione...");
            cmbPais.DisplayMember= "Descricao";
            cmbPais.ValueMember = "Id";
            cmbPais.SelectedIndex = 0;
            
        }
        private void PrencherEstado(int idPais)
        {
            List<Estado> lstEstado = new List<Estado>();

            Estado estado= new Estado();

            estado.Id = 1;
            estado.Descricao = "Sao Paulo";
            estado.PaisId = 1;
            lstEstado.Add(estado);

            estado = new Estado();
            estado.Id = 2;
            estado.Descricao = "Pernambuco";
            estado.PaisId = 1;
            lstEstado.Add(estado);

            estado = new Estado();
            estado.Id = 3;
            estado.Descricao = "Lima";
            estado.PaisId = 3;
            lstEstado.Add(estado);

            estado = new Estado();
            estado.Id = 4;
            estado.Descricao = "Buenos Aires";
            estado.PaisId = 2;
            lstEstado.Add(estado);


            cmbEstado.DataSource = lstEstado.Where(x => x.PaisId == idPais).ToList();
            cmbEstado.Items.Insert(1, "Selecione...");
            cmbEstado.DisplayMember = "Descricao";
            cmbEstado.ValueMember = "Id";
            cmbEstado.SelectedIndex = 0;


        }
        private void PrencherCidade(int idEstado)
        {

            List<Cidade> lstCidade = new List<Cidade>();
            Cidade cidade = new Cidade();

            cidade.Id = 1;
            cidade.Descricao = "Sao Paulo";
            cidade.EstadoId = 1;
            lstCidade.Add(cidade);

            cidade = new Cidade();
            cidade.Id = 2;
            cidade.Descricao = "Asa branca";
            cidade.EstadoId = 2;
            lstCidade.Add(cidade);

            cidade = new Cidade();
            cidade.Id = 3;
            cidade.Descricao = "Callao";
            cidade.EstadoId = 3;
            lstCidade.Add(cidade);

            cidade = new Cidade();
            cidade.Id = 4;
            cidade.Descricao = "La plata";
            cidade.EstadoId = 4;
            lstCidade.Add(cidade);


           
            cmbCidade.DataSource = lstCidade.Where(x => x.EstadoId == idEstado).ToList();
            cmbCidade.Items.Insert(2, "Selecione...");
            cmbCidade.DisplayMember = "Descricao";
            cmbCidade.ValueMember = "Id";
            cmbCidade.SelectedIndex = 0;

        }
        #endregion

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            PrencherPais();
           
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
           PrencherEstado(((Pais)cmbPais.SelectedValue).Id);
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrencherCidade(((Estado)cmbEstado.SelectedValue).Id);
        }
    }
}
