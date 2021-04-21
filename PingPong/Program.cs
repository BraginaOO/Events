using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping gamer1 = new Ping();
            Pong gamer2 = new Pong();

            gamer1.OnGetPong += gamer2.Play;
            gamer2.OnGetPing += gamer1.Play;

            gamer1.Play();
        }
    }
}
