﻿using System;

 namespace Ch01
{
    internal class Movie
    {
        private Price _price;
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
                    throw new Exception("error pricode input");
            }
            
            PriceCode = priceCode;
        }

        public string Title { get; }

        public int PriceCode
        {
            get { return _price.PriceCode; }
            set { _price.PriceCode = value; }
        }

        public double CountThisAmount(int dayRented)
        {
            var price = _price;
            return price.CountThisAmount(dayRented);
        }

        public int CountRenterPoints(int dayRented)
        {
            var price = _price;

            return price.CountRenterPoints(dayRented);
        }
    }

    internal class NewReleasePrice : Price
    {
        public override double CountThisAmount(int dayRented)
        {
            double thisAmount = 0;
            thisAmount += dayRented * 3;
            return thisAmount;
        }

        public override int CountRenterPoints(int dayRented)
        {
            int renterPoints = 0;
            renterPoints++;

            if (dayRented > 1)
            {
                renterPoints++;
            }

            return renterPoints;
        }
    }

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

    internal abstract class Price
    {
        public int PriceCode { get; set; }

        public abstract double CountThisAmount(int dayRented);

        public virtual int CountRenterPoints(int dayRented)
        {
            int renterPoints = 0;
            renterPoints++;
            return renterPoints;
        }
    }
}