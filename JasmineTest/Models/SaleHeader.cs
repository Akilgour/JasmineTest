using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JasmineTest.Models
{
    public class SaleHeader
    {
        public int SaleHeaderId { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerSecondName { get; set; }

        public string Address { get; set; }

        public virtual List<SaleItem> SaleIem { get; set; }
    }
}