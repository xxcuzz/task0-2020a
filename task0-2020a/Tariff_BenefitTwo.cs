namespace task0_2020a
{
    class Tariff_BenefitTwo : Tariff
    {
        public int FreeEnergy = 50;
        public override double Calculate(int e)
        {
            double cost = e > FreeEnergy ? BaseCost * (e - FreeEnergy) : 0; 
            return cost;
        }
    }
}
