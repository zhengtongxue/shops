using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Shops
{
    internal class Customer
    {
        private List<Rental> _rentals = new List<Rental>();

        private string Name { get; }
        
        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        public string Statement()
        {
            TextWriter textWriter = new StringWriter();
            textWriter.WriteLine("租借人：" + Name);
            foreach (var rental in _rentals)
            {
                //show figures for this rental
                textWriter.WriteLine(rental.CountDetail());
            }
            
            textWriter.WriteLine("本次费用合计： " + CountTotalAmount());
            textWriter.WriteLine("累计获得" + CountFrequentRenterPoints() + " 积分。");
            return textWriter.ToString();
        }

        private int CountFrequentRenterPoints()
        {
            return _rentals.Sum(rental => rental.CountRenterPoints());
        }

        private double CountTotalAmount()
        {
            return _rentals.Sum(rental => rental.CountThisAmount());
        }
    }
}