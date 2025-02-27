﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Configuration;


namespace Gobernacion_del_Magdalena
{
    public partial class Form1 : Form
    {
        RecaudoService service;
        public Form1()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            service = new RecaudoService(connectionString);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string mensaje = service.GuardarArchivoPlano();
            MessageBox.Show(mensaje, "Mensaje de confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string nit = TxtNitAgente.Text.Trim();
            if (nit != null)
            {
                Recaudo recaudo = service.Buscar(nit);


                if (recaudo != null)
                {

                    MessageBox.Show($"SE ENCONTRO NIT");

                }
                else
                {
                    MessageBox.Show($"NO SE ENCONTRO NIT");

                }
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarRecaudo frmConsultar = new FrmConsultarRecaudo();
            frmConsultar.Show();

        }
    }
}
