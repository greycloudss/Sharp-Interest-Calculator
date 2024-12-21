using System;

namespace application_name.LoanPackage
{
    public class Exponential : Loan
    {
        private int months;
        private double amount;
        private double total, interest;
        private double[] payments;

        public Exponential(double interest, int months, double amount) : base(interest, months, amount)
        {
            this.payments = new double[months];
            this.total = amount + (amount * (interest / 100) * (months / 12.0));
        }

        public override int getMonths()
        {
            return months;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double getTotalInterest()
        {
            return total - amount;
        }

        public double getTotalPayment()
        {
            return amount + getAccumulatedInterest(months);
        }

        public double getAccumulatedInterest(int month)
        {
            double monthlyRate = interest / 100 / 12;
            return amount * (Math.Pow(1 + monthlyRate, month) - 1);
        }

        public double getMonthlyPayment()
        {
            double monthlyRate = (interest / 100) / 12;
            if (monthlyRate == 0)
            {
                return amount / months;
            }
            return (amount * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                    (Math.Pow(1 + monthlyRate, months) - 1);
        }

        public override double[] getPayments() {
            this.payments = new double[this.months];
            double monthlyRate = interest / 100 / 12;
            double remainingBalance = getTotalPayment();

            for (int month = 0; month < this.months; month++)
            {
                double interestPayment = remainingBalance * monthlyRate;
                double principalPayment = remainingBalance / (this.months - month);
                double monthlyPayment = principalPayment + interestPayment;

                this.payments[month] = monthlyPayment;

                remainingBalance -= principalPayment;

                if (month == this.months - 1 && Math.Abs(remainingBalance) < 0.01)
                {
                    remainingBalance = 0;
                }
            }


            return payments;
        }
    }
}