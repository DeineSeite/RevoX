using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace RevoProjectX.Models
{
    [JsonObject]
    public  class PartyModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Color { get; set; }
        public string Capacity { get; set; }
        public string Price { get; set; }
        public string Men { get; set; }
        public string Ladies { get; set; }
        public string Line { get; set; }
        public ImageSource Background { get; set; }
    }
}
