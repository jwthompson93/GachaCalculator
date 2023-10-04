namespace WebAppMvc.Modules
{
    public abstract class IGachaModule
    {
        private string _label;

        public IGachaModule(string label)
        {
            _label = label;
        }

        // Primogems, Stellar Jades etc
        public abstract int GetCurrency();

        // Intertwined Fate, Star Rail Pass etc
        public abstract int GetTickets();
    }
}
