using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class Calculation
    {
        public double doCalculation(string[] array)
        {
            double price = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null || array[i].Length != 0) {
                    if (array[i].ToString() == "Meal") price += 3.00; //Meal option

                    if (array[i].ToString() == "Small") price += 4.99; //Size
                    if (array[i].ToString() == "Medium") price += 6.99;
                    if (array[i].ToString() == "Large") price += 8.99;
                    if (array[i].ToString() == "King") price += 10.99;
                    if (array[i].ToString() == "Mega") price += 12.99;

                    if (array[i].ToString().Contains("Mayo")) price += 0.25; //Sauces
                    if (array[i].ToString().Contains("Mustard")) price += 0.25;
                    if (array[i].ToString().Contains("Avocado")) price += 1.25;
                    if (array[i].ToString().Contains("Ranch")) price += 0.25;
                    if (array[i].ToString().Contains("Barbeque")) price += 0.25;

                    if (array[i].ToString().Contains("Lettuce")) price += 0.50; //Toppings
                    if (array[i].ToString().Contains("Tomato")) price += 0.50;
                    if (array[i].ToString().Contains("Onions")) price += 0.50;
                    if (array[i].ToString().Contains("Pickles")) price += 0.50;
                    if (array[i].ToString().Contains("Spinach")) price += 0.50;

                    if (array[i].ToString().Contains("Add Bacon")) price += 2.00; //Additions
                    if (array[i].ToString().Contains("Add Pepperoni")) price += 2.00;
                    if (array[i].ToString().Contains("Extra Meat")) price += 2.00;
                    if (array[i].ToString().Contains("Extra Cheese")) price += 2.00;
                    if (array[i].ToString().Contains("Extra Avocado")) price += 2.00;

                    if (array[i].ToString().Contains("Chips")) price += 1.00; //Sides
                    if (array[i].ToString().Contains("Cookies")) price += 2.00;
                    if (array[i].ToString().Contains("Meatballs")) price += 3.00;
                    if (array[i].ToString().Contains("Mac & Cheese")) price += 3.00;
                    if (array[i].ToString().Contains("Mashed Potatoes")) price += 2.00;

                } 
                else continue;
                
         
            }
            return price;
        }

        public double getResult(double subTotal, double tips, double tax)
        {
            double Subtotal = subTotal;
            double Taxes = tax;
            double Total = Subtotal + Taxes + tips;

            return Total;
        }
    }

}