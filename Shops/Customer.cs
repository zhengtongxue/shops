﻿using System.Collections.Generic;
using System.IO;

namespace Ch01
{
    internal class Customer
    {
        private List<Rental> _rentals = new List<Rental>();
        
        public string Name { get; }
        
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
                textWriter.WriteLine(CountDetail(rental));
            }
            
            textWriter.WriteLine("本次费用合计： " + CountTotalAmount());
            textWriter.WriteLine("累计获得" + CountFrequentRenterPoints() + " 积分。");
            return textWriter.ToString();
        }

        private static string CountDetail(Rental rental)
        {
            return rental.Movie.Title + ":" + CountThisAmount(rental);
        }

        private int CountFrequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach (var rental in _rentals)
            {
                //add frequentRenterPoints
                frequentRenterPoints++;
                if (rental.Movie.PriceCode == Movie.NewRelease && rental.DayRented > 1)
                {
                    frequentRenterPoints++;
                }
            }

            return frequentRenterPoints;
        }

        private double CountTotalAmount()
        {
            double totalAmount = 0;
            foreach (var rental in _rentals)
            {
                totalAmount += CountThisAmount(rental);
            }

            return totalAmount;
        }

        private static double CountThisAmount(Rental rental)
        {
            double thisAmount = 0;

            switch (rental.Movie.PriceCode)
            {
                case Movie.Regular:
                {
                    thisAmount += 2;
                    if (rental.DayRented > 2)
                    {
                        thisAmount += (rental.DayRented - 2) * 1.5;
                    }
                }
                    break;
                case Movie.NewRelease:
                {
                    thisAmount += rental.DayRented * 3;
                }
                    break;
                case Movie.Children:
                {
                    thisAmount += 1.5;
                    if (rental.DayRented > 3)
                    {
                        thisAmount += (rental.DayRented - 3) * 1.5;
                    }
                }
                    break;
            }

            return thisAmount;
        }
    }
}