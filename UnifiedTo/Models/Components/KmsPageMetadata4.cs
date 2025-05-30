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
    

    public class KmsPageMetadata4Type
    {
        private KmsPageMetadata4Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static KmsPageMetadata4Type Boolean { get { return new KmsPageMetadata4Type("boolean"); } }
        
        public static KmsPageMetadata4Type KmsPageMetadataSchemasExtraData2 { get { return new KmsPageMetadata4Type("KmsPageMetadata_Schemas_extra_data_2"); } }
        
        public static KmsPageMetadata4Type Null { get { return new KmsPageMetadata4Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(KmsPageMetadata4Type v) { return v.Value; }
        public static KmsPageMetadata4Type FromString(string v) {
            switch(v) {
                case "boolean": return Boolean;
                case "KmsPageMetadata_Schemas_extra_data_2": return KmsPageMetadataSchemasExtraData2;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for KmsPageMetadata4Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((KmsPageMetadata4Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(KmsPageMetadata4.KmsPageMetadata4Converter))]
    public class KmsPageMetadata4 {
        public KmsPageMetadata4(KmsPageMetadata4Type type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public bool? Boolean { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public KmsPageMetadataSchemasExtraData2? KmsPageMetadataSchemasExtraData2 { get; set; }

        public KmsPageMetadata4Type Type { get; set; }


        public static KmsPageMetadata4 CreateBoolean(bool boolean) {
            KmsPageMetadata4Type typ = KmsPageMetadata4Type.Boolean;

            KmsPageMetadata4 res = new KmsPageMetadata4(typ);
            res.Boolean = boolean;
            return res;
        }

        public static KmsPageMetadata4 CreateKmsPageMetadataSchemasExtraData2(KmsPageMetadataSchemasExtraData2 kmsPageMetadataSchemasExtraData2) {
            KmsPageMetadata4Type typ = KmsPageMetadata4Type.KmsPageMetadataSchemasExtraData2;

            KmsPageMetadata4 res = new KmsPageMetadata4(typ);
            res.KmsPageMetadataSchemasExtraData2 = kmsPageMetadataSchemasExtraData2;
            return res;
        }

        public static KmsPageMetadata4 CreateNull() {
            KmsPageMetadata4Type typ = KmsPageMetadata4Type.Null;
            return new KmsPageMetadata4(typ);
        }

        public class KmsPageMetadata4Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(KmsPageMetadata4);

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
                    return new KmsPageMetadata4(KmsPageMetadata4Type.KmsPageMetadataSchemasExtraData2)
                    {
                        KmsPageMetadataSchemasExtraData2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<KmsPageMetadataSchemasExtraData2>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(KmsPageMetadataSchemasExtraData2), new KmsPageMetadata4(KmsPageMetadata4Type.KmsPageMetadataSchemasExtraData2), "KmsPageMetadataSchemasExtraData2"));
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
                    return new KmsPageMetadata4(KmsPageMetadata4Type.Boolean)
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
                KmsPageMetadata4 res = (KmsPageMetadata4)value;
                if (KmsPageMetadata4Type.FromString(res.Type).Equals(KmsPageMetadata4Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
                    return;
                }
                if (res.KmsPageMetadataSchemasExtraData2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.KmsPageMetadataSchemasExtraData2));
                    return;
                }

            }

        }

    }
}