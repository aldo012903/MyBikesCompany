using MyBikesCompany.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesCompany.Business
{
    public class RoadBike : Bike
    {
        private ETireType _tireType;

        public ETireType TireType { get => _tireType; set => _tireType = value; }

        #region Constructor
        public RoadBike() : base()
        {

        }
        public RoadBike(int id) : base(id)
        {

        }

        public RoadBike(int id, string model) : base(id, model)
        {

        }

        public RoadBike(int id, string model, int manufacturingYear) : base(id, model, manufacturingYear)
        {

        }

        public RoadBike(int id, string model, int manufacturingYear, EColor colour) : base(id, model, manufacturingYear, colour)
        {

        }

        public RoadBike(int id, string model, int manufacturingYear, EColor colour, ETireType TireType) : base(id, model, manufacturingYear, colour)
        {
            this._tireType = TireType;
        }
        #endregion

        public override string AllFields()
        {
            return "Road Bike: " + base.AllFields() + $", Tire type: {_tireType}";
        }
    }
}
