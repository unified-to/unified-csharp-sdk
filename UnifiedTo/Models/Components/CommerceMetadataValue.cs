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
    

    public class CommerceMetadataValueType
    {
        private CommerceMetadataValueType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CommerceMetadataValueType CommerceMetadataSchemas1 { get { return new CommerceMetadataValueType("CommerceMetadata_Schemas_1"); } }
        
        public static CommerceMetadataValueType CommerceMetadataSchemas2 { get { return new CommerceMetadataValueType("CommerceMetadata_Schemas_2"); } }
        
        public static CommerceMetadataValueType CommerceMetadataSchemas3 { get { return new CommerceMetadataValueType("CommerceMetadata_Schemas_3"); } }
        
        public static CommerceMetadataValueType CommerceMetadataSchemas4 { get { return new CommerceMetadataValueType("CommerceMetadata_Schemas_4"); } }
        
        public static CommerceMetadataValueType CommerceMetadataSchemas5 { get { return new CommerceMetadataValueType("CommerceMetadata_Schemas_5"); } }
        
        public static CommerceMetadataValueType Null { get { return new CommerceMetadataValueType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CommerceMetadataValueType v) { return v.Value; }
        public static CommerceMetadataValueType FromString(string v) {
            switch(v) {
                case "CommerceMetadata_Schemas_1": return CommerceMetadataSchemas1;
                case "CommerceMetadata_Schemas_2": return CommerceMetadataSchemas2;
                case "CommerceMetadata_Schemas_3": return CommerceMetadataSchemas3;
                case "CommerceMetadata_Schemas_4": return CommerceMetadataSchemas4;
                case "CommerceMetadata_Schemas_5": return CommerceMetadataSchemas5;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CommerceMetadataValueType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CommerceMetadataValueType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(CommerceMetadataValue.CommerceMetadataValueConverter))]
    public class CommerceMetadataValue {
        public CommerceMetadataValue(CommerceMetadataValueType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public CommerceMetadataSchemas1? CommerceMetadataSchemas1 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CommerceMetadataSchemas2? CommerceMetadataSchemas2 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CommerceMetadataSchemas3? CommerceMetadataSchemas3 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CommerceMetadataSchemas4? CommerceMetadataSchemas4 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public CommerceMetadataSchemas5? CommerceMetadataSchemas5 { get; set; }

        public CommerceMetadataValueType Type { get; set; }


        public static CommerceMetadataValue CreateCommerceMetadataSchemas1(CommerceMetadataSchemas1 commerceMetadataSchemas1) {
            CommerceMetadataValueType typ = CommerceMetadataValueType.CommerceMetadataSchemas1;

            CommerceMetadataValue res = new CommerceMetadataValue(typ);
            res.CommerceMetadataSchemas1 = commerceMetadataSchemas1;
            return res;
        }

        public static CommerceMetadataValue CreateCommerceMetadataSchemas2(CommerceMetadataSchemas2 commerceMetadataSchemas2) {
            CommerceMetadataValueType typ = CommerceMetadataValueType.CommerceMetadataSchemas2;

            CommerceMetadataValue res = new CommerceMetadataValue(typ);
            res.CommerceMetadataSchemas2 = commerceMetadataSchemas2;
            return res;
        }

        public static CommerceMetadataValue CreateCommerceMetadataSchemas3(CommerceMetadataSchemas3 commerceMetadataSchemas3) {
            CommerceMetadataValueType typ = CommerceMetadataValueType.CommerceMetadataSchemas3;

            CommerceMetadataValue res = new CommerceMetadataValue(typ);
            res.CommerceMetadataSchemas3 = commerceMetadataSchemas3;
            return res;
        }

        public static CommerceMetadataValue CreateCommerceMetadataSchemas4(CommerceMetadataSchemas4 commerceMetadataSchemas4) {
            CommerceMetadataValueType typ = CommerceMetadataValueType.CommerceMetadataSchemas4;

            CommerceMetadataValue res = new CommerceMetadataValue(typ);
            res.CommerceMetadataSchemas4 = commerceMetadataSchemas4;
            return res;
        }

        public static CommerceMetadataValue CreateCommerceMetadataSchemas5(CommerceMetadataSchemas5 commerceMetadataSchemas5) {
            CommerceMetadataValueType typ = CommerceMetadataValueType.CommerceMetadataSchemas5;

            CommerceMetadataValue res = new CommerceMetadataValue(typ);
            res.CommerceMetadataSchemas5 = commerceMetadataSchemas5;
            return res;
        }

        public static CommerceMetadataValue CreateNull() {
            CommerceMetadataValueType typ = CommerceMetadataValueType.Null;
            return new CommerceMetadataValue(typ);
        }

        public class CommerceMetadataValueConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CommerceMetadataValue);

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
                    return new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas1)
                    {
                        CommerceMetadataSchemas1 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CommerceMetadataSchemas1>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CommerceMetadataSchemas1), new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas1), "CommerceMetadataSchemas1"));
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
                    return new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas2)
                    {
                        CommerceMetadataSchemas2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CommerceMetadataSchemas2>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CommerceMetadataSchemas2), new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas2), "CommerceMetadataSchemas2"));
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
                    return new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas3)
                    {
                        CommerceMetadataSchemas3 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CommerceMetadataSchemas3>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CommerceMetadataSchemas3), new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas3), "CommerceMetadataSchemas3"));
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
                    return new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas4)
                    {
                        CommerceMetadataSchemas4 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CommerceMetadataSchemas4>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CommerceMetadataSchemas4), new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas4), "CommerceMetadataSchemas4"));
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
                    return new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas5)
                    {
                        CommerceMetadataSchemas5 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<CommerceMetadataSchemas5>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(CommerceMetadataSchemas5), new CommerceMetadataValue(CommerceMetadataValueType.CommerceMetadataSchemas5), "CommerceMetadataSchemas5"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
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
                CommerceMetadataValue res = (CommerceMetadataValue)value;
                if (CommerceMetadataValueType.FromString(res.Type).Equals(CommerceMetadataValueType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.CommerceMetadataSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CommerceMetadataSchemas1));
                    return;
                }
                if (res.CommerceMetadataSchemas2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CommerceMetadataSchemas2));
                    return;
                }
                if (res.CommerceMetadataSchemas3 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CommerceMetadataSchemas3));
                    return;
                }
                if (res.CommerceMetadataSchemas4 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CommerceMetadataSchemas4));
                    return;
                }
                if (res.CommerceMetadataSchemas5 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.CommerceMetadataSchemas5));
                    return;
                }

            }

        }

    }
}