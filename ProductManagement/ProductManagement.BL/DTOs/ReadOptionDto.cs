using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.DTOs
{
    public class ReadOptionDto
    {
        public int Id { get; set; }

        public string OptionName { get; set; }

        public string Status { get; set; }

        public string CreatedDate { get; set; }

        public int CreatedUserId { get; set; }

        public string CreatedUserName { get; set; }  

        public int ProductId { get; set; }

        public string ProductName { get; set; }
    }
}
