using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab08
{
    public partial class fPlanet : Form
    {
        private Planet planet;

        public fPlanet(ref Planet planet)
        {
            InitializeComponent();
            this.planet = planet;
        }

        private void fPlanet_Load(object sender, EventArgs e)
        {
            txtName.Text = planet.Name;
            txtStarSystem.Text = planet.StarSystem;
            txtDiameter.Text = planet.DiameterKm.ToString();
            txtDistance.Text = planet.DistanceFromSunMln.ToString();
            txtMass.Text = planet.MassKg.ToString();
            txtMoons.Text = planet.NumberOfMoons.ToString();
            chkRings.Checked = planet.HasRings;
            chkAtmosphere.Checked = planet.HasAtmosphere;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            planet.Name = txtName.Text;
            planet.StarSystem = txtStarSystem.Text;
            planet.DiameterKm = double.Parse(txtDiameter.Text);
            planet.DistanceFromSunMln = double.Parse(txtDistance.Text);
            planet.MassKg = double.Parse(txtMass.Text);
            planet.NumberOfMoons = int.Parse(txtMoons.Text);
            planet.HasRings = chkRings.Checked;
            planet.HasAtmosphere = chkAtmosphere.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}