using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Requests
{
    /// <summary>
    /// Coucou II
    /// </summary>
    public class PageRequest
    {
        /// <summary>
        /// Fuck
        /// </summary>
        /// 
        public int? page {get; set; }
        /// <summary>
        /// Fuck Too
        /// </summary>
        public int? maxPerPage {get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? pageSize { get; set; }
        
        /// <summary>
        /// Coucou
        /// </summary>
        /// 
        public PageRequest()
        {
            page = 1;
            pageSize = 10;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a_page"></param>
        /// <param name="a_pageSize"></param>
        public PageRequest(int a_page, int a_pageSize)
        {
            page = a_page;
            pageSize = a_pageSize;
        }
    }
}
