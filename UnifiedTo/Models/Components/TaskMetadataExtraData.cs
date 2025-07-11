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
    

    public class TaskMetadataExtraDataType
    {
        private TaskMetadataExtraDataType(string value) { Value = value; }

        public string Value { get; private set; }
        public static TaskMetadataExtraDataType TaskMetadata1 { get { return new TaskMetadataExtraDataType("TaskMetadata_1"); } }
        
        public static TaskMetadataExtraDataType TaskMetadata2 { get { return new TaskMetadataExtraDataType("TaskMetadata_2"); } }
        
        public static TaskMetadataExtraDataType TaskMetadata3 { get { return new TaskMetadataExtraDataType("TaskMetadata_3"); } }
        
        public static TaskMetadataExtraDataType TaskMetadata4 { get { return new TaskMetadataExtraDataType("TaskMetadata_4"); } }
        
        public static TaskMetadataExtraDataType TaskMetadata5 { get { return new TaskMetadataExtraDataType("TaskMetadata_5"); } }
        
        public static TaskMetadataExtraDataType Null { get { return new TaskMetadataExtraDataType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(TaskMetadataExtraDataType v) { return v.Value; }
        public static TaskMetadataExtraDataType FromString(string v) {
            switch(v) {
                case "TaskMetadata_1": return TaskMetadata1;
                case "TaskMetadata_2": return TaskMetadata2;
                case "TaskMetadata_3": return TaskMetadata3;
                case "TaskMetadata_4": return TaskMetadata4;
                case "TaskMetadata_5": return TaskMetadata5;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for TaskMetadataExtraDataType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((TaskMetadataExtraDataType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(TaskMetadataExtraData.TaskMetadataExtraDataConverter))]
    public class TaskMetadataExtraData {
        public TaskMetadataExtraData(TaskMetadataExtraDataType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMetadata1? TaskMetadata1 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMetadata2? TaskMetadata2 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMetadata3? TaskMetadata3 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMetadata4? TaskMetadata4 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public TaskMetadata5? TaskMetadata5 { get; set; }

        public TaskMetadataExtraDataType Type { get; set; }


        public static TaskMetadataExtraData CreateTaskMetadata1(TaskMetadata1 taskMetadata1) {
            TaskMetadataExtraDataType typ = TaskMetadataExtraDataType.TaskMetadata1;

            TaskMetadataExtraData res = new TaskMetadataExtraData(typ);
            res.TaskMetadata1 = taskMetadata1;
            return res;
        }

        public static TaskMetadataExtraData CreateTaskMetadata2(TaskMetadata2 taskMetadata2) {
            TaskMetadataExtraDataType typ = TaskMetadataExtraDataType.TaskMetadata2;

            TaskMetadataExtraData res = new TaskMetadataExtraData(typ);
            res.TaskMetadata2 = taskMetadata2;
            return res;
        }

        public static TaskMetadataExtraData CreateTaskMetadata3(TaskMetadata3 taskMetadata3) {
            TaskMetadataExtraDataType typ = TaskMetadataExtraDataType.TaskMetadata3;

            TaskMetadataExtraData res = new TaskMetadataExtraData(typ);
            res.TaskMetadata3 = taskMetadata3;
            return res;
        }

        public static TaskMetadataExtraData CreateTaskMetadata4(TaskMetadata4 taskMetadata4) {
            TaskMetadataExtraDataType typ = TaskMetadataExtraDataType.TaskMetadata4;

            TaskMetadataExtraData res = new TaskMetadataExtraData(typ);
            res.TaskMetadata4 = taskMetadata4;
            return res;
        }

        public static TaskMetadataExtraData CreateTaskMetadata5(TaskMetadata5 taskMetadata5) {
            TaskMetadataExtraDataType typ = TaskMetadataExtraDataType.TaskMetadata5;

            TaskMetadataExtraData res = new TaskMetadataExtraData(typ);
            res.TaskMetadata5 = taskMetadata5;
            return res;
        }

        public static TaskMetadataExtraData CreateNull() {
            TaskMetadataExtraDataType typ = TaskMetadataExtraDataType.Null;
            return new TaskMetadataExtraData(typ);
        }

        public class TaskMetadataExtraDataConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(TaskMetadataExtraData);

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
                    return new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata1)
                    {
                        TaskMetadata1 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMetadata1>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMetadata1), new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata1), "TaskMetadata1"));
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
                    return new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata2)
                    {
                        TaskMetadata2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMetadata2>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMetadata2), new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata2), "TaskMetadata2"));
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
                    return new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata3)
                    {
                        TaskMetadata3 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMetadata3>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMetadata3), new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata3), "TaskMetadata3"));
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
                    return new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata4)
                    {
                        TaskMetadata4 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMetadata4>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMetadata4), new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata4), "TaskMetadata4"));
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
                    return new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata5)
                    {
                        TaskMetadata5 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<TaskMetadata5>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(TaskMetadata5), new TaskMetadataExtraData(TaskMetadataExtraDataType.TaskMetadata5), "TaskMetadata5"));
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
                TaskMetadataExtraData res = (TaskMetadataExtraData)value;
                if (TaskMetadataExtraDataType.FromString(res.Type).Equals(TaskMetadataExtraDataType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.TaskMetadata1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMetadata1));
                    return;
                }
                if (res.TaskMetadata2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMetadata2));
                    return;
                }
                if (res.TaskMetadata3 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMetadata3));
                    return;
                }
                if (res.TaskMetadata4 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMetadata4));
                    return;
                }
                if (res.TaskMetadata5 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.TaskMetadata5));
                    return;
                }

            }

        }

    }
}