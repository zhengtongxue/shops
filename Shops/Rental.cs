﻿ namespace Shops
{
    internal class Rental
    {
        public Rental(Movie movie, int dayRented)
        {
            Movie = movie;
            DayRented = dayRented;
        }

        private int DayRented { get; }

        private Movie Movie { get; }

        public double CountThisAmount()
        {
            return Movie.CountThisAmount(DayRented);
        }

        public string CountDetail()
        {
            return Movie.Title + ":" + CountThisAmount();
        }

        public int CountRenterPoints()
        {
            return Movie.CountRenterPoints(DayRented);
        }
    }
}