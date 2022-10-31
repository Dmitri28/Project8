using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Pizza : Firm
    {
        private double priceByThePizza;
        private double priceByTheSalat;
        private double priceByTheDrink;
        private double priceByTheOntherFood;

        public Pizza()
        {
        }

        public Pizza(double priceByThePizza, double priceByTheSalat, double priceByTheDrink, double priceByTheOntherFood, String DirectorsName, String DirectorsLastName, String ChiefAccountName)
        {

            this.priceByThePizza = priceByThePizza;
            this.priceByTheSalat = priceByTheSalat;
            this.priceByTheDrink = priceByTheDrink;
            this.priceByTheOntherFood = priceByTheOntherFood;

        }

    }


}