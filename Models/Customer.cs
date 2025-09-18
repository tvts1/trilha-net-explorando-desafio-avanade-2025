namespace Hotel.Models
{
    public class Customer
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Customer(string name, string lastName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name can't be null or empty.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name can't be null or empty.", nameof(lastName));
            }

            Name = name;
            LastName = lastName;
        }
    }
}