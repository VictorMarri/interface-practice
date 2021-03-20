using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Entities
{
    public class Installment
    {
        private DateTime Data;
        private double Amount;


        public Installment(DateTime data, double amount)
        {
            Data = data;
            Amount = amount;
        }

        public DateTime getData()
        {
            return Data;
        }

        public double getAmount()
        {
            return Amount;
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") +
                " - " + 
                Amount.ToString();
        }


    }
}
