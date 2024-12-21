namespace application_name.LoanPackage
{
    public class Linear : Loan
    {
        private int months;
        private double amount;
        private double total, interest;
        private double[] payments;

        public Linear(double interest, int months, double amount) : base(interest, months, amount)
        {
            this.total = amount + (amount * (interest / 100) * (months / 12.0));
        }

        public override int getMonths() {
            return months;
        }

        public override double getAmount() {
            return amount;
        }

        public override double getTotalInterest()
        {
            return total - amount;
        }

        public double getInterest()
        {
            return interest;
        }

        public double getMonthlyPayment()
        {
            return amount / this.months;
        }

        public double getTotalPayment()
        {
            return amount + (amount * (interest / 100) * (months / 12.0));
        }

        public double getAccumulatedInterest(int month)
        {
            double monthlyInterestRate = interest / 100 / 12;
            return amount * monthlyInterestRate * month;
        }

        public override double[] getPayments() {
            payments = new double[months];
            double principalPerMonth = getMonthlyPayment();
            double remainingBalance = getTotalPayment();

            for (int month = 0; month < months; month++)
            {
                double interestPayment = remainingBalance * (interest / 100 / 12);
                double monthlyPayment = principalPerMonth + 2 * interestPayment;

                if (month == months - 1)
                    monthlyPayment = monthlyPayment - interestPayment;
                payments[month] = monthlyPayment;

                remainingBalance -= principalPerMonth;
            }

            return payments;
        }
    }
}