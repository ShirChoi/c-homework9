using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            Converter converter = new Converter(11.3280, 13.3093, 0.1525);

            double somoni = Read("somoni");

            Console.WriteLine($"{somoni} somoni = {converter.SomonToDollar(somoni)} dollars");
            Console.WriteLine($"{somoni} somoni = {converter.SomonToEuro(somoni)} euros");
            Console.WriteLine($"{somoni} somoni = {converter.SomonToRouble(somoni)} roubles");

            double dollar = Read("dollar");
            System.Console.WriteLine($"{dollar} dollars = {converter.DollarToSomon(dollar)} somoni");

            double euro = Read("euro");
            System.Console.WriteLine($"{euro} euros = {converter.EuroToSomon(euro)} somoni");

            double rouble = Read("rouble");
            System.Console.WriteLine($"{rouble} roubles = {converter.RoubleToSomon(rouble)} somoni");
        } 

        static double Read(string varName) {
            System.Console.Write($"{varName}: ");

            return double.Parse(Console.ReadLine());
        }
    }

    class Converter {
        private double _usd;
        private double _eur;
        private double _rub;

        public Converter(double usd, double eur, double rub) {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double SomonToDollar(in double somoni) {
            return somoni / _usd;
        }

        public double SomonToEuro(in double somoni) {
            return somoni / _eur;
        }

        public double SomonToRouble(in double somoni) {
            return somoni / _rub;
        }

        public double DollarToSomon(in double dollar) {
            return dollar * _usd;
        }

        public double EuroToSomon(in double euro) {
            return euro * _eur;
        }

        public double RoubleToSomon(in double rouble) {
            return rouble * _rub;
        }
    }
}
