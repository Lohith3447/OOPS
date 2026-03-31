namespace BankAccountOops
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>(); //Good to have capital letter starting for global variable
        public Form1()
        {
            InitializeComponent();

            //BankAccount bankAccount = new BankAccount("Lohith");

            //bankAccount.Owner = "Lohith";
            //bankAccount.AccountNumber = Guid.NewGuid();
            //bankAccount.Balance = 1999;

            //BankAccount bankAccount2 = new BankAccount("SpiderMan");

            //bankAccount2.Owner = "SpiderMan";
            //bankAccount2.AccountNumber = Guid.NewGuid();
            //bankAccount2.Balance = 100;

            //BankAccount bankAccount3 = new BankAccount("IronMan");

            //bankAccount3.Owner = "IronMan";
            //bankAccount3.AccountNumber = Guid.NewGuid();
            //bankAccount3.Balance = 3000;


            //BankAccount bankAccount4 = new BankAccount("Mark");

            //List<BankAccount> bankAccounts = new List<BankAccount>();
            //bankAccounts.Add(bankAccount);
            //bankAccounts.Add(bankAccount2);
            //bankAccounts.Add(bankAccount3);
            //bankAccounts.Add(bankAccount4);

            //List<BankAccount> BankAccounts = [bankAccount, bankAccount2, bankAccount3, bankAccount4];

        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text)) return;

            if (InterestRateNum.Value > 0)
            {
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));

                //SavingsAccount savingsAccount = new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value);
                //BankAccounts.Add(savingsAccount);
            }
            else
            {

                BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
                BankAccounts.Add(bankAccount);
            }

            RefreshGrid();

            OwnerTxt.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message =  selectedBankAccount.Deposit(AmountNum.Value);

                RefreshGrid();

                AmountNum.Value = 0;

                MessageBox.Show(message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(AmountNum.Value);

                RefreshGrid();

                AmountNum.Value = 0;

                MessageBox.Show(message);
            }

        }
    } 

}
