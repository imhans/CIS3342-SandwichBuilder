using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Project1
{
    public partial class sandwich : System.Web.UI.Page
    {
        Calculation calc = new Calculation();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Pulling User Information
                String name = Request["userName"];
                String number = Request["phoneNumber"];

                //An array storing all value from users
                string[] orderDetails = new string[7];
                orderDetails[0] = Request["sandwichSize"];
                orderDetails[1] = Request["toaster"];
                orderDetails[2] = Request["sauce"];
                orderDetails[3] = Request["topping"];
                orderDetails[4] = Request["addition"];
                orderDetails[5] = Request["meal"];
                orderDetails[6] = Request["side"];

                String size = orderDetails[0].ToString();
                String toaster = orderDetails[1].ToString();
                String sauces = Request["sauce"];
                String toppings = Request["topping"];
                String additions = orderDetails[4].ToString();
                String meals = orderDetails[5].ToString();
                String sides = orderDetails[6].ToString();
                String tips = Request["tips"];


                double subtotal = calc.doCalculation(orderDetails); //subtotal
                string subtotalString = subtotal.ToString("C2");

                double tax = subtotal * 0.08; //tax
                string taxString = tax.ToString("C2");

                double tip; //tip
                if (String.IsNullOrEmpty(tips)) tip = 0;
                else tip = Convert.ToDouble(tips);
                string tipString = tip.ToString("C2");

                double total = calc.getResult(subtotal, tip, tax); //total
                string totalString = total.ToString("C2");



                //[ Customer Info ] 
                lblCustomer.Text = setCustomerLabel(name, number);

                //[ Your Order ]
                lblOrder.Text = setOrderlabel(size, meals, sauces, toppings, additions, sides);

                //[ Transaction Details ]
                lblTransaction.Text = setTrasactionLabel(subtotal.ToString("C2"), tax.ToString("C2"), tip.ToString("C2"), total.ToString("C2"));
            }
            
        }

        public string setCustomerLabel(string name, string number)
        {
            string text = "";
            text +=
                "<div><h3 id=\"bold\"> Thank you for the order!</h3><hr><h4 id=\"bold\">[Customer Info]</h4>"
                + "Customer Name : " + name + "<br/>"
                + "Contact Number : " + number + "<br/><br/></div>";
            return text;
        }
        public string setOrderlabel(string size, string meals, string sauces, string toppings, string additions, string sides)
        {
            
            string text = "";
            text += "<div><h4 id=\"bold\">[ Your Order ]</h4>"
                + size + " Sandwich " + meals + "<br/><br/>";

            if (!String.IsNullOrEmpty(sauces)) text += "Sauces: " + sauces.Substring(2) + "<br/>";
            if (!String.IsNullOrEmpty(toppings)) text += "Toppings: " + toppings.Substring(2) + "<br/>";
            if (!String.IsNullOrEmpty(additions)) text += "Additions: " + additions.Substring(2) + "<br/>";
            if (!String.IsNullOrEmpty(sides)) text += "Sides: " + sides.Substring(2) + "<br/>";

            text += "<br/></div>";

            return text;
        }

        public string setTrasactionLabel(string subtotal, string tax, string tip, string total)
        {
            string text = "";
            text +=
                "<div><h4 id=\"bold\">[ Transaction Details ]</h4>"
                + "Subtotal: " + subtotal + "<br/>"
                + "Taxes: " + tax + "<br/>"
                + "Tips: " + tip + "<br/>" 
                + "Total: " + total + "<br/></div> <hr>";
            return text;
        }
    }
}