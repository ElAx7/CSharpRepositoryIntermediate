namespace Section3.AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludedOrders: true);
            if (rating == 0)
                Console.WriteLine("Promote to level 1");
            else
                Console.WriteLine("Promote to level 2");

        }

        protected int CalculateRating(bool excludedOrders)
        {
            return 0;
        }
    }
}