using System;

namespace application_name.LoanPackage
{
    public class Anuential : Loan
    {
        private int months;
        private double amount;
        private double total, interest;
        private double[] payments;

        public Anuential(double interest, int months, double amount) : base(interest, months, amount)
        {
            payments = new double[months];
            total = amount + (amount * (interest / 100) * (months / 12.0));
        }

        public override int getMonths()
        {
            return months;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double getTotalInterest() {
            return total - amount;
        }

        
        public double getTotalPayment()
        {
            return amount + getAccumulatedInterest(months);
        }

        public double getMonthlyPayment()
        {
            double monthlyInterestRate = interest / 100 / 12;
            if (monthlyInterestRate == 0)
                return amount / months;

            return (amount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, months)) /
                    (Math.Pow(1 + monthlyInterestRate, months) - 1);
        }

        public double getAccumulatedInterest(int month)
        {
            double totalPaid = getMonthlyPayment() * month;
            double principalPaid = amount - calculateRemainingBalance(month);
            return totalPaid - principalPaid;
        }

        private double calculateRemainingBalance(int month)
        {
            double monthlyInterestRate = interest / 100 / 12;
            return amount * Math.Pow(1 + monthlyInterestRate, month) -
                    (getMonthlyPayment() * (Math.Pow(1 + monthlyInterestRate, month) - 1)) / monthlyInterestRate;
        }

        public override double[] getPayments() {
            payments = new double[months];
            double monthlyInterestRate = interest / 100 / 12;
            double remainingBalance = getTotalPayment();

            for (int month = 0; month < months; month++)
            {
                double interestPortion = remainingBalance * monthlyInterestRate;
                double principalPortion = remainingBalance / (months - month);
                double monthlyPayment = principalPortion + interestPortion;

                payments[month] = monthlyPayment;

                remainingBalance -= principalPortion;

                if (month == months - 1 && Math.Abs(remainingBalance) < 0.01)
                    remainingBalance = 0;

            }
            return payments;
        }
    }
}