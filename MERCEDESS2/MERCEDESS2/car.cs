using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MERCEDESS2
{
    public class car
    {
        public string model;
        public int price;
        public int speed;
        public string color;

        public car (string model, int price, int speed, string color)
        {
            this.model = model;
            this.price = price;
            this.speed = speed;
            this.color = color;

        }


        public string GetDetalis()
        {
            return $"model:{model}, price:{price}, speed:{speed}, color:{color}";
        }
    }
}
