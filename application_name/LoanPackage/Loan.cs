namespace application_name.LoanPackage
{
    public abstract class Loan 
    {
        private int months;
        private double amount;
        private double[] payments;

        protected Loan() {
            payments = new double[0];
            amount = 0;
            months = 0;
        }

        protected Loan(int months, double amount) {
            this.months = months;
            this.amount = amount;
            payments = new double[months];  
        }

        public abstract int getMonths(); 
        public abstract double getAmount();
        public abstract double[] getPayments();
    }
}
