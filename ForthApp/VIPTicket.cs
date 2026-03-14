namespace ForthApp
{
    class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; private set; } = 50m;

        public decimal TotalWithFee => (Price + ServiceFee) * 1.14m;

        public VIPTicket(string movieName, decimal price, bool loungeAccess)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override void PrintTicket()
        {
            Console.WriteLine("[VIP Ticket]");
            base.PrintTicket();
            Console.WriteLine($"  Lounge       : {(LoungeAccess ? "Yes" : "No")}");
            Console.WriteLine($"  Service Fee  : {ServiceFee:F2} EGP");
            Console.WriteLine($"  Total + Fee  : {TotalWithFee:F2} EGP");
        }
    }
}
