using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UTruckinServiceApp.Models
{
    public class VehicleResponse
    {
        public Result Result { get; set; }           
        public List<Content> Content { get; set; }   
        public Pageable Pageable { get; set; }
    }
}

