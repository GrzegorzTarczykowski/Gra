using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gra.Model;

namespace Gra.ViewModel.PlaygroundHandler
{
    class MapHandler
    {
        public ObservableCollection<LocationOnMap> listLocationOfMap { get; set; } 
        public MapHandler()
        {
            listLocationOfMap = new ObservableCollection<LocationOnMap> { new LocationOnMap() { PathToImage = "/Gra;component/Images/kostka.png" } };
            listLocationOfMap.Add(new LocationOnMap() { PathToImage = "/Gra;component/Images/grass.png" });
            listLocationOfMap.Add(new LocationOnMap() { PathToImage = "/Gra;component/Images/grayTown.png" });
        }
    }
}
