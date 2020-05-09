//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PatientTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientTable()
        {
            this.DoctorAppointTables = new HashSet<DoctorAppointTable>();
            this.LabAppointTables = new HashSet<LabAppointTable>();
        }
    
        public int PatientID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "* Required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* Required!")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorAppointTable> DoctorAppointTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabAppointTable> LabAppointTables { get; set; }
        public virtual UserTypeTable UserTypeTable { get; set; }
    }
}
