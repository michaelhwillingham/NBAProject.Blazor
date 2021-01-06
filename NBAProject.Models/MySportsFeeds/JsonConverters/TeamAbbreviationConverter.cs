using System;
using NBAProject.Models.MySportsFeeds.Enums;
using Newtonsoft.Json;

namespace NBAProject.Models.MySportsFeeds.JsonConverters
{
    internal class TeamAbbreviationConverter : JsonConverter
    {
        public static readonly TeamAbbreviationConverter Singleton = new();

        public override bool CanConvert(Type t)
        {
            return t == typeof(TeamAbbreviation) || t == typeof(TeamAbbreviation?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ATL":
                    return TeamAbbreviation.Atl;
                case "BOS":
                    return TeamAbbreviation.Bos;
                case "BRO":
                    return TeamAbbreviation.Bro;
                case "CHA":
                    return TeamAbbreviation.Cha;
                case "CHI":
                    return TeamAbbreviation.Chi;
                case "CLE":
                    return TeamAbbreviation.Cle;
                case "DAL":
                    return TeamAbbreviation.Dal;
                case "DEN":
                    return TeamAbbreviation.Den;
                case "DET":
                    return TeamAbbreviation.Det;
                case "GSW":
                    return TeamAbbreviation.Gsw;
                case "HOU":
                    return TeamAbbreviation.Hou;
                case "IND":
                    return TeamAbbreviation.Ind;
                case "LAC":
                    return TeamAbbreviation.Lac;
                case "LAL":
                    return TeamAbbreviation.Lal;
                case "MEM":
                    return TeamAbbreviation.Mem;
                case "MIA":
                    return TeamAbbreviation.Mia;
                case "MIL":
                    return TeamAbbreviation.Mil;
                case "MIN":
                    return TeamAbbreviation.Min;
                case "NOP":
                    return TeamAbbreviation.Nop;
                case "NYK":
                    return TeamAbbreviation.Nyk;
                case "OKL":
                    return TeamAbbreviation.Okl;
                case "ORL":
                    return TeamAbbreviation.Orl;
                case "PHI":
                    return TeamAbbreviation.Phi;
                case "PHX":
                    return TeamAbbreviation.Phx;
                case "POR":
                    return TeamAbbreviation.Por;
                case "SAC":
                    return TeamAbbreviation.Sac;
                case "SAS":
                    return TeamAbbreviation.Sas;
                case "TOR":
                    return TeamAbbreviation.Tor;
                case "UTA":
                    return TeamAbbreviation.Uta;
                case "WAS":
                    return TeamAbbreviation.Was;
            }

            throw new Exception("Cannot unmarshal type TeamAbbreviation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TeamAbbreviation) untypedValue;
            switch (value)
            {
                case TeamAbbreviation.Atl:
                    serializer.Serialize(writer, "ATL");
                    return;
                case TeamAbbreviation.Bos:
                    serializer.Serialize(writer, "BOS");
                    return;
                case TeamAbbreviation.Bro:
                    serializer.Serialize(writer, "BRO");
                    return;
                case TeamAbbreviation.Cha:
                    serializer.Serialize(writer, "CHA");
                    return;
                case TeamAbbreviation.Chi:
                    serializer.Serialize(writer, "CHI");
                    return;
                case TeamAbbreviation.Cle:
                    serializer.Serialize(writer, "CLE");
                    return;
                case TeamAbbreviation.Dal:
                    serializer.Serialize(writer, "DAL");
                    return;
                case TeamAbbreviation.Den:
                    serializer.Serialize(writer, "DEN");
                    return;
                case TeamAbbreviation.Det:
                    serializer.Serialize(writer, "DET");
                    return;
                case TeamAbbreviation.Gsw:
                    serializer.Serialize(writer, "GSW");
                    return;
                case TeamAbbreviation.Hou:
                    serializer.Serialize(writer, "HOU");
                    return;
                case TeamAbbreviation.Ind:
                    serializer.Serialize(writer, "IND");
                    return;
                case TeamAbbreviation.Lac:
                    serializer.Serialize(writer, "LAC");
                    return;
                case TeamAbbreviation.Lal:
                    serializer.Serialize(writer, "LAL");
                    return;
                case TeamAbbreviation.Mem:
                    serializer.Serialize(writer, "MEM");
                    return;
                case TeamAbbreviation.Mia:
                    serializer.Serialize(writer, "MIA");
                    return;
                case TeamAbbreviation.Mil:
                    serializer.Serialize(writer, "MIL");
                    return;
                case TeamAbbreviation.Min:
                    serializer.Serialize(writer, "MIN");
                    return;
                case TeamAbbreviation.Nop:
                    serializer.Serialize(writer, "NOP");
                    return;
                case TeamAbbreviation.Nyk:
                    serializer.Serialize(writer, "NYK");
                    return;
                case TeamAbbreviation.Okl:
                    serializer.Serialize(writer, "OKL");
                    return;
                case TeamAbbreviation.Orl:
                    serializer.Serialize(writer, "ORL");
                    return;
                case TeamAbbreviation.Phi:
                    serializer.Serialize(writer, "PHI");
                    return;
                case TeamAbbreviation.Phx:
                    serializer.Serialize(writer, "PHX");
                    return;
                case TeamAbbreviation.Por:
                    serializer.Serialize(writer, "POR");
                    return;
                case TeamAbbreviation.Sac:
                    serializer.Serialize(writer, "SAC");
                    return;
                case TeamAbbreviation.Sas:
                    serializer.Serialize(writer, "SAS");
                    return;
                case TeamAbbreviation.Tor:
                    serializer.Serialize(writer, "TOR");
                    return;
                case TeamAbbreviation.Uta:
                    serializer.Serialize(writer, "UTA");
                    return;
                case TeamAbbreviation.Was:
                    serializer.Serialize(writer, "WAS");
                    return;
            }

            throw new Exception("Cannot marshal type TeamAbbreviation");
        }
    }
}