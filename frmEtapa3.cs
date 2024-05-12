using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoEtapa3
{
    public partial class frmEtapa3 : Form
    {
        public frmEtapa3()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;

        private void frmEtapa3_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.crearAuto();
            objAvion.crearAvion();
            objBarco.crearBarco();
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            objAuto.crearAuto();
            objAuto.Auto.Location = new Point(400, 500);
            this.Controls.Add(objAuto.Auto);
        }

        private void btnCrearAvion_Click(object sender, EventArgs e)
        {
            objAvion.crearAvion();
            objAvion.Avion.Location = new Point(200, 100);
            Controls.Add(objAvion.Avion);
        }

        private void btnCrearBarco_Click(object sender, EventArgs e)
        {
            objBarco.crearBarco();
            objBarco.Barco.Location = new Point(300, 350);
            this.Controls.Add(objBarco.Barco);
        }
    }
}
