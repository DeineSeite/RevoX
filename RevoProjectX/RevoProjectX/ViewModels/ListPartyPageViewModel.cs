using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RevoProjectX.Models;
using RevoProjectX.Pages;

namespace RevoProjectX.ViewModels
{
 public  class ListPartyPageViewModel: BaseViewModel
    {
        
        public  ObservableCollection<PartyModel> PartyCollection { get; set; }

     public ListPartyPageViewModel()
     {
            var assembly = typeof(ListPartyPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("RevoProjectX.PartyData.json");

          


            using (var reader = new System.IO.StreamReader(stream))
            {

                var json = reader.ReadToEnd();
                var rootobject = JsonConvert.DeserializeObject<ObservableCollection<PartyModel>>(json);

                PartyCollection = rootobject;
            }
        }
    }
}
