namespace ForthApp
{
    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D)
            : base(movieName, is3D ? price + 30m : price)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            Console.WriteLine("[IMAX Ticket]");
            base.PrintTicket();
            Console.WriteLine($"  3D           : {(Is3D ? "Yes (+30 EGP)" : "No")}");
        }
    }
}
