namespace Hotel.Models
{
    public class Suite
    {
        public string SuiteType { get; private set; }
        public int Capacity { get; private set; }
        public decimal PricePerNight { get; private set; }

        public Suite(string suiteType, int capacity, decimal pricePerNight)
        {
            if (string.IsNullOrWhiteSpace(suiteType))
            {
                throw new ArgumentException("Suite type can't be null or empty.", nameof(suiteType));
            }

            if (capacity < 0)
            {
                throw new ArgumentException("Capacity can't be negative.", nameof(capacity));
            }

            if (pricePerNight < 0)
            {
                throw new ArgumentException("Price can't be negative.", nameof(pricePerNight));
            }
            
            SuiteType = suiteType;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }
    }
}