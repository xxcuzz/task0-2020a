namespace task0_2020a
{
    abstract class Tariff : ITariff
    {
        public static int BaseCost = 15;
        public abstract double Calculate(int e);
    }
}
