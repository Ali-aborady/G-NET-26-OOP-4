namespace ForthApp
{
    class Projector
    {
        public bool IsRunning { get; private set; } = false;

        public void Start()
        {
            IsRunning = true;
            Console.WriteLine("Projector started");
        }

        public void Stop()
        {
            IsRunning = false;
            Console.WriteLine("Projector stopped");
        }
    }
}
