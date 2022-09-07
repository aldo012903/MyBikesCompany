using MyBikesCompany.Business;
using MyBikesCompany.Business.Enums;
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
    public partial class MountainBikeForm : Form
    {
        private List<Bike> _listOfBikes;
        private int _originalBikeId = -1;
        private MountainBike? _mountainBike;
        private bool _ChangeType = false;
        private RoadBike? _myRoadBike;
        private bool changeP = false;

        public MountainBikeForm(List<Bike> listOfBikes, bool permissionU, MountainBike? bike)
        {
            InitializeComponent();
            _listOfBikes = listOfBikes;
            changeP = permissionU;
            if (changeP)
            {
                _mountainBike = bike;
                txtId.Text = bike.Id.ToString();
                txtModel.Text = bike.Model;
                txtMY.Text = bike.ManufacturingYear.ToString();
                cbColor.Text = bike.Color.ToString();
                cbSuspension.Text = bike.BikeSuspencion.ToString();
                btnChangeT.Visible = true;
            }
        }

        private bool AllFieldsCorrect(ref int a, ref int b)
        {
            int id;
            int year;
            if (!int.TryParse(txtId.Text, out id) && Validator.ValidId(txtId.Text))
            {
                MessageBox.Show("The Bike Id must be numeric");
                return false;
            }
            else if (id != _originalBikeId && _listOfBikes.Any(s => s.Id == id) && changeP == false)
            {
                MessageBox.Show("This Department Id already exists");
                return false;
            }
            else if (id <= 0)
            {
                MessageBox.Show("This Department Id must be a positive number");
                return false;
            }
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Model has to be specified");
                return false;
            }
            else if (!int.TryParse(txtMY.Text, out year))
            {
                MessageBox.Show("MY (Manufacturing Year) has to be specified");
                return false;
            }
            else if (b > 2022)
            {
                MessageBox.Show("MY (Manufacturing Year) has to be a valid year");
                return false;
            }
            else if (cbColor.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a color");
                return false;
            }
            else if (cbSuspension.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a tire type");
                return false;
            }

            a = id;
            b = year;
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var BikeId = new int();
            var year = new int();

            if (!AllFieldsCorrect(ref BikeId, ref year))
                return;

            _mountainBike = new MountainBike(BikeId, txtModel.Text, year,
                    (EColor)cbColor.SelectedIndex,
                    (ESuspension)cbSuspension.SelectedIndex);

            int delIndex = 0;
            int count = 0;
            foreach (var biker in _listOfBikes)
            {

                if (biker.Id.ToString() == txtId.Text)
                {
                    delIndex = count;
                }
                count++;
            }

            if (changeP == true)
            {
                _listOfBikes.RemoveAt(delIndex);
            }
            _listOfBikes.Add(_mountainBike);

            if (changeP) {
                MessageBox.Show("Bike succesfully updated\n Refresh the list view to see the new entry reflected", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bike succesfully created\n Refresh the list view to see the new entry reflected", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnChangeT_Click(object sender, EventArgs e)
        {
            var BikeId = new int();
            var year = new int();

            if (!AllFieldsCorrect(ref BikeId, ref year))
                return;

            RoadBike newBike = new RoadBike();
            newBike.Id = _mountainBike.Id;
            newBike.Model = txtModel.Text;
            newBike.Color = (EColor)cbColor.SelectedIndex;
            newBike.ManufacturingYear = year;
            newBike.TireType = ETireType.Regular;
            int delIndex = 0;
            int count = 0;
            foreach (var biker in _listOfBikes)
            {

                if (biker.Id.ToString() == txtId.Text)
                {
                    delIndex = count;
                }
                count++;
            }

            if (changeP == true)
            {
                _listOfBikes.RemoveAt(delIndex);
            }
            _listOfBikes.Add(newBike);

            if (changeP)
            {
                MessageBox.Show("Bike succesfully updated\n Refresh the list view to see the new entry reflected\n " +
                    "The Tyre was predefined as Regular if you want to change it update the information select the bike and click update. ", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
