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
                textWriter.WriteLine(rental.CountDetail());
            }
            
            textWriter.WriteLine("本次费用合计： " + CountTotalAmount());
            textWriter.WriteLine("累计获得" + CountFrequentRenterPoints() + " 积分。");
            return textWriter.ToString();
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
                totalAmount += rental.CountThisAmount();
            }

            return totalAmount;
        }
    }
}