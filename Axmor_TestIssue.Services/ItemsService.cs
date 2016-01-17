using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axmor_TestIssue.Core.Interfaces;
using Axmor_TestIssue.Core.Models;

namespace Axmor_TestIssue.Services
{
    public class ItemsService: CrudService<Item>, IItemsService
    {
        public ItemsService(IRepo<Item> repo) : base(repo)
        {
        }

        public IEnumerable<Item> GetAllItems()
        {
            return this.Repo.GetAll();
        }
    }
}
