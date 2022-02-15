using System;
//TShirtOrder.cs
//Programmer: Rob Garner (rgarner7@cnm.edu)
//Date: 10 Mar 2020
//Purpose: Model a TShirt order.
namespace TShirtOrders
{
    /// <summary>
    /// TShirtOrder
    /// Provides a model of a shirt order.
    /// </summary>
    public class TShirtOrder
    {
        public TShirtOrder(string firstName = "", string lastName = "", string address = "",  int numColors = 1, int numShirts = 1,  bool isLocalPickup = true, DateTime? orderDate = null, double printAreaInSqIn = 0) //AM. Set printAreaInSqIn to 0.
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            IsLocalPickup = isLocalPickup;
            this.printAreaInSqIn = printAreaInSqIn;
            this.numColors = numColors;
            this.numShirts = numShirts;
            Calc();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsLocalPickup { get; set; }
        private double printAreaInSqIn;
        public double PrintAreaInSqIn
        {
            get { return printAreaInSqIn; }
            set { printAreaInSqIn = value; Calc(); }
        }

        private int numColors;
        public int NumColors
        {
            get { return NumColors; }
            set { NumColors = value; Calc(); }
        }

        private int numShirts;
        public int NumShirts
        {
            get { return numShirts; }
            set { numShirts = value; Calc(); }
        }
        public decimal Price { private get; set; }
        private void Calc()
        {
            Price = (decimal)(numShirts * (numColors * 2.25 + printAreaInSqIn * .05)); //AM. Added deciaml to convert the int and double to a float.
        }
        public override string ToString()
        {
            return FirstName+" "
                +LastName+" "
                +OrderDate.ToString() + ("MM/dd/yyyy HH:mm:ss")+" " //AM. Added () and a +.
                +" Price: "+Price.ToString();
        }
    }
}
