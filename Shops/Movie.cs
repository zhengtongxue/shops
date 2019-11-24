﻿namespace Ch01
{
    internal class Movie
    {
        public const int Children = 2; //儿童片
        public const int Regular = 0;//普通片
        public const int NewRelease = 1;//新片

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public string Title { get; }

        public int PriceCode { get; set; }

        public double CountThisAmount(int dayRented)
        {
            double thisAmount = 0;

            switch (PriceCode)
            {
                case Regular:
                {
                    thisAmount += 2;
                    if (dayRented > 2)
                    {
                        thisAmount += (dayRented - 2) * 1.5;
                    }
                }
                    break;
                case NewRelease:
                {
                    thisAmount += dayRented * 3;
                }
                    break;
                case Children:
                {
                    thisAmount += 1.5;
                    if (dayRented > 3)
                    {
                        thisAmount += (dayRented - 3) * 1.5;
                    }
                }
                    break;
            }

            return thisAmount;
        }

        public int CountRenterPoints(int dayRented)
        {
            int renterPoints = 0;
            renterPoints++;

            if (PriceCode == NewRelease && dayRented > 1)
            {
                renterPoints++;
            }

            return renterPoints;
        }
    }
}