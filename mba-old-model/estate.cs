//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mba_old_model
{
    using System;
    using System.Collections.Generic;
    
    public partial class estate
    {
        public int estate_id { get; set; }
        public int case_id { get; set; }
        public Nullable<System.DateTime> estate_date { get; set; }
        public short estate_type { get; set; }
        public string estate_description { get; set; }
        public string estate_law_description { get; set; }
        public string estate_defect_description { get; set; }
        public Nullable<decimal> estate_price { get; set; }
        public Nullable<decimal> estate_law_price { get; set; }
        public Nullable<decimal> estate_defect_price { get; set; }
        public short estate_print { get; set; }
        public string Insert_user { get; set; }
        public System.DateTime Insert_date { get; set; }
        public string Update_user { get; set; }
        public Nullable<System.DateTime> Update_date { get; set; }
        public Nullable<System.DateTime> Update_date_dbo { get; set; }
        public string Delete_user { get; set; }
        public Nullable<System.DateTime> Delete_date { get; set; }
        public byte Delete_statute { get; set; }
    }
}