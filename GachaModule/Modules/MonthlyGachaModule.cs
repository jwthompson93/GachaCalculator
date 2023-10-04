using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMvc.Modules;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GachaModule.Modules
{
    public class MonthlyGachaModule : IGachaModule
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private int _monthlyCurrency;
        private int _monthlyTicket;

        public MonthlyGachaModule(string label, DateTime endDate, int monthlyCurrency, int monthlyTicket) : base(label)
        {
            _startDate = new DateTime();
            _endDate = endDate;
            _monthlyCurrency = monthlyCurrency;
            _monthlyTicket = monthlyTicket;
        }

        public MonthlyGachaModule(string label, DateTime startDate, DateTime endDate, int dailyCurrency, int dailyTicket) : base(label)
        {
            _startDate = startDate;
            _endDate = endDate;
            _monthlyCurrency = dailyCurrency;
            _monthlyTicket = dailyTicket;
        }
        public override int GetCurrency()
        {
            return CalculateMonthDifference() * _monthlyCurrency;
        }

        public override int GetTickets()
        {
            return CalculateMonthDifference() * _monthlyTicket;
        }

        private int CalculateMonthDifference()
        {
            return ((_endDate.Year - _startDate.Year) * 12) + _endDate.Month - _startDate.Month;
        }
    }
}
