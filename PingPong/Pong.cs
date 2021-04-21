using System;

namespace PingPong
{
    public class Pong
    {
        public delegate void PlayHandler();
        public event PlayHandler OnGetPing;

        public void Play()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 2)
            {
                Console.WriteLine("Pong got Ping");
                OnGetPing?.Invoke();
            }
            else
            {
                Console.WriteLine("Ping missed, wins Pong");
            }
        }
    }
}
