namespace application_name.LoanPackage
{
    public class Linear : Loan
    {
        private int months;
        private double amount;
        private double[] payments;

        public Linear() : base() {
            this.payments = new double[0];
            this.months = 0;
            this.amount = 0;
        }

        public Linear(int months, double amount) : base(months, amount) {
            this.payments = new double[months];
            this.months = months;
            this.amount = amount;
        }

        public override int getMonths() {
            return months;
        }

        public override double getAmount() {
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
