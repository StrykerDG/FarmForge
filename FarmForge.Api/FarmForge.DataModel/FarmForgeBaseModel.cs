using System;

namespace FarmForge.DataModel
{
    public class FarmForgeBaseModel
    {
        public DateTime Created { get; set; }
        public DateTime Modifed { get; set; }
        public bool IsDeleted { get; set; }
    }
}
