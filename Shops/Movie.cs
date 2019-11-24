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
    }
}