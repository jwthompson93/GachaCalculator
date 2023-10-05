using GachaModule.Modules.Types;
using Xunit;

namespace GachaModuleTests
{
    public class GachaModuleTests
    {
        public static readonly object[][] DailyGachaModuleData =
        {
            new object[] { new DateTime(2023, 10, 4), new DateTime(2023, 10, 6), 60, 0, 120, 0 },
            new object[] { new DateTime(2023, 10, 4), new DateTime(2023, 10, 10), 60, 1, 360, 6 },
            new object[] { new DateTime(2023, 10, 4), new DateTime(2023, 11, 28), 60, 1, 3300, 55 }
        };

        public static readonly object[][] MonthlyGachaModuleData =
        {
            new object[] { new DateTime(2023, 10, 4), new DateTime(2023, 10, 6), 0, 5, 0, 0 },
            new object[] { new DateTime(2023, 10, 4), new DateTime(2023, 12, 10), 0, 5, 0, 10 },
            new object[] { new DateTime(2023, 10, 4), new DateTime(2024, 1, 28), 0, 5, 0, 15 }
        };

        [Theory]
        [InlineData(256, 2, 256, 2)]
        public void TestGeneralGachaModule(int currency, int tickets, int expectedCurrency, int expectedTickets)
        {
            var generalGachaModule = new GeneralGachaModule(currency, tickets);

            Assert.Equal(generalGachaModule.GetCurrency(), expectedCurrency);
            Assert.Equal(generalGachaModule.GetTickets(), expectedTickets);
        }

        [Theory, MemberData(nameof(DailyGachaModuleData))]
        public void TestDailyGachaModule(DateTime startDate, DateTime endDate, int dailyCurrency, int dailyTickets, 
            int expectedCurrency, int expectedTickets)
        {
            var dailyGachaModule = new DailyGachaModule("Daily Commissions", dailyCurrency, dailyTickets, endDate, startDate);

            Assert.Equal(dailyGachaModule.GetCurrency(), expectedCurrency);
            Assert.Equal(dailyGachaModule.GetTickets(), expectedTickets);
        }

        [Theory, MemberData(nameof(MonthlyGachaModuleData))]
        public void TestMonthlyGachaModule(DateTime startDate, DateTime endDate, int dailyCurrency, int dailyTickets, 
            int expectedCurrency, int expectedTickets)
        {
            var monthlyGachaModule = new MonthlyGachaModule("Paimon's Bargains", dailyCurrency, dailyTickets, endDate, startDate);

            Assert.Equal(monthlyGachaModule.GetCurrency(), expectedCurrency);
            Assert.Equal(monthlyGachaModule.GetTickets(), expectedTickets);
        }
    }
}