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
    

    public class IntegrationSchemasSandbox3Type
    {
        private IntegrationSchemasSandbox3Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static IntegrationSchemasSandbox3Type Number { get { return new IntegrationSchemasSandbox3Type("number"); } }
        
        public static IntegrationSchemasSandbox3Type IntegrationSchemasSandbox32 { get { return new IntegrationSchemasSandbox3Type("Integration_Schemas_sandbox_3_2"); } }
        
        public static IntegrationSchemasSandbox3Type Null { get { return new IntegrationSchemasSandbox3Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(IntegrationSchemasSandbox3Type v) { return v.Value; }
        public static IntegrationSchemasSandbox3Type FromString(string v) {
            switch(v) {
                case "number": return Number;
                case "Integration_Schemas_sandbox_3_2": return IntegrationSchemasSandbox32;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for IntegrationSchemasSandbox3Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((IntegrationSchemasSandbox3Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(IntegrationSchemasSandbox3.IntegrationSchemasSandbox3Converter))]
    public class IntegrationSchemasSandbox3 {
        public IntegrationSchemasSandbox3(IntegrationSchemasSandbox3Type type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public IntegrationSchemasSandbox32? IntegrationSchemasSandbox32 { get; set; }

        public IntegrationSchemasSandbox3Type Type { get; set; }


        public static IntegrationSchemasSandbox3 CreateNumber(double number) {
            IntegrationSchemasSandbox3Type typ = IntegrationSchemasSandbox3Type.Number;

            IntegrationSchemasSandbox3 res = new IntegrationSchemasSandbox3(typ);
            res.Number = number;
            return res;
        }

        public static IntegrationSchemasSandbox3 CreateIntegrationSchemasSandbox32(IntegrationSchemasSandbox32 integrationSchemasSandbox32) {
            IntegrationSchemasSandbox3Type typ = IntegrationSchemasSandbox3Type.IntegrationSchemasSandbox32;

            IntegrationSchemasSandbox3 res = new IntegrationSchemasSandbox3(typ);
            res.IntegrationSchemasSandbox32 = integrationSchemasSandbox32;
            return res;
        }

        public static IntegrationSchemasSandbox3 CreateNull() {
            IntegrationSchemasSandbox3Type typ = IntegrationSchemasSandbox3Type.Null;
            return new IntegrationSchemasSandbox3(typ);
        }

        public class IntegrationSchemasSandbox3Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(IntegrationSchemasSandbox3);

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
                    return new IntegrationSchemasSandbox3(IntegrationSchemasSandbox3Type.IntegrationSchemasSandbox32)
                    {
                        IntegrationSchemasSandbox32 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<IntegrationSchemasSandbox32>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(IntegrationSchemasSandbox32), new IntegrationSchemasSandbox3(IntegrationSchemasSandbox3Type.IntegrationSchemasSandbox32), "IntegrationSchemasSandbox32"));
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
                    var converted = Convert.ToDouble(json);
                    return new IntegrationSchemasSandbox3(IntegrationSchemasSandbox3Type.Number)
                    {
                        Number = converted
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
                IntegrationSchemasSandbox3 res = (IntegrationSchemasSandbox3)value;
                if (IntegrationSchemasSandbox3Type.FromString(res.Type).Equals(IntegrationSchemasSandbox3Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }
                if (res.IntegrationSchemasSandbox32 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.IntegrationSchemasSandbox32));
                    return;
                }

            }

        }

    }
}