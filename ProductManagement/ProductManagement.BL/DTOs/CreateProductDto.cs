using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.DTOs
{
    public class CreateProductDto
    {
        public string CodeProduct { get; set; }

        public string ProductName { get; set; }

        public decimal QuantityStock { get; set; }

        public byte[] ImageProduct { get; set; }

        public string Status { get; set; }

        public System.DateTime CreatedDate { get; set; }

        public int CreatedUserId { get; set; }

        public int SupplierId { get; set; }

    }
}
