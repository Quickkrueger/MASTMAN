using Godot;
using MASTMAN.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace MASTMAN.Scripts.Data.Models
{
    public partial class BackgroundData : Resource
    {
        [Export]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [Export]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [Export]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Export]
        [JsonPropertyName("skills")]
        public string[] Skills { get; set; }

        public override string ToString()
        {
            string output = "{\n";
            output += $"\t{Id}\n";
            output += $"\t{Name}\n";
            output += $"\t{Description}\n";
            output += $"\t{LogHelper.ToStringList(Skills.ToList())}\n";
            output += "}";
            return output;
        }


    }


}
