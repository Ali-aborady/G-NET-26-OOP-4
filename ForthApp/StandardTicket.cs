namespace ForthApp
{
    class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override void PrintTicket()
        {
            Console.WriteLine("[Standard Ticket]");
            base.PrintTicket();                         
            Console.WriteLine($"  Seat         : {SeatNumber}");
        }
    }
}
