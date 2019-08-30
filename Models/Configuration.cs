using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Models
{
    public class Configuration
    {
        public int Id { get; set; }
        public string HeadTitleFontSize { get; set; }
        public string HeadTitleFontColor { get; set; }
        public string SubHeadTitleFontSize { get; set; }
        public string SubHeadTitleFontColor { get; set; }
        public string ContentFontSize { get; set; }
        public string ContentFontColor { get; set; }
        public string ProjectLinkButtonClass { get; set; }
        public string BadgeColor { get; set; }
        public string ButtonClass { get; set; }
        public string FooterCopyrightFontSize { get; set; }
        public string FooterCopyrightFontColor { get; set; }
        public object Navbar { get; set; }
    }
}
