namespace UTruckinServiceApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
        public string VehicleNumber { get; set; }
        public VehicleDriver VehicleDriver { get; set; }
    }
}
