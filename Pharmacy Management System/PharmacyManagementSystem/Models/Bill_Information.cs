//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmacyManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Bill_Information
    {
        public Bill_Information()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public string Invoice_No { get; set; }
        public double Total_Amount { get; set; }
        public string Discount { get; set; }
        public double Discount_Amount { get; set; }
        public double Total_Payable { get; set; }
        public double Paid { get; set; }
        public double Returned { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime Date { get; set; }
    
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
