namespace application_name.LoanPackage
{
    public class Anuential : Loan
    {
        private int months;
        private double amount;
        private double[] payments;

        public Anuential(int months, double amount) : base(months, amount) {
            this.payments = new double[months];
        }

        public override int getMonths()
        {
            return months;
        }

        public override double getAmount()
        {
            return amount;
        }

        public override double[] getPayments() {
             /*
             *
             * TODO: Implement logic
             *
             */

            return payments;
        }
    }
}
