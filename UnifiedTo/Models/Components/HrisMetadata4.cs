//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace UnifiedTo.Models.Components
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    

    public class HrisMetadata4Type
    {
        private HrisMetadata4Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static HrisMetadata4Type Boolean { get { return new HrisMetadata4Type("boolean"); } }
        
        public static HrisMetadata4Type HrisMetadataSchemasExtraData2 { get { return new HrisMetadata4Type("HrisMetadata_Schemas_extra_data_2"); } }
        
        public static HrisMetadata4Type Null { get { return new HrisMetadata4Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(HrisMetadata4Type v) { return v.Value; }
        public static HrisMetadata4Type FromString(string v) {
            switch(v) {
                case "boolean": return Boolean;
                case "HrisMetadata_Schemas_extra_data_2": return HrisMetadataSchemasExtraData2;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for HrisMetadata4Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((HrisMetadata4Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(HrisMetadata4.HrisMetadata4Converter))]
    public class HrisMetadata4 {
        public HrisMetadata4(HrisMetadata4Type type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public HrisMetadataSchemasExtraData2? HrisMetadataSchemasExtraData2 { get; set; }

        public HrisMetadata4Type Type { get; set; }


        public static HrisMetadata4 CreateBoolean(bool boolean) {
            HrisMetadata4Type typ = HrisMetadata4Type.Boolean;

            HrisMetadata4 res = new HrisMetadata4(typ);
            res.Boolean = boolean;
            return res;
        }

        public static HrisMetadata4 CreateHrisMetadataSchemasExtraData2(HrisMetadataSchemasExtraData2 hrisMetadataSchemasExtraData2) {
            HrisMetadata4Type typ = HrisMetadata4Type.HrisMetadataSchemasExtraData2;

            HrisMetadata4 res = new HrisMetadata4(typ);
            res.HrisMetadataSchemasExtraData2 = hrisMetadataSchemasExtraData2;
            return res;
        }

        public static HrisMetadata4 CreateNull() {
            HrisMetadata4Type typ = HrisMetadata4Type.Null;
            return new HrisMetadata4(typ);
        }

        public class HrisMetadata4Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(HrisMetadata4);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new HrisMetadata4(HrisMetadata4Type.HrisMetadataSchemasExtraData2)
                    {
                        HrisMetadataSchemasExtraData2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<HrisMetadataSchemasExtraData2>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(HrisMetadataSchemasExtraData2), new HrisMetadata4(HrisMetadata4Type.HrisMetadataSchemasExtraData2), "HrisMetadataSchemasExtraData2"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    var converted = Convert.ToBoolean(json);
                    return new HrisMetadata4(HrisMetadata4Type.Boolean)
                    {
                        Boolean = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                HrisMetadata4 res = (HrisMetadata4)value;
                if (HrisMetadata4Type.FromString(res.Type).Equals(HrisMetadata4Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }
                if (res.HrisMetadataSchemasExtraData2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.HrisMetadataSchemasExtraData2));
                    return;
                }

            }

        }

    }
}