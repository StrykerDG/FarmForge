using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmForge.DataModel
{
    [Table("Telemetry")]
    public class Telemetry : FarmForgeBaseModel
    {
        [Key]
        public int TelemetryId { get; set; }
        public int InterfaceId { get; set; }
        // [ForeignKey("InterfaceId")]
        // public Interface Interface { get; set; }
        public DateTime TimeStamp { get; set; }
        public double? Value { get; set; }
        public string StringValue { get; set; }
        public bool? BoolValue { get; set; }
    }
}
