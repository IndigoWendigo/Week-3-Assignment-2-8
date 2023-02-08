namespace Week3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Speed Limit: ");

            int speedLm = Convert.ToInt32(Console.ReadLine());

            int dPoints;

            Car c = new Car();

            c.getMake();
            c.getModel();
            c.getSpeed();

            if(c.speed > speedLm)
            {
                dPoints = (c.speed - speedLm) / 5;
            }
            else
            {
                dPoints = 0;
            }

            string licenseStatus;


            if(dPoints >= 10)
            {
                licenseStatus = "LICENSE SUSPENDED";
            }
            else
            {
                licenseStatus = "OK";
            }

            Console.WriteLine("Speed Limit: " + speedLm);
            Console.WriteLine("");
            Console.WriteLine(c.model + " " + c.make + " " + c.speed + "mph: ");
            Console.WriteLine(dPoints + " DEMERITS, " + licenseStatus);

        }

        public class Car
        {

            public string make = "";
            public string model = "";
            public int speed;

            public void getMake()
            {
                Console.WriteLine("Enter The Car's Make: ");
                make = Console.ReadLine();
            }

            public void getModel()
            {
                Console.WriteLine("Enter The Car's Model: ");
                model = Console.ReadLine();
            }

            public void getSpeed()
            {
                Console.WriteLine("Enter The Car's Speed: ");
                speed = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}