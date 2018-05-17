using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Ingredient
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
