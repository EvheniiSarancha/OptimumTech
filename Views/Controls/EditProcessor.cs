﻿using Optimum_Tech.Model.Products;

namespace Optimum_Tech.Controls
{
    public partial class EditProcessor : UserControl
    {
        Processor cpu;
        public EditProcessor(Processor cpu)
        {
            InitializeComponent();

            this.cpu = cpu;

            this.textBoxId.Text = $"{cpu.Id}";
            this.textBoxName.Text = $"{cpu.Name}";
            this.textBoxPrice.Text = $"{cpu.Price}";
            this.textBoxResponses.Text = $"{cpu.Responses}";
            this.textBoxRating.Text = $"{cpu.Rating}";
            this.textBoxAvailable.Text = $"{cpu.IsAvailable}";

            this.textBoxManufacturer.Text = $"{cpu.Manufacturer}";
            this.textBoxSocket.Text = $"{cpu.Socket}";
            this.textBoxCores.Text = $"{cpu.Cores}";
            this.textBoxThreads.Text = $"{cpu.Threads}";
            this.textBoxClockSpeedDefault.Text = $"{cpu.ClockSpeedDefault}";
            this.textBoxClockSpeedBoost.Text = $"{cpu.ClockSpeedBoost}";
        }
    }
}
