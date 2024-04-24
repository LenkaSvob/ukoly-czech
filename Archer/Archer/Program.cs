namespace Archer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrowsToShoot = 10;

            Archer archer = new Archer(arrowsToShoot);

            for (int i = 0; i < arrowsToShoot; i++)
            {
                archer.Shoot();
            }
            archer.Shoot(); // now no arrows left

            Console.ReadLine();
        }
    }
    class Archer
    {
        public int NumOfArrows { get; set; }

        public Archer(int totalArrow)
        {
            this.NumOfArrows = totalArrow;
        }
        public void Shoot()
        {
            if (NumOfArrows > 0)
            {
                Console.WriteLine("I always hit right in the middle!");
                NumOfArrows--;
            }
            else if (NumOfArrows == 0)
            {
                Console.WriteLine("No arrows left");
            }
        }
    }
}

