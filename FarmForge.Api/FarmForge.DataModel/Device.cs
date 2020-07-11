using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmForge.DataModel
{
    [Table("Device")]
    public class Device : FarmForgeBaseModel
    {
        [Key]
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public string SerialNumber { get; set; }
        public ICollection<Interface> Interfaces { get; set; }
    }
}
