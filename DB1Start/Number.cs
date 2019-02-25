using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DB1Start
{
    class Number
    {
        public double Value { get;private set ; }
        public string Even { get; set; }
        public string Odds { get; set; }
        public double DoubleValue { get; set; }
        public string Prime { get; set; }

        public Number()
        {
        }

        public Number(double value)
        {
            Value = value;   
        }


        public void EvenOdds()
        {
            if(Value == 1)
            {
                Even = "Numero Neutro";
                
            }
            else if(Value % 2 == 0)
            {
                Even = "é Par";
                Odds = "Não é Impar";
            }
            else
            {
                Even = "Não é Par";
                Odds = "É Impar";
            }
        }

        public void Double()
        {
            DoubleValue = Value * 2;
        }

        public void PrimeNumber()
        {
            for (double i = 2; i < Value; i++)
            {
                double resto = Value % i;
                if (resto == 0)
                {
                    Prime = "Não é um número primo";
                    i = Value + 1;
                }
                else
                {
                    Prime ="É um número primo";
                }
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("O numero : ");
            sb.AppendLine(Value.ToString("F2",CultureInfo.InvariantCulture));
            sb.AppendLine(Even);
            sb.AppendLine(Odds);
            if(Value > 10)
            {
                sb.AppendLine("O Numero é maior que 10!!");
            }
            else if(Value == 10)
            {
                sb.AppendLine("O numero é igual a 10");
            }
            else
            {
                sb.AppendLine("O Numero é menor que 10!!");
            }
            sb.Append("O Dobro de "+Value.ToString("F2",CultureInfo.InvariantCulture)+" é ");
            sb.AppendLine(DoubleValue.ToString("F2",CultureInfo.InvariantCulture));
            sb.AppendLine(Prime);
            return sb.ToString();
           
        }
    }
}
