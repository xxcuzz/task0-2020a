namespace task0_2020a
{
    class Tariff_BenefitOne : Tariff
    {
        public double k = 2.0 / 3.0;
        public override double Calculate(int e)
        {
            double cost = BaseCost * e * k;
            return cost;
        }
    }
}
