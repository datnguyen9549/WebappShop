using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeopageTitle { get; set; }
        string SeoAlias { get; set; }
        string SeoKeywords { get; set; }
        string SeoDescription { get; set; }
    }
}
