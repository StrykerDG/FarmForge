using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmForge.DataModel
{
    [Table("InterfaceType")]
    public class InterfaceType : FarmForgeBaseModel
    {
        [Key]
        public int InterfaceTypeId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string ModelNumber { get; set; }
        public int ParentInterfaceTypeId { get; set; }
    }
}
