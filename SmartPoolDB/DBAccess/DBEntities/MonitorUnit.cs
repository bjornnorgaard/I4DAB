//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonitorUnit
    {
        public int Id { get; set; }
        public int PoolId { get; set; }
    
        public virtual Pool Pool { get; set; }
    }
}
