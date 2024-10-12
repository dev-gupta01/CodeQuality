using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeQuality.dev.Functions.Bad
{
    public enum EmployeeType
    {
        COMMISSIONED,
        HOURLY,
        SALARIED
    }

    public class Money
    {
        public int cash;
        public int cheque;
    }

    public class Employee
    {
        public EmployeeType type;
    }

    public class Switch
    {
        public Money CalculatePay(Employee e)
        {
            switch (e.type)
            {
                case EmployeeType.COMMISSIONED:
                    return CalculateCommissionPay(e);
                case EmployeeType.HOURLY:
                    return CalculateHourlyPay(e);
                case EmployeeType.SALARIED:
                    return CalculateSalariedPay(e);
                default:
                    throw new NotImplementedException();
            }
        }

        private Money CalculateCommissionPay(Employee e)
        {
            Money money = new Money();
            // logic

            return money;
        }

        private Money CalculateHourlyPay(Employee e)
        {
            Money money = new Money();
            // logic

            return money;
        }

        private Money CalculateSalariedPay(Employee e)
        {
            Money money = new Money();
            // logic

            return money;
        }
    }
}
