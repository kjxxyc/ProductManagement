using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.DTOs
{
    public class ReadUserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string Status { get; set; }

        public System.DateTime CreatedDate { get; set; }
    }
}
