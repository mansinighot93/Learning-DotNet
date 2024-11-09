namespace Banking{
    public class Account{
        private float balance = 5000;

        public Account(){
            this.balance = 10000;
        }

        public Account(float initialBalance){
            this.balance = initialBalance;
        }

        public void SetBalance(float amount){
            this.balance = amount;
        }

        public float GetBalance(){
            return this.balance;
        }

        public void Withdraw(float amount){
            if(amount <= 0){
                throw new Exception("Amount must be be greater than zero");
            }
            this.balance -= amount;
        }

        public void Deposite(float amount){
            this.balance += amount;
        }
        
        ~Account(){
            /*destructor is always called by Garbage Collector 
        before object is going to be removed from Heap*/
        }
    }
}
