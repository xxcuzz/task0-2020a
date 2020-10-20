namespace task0_2020a
{
    class Tariff_Default : Tariff
    {
        public override double Calculate(int e)
        {
            double cost = BaseCost * e;
            return cost;
        }
    }
}
