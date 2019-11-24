﻿using System;

 namespace Ch01
{
    internal class Movie
    {
        private readonly Price _price;
        public const int Children = 2; //儿童片
        public const int Regular = 0;//普通片
        public const int NewRelease = 1;//新片

        public Movie(string title, int priceCode)
        {
            Title = title;

            switch (priceCode)
            {
                case Children:
                    _price = new ChildrenPrice();
                    break;
                case Regular:
                    _price = new RegularPrice();
                    break;
                case NewRelease:
                    _price = new NewReleasePrice();
                    break;
                default:
                    throw new Exception("error price code input");
            }
        }

        public string Title { get; }

        public double CountThisAmount(int dayRented)
        {
            return _price.CountThisAmount(dayRented);
        }

        public int CountRenterPoints(int dayRented)
        {
            return _price.CountRenterPoints(dayRented);
        }
    }
}