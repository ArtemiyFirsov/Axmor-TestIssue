using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Axmor_TestIssue.Core.Models
{
    public class Item:BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
