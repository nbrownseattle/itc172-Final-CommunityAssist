//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    
    public partial class fx_EmployeeGrants_Result
    {
        public int GrantRequestKey { get; set; }
        public Nullable<int> PersonKey { get; set; }
        public System.DateTime GrantRequestDate { get; set; }
        public System.DateTime GrantReviewDate { get; set; }
        public string GrantRequestExplanation { get; set; }
        public Nullable<decimal> GrantRequestAmount { get; set; }
        public Nullable<decimal> GrantAllocationAmount { get; set; }
    }
}
