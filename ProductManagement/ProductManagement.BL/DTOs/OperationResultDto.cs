using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.DTOs
{
    public class OperationResultDto
    {
        public object Result { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; } = true;
    }
}
