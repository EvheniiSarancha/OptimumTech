﻿namespace Optimum_Tech.Model.Products
{
    public class Processor : Product
    {
        private string manufacturer;
        private string socket;
        private int cores;
        private int threads;
        private double clockSpeedDefault;
        private double clockSpeedBoost;

        public string Manufacturer
        {
            get => manufacturer;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Manufacturer can't be null or empty value!");

                manufacturer = value;
            }
        }
        public string Socket
        {
            get => socket;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Socket can't be null or empty value!");

                socket = value;
            }
        }
        public int Cores
        {
            get => cores;
            set
            {
                if (value >= 1 && value <= 64)
                    cores = value;
                else
                    throw new Exception("Cores can only be in range [1-64]");
            }
        }
        public int Threads
        {
            get => threads;
            set
            {
                if (value >= 1 && value <= 128)
                    threads = value;
                else
                    throw new Exception("Threads can only be in range [1-128]");
            }
        }
        public double ClockSpeedDefault
        {
            get => clockSpeedDefault;
            set
            {
                if (value >= 0.1 && value <= 6)
                    clockSpeedDefault = value;
                else
                    throw new Exception("ClockSpeedDefault can only be in range [0.1-6]");
            }
        }
        public double ClockSpeedBoost
        {
            get => clockSpeedBoost;
            set
            {
                if (value >= 0.1 && value <= 6)
                    clockSpeedBoost = value;
                else
                    throw new Exception("ClockSpeedBoost can only be in range [0.1-6]");
            }
        }
    }
}
