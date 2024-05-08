using System;

namespace ClassLibrary
{
    public class clsPayments
    {
        //hi
        public bool PaymentsStatus { get; set; }
        public DateTime PaymentsDate { get; set; }
        public int PaymentsId { get; set; }
        public int OrderId { get; set; }
        public string BillingAddress { get; set; }
        public string PaymentMethod { get; set; }
        public double Amount { get; set; }
    }
}