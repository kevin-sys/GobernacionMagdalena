using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using System.Configuration;

namespace Gobernacion_del_Magdalena
{
    public partial class FrmConsultarRecaudo : Form
    {
        RecaudoService service;
        public FrmConsultarRecaudo()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            service = new RecaudoService(connectionString);
            DgvRecaudo.DataSource = null;
            recaudos.Clear();
            recaudos = service.ConsultarTodos();
            DgvRecaudo.DataSource = recaudos;
        }
        List<Recaudo> recaudos = new List<Recaudo>();

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = service.ValorTotalAdultoMayor().ToString();

        }
    }
}
