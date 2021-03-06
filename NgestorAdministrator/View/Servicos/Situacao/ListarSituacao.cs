﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NgestorAdministrator.View.Components.DefualtHeader;

namespace NgestorAdministrator.View.Servicos.Situacao
{
    public partial class ListarSituacao : UserControl
    {
        public ListarSituacao()
        {
            InitializeComponent();
        }

        private void btnNovoCodigo_Click(object sender, EventArgs e)
        {
            Novo novo = new Novo();
            novo.ShowDialog();
        }

        private void ListarServicoCodigoBaixa_Load(object sender, EventArgs e)
        {
            TopHeader topHeader = new TopHeader("Serviço","Situação");
            topHeader.Dock = DockStyle.Fill;
            painelTopHeader.Controls.Add(topHeader);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
