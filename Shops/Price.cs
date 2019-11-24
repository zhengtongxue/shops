namespace Ch01
{
    internal abstract class Price
    {
        public int PriceCode { get; set; }

        public abstract double CountThisAmount(int dayRented);

        public virtual int CountRenterPoints(int dayRented)
        {
            int renterPoints = 0;
            renterPoints++;
            return renterPoints;
        }
    }
}