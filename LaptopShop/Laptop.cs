using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop
{
    
    
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string screen;
        private Battery battery;
        private int price;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Enter a valid manufacturer");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Enter a valid processor");
                }
                else
                {
                    this.processor = value;
                }
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Enter a valid ram");
                }
                else
                {
                    this.ram = value;
                }
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Enter a valid graphics card");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Enter a valid screen");
                }
                else
                {
                    this.screen = value;
                }
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Enter a valid price");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        
        public Laptop(string model, int price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, int price, string manufacturer = null, string processor = null, string ram = null, string graphicsCard = null, Battery battery = null, string screen = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.Screen = screen;
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            finalResult.AppendLine("model: " + this.Model);
            if (this.Manufacturer != null)
            {
                finalResult.AppendLine("manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                finalResult.AppendLine("processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                finalResult.AppendLine("RAM: " + this.Ram);
            }
            if (this.graphicsCard != null)
            {
                finalResult.AppendLine("Graphics card: " + this.graphicsCard);
            }
            if (this.Screen != null)
            {
                finalResult.AppendLine("screen: " + this.Screen);
            }
            if (this.Battery != null)
            {
                finalResult.Append(this.Battery.ToString());
            }
            finalResult.AppendLine("price: " + this.Price);

            return finalResult.ToString();
        }

    }
    
}
