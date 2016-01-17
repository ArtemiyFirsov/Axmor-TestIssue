using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axmor_TestIssue.Core.Models;

namespace Axmor_TestIssue.Core.Interfaces
{
    public interface IItemsService
    {
        IEnumerable<Item> GetAllItems();
    }
}
