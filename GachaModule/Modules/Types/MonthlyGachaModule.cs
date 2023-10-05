using WebAppMvc.Modules;

namespace GachaModule.Modules.Types
{
    public class MonthlyGachaModule : IGachaModule
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private int _monthlyCurrency;
        private int _monthlyTicket;

        public MonthlyGachaModule(string label, int monthlyCurrency, int monthlyTicket, DateTime endDate) : base(label)
        {
            _startDate = new DateTime();
            _endDate = endDate;
            _monthlyCurrency = monthlyCurrency;
            _monthlyTicket = monthlyTicket;
        }

        public MonthlyGachaModule(string label, int monthlyCurrency, int monthlyTicket, DateTime endDate, DateTime startDate) : 
            this(label, monthlyCurrency, monthlyTicket, endDate)
        {
            _startDate = startDate;
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
            return (_endDate.Year - _startDate.Year) * 12 + _endDate.Month - _startDate.Month;
        }
    }
}
