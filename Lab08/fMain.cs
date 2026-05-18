using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPlanets.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.HeaderText = "Назва";
            gvPlanets.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "StarSystem";
            column.HeaderText = "Зоряна система";
            gvPlanets.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DiameterKm";
            column.HeaderText = "Діаметр (км)";
            gvPlanets.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DistanceFromSunMln";
            column.HeaderText = "Відстань (млн км)";
            gvPlanets.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MassKg";
            column.HeaderText = "Маса (кг)";
            gvPlanets.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NumberOfMoons";
            column.HeaderText = "Супутники";
            column.Width = 70;
            gvPlanets.Columns.Add(column);

            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.DataPropertyName = "HasRings";
            chkColumn.HeaderText = "Кільця";
            chkColumn.Width = 60;
            gvPlanets.Columns.Add(chkColumn);

            chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.DataPropertyName = "HasAtmosphere";
            chkColumn.HeaderText = "Атмосфера";
            chkColumn.Width = 70;
            gvPlanets.Columns.Add(chkColumn);

            bindSrcPlanets.Add(new Planet("Земля", "Сонячна", 12742, 149.6, 5.97e24, 1, false, true));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Planet planet = new Planet();
            fPlanet fp = new fPlanet(ref planet);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                bindSrcPlanets.Add(planet);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Planet planet = (Planet)bindSrcPlanets.List[bindSrcPlanets.Position];
            fPlanet fp = new fPlanet(ref planet);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                bindSrcPlanets.List[bindSrcPlanets.Position] = planet;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPlanets.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPlanets.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}