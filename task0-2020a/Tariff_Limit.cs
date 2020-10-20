namespace task0_2020a
{
    class Tariff_Limit : Tariff
    {
        public int Limit = 150;
        public double K = 1.0 / 3.0;
        public override double Calculate(int e)
        {
            double cost;
            if(e < Limit)
            {
                cost = e * BaseCost;
            }
            else
            {
                cost = BaseCost * Limit;
                double mem =  BaseCost *(1 + K) * (e - Limit);
                cost += mem;
            }
            return cost;
        }
    }
}
