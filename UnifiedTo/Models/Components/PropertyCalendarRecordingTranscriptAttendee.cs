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
    using UnifiedTo.Models.Components;
    using UnifiedTo.Utils;
    
    public class PropertyCalendarRecordingTranscriptAttendee
    {

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("status")]
        public PropertyCalendarRecordingTranscriptAttendeeStatus? Status { get; set; }

        [JsonProperty("user_id")]
        public string? UserId { get; set; }
    }
}