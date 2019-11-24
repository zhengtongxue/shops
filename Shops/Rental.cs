﻿namespace Ch01
{
    internal class Rental
    {
        public Rental(Movie movie, int dayRented)
        {
            Movie = movie;
            DayRented = dayRented;
        }

        public int DayRented { get; }

        public Movie Movie { get; }

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
            var dayRented = DayRented;

            return CountRenterPoints(dayRented);
        }

        private int CountRenterPoints(int dayRented)
        {
            int renterPoints = 0;
            renterPoints++;

            if (Movie.PriceCode == Movie.NewRelease && dayRented > 1)
            {
                renterPoints++;
            }

            return renterPoints;
        }
    }
}