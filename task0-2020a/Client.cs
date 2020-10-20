using System;
using System.ComponentModel;
using task0_2020a.Enums;

namespace task0_2020a
{
    class Client
    {
        private string clientName;
        private int energy;
        public string ClientName
        {
            get
            {
                return clientName;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    clientName = value;
                else
                    throw new ArgumentNullException(nameof(ClientName), "Name must not be empty ");
            }
        }
        public int Energy
        {
            get
            {
                return energy;
            }
            private set
            {
                if (value >= 0)
                    energy = value;
                else
                    throw new ArgumentException("Energy must be positive",nameof(Energy));
            }
        }

        public ETariff Tariff { get; set; }
        CalculateMethod cm;

        public Client(string s, int e, int t)
        {
            ClientName = s;
            Energy = e;
            Tariff = (ETariff)t;
        }

        public double CostPerMonth(ETariff tariff, int Energy) {

            switch ((int)tariff)
            {
                case 0:
                    cm = new CalculateMethod(new Tariff_Default());
                    return cm.ExecuteCalculate(Energy);
                case 1:
                    cm = new CalculateMethod(new Tariff_Limit());
                    return cm.ExecuteCalculate(Energy);
                case 2:
                    cm = new CalculateMethod(new Tariff_BenefitOne());
                    return cm.ExecuteCalculate(Energy);
                case 3:
                    cm = new CalculateMethod(new Tariff_BenefitTwo());
                    return cm.ExecuteCalculate(Energy);
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        public void Print(IPrinter printer) {
            string str = String.Format("{0,10}\t|{1,5}\t|{2,15}\t|{3,10}", ClientName, Energy, Tariff, CostPerMonth(Tariff, Energy));
            printer.Print(str);
        }
    }
}
