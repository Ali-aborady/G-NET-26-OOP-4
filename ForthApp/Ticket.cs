namespace ForthApp
{
    abstract class Ticket
    {
        private static int _counter = 0;
        public static int GetTotalTickets() => _counter;

        private int _ticketId;
        private string _movieName = default!;
        private decimal _price;

        public int TicketId => _ticketId;

        public string MovieName
        {
            get => _movieName;
            protected set { if (!string.IsNullOrEmpty(value)) _movieName = value; }
        }

        public decimal Price
        {
            get => _price;
            protected set { if (value > 0) _price = value; }
        }

        public decimal PriceAfterTax => _price * 1.14m;

        protected Ticket(string movieName, decimal price)
        {
            _counter++;
            _ticketId = _counter;
            MovieName = movieName;
            Price = price;
        }
        // SetPrice — METHOD OVERLOADING (static binding)
        // Two versions: one param vs two params

        // Version 1: set price directly
        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"  Price set directly to {Price:F2} EGP");
        }

        // Version 2: set price = basePrice × multiplier
        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"  Price set to {basePrice} × {multiplier} = {Price:F2} EGP");
        }

        // PrintTicket — VIRTUAL (dynamic binding)
        // Children override this to add their own extra info
        public virtual void PrintTicket()
        {
            Console.WriteLine($"  ID           : {TicketId}");
            Console.WriteLine($"  Movie        : {MovieName}");
            Console.WriteLine($"  Price        : {Price:F2} EGP");
            Console.WriteLine($"  Price + Tax  : {PriceAfterTax:F2} EGP");
        }
    }
}
