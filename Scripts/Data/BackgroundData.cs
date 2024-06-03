﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class BackgroundData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("skills")]
        public List<string> Skills { get; set; }

    }
}