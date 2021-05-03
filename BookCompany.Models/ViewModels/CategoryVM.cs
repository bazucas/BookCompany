using System.Collections.Generic;

namespace BookCompany.Models.ViewModels
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
        //public PagingInfo PagingInfo { get; set; }
    }
}
