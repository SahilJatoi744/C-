//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nadroga_Arya_College.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mst_question
    {
        public int que_id { get; set; }
        public Nullable<int> test_id { get; set; }
        public string que_desc { get; set; }
        public string ans1 { get; set; }
        public string ans2 { get; set; }
        public string ans3 { get; set; }
        public string ans4 { get; set; }
        public Nullable<int> true_ans { get; set; }
    }
}
