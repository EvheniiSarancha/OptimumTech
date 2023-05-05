﻿using Optimum_Tech.Model.Interfaces;

namespace Optimum_Tech.Model.Products
{
    public abstract class Product : IProduct
    {
        private int rating;
        private int responses;
        private decimal price;
        private string name;
        private bool isAvailable;

        public Guid Id { get; set; }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException($"{nameof(Name)} can't be null or empty value!");
                if (value.Length > 45)
                    throw new ArgumentOutOfRangeException($"{nameof(Name)} can only be up to 45 characters in length!");
                name = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0 || value > 99999)
                    throw new ArgumentOutOfRangeException($"{nameof(Price)} can only be in range [0-99999]");
                price = value;
            }
        }
        public int Responses
        {
            get => responses;
            set
            {
                if (value < 0 || value > 999)
                    throw new ArgumentOutOfRangeException($"{nameof(Responses)} can only be in range [0-999]");
                responses = value;
            }
        }
        public int Rating
        {
            get => rating;
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentOutOfRangeException($"{nameof(Rating)} can only be in range [0-5]");
                rating = value;
            }
        }
        public bool IsAvailable
        {
            get => isAvailable;
            set => isAvailable = value;
        }
    }
}
