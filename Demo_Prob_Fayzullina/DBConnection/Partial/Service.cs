using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Prob_Fayzullina.DBConnection
{
    public partial class Service
    {
        public string Discount0
        {
            get
            {
                string result = "";
                if (Discount >= 0 && Discount < 5)
                    result = $"{Discount.Value}";
                return result;
            }
        }
        public string Discount5
        {
            get
            {
                string result = "";
                if (Discount >= 5 && Discount < 15)
                    result = $"{Discount.Value}";
                return result;
            }
        }
        public string Discount15
        {
            get
            {
                string result = "";
                if (Discount >= 15 && Discount < 30)
                    result = $"{Discount.Value}";
                return result;
            }
        }
        public string Discount30
        {
            get
            {
                string result = "";
                if (Discount >= 30 && Discount < 70)
                    result = $"{Discount.Value}";
                return result;
            }
        }
        public string Discount70
        {
            get
            {
                string result = "";
                if (Discount >= 70 && Discount < 100)
                    result = $"{Discount.Value}";
                return result;
            }
        }
        public double NewCost
        {
            get
            {
                return (double)(Cost - Cost * Discount.Value / 100);
            }
        }
        public string Color
        {
            get
            {
                string result = "";
                if (Discount != 0)
                {
                    result = "#c3ff80";
                }
                else
                {
                    result = "#ffffff";
                }
                return result;
            }
        }
        public string DurationInMinutes
        {
            get
            {
                string result = "";
                return result = $"за {Convert.ToString(DurationInSeconds / 60)} минут";
            }
        }
        //public bool NotVisible
        //{
        //    
        //}
    }
}
