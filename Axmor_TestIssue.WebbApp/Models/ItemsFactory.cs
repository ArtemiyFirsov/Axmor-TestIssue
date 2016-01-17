using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Axmor_TestIssue.Core.Interfaces;
using Axmor_TestIssue.Core.Models;

namespace Axmor_TestIssue.WebbApp.Models
{
    public class ItemsFactory
    {
        private IItemsService _service;

        public ItemsFactory()
        {
            _service = DependencyResolver.Current.GetService<IItemsService>();
        }

        public IEnumerable<Item> GetAllItems()
        {
            if (_service == null)
            {
                _service = DependencyResolver.Current.GetService<IItemsService>();
            }
            return _service.GetAllItems();
        }
    }
}