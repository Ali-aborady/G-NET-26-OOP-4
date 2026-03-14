namespace ForthApp
{
    class TicketProcessor
    {
        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n=== Processing Ticket ===");
            t.PrintTicket();   // dynamic binding works here too
        }
    }
}
