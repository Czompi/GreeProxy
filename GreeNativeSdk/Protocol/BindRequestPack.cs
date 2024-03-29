﻿namespace GreeNativeSdk.Protocol
{
    using System.Text.Json.Serialization;

    public class BindRequestPack
    {
        [JsonPropertyName("t")]
        public string Type { get => "bind"; private set { } }

        [JsonPropertyName("uid")]
        public int UID { get => 0; private set { } }

        [JsonPropertyName("mac")]
        public string MAC { get; set; }
    }
}
