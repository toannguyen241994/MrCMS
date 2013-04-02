﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MrCMS.Entities.Documents.Web;
using MrCMS.Web.Apps.Core.Pages;

namespace MrCMS.Web.Apps.Articles.Pages
{
    public class ArticleList : TextPage
    {
        [DisplayName("Page Size")]
        public virtual int PageSize { get; set; }
        [DisplayName("Allow Paging")]
        public virtual bool AllowPaging { get; set; }
    }
}