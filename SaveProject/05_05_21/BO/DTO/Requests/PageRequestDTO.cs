using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    public class PageRequest
    {
        public int? page {get; set; }
        public int? maxPerPage {get; set; }

        public PageRequest()
        {
        }
    }
}
