using System;
using System.Collections.Generic;
using ICanDoIt.Entity.Entities;

namespace ICanDoIt.Client.Models
{
    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public string UserId { get; set; }
    }

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling(((decimal)TotalItems / ItemsPerPage));
        }
    }
}