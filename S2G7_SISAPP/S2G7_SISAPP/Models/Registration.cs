//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S2G7_SISAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int Registration_ID { get; set; }
        public int Student_ID { get; set; }
        public int Course_ID { get; set; }
        public int Term_ID { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
        public virtual StudyTerm StudyTerm { get; set; }
    }
}
