using Godot;
using MASTMAN.Util;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class BackgroundData : Resource
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("skills")]
        public List<string> Skills { get; set; }

        public override string ToString()
        {
            string output = "{\n";
            output += $"\t{Id}\n";
            output += $"\t{Name}\n";
            output += $"\t{Description}\n";
            output += $"\t{LogHelper.ToStringList(Skills)}\n";
            output += "}";
            return output;
        }


    }


}
