using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO.Responses
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageResponse<T>
    {
        /// <summary>
        /// Current Page
        /// </summary>
        public int Page
        {
            get; set;
        }

        /// <summary>
        /// Limit entities on one page
        /// </summary>
        public int PageSize
        {
            get; set;
        }

        /// <summary>
        /// Total count entities repository
        /// </summary>
        public int? TotalRecords
        {
            get; set;
        }

        /// <summary>
        /// TotalPages
        /// </summary>
        public int? TotalPages => TotalRecords.HasValue ? (int)Math.Ceiling(TotalRecords.Value / (double)PageSize) : (int?)null;

        /// <summary>
        /// List entities of the current page
        /// </summary>
        public List<T> Data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public PageResponse()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecords"></param>
        /// <param name="data"></param>
        public PageResponse(int page, int pageSize, int? totalRecords, List<T> data)
        {
            Page = page;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            Data = data;
        }

    }
}
