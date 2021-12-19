using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class SpaceStation
    {
        public abstract void FireLaser();
    }

    public class DeathStar : SpaceStation
    {
        public override void FireLaser() => Console.WriteLine("Pew pew");
    }

}  

