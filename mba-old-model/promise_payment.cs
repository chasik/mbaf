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
    
    public partial class promise_payment
    {
        public int promise_payment_id { get; set; }
        public int case_id { get; set; }
        public int contact_id { get; set; }
        public decimal promise_amount { get; set; }
        public System.DateTime promise_date { get; set; }
        public short promise_type_activity { get; set; }
        public Nullable<bool> new_promise_obtained { get; set; }
        public Nullable<int> parent_promise_payment_id { get; set; }
        public string Insert_user { get; set; }
        public System.DateTime Insert_date { get; set; }
        public string Update_user { get; set; }
        public Nullable<System.DateTime> Update_date { get; set; }
        public string Delete_user { get; set; }
        public Nullable<System.DateTime> Delete_date { get; set; }
        public int Delete_statute { get; set; }
        public Nullable<System.DateTime> Update_date_dbo { get; set; }
    
        public virtual @case @case { get; set; }
        public virtual contact contact { get; set; }
    }
}