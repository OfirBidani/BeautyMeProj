//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.Appointment_can_give_treatment = new HashSet<Appointment_can_give_treatment>();
            this.Appointment_can_give_treatment1 = new HashSet<Appointment_can_give_treatment>();
            this.Future_Appointment = new HashSet<Future_Appointment>();
            this.Treatment_for_appointment = new HashSet<Treatment_for_appointment>();
            this.Treatment_for_appointment1 = new HashSet<Treatment_for_appointment>();
        }
    
        public string Number_appointment { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Start_time { get; set; }
        public System.TimeSpan End_time { get; set; }
        public string Is_client_house { get; set; }
    
        public virtual Business Business { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment_can_give_treatment> Appointment_can_give_treatment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment_can_give_treatment> Appointment_can_give_treatment1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Future_Appointment> Future_Appointment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment_for_appointment> Treatment_for_appointment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Treatment_for_appointment> Treatment_for_appointment1 { get; set; }
    }
}
