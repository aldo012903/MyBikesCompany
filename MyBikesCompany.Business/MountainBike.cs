using MyBikesCompany.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesCompany.Business
{
    public class MountainBike : Bike
    {

        private ESuspension _suspencion;

        public ESuspension BikeSuspencion { get => _suspencion; set => _suspencion = value; }

        #region Constructor
        public MountainBike() : base()
        {

        }

        public MountainBike(int id) : base(id)
        {

        }

        public MountainBike(int id, string model) : base(id, model)
        {

        }

        public MountainBike(int id, string model, int manufacturingYear) : base(id, model, manufacturingYear)
        {

        }

        public MountainBike(int id, string model, int manufacturingYear, EColor colour) : base(id, model, manufacturingYear, colour)
        {

        }

        public MountainBike(int id, string model, int manufacturingYear, EColor colour, ESuspension suspencion) : base(id, model, manufacturingYear, colour)
        {
            this._suspencion = suspencion;
        }
        #endregion

        public override string AllFields()
        {
            return "Mountain Bike: " + base.AllFields() + $", Suspension: {_suspencion}";
        }
    }
}
