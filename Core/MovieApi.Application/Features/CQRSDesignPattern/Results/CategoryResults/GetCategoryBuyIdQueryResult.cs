using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryBuyIdQueryResult
    {
        public int CategoryId { get; set; }
        public string CtegoryName { get; set; }
    }
}
