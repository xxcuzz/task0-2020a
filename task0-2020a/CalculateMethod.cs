namespace task0_2020a
{
    class CalculateMethod
    {
        private readonly ITariff _tariff;

        public CalculateMethod(ITariff chosenTariff)
        {
            _tariff = chosenTariff;
        }

        public double ExecuteCalculate(int e)
        {
            return _tariff.Calculate(e);
        }
    }
}
