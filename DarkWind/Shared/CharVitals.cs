﻿using System.Text.Json.Serialization;

namespace DarkWind.Shared;

public class CharVitals {
    [JsonPropertyName("hp")]
    public int Health { get; set; }
    [JsonPropertyName("maxhp")]
    public int MaxHealth { get; set; }
}
