using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class Account : IAccount
    {
        protected internal event AccountStateHandler Withdrawed;
        protected internal event AccountStateHandler Added;
        protected internal event AccountStateHandler Opened;
        protected internal event AccountStateHandler Closed;
        protected internal event AccountStateHandler Calculated;

        static int counter = 0;
        protected int _days = 0;

        public decimal Sum { get; private set; }
        public int Percentage { get; private set; }
        public int Id { get; private set; }

        public Account(decimal sum, int percentage)
        {
            Sum = sum;
            Percentage = percentage;
            Id = ++counter;
        }

        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if (e != null)
                handler?.Invoke(this, e);
        }
        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }
        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }
        protected virtual void OnOpened(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }
        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }
        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }

        public virtual void Put(decimal sum)
        {
            Sum += sum;
            OnAdded(new AccountEventArgs($"На счёт поступило: {sum}", sum));
        }
        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;

            if (Sum >= sum)
            {
                Sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs($"Со счёта #{Id} снято {sum}", sum));
            }
            else
            {
                OnWithdrawed(new AccountEventArgs($"Недостаточно средств на счету #{Id}", 0));
            }
            return result;
        }
        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs($"Открыт новый счёт #{Id}", Sum));
        }
        protected internal virtual void Close()
        {
            OnClosed(new AccountEventArgs($"Закрыт счёт #{Id}, Итоговая сумма:{Sum}", Sum));
        }
        protected internal void IncrementDays()
        {
            _days++;
        }
        protected internal virtual void Calculate()
        {
            decimal incriment = Sum * Percentage / 100;
            Sum = Sum + incriment;
            OnCalculated(new AccountEventArgs($"Начислены проценты в размере {incriment}", incriment));
        }
    }
}
