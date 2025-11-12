namespace UTruckinServiceApp.Models
{
    public class Pageable
    {
        public int Total { get; set; }
        public int? Prev { get; set; }
        public int? Next { get; set; }
        public int Current { get; set; }
    }
}
