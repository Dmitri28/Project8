using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class CaffeSunyDay : Firm
    {
        private double priceByTheMeet;
        private double priceByTheKebab;
        private double priceByTheSoup;
        private double priceByTheBorsch;
        private double priceByTheAlcoholDrink;
        private double priceByTheWithoutAlcohol;



        public double getPriceByTheMeet()
        {
            return priceByTheMeet;
        }

        public void setPriceByTheMeet(double priceByTheMeet)
        {
            this.priceByTheMeet = priceByTheMeet;
        }

        public double getPriceByTheKebab()
        {
            return priceByTheKebab;
        }

        public void setPriceByTheKebab(double priceByTheKebab)
        {
            this.priceByTheKebab = priceByTheKebab;
        }

        public double getPriceByTheSoup()
        {
            return priceByTheSoup;
        }

        public void setPriceByTheSoup(double priceByTheSoup)
        {
            this.priceByTheSoup = priceByTheSoup;
        }

        public double getPriceByTheBorsch()
        {
            return priceByTheBorsch;
        }

        public void setPriceByTheBorsch(double priceByTheBorsch)
        {
            this.priceByTheBorsch = priceByTheBorsch;
        }

        public double getPriceByTheAlcoholDrink()
        {
            return priceByTheAlcoholDrink;
        }

        public void setPriceByTheAlcoholDrink(double priceByTheAlcoholDrink)
        {
            this.priceByTheAlcoholDrink = priceByTheAlcoholDrink;
        }

        public double getPriceByTheWithoutAlcohol()
        {
            return priceByTheWithoutAlcohol;
        }

        public void setPriceByTheWithoutAlcohol(double priceByTheWithoutAlcohol)
        {
            this.priceByTheWithoutAlcohol = priceByTheWithoutAlcohol;
        }
    }
}
