﻿namespace Restaurant
{
    public class Coffee : HotBeverage 
    {
        private const int DefaultMilliliters =50;
        private const decimal DefaultPrice = 3.5M;


        public Coffee(string name,double caffeine) 
            : base(name, DefaultPrice, DefaultMilliliters)
        {
            this.Caffeine = caffeine;
            
        }

        public double Caffeine { get; set; }
    }
}