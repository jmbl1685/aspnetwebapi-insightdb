using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Lunch
    {
        [JsonProperty("_id")]
        public Guid LunchID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ingredient")]
        public string Ingredients { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        private Guid lunchID
        {
            get => LunchID;
            set => LunchID = Guid.NewGuid();
        } 

    }
}
