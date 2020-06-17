using System.Collections.Generic;
using System.Data;

namespace Turbo
{
    public class InfoModel
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string body_type { get; set; }
        public string walk { get; set; }
        public string price { get; set; }
        public string color { get; set; }
        public string currency { get; set; }
        public bool credit { get; set; }
        public bool barter { get; set; }
        public string additional_information { get; set; }
        public string fuel_type { get; set; }
        public string transmission { get; set; }
        public string gearbox { get; set; }
        public string graduation_year { get; set; }
        public string engine_capacity { get; set; }
        public int HP { get; set; }
        public bool alloy_wheels { get; set; }
        public bool central_closure { get; set; }
        public bool leather_salon { get; set; }
        public bool seat_ventilation { get; set; }
        public bool USA { get; set; }
        public bool parking_radar { get; set; }
        public bool xenon { get; set; }
        public bool luke { get; set; }
        public bool conditioner { get; set; }
        public bool rear_view_camera { get; set; }
        public bool rain_sensor { get; set; }
        public bool seat_heating { get; set; }
        public bool side_curtains { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public DataTable Photos { get; set; }

        public InfoModel(int id, string brand, string model, string body_type, string walk, string color, string price, string currency, bool credit, bool barter, string additional_information, string fuel_type, string transmission, string gearbox, string graduation_year, string engine_capacity, int HP, bool alloy_wheels, bool central_closure, bool leather_salon, bool seat_ventilation, bool uSA, bool parking_radar, bool xenon, bool luke, bool conditioner, bool rear_view_camera, bool rain_sensor, bool seat_heating, bool side_curtains, string name, string city, string email, DataTable Photos)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.body_type = body_type;
            this.walk = walk;
            this.color = color;
            this.price = price;
            this.currency = currency;
            this.credit = credit;
            this.barter = barter;
            this.additional_information = additional_information;
            this.fuel_type = fuel_type;
            this.transmission = transmission;
            this.gearbox = gearbox;
            this.graduation_year = graduation_year;
            this.engine_capacity = engine_capacity;
            this.HP = HP;
            this.alloy_wheels = alloy_wheels;
            this.central_closure = central_closure;
            this.leather_salon = leather_salon;
            this.seat_ventilation = seat_ventilation;
            USA = uSA;
            this.parking_radar = parking_radar;
            this.xenon = xenon;
            this.luke = luke;
            this.conditioner = conditioner;
            this.rear_view_camera = rear_view_camera;
            this.rain_sensor = rain_sensor;
            this.seat_heating = seat_heating;
            this.side_curtains = side_curtains;
            this.name = name;
            this.city = city;
            this.email = email;
            this.Photos = Photos;
        }
    }
}
