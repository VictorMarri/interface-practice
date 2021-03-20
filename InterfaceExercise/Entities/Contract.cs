using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Entities
{
    public class Contract
    {
        private int ContractNumber;
        private DateTime ContractDate;
        private double ContractValue;
        private List<Installment> Installments;

        public Contract(int contractNumber, DateTime contractDate, double contractValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
            Installments = new List<Installment>();
        }

        public int getContractNumber()
        {
            return ContractNumber;
        }

        public DateTime getContractDate()
        {
            return ContractDate;
        }

        public double getContractValue()
        {
            return ContractValue;
        }

        public List<Installment> getInstallments()
        {
            return Installments;
        }

        public void addInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
