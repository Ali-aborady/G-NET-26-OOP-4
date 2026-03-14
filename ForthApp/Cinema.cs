namespace ForthApp
{
    class Cinema
    {
        public string CinemaName { get; private set; }
        private Projector _projector = new Projector();   // Composition
        private Ticket[] _tickets = new Ticket[20];       // polymorphic array

        public Cinema(string name) { CinemaName = name; }

        public void OpenCinema()
        {
            Console.WriteLine($"\n=== {CinemaName} is OPEN ===");
            _projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine($"\n=== {CinemaName} is CLOSING ===");
            _projector.Stop();
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        // PrintAllTickets — uses DYNAMIC BINDING
        // Calls PrintTicket() on each ticket.
        // CLR decides at runtime which version (Standard/VIP/IMAX)
        public void PrintAllTickets()
        {
            Console.WriteLine($"\n=== All Tickets in {CinemaName} ===\n");
            bool any = false;
            foreach (Ticket t in _tickets)
            {
                if (t != null)
                {
                    t.PrintTicket();   // dynamic binding → correct child version
                    Console.WriteLine(new string('-', 38));
                    any = true;
                }
            }
            if (!any) Console.WriteLine("  No tickets yet.");
        }
    }
}
