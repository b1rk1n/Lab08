using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fPlanet : Form
    {
        public Planet Result { get; private set; }

        public fPlanet(Planet planet)
        {
            InitializeComponent();
            Result = new Planet();
            Result.Name = planet.Name;
            Result.StarSystem = planet.StarSystem;
            Result.DiameterKm = planet.DiameterKm;
            Result.DistanceFromSunMln = planet.DistanceFromSunMln;
            Result.MassKg = planet.MassKg;
            Result.NumberOfMoons = planet.NumberOfMoons;
            Result.HasRings = planet.HasRings;
            Result.HasAtmosphere = planet.HasAtmosphere;
        }

        private void fPlanet_Load(object sender, EventArgs e)
        {
            txtName.Text = Result.Name;
            txtStarSystem.Text = Result.StarSystem;
            txtDiameter.Text = Result.DiameterKm.ToString();
            txtDistance.Text = Result.DistanceFromSunMln.ToString();
            txtMass.Text = Result.MassKg.ToString();
            txtMoons.Text = Result.NumberOfMoons.ToString();
            chkRings.Checked = Result.HasRings;
            chkAtmosphere.Checked = Result.HasAtmosphere;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result.Name = txtName.Text;
            Result.StarSystem = txtStarSystem.Text;
            Result.DiameterKm = double.Parse(txtDiameter.Text);
            Result.DistanceFromSunMln = double.Parse(txtDistance.Text);
            Result.MassKg = double.Parse(txtMass.Text);
            Result.NumberOfMoons = int.Parse(txtMoons.Text);
            Result.HasRings = chkRings.Checked;
            Result.HasAtmosphere = chkAtmosphere.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}