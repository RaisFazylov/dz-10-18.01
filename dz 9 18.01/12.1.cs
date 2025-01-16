/* Упражнение 12.1 Для класса банковский счет переопределить операторы == и != для
сравнения информации в двух счетах. Переопределить метод Equals аналогично оператору
==, не забыть переопределить метод GetHashCode(). Переопределить метод ToString() для
печати информации о счете. Протестировать функционирование переопределенных методов
и операторов на простом примере.
*/
namespace BankingSystem
{
    internal class BankAccount
    {
        public int AccountNumber { get; private set; }

        internal BankAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public override bool Equals(object obj)
        {
            return obj is BankAccount account && AccountNumber == account.AccountNumber;
        }
        public override int GetHashCode() => AccountNumber;

        public static bool operator ==(BankAccount a, BankAccount b) => a.Equals(b);
        public static bool operator !=(BankAccount a, BankAccount b) => !a.Equals(b);

        public override string ToString() => $"Bank Account Number: {AccountNumber}";
    }
}

