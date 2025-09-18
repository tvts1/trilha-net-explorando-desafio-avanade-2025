namespace Hotel.Models
{
    public class Reservation
    {

        public List<Customer> Guests { get; private set; }
        public Suite Suite { get; private set; }
        public int ReservationDays { get; private set; }

        public Reservation(List<Customer> guests, Suite suite, int reservationDays)
        {
            Suite = suite;
            ReservationDays = reservationDays;
            SetGuests(guests);
        }

        public void SetGuests(List<Customer> guests)
        {
            if (guests == null) ArgumentNullException.ThrowIfNull(guests);

            if (Suite.Capacity < guests.Count())
            {
                throw new ArgumentException("Number of guests exceeds suite capacity");
            }

            Guests = guests;
        }

        public void AddSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestsQuantity => Guests.Count();

        public decimal CalculateTotalPrice()
        {
            decimal total = ReservationDays * Suite.PricePerNight;

            if (ReservationDays > 10)
            {
                total *= 0.9m;
            }

            return total;
        }
    }
}