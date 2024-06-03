﻿using System.Text.Json.Serialization;

namespace MASTMAN.Data
{
    public class TagData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        [JsonPropertyName("filter_ignore")]
        public bool? FilterIgnore { get; set; }
    }
}
