using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped] // This will stop entity framework looking at this property
        [DisplayName("Customer Name")] // This will the caption the view uses
        public string CustomerFullName { get { return string.Format("{0} {1}", CustomerFirstName, CustomerSecondName); } }
    }
}