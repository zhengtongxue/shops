using System;

namespace Shops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var statement = GetStatement();
            Console.Write(statement);
        }

        public static string GetStatement()
        {
            var moviePdz = new Movie("攀登者", Movie.NewRelease);
            var movieNz = new Movie("哪吒之魔童降世", Movie.Children);
            var movieKczdy = new Movie("昆虫总动员", Movie.Children);
            var movieZl = new Movie("战狼", Movie.Regular);
            var movieRzdf = new Movie("让子弹飞", Movie.Regular);

            var customer = new Customer("张三");
            var rentalPdz = new Rental(moviePdz, 2);
            customer.AddRental(rentalPdz);
            var rentalNz = new Rental(movieNz, 2);
            customer.AddRental(rentalNz);
            var rentalKczdy = new Rental(movieKczdy, 4);
            customer.AddRental(rentalKczdy);
            var rentalZl = new Rental(movieZl, 2);
            customer.AddRental(rentalZl);
            var rentalRzdf = new Rental(movieRzdf, 4);
            customer.AddRental(rentalRzdf);

            var statement = customer.Statement();
            return statement;
        }
    }
}