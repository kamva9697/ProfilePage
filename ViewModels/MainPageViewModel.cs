using System.Collections.ObjectModel;
using ProfilePage.Models;

namespace ProfilePage.ViewModels
{
    public class MainPageViewModel
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public string JobTitle { get; set; }
        public ObservableCollection<Interest> Interests { get; set; }


        public MainPageViewModel()
        {
            // Mocks Data Source that would be 
            // ideally retrieved through an Back-end Service/Repo.
            Name = "John Williams";
            JobTitle = "Tech Lead";
            Biography =
                "My name is John and I enjoy meet new people and finding ways to help them have an uplifting experience ...";
            Interests = new ObservableCollection<Interest>
            {
                new Interest(Description :"Music", BgColor : "#ffeefa"),
                new Interest(Description :  "Photo", BgColor : "#eaefff"),
                new Interest(Description :  "Art History", BgColor : "#fef1e8"),
                new Interest(Description :  "Design", BgColor : "#eaefff"),
                new Interest(Description :  "Art Filma", BgColor : "#fef1e8"),
                new Interest(Description :  "Dancing", BgColor : "#ffeefa"),
            };
        }
    }
}
