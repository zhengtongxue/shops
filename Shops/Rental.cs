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
            double thisAmount = 0;

            switch (Movie.PriceCode)
            {
                case Movie.Regular:
                {
                    thisAmount += 2;
                    if (DayRented > 2)
                    {
                        thisAmount += (DayRented - 2) * 1.5;
                    }
                }
                    break;
                case Movie.NewRelease:
                {
                    thisAmount += DayRented * 3;
                }
                    break;
                case Movie.Children:
                {
                    thisAmount += 1.5;
                    if (DayRented > 3)
                    {
                        thisAmount += (DayRented - 3) * 1.5;
                    }
                }
                    break;
            }

            return thisAmount;
        }

        public string CountDetail()
        {
            return Movie.Title + ":" + CountThisAmount();
        }

        public int CountRenterPoints()
        {
            int renterPoints = 0;
            renterPoints++;
            if (Movie.PriceCode == Movie.NewRelease && DayRented > 1)
            {
                renterPoints++;
            }

            return renterPoints;
        }
    }
}