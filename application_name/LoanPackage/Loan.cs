namespace application_name.LoanPackage
{
    public abstract class Loan 
    {
        private int months;
        private double amount;
        private double total, interest;
        private double[] payments;

        protected Loan(double interest, int months, double amount) {
            this.months = months;
            this.amount = amount;
            this.interest = interest;
            payments = new double[months];  
        }


        public abstract double getTotalInterest();
        public abstract int getMonths(); 
        public abstract double getAmount();
        public abstract double[] getPayments();
    }
}
