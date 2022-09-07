using MyBikesCompany.Business;
using MyBikesCompany.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesCompany.UI
{
    public partial class MainForm : Form
    {
        private List<Bike> _listOfBikes = BikeXMLData.Load();
        private Dictionary<int, int> dictionaryOfIndexes = new Dictionary<int, int>();
        private bool _allChangesSave = true;
        private Form activeForm = null;


        public MainForm()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void btnBike_Click(object sender, EventArgs e)
        {
            if (plBikes.Visible)
            {
                plBikes.Hide();
            }
            else
            {
                plBikes.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_allChangesSave)
            {
                var answer = MessageBox.Show("Do you want to close the application without saving your previous changes?",
                                           "Warning", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
                if (answer == DialogResult.No) e.Cancel = true;
            }

            else
            {
                var answer = MessageBox.Show("Do you really want to exit the application?",
                                           "Confirmation", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                if (answer == DialogResult.No) e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to save the list of bikes?",
                                         "Confirmation", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                BikeXMLData.Save(_listOfBikes);
                _allChangesSave = true;
            }
        }

        private void btnShowML_Click(object sender, EventArgs e)
        {
            if (plOpt.Visible)
            {
                plOpt.Visible = false;
                btnShowML.Location = new Point(1407, 4);
                lstBikes.Size = new Size(1508, 260);
                btnShowML.Text = "Show";
            }
            else
            {
                plOpt.Visible = true;
                btnShowML.Location = new Point(1407, 74);
                lstBikes.Size = new Size(1508, 196);
                btnShowML.Text = "Hide";
            }
        }

        private void UpdateListView()
        {
            _listOfBikes = _listOfBikes.OrderBy(o => o.Id).ToList();
            lstBikes.Items.Clear();
            dictionaryOfIndexes.Clear();

            int listCounter = 0;
            foreach (var bike in _listOfBikes)
            {
                bool add = false;

                if (rbAll.Checked) add = true;
                if (rbRoad.Checked && bike is RoadBike) add = true;
                if (rbMountain.Checked && bike is MountainBike) add = true;
                if (add)
                {
                    var listViewItem = new ListViewItem(bike.AllFields());
                    dictionaryOfIndexes.Add(lstBikes.Items.Count, listCounter);
                    lstBikes.Items.Add(listViewItem);
                }
                listCounter++;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void rbMountain_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void rbRoad_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null) {
                activeForm.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.ValidId(txtSearch.Text))
            {
                Int32.TryParse(txtSearch.Text, out int storedID);
                Bike? bike = _listOfBikes.FirstOrDefault(s => s!.Id == storedID, null);


                if (bike is not null)
                {
                    MessageBox.Show(bike.AllFields(), "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    MessageBox.Show("Id not found", "Make sure id exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Non valid id", "Please inform a correct id",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (Validator.ValidId(txtSearch.Text))
            {
                int.TryParse(txtSearch.Text, out int storedID);

                foreach (var bike in _listOfBikes)
                {
                    if (storedID == bike.Id)
                    {

                        var answer = MessageBox.Show("Do you really want to delete this bike",
                                         "Confirmation", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {
                            _listOfBikes.Remove(bike);
                            UpdateListView();
                            _allChangesSave = false;
                        }
                        return;
                    }
                }
                MessageBox.Show("Id not found", "Make sure id exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Non valid id", "Please inform a correct id",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void activateForm(Form requestForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = requestForm;
            requestForm.TopLevel = false;
            requestForm.FormBorderStyle = FormBorderStyle.None;
            requestForm.Dock = DockStyle.Fill;
            plHome.Controls.Add(requestForm);
            plHome.Tag = requestForm;
            requestForm.BringToFront();
            requestForm.Show();
        }

        private void btnMountain_Click(object sender, EventArgs e)
        {
            activateForm(new MountainBikeForm(_listOfBikes, false, null));
        }

        private void btnRoad_Click(object sender, EventArgs e)
        {
            activateForm(new RoadBikeForm(_listOfBikes, false, null));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lstBikes.FocusedItem = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.ValidId(txtSearch.Text))
            {
                int.TryParse(txtSearch.Text, out int storedID);

                foreach (var bike in _listOfBikes)
                {
                    if (storedID == bike.Id)
                    {

                        var answer = MessageBox.Show("Do you really want to edit this bike",
                                         "Confirmation", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {

                            if (bike is RoadBike)
                            {
                                var ubike = (RoadBike)bike;
                                activateForm(new RoadBikeForm(_listOfBikes, true, ubike));
                            }
                            if (bike is MountainBike)
                            {
                                var ubike = (MountainBike)bike;
                                activateForm(new MountainBikeForm(_listOfBikes, true, ubike));
                            }
                            _allChangesSave = false;
                        }
                        return;
                    }
                }
                MessageBox.Show("Id not found", "Make sure id exists",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Non valid id", "Please inform a correct id",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
