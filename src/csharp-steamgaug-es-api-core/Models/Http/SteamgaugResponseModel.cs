using System.Collections.Generic;
using Newtonsoft.Json;

namespace csharp_steamgaug_es_api_core.Models.Http
{
    public class SteamgaugResponseModel
    {
        [JsonProperty(PropertyName = "ISteamClient")]
        public SteamClient SteamClient { get; set; }
        [JsonProperty(PropertyName = "SteamCommunity")]
        public SteamCommunity SteamCommunity { get; set; }
        [JsonProperty(PropertyName = "SteamStore")]
        public SteamStore SteamStore { get; set; }
        [JsonProperty(PropertyName = "ISteamUser")]
        public SteamUser SteamUser { get; set; }
        [JsonProperty(PropertyName = "ISteamGameCoordinator")]
        public Dictionary<string, SteamGameData> SteamGameCoordinator { get; set; }
        [JsonProperty(PropertyName = "IEconItems")]
        public Dictionary<string, GameEconItems> EconItems { get; set; }
    }

    public class SteamClient
    {
        [JsonProperty(PropertyName = "online")]
        public int Online { get; set; }
    }

    public class SteamCommunity
    {
        [JsonProperty(PropertyName = "online")]
        public int Online { get; set; }
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }

    public class SteamStore
    {
        [JsonProperty(PropertyName = "online")]
        public int Online { get; set; }
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }

    public class SteamUser
    {
        [JsonProperty(PropertyName = "online")]
        public int Online { get; set; }
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }

    public class SteamGameData
    {
        [JsonProperty(PropertyName = "online")]
        public int Online { get; set; }
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        [JsonProperty(PropertyName = "stats")]
        public Stats Stats { get; set; }
    }

    public class Stats
    {
        [JsonProperty(PropertyName = "spyScore")]
        public string SpyScore { get; set; }
        [JsonProperty(PropertyName = "engiScore")]
        public string EngiScore { get; set; }
        [JsonProperty(PropertyName = "players_searching")]
        public int? PlayersSearching { get; set; }
        [JsonProperty(PropertyName = "players_online")]
        public int? PlayersOnline { get; set; }
    }

    public class GameEconItems
    {
        [JsonProperty(PropertyName = "online")]
        public int Online { get; set; }
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }
}