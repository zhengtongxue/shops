using System;
using Ch01;

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
            Movie movie_pdz = new Movie("攀登者", Movie.NewRelease);
            Movie movie_nz = new Movie("哪吒之魔童降世", Movie.Children);
            Movie movie_kczdy = new Movie("昆虫总动员", Movie.Children);
            Movie movie_zl = new Movie("战狼", Movie.Regular);
            Movie movie_rzdf = new Movie("让子弹飞", Movie.Regular);

            Customer customer = new Customer("张三");
            Rental rental_pdz = new Rental(movie_pdz, 2);
            customer.AddRental(rental_pdz);
            Rental rental_nz = new Rental(movie_nz, 2);
            customer.AddRental(rental_nz);
            Rental rental_kczdy = new Rental(movie_kczdy, 4);
            customer.AddRental(rental_kczdy);
            Rental rental_zl = new Rental(movie_zl, 2);
            customer.AddRental(rental_zl);
            Rental rental_rzdf = new Rental(movie_rzdf, 4);
            customer.AddRental(rental_rzdf);

            var statement = customer.Statement();
            return statement;
        }
    }
}