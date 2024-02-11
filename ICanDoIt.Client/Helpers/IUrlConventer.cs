using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICanDoIt.Client.Helpers
{
    public interface IUrlConventer
    {
        string GetProductUrlWithName(string name);
        string GetCategoryUrlWithName(string name);
    }
}
