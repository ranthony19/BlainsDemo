{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bananasTotalCost = CalculateTotalCost(5.0);
            Console.WriteLine(bananasTotalCost);

            ProcessData(new List<int> () {2, 20, 30, 42, 50 });

            var person = new Person()
            {
                FirstName = "Cool",
                LastName = "Guy"
            };

            Console.WriteLine(person.GetFullName());
        }

        public static double CalculateTotalCost(double quantity)
        {
            double unitPrice = 10.0;
            double taxRate = 0.08;
            double totalCost = quantity * unitPrice * (1 + taxRate);
            return totalCost;
        }

        public static void ProcessData(List<int> data)
        {
            // Validation
            if (data != null && data.Count > 0)
            {
                // Perform some operations
                for (int i = 0; i < data.Count; i++)
                {
                    // More complex operations
                    int result = data[i] * 2;
                    Console.WriteLine(result);
                }

                // Handle edge cases
                if (data.Contains(42))
                {
                    Console.WriteLine("Found 42!");
                }
            }
            else
            {
                Console.WriteLine("Invalid data!");
            }
        }
    }

    // This is a class that represents a Person
    public class Person
    {
        // This is a property for the person's first name
        public string FirstName { get; set; }

        // This is a property for the person's last name
        public string LastName { get; set; }

        // This is a method to get the full name of the person
        public string GetFullName()
        {
            // Combine the first name and last name
            return $"{FirstName} {LastName}";
        }
    }
}
