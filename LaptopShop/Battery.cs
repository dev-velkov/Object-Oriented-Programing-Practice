using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop
{
    

    public class Battery
    {
        private string type;
        private double life;

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Enter a valiv battery type");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public double Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Enter a valid battry life");
                }
                else
                {
                    this.life = value;
                }
            }
        }

        public Battery(string batterType)
        {
            this.Type = batterType;
        }

        public Battery(string batterType, double batteryLife) : this(batterType)
        {
            this.Life = batteryLife;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Type != null)
            {
                result.AppendLine("Battery: " + this.Type);
            }
            if (this.Life > 0)
            {
                result.AppendLine("Battery life: " + this.Life + " hours");
            }
            return result.ToString();
        }
    }
}
