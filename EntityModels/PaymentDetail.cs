namespace fans.EntityModels
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public string Limit { get; set; }
        public string Amount { get; set; }
        public string PaymentBank { get; set; }
        public string PaymentCustomer { get; set; }
        public string PaymentConfirm { get; set; }
        public bool Paid { get; set; }
        public virtual Member Member { get; set; }
    }
}