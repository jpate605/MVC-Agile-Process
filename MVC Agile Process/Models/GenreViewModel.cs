using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Agile_Process.Models
{
    public class GenreViewModel
    {
        public List<Project>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
