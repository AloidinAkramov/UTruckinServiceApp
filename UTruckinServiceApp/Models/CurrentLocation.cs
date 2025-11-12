namespace UTruckinServiceApp.Models
{
    public class CurrentLocation
    {
        public CurrentCoordinates CurrentCoordinates { get; set; }
        public NearCoordinates NearCoordinates { get; set; }
        public double Distance { get; set; }
        public string StateName { get; set; }
        public string LocationName { get; set; }
        public DateTime DateTime { get; set; }
        public string Direction { get; set; }
    }
}
