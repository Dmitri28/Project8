using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Placinta : Firm
    {
        private double priceByThePlacinta;
        private double priceByTheSalat;
        private double priceByTheDrink;
        private double priceOnatherFood;

        public Placinta(double priceByThePlacinta, double priceByTheSalat, double priceByTheDrink, double priceOnatherFood, String DirectorsName, String DirectorsLastName, String ChiefAccountName)
        {

            this.priceByThePlacinta = priceByThePlacinta;
            this.priceByTheSalat = priceByTheSalat;
            this.priceByTheDrink = priceByTheDrink;
            this.priceOnatherFood = priceOnatherFood;
        }
    }

}

