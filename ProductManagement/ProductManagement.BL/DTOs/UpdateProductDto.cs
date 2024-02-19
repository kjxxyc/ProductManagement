using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.DTOs
{
    public class UpdateProductDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        
        public decimal QuantityStock { get; set; }
        
        public byte[] ImageProduct { get; set; }

        public List<CreateOrUpdateOptionDto> Options { get; set; }
    }
}
