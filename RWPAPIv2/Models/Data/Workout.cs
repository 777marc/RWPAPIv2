//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RWPAPIv2.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Workout
    {
        public int iPKID { get; set; }
        public Nullable<System.DateTime> ItemDate { get; set; }
        public Nullable<double> Distance { get; set; }
        public Nullable<int> Time { get; set; }
        public string RunType { get; set; }
        public Nullable<double> Temp { get; set; }
        public string Note { get; set; }
        public string Title { get; set; }
        public string Felt { get; set; }
        public string UserName { get; set; }
    }
}
