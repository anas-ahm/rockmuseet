using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rockmuseet_og_gasolin.Pages.bands;

public class GasolinModel : PageModel
{
    
    // We create a public list of Song objects that our page can play.
    public List<Song> Songs { get; set; } = new();
    public void OnGet()
    {
        
        Songs = new List<Song>
        {
            new Song { Title = "Det bedste til mig og mine venner", FilePath = "/music/det-bedste-til-mig-og-mine-venner.mp3" },
            new Song { Title = "Hvad gor vi nu lille du", FilePath = "/music/hvad-gor-vi-nu-lille-du.mp3" },
            new Song { Title = "Kvinde min", FilePath = "/music/kvinde-min.mp3" }
        };
    }
    
    // song class
    public class Song
    {
        public string Title { get; set; } = "";
        public string FilePath { get; set; } = "";
    }
}