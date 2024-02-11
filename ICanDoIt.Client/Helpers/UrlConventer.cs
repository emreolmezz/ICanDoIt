using ICanDoIt.Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Helpers
{
    public class UrlConventer : IUrlConventer
    {
        private readonly IProductService _productService;
        public UrlConventer(IProductService productService)
        {
            _productService = productService;
        }
        public string GetProductUrlWithName(string name)
        {
            string phrase = string.Format("{0}", name);

            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 250 ? str.Length : 250).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens
            Random rnd = new Random();
            int number = rnd.Next(0, 101);
            if (_productService.GetProductWithUrl(str))
            {
                return str + number.ToString();
            }
            else
            {
                return str;
            }
        }
        public string GetCategoryUrlWithName(string name)
        {
            string phrase = string.Format("{0}", name);

            string str = RemoveAccent(phrase).ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 250 ? str.Length : 250).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens

            return str;
        }
        private string RemoveAccent(string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
    }
}
