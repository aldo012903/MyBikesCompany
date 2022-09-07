using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MyBikesCompany.Business.Enums;

namespace MyBikesCompany.Business
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    public abstract class Bike
    {
        private int _id;
        private string _model = "";
        private int _manufacturingYear;
        private EColor _color;

        public int Id { get => _id; set => _id = value; }
        public string Model { get => _model; set => _model = value; }
        public EColor Color { get => _color; set => _color = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }
        protected Bike()
        {
            _id = 0;
            _model = "";
            _manufacturingYear = 0;
            _color = EColor.Undefined;
        }

        protected Bike(int id) : this()
        {
            _id = id;
        }
        protected Bike(int id, string model) : this(id)
        {
            _model = model;
        }

        protected Bike(int id, string model, int manufacturingYear) : this(id, model)
        {
            _manufacturingYear = manufacturingYear;
        }

        protected Bike(int id, string model, int manufacturingYear, EColor colour) : this(id, model, manufacturingYear)
        {
            _color = colour;
        }
        public virtual string AllFields()
        {
            return $"Id: {_id}, Model: {_model}, Manufacturing Year: {_manufacturingYear}, Colour: {_color}";
        }
    }
}



    


