//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchentsIT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class UserRegister
    {
      
        public System.Guid EmpID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Designation { get; set; }
       
        public string Password { get; set; }
       
        public string ResetpasswordCode { get; set; }
        [Required]
        public string Phone_Number { get; set; }
        public Nullable<int> Firstregister { get; set; }
        public Nullable<int> registercount { get; set; }
    }
}