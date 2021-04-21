using System;

namespace PingPong
{
    public class Ping
    {
        public delegate void PlayHandler();
        public event PlayHandler OnGetPong;

        public void Play()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 2)
            {
                Console.WriteLine("Ping got Pong");
                OnGetPong?.Invoke();
            }
            else
            {
                Console.WriteLine("Pong missed, wins Ping");
            }
        }
    }
}
