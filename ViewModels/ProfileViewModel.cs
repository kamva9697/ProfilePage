using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ProfilePage.Models;

namespace ProfilePage.ViewModels
{
    public class ProfileViewModel
    {
        public ObservableCollection<Profile> Profiles { get; set; }

        public ProfileViewModel()
        {
            Profiles = new ObservableCollection<Profile>
            {
                new Profile(Description: "Music", BgColor: Color.FromArgb("#ffeefa")),
                new Profile(Description :"Photo", BgColor : Color.FromArgb("#eaefff")),
                new Profile(Description : "Art History", BgColor : Color.FromArgb("#fef1e8")),
                new Profile(Description : "Design", BgColor : Color.FromArgb("#eaefff")),
                new Profile(Description : "Art Filma", BgColor : Color.FromArgb("#fef1e8")),
                new Profile(Description : "Dancing", BgColor : Color.FromArgb("#ffeefa")),

        };
        }
    }
}
