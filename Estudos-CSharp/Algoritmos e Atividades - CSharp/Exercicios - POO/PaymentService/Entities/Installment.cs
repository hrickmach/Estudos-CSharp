using System;

namespace PaymentService.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.DueDate = dueDate;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return DueDate
                 + " - "
                 + Amount;
        }
    }
}