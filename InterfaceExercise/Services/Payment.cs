using InterfaceExercise.Entities;
using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Services
{
    public class Payment
    {
        private readonly IPaymentService _service;

        public Payment(IPaymentService service)
        {
            _service = service;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.getContractValue() / months;

            for (int i = 1; i < months; i++)
            {
                DateTime date = contract.getContractDate().AddMonths(i);
                double updatedQuota = basicQuota + _service.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _service.PaymentFee(updatedQuota);

                contract.addInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
