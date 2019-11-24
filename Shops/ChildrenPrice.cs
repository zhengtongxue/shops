namespace Shops
{
    internal class ChildrenPrice : Price
    {
        public override double CountThisAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += 1.5;
            if (dayRented > 3)
            {
                thisAmount += (dayRented - 3) * 1.5;
            }
            return thisAmount;
        }
    }
}