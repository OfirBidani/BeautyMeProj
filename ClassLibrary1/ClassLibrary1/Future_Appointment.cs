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
    
    public partial class Future_Appointment
    {
        public string Future_appointment_number { get; set; }
        public string Address { get; set; }
        public string Client_ID_number { get; set; }
        public string Type_treatment_Number { get; set; }
        public string Number_appointment { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Client Client { get; set; }
        public virtual Client Client1 { get; set; }
        public virtual Type_Treatment Type_Treatment { get; set; }
    }
}
