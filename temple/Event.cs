//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace temple
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public Nullable<double> EventExpence { get; set; }
        public Nullable<int> PriestID { get; set; }
    
        public virtual Priest Priest { get; set; }
    }
}
