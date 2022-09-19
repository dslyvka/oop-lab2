namespace Convertor
{
    internal class Convertor
    {
        private double usd;
        private double eur;
        private double rub;

        public Convertor(double rub, double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ToUsd(double uah)
        {
            return uah / this.usd;
        }

        public double ToEur(double uah)
        {
            return uah / this.eur;
        }

        public double ToRub(double uah)
        {
            return uah / this.rub;
        }

        public double UsdToUah(double usd)
        {
            return this.usd * usd;
        }

        public double EurToUah(double eur)
        {
            return this.eur * eur;
        }

        public double RubToUah(double rub)
        {
            return this.rub * rub;
        }


    }
}
