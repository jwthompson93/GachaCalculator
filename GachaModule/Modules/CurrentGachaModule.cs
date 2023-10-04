using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMvc.Modules;

namespace GachaModule.Modules
{
    public class CurrentGachaModule : IGachaModule
    {
        private int _currency = 0;
        private int _ticket = 0;

        public CurrentGachaModule(int currency, int ticket) : base("Current") {
            _currency = currency;
            _ticket = ticket;
        }

        public override int GetCurrency()
        {
            return _currency;
        }

        public override int GetTickets()
        {
            return _ticket;
        }
    }
}
