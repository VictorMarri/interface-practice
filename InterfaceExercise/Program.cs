using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System;
using static System.Console;

namespace InterfaceExercise
{
    class Program
    {
        Contract contract;
        static void Main(string[] args)
        {
            WriteLine("Enter contract Data");
            Write("\nNumber: ");
            int contractNumber = int.Parse(ReadLine());
            Write("\nDate (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(ReadLine());
            Write("\nContract Value: ");
            double contractValue = double.Parse(ReadLine());
            Write("\nEnter Number os Installments: ");
            int stallmentsNumber = int.Parse(ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            Payment contractService = new Payment(new PayPalPayment());
            contractService.ProcessContract(contract, stallmentsNumber);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.getInstallments())
            {
                Console.WriteLine(installment);
            }
    }
}
