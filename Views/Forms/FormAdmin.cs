﻿using Newtonsoft.Json;
using Optimum_Tech.Controls;
using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Forms;
using Optimum_Tech.Model;
using Optimum_Tech.Model.Products;
using Timer = System.Windows.Forms.Timer;

namespace Optimum_Tech.View.Forms
{
    public partial class FormAdmin : Form
    {
        private readonly FormMain formMain;
        private Control currentControl;

        public FormAdmin(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;

            listBoxProducts.Items.AddRange(ProductManager.processors.Select(p => p.Name).OrderBy(n => n).ToArray());
            listBoxProducts.Items.AddRange(ProductManager.graphicsCards.Select(p => p.Name).OrderBy(n => n).ToArray());
            listBoxProducts.Sorted = true;
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentControl != null)
            {
                panelProduct.Controls.Remove(currentControl);
            }

            string selectedProduct = listBoxProducts.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedProduct))
            {
                Product product = ProductManager.products.FirstOrDefault(p => p.Name == selectedProduct);

                if (product is GraphicsCard graphicsCard)
                {
                    currentControl = new EditGraphicsCard(graphicsCard);
                }
                else if (product is Processor processor)
                {
                    currentControl = new EditProcessor(processor);
                }

                if (currentControl != null)
                {
                    panelProduct.Controls.Add(currentControl);
                    currentControl.Dock = DockStyle.Left;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string productName = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(productName))
            {
                string selectedProduct = listBoxProducts.Items.Cast<string>().FirstOrDefault(name => name.StartsWith(productName, StringComparison.OrdinalIgnoreCase));

                if (selectedProduct != null)
                {
                    listBoxProducts.SelectedItem = selectedProduct;
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (currentControl != null)
            {
                if (currentControl is EditProcessor editProcessor)
                {
                    foreach (Processor product in ProductManager.processors)
                    {
                        try
                        {
                            if (product.Id == Guid.Parse(editProcessor.textBoxId.Text))
                            {
                                product.Name = editProcessor.textBoxName.Text;
                                product.Price = decimal.Parse(editProcessor.textBoxPrice.Text);
                                product.Responses = int.Parse(editProcessor.textBoxResponses.Text);
                                product.Rating = int.Parse(editProcessor.textBoxRating.Text);
                                product.IsAvailable = bool.Parse(editProcessor.textBoxAvailable.Text);

                                product.Manufacturer = editProcessor.textBoxManufacturer.Text;
                                product.Socket = editProcessor.textBoxSocket.Text;
                                product.Cores = int.Parse(editProcessor.textBoxCores.Text);
                                product.Threads = int.Parse(editProcessor.textBoxThreads.Text);
                                product.ClockSpeedDefault = double.Parse(editProcessor.textBoxClockSpeedDefault.Text);
                                product.ClockSpeedBoost = double.Parse(editProcessor.textBoxClockSpeedBoost.Text);

                                ProductManager.SaveChanges();
                            }
                        }
                        catch (ArgumentOutOfRangeException e1)
                        {
                            MessageBox.Show(e1.Message);
                            break;
                        }
                        catch (ArgumentNullException e2)
                        {
                            MessageBox.Show(e2.Message);
                            break;
                        }
                        catch (FormatException e3)
                        {
                            MessageBox.Show(e3.Message);
                            break;
                        }
                    }

                    string processorsJson = JsonConvert.SerializeObject(ProductManager.processors);
                    File.WriteAllText("processors.json", processorsJson);
                }
                else if (currentControl is EditGraphicsCard editGraphicsCard)
                {
                    foreach (GraphicsCard product in ProductManager.graphicsCards)
                    {
                        try
                        {
                            if (product.Id == Guid.Parse(editGraphicsCard.textBoxId.Text))
                            {
                                product.Name = editGraphicsCard.textBoxName.Text;
                                product.Price = decimal.Parse(editGraphicsCard.textBoxPrice.Text);
                                product.Responses = int.Parse(editGraphicsCard.textBoxResponses.Text);
                                product.Rating = int.Parse(editGraphicsCard.textBoxRating.Text);
                                product.IsAvailable = bool.Parse(editGraphicsCard.textBoxAvailable.Text);

                                product.Manufacturer = editGraphicsCard.textBoxManufacturer.Text;
                                product.VRAM = int.Parse(editGraphicsCard.textBoxVRAM.Text);
                                product.MemoryInterface = int.Parse(editGraphicsCard.textBoxMemoryInterface.Text);
                                product.MemoryType = editGraphicsCard.textBoxMemoryType.Text;
                                product.ClockSpeed = double.Parse(editGraphicsCard.textBoxClockSpeedDefault.Text);
                                product.MinimumWattage = int.Parse(editGraphicsCard.textBoxMinimumWattage.Text);

                                ProductManager.SaveChanges();
                            }
                        }
                        catch (ArgumentOutOfRangeException e1)
                        {
                            MessageBox.Show(e1.Message);
                            break;
                        }
                        catch (ArgumentNullException e2)
                        {
                            MessageBox.Show(e2.Message);
                            break;
                        }
                        catch (FormatException e3)
                        {
                            MessageBox.Show(e3.Message);
                            break;
                        }
                    }

                    string graphicsCardsJson = JsonConvert.SerializeObject(ProductManager.graphicsCards);
                    File.WriteAllText("graphicsCards.json", graphicsCardsJson);
                }
            }
        }

        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxSearchUserText.Text.Trim();

            if (!string.IsNullOrEmpty(userLogin))
            {
                List<User> users = UserManager.LoadUsers();
                bool userExists = users.Any(user => user.Login == userLogin);

                if (userExists)
                {
                    textBoxState.Text = "exists";
                    textBoxState.ForeColor = Color.Aquamarine;
                }
                else
                {
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, ev) =>
                    {
                        textBoxState.Text = "isn't selected";
                        textBoxState.ForeColor = Color.White;

                        timer.Stop();
                        timer.Dispose();
                    };

                    textBoxState.Text = "does not exist";
                    textBoxState.ForeColor = Color.Red;

                    timer.Start();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxSearchUserText.Text.Trim();

            if (!string.IsNullOrEmpty(userLogin))
            {
                List<User> users = UserManager.LoadUsers();
                User userToRemove = users.FirstOrDefault(u => u.Login == userLogin);

                if (userToRemove != null)
                {
                    userToRemove.Dispose();
                    users.Remove(userToRemove);

                    textBoxState.Text = "is deleted";
                    textBoxState.ForeColor = Color.LimeGreen;
                }
            }
        }

        private void buttonDelSave_Click(object sender, EventArgs e)
        {
            UserManager.SaveUsers();
            MessageBox.Show($"Changes are saved");
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void textBoxSearchUserText_Click(object sender, EventArgs e)
        {
            textBoxSearchUserText.Clear();
        }

        private void buttonRepository_Click(object sender, EventArgs e)
        {
            string folderPath = @"..\..\Repository";
            System.Diagnostics.Process.Start("explorer.exe", folderPath);
        }
    }
}