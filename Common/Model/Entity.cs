using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    [Serializable]
    public class Entity
    {
        public string Id { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedBy { get; set; }

        public bool IsActive { get; set; } 

        public bool IsDeleted { get; set; } 

    }
}
