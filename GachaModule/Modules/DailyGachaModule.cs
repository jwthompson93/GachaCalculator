using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMvc.Modules;

namespace GachaModule.Modules
{
    public class DailyGachaModule : IGachaModule
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private int _dailyCurrency;
        private int _dailyTicket;

        public DailyGachaModule(string label, DateTime endDate, int dailyCurrency, int dailyTicket) : base(label)
        {
            _startDate = new DateTime();
            _endDate = endDate;
            _dailyCurrency = dailyCurrency;
            _dailyTicket = dailyTicket;
        }

        public DailyGachaModule(string label, DateTime startDate, DateTime endDate, int dailyCurrency, int dailyTicket) : base(label)
        {
            _startDate = startDate;
            _endDate = endDate;
            _dailyCurrency = dailyCurrency;
            _dailyTicket = dailyTicket;
        }

        public override int GetCurrency()
        {
            return _endDate.Subtract(_startDate).Days * _dailyCurrency;
        }

        public override int GetTickets()
        {
            return _endDate.Subtract(_startDate).Days * _dailyTicket;
        }
    }
}
