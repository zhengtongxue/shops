namespace Ch01
{
    internal class RegularPrice : Price
    {
        public override double CountThisAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += 2;
            if (dayRented > 2)
            {
                thisAmount += (dayRented - 2) * 1.5;
            }
            return thisAmount;
        }
    }
}