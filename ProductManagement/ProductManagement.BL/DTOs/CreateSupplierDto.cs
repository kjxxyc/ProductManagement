using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.DTOs
{
    public class CreateSupplierDto
    {
        public string SupplierName { get; set; }

        public string Status { get; set; }

        public System.DateTime CreatedDate { get; set; }

        public int CreatedUserId { get; set; }
    }
}
