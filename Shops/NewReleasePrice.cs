namespace Shops
{
    internal class NewReleasePrice : Price
    {
        public override double CountThisAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += dayRented * 3;
            return thisAmount;
        }

        public override int CountRenterPoints(int dayRented)
        {
            int renterPoints = 0;
            renterPoints++;

            if (dayRented > 1)
            {
                renterPoints++;
            }

            return renterPoints;
        }
    }
}