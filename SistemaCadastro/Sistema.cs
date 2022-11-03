﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco(); // Instancia o ConectaBanco 
            DataTable tabelaDados = new DataTable(); // Isatancia uma tabela virtual, que vai recebr a tabrla virtul de outra função
            tabelaDados = con.listaGeneros(); 
            cbGenero.DataSource = tabelaDados; // Especifica a fonte de dados 
            cbGenero.DisplayMember = "genero"; // Texto que sera mostrado
            cbGenero.ValueMember = "idgenero"; // Qual valor que será guardado quando selecionado
            lbmMsgErro.Text = con.mensagem;


        }


        private void BtnConfirmaCadastro_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            


        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}