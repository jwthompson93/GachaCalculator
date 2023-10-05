using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMvc.Modules;

namespace GachaModule.Modules.Types
{
    public class DailyGachaModule : IGachaModule
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private int _dailyCurrency;
        private int _dailyTicket;

        public DailyGachaModule(string label, int dailyCurrency, int dailyTicket, DateTime endDate) : base(label)
        {
            _startDate = new DateTime();
            _endDate = endDate;
            _dailyCurrency = dailyCurrency;
            _dailyTicket = dailyTicket;
        }

        public DailyGachaModule(string label, int dailyCurrency, int dailyTicket, DateTime endDate, DateTime startDate) : 
            this(label, dailyCurrency, dailyTicket, endDate)
        {
            _startDate = startDate;
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
