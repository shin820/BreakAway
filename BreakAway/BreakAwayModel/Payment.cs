//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BreakAwayModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public int ReservationID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Reservation Reservation { get; set; }
    }
}
