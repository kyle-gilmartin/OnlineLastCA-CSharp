//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineLastCA_CSharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatsTBL
    {
        public int StatsID { get; set; }
        public int TeamID { get; set; }
        public string Manager { get; set; }
        public string TopForward { get; set; }
        public string TopMid { get; set; }
        public string TopDefender { get; set; }
        public string TopGk { get; set; }
    
        public virtual TeamTBL TeamTBL { get; set; }
    }
}
