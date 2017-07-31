using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Работа с валютной парой
/// </summary>
namespace ExmoAPI.General
{
    public class CurrencyPair
    {
        private const char SeparateCharacter = '_';
        public string BaseCurrency { get; private set; }
        public  string QuoteCurrency { get; private set; }

        public CurrencyPair(string baseCurrency, string quoteCurrency)
        {
            BaseCurrency = baseCurrency;
            QuoteCurrency = quoteCurrency;
        }

        //Убираем символ разделитель валютных пар
        public static CurrencyPair Parse(string currencyPair)
        {
            string[] valueSplit = currencyPair.Split(SeparateCharacter);
            return new CurrencyPair(valueSplit[0], valueSplit[1]);
        }

        public override string ToString()
        {
            return BaseCurrency + SeparateCharacter + QuoteCurrency;
        }

        public static bool operator ==(CurrencyPair a, CurrencyPair b)
        {
            if (ReferenceEquals(a, b)) return true;
            if((object)a==null ^ (object)b == null) return false;
            return a.BaseCurrency == b.BaseCurrency && a.QuoteCurrency == b.QuoteCurrency;
        }

        public static bool operator !=(CurrencyPair a, CurrencyPair b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            CurrencyPair b=obj as CurrencyPair;
            return (object) b != null && Equals(b);
        }

        protected bool Equals(CurrencyPair b)
        {
            return b.BaseCurrency == BaseCurrency && b.QuoteCurrency == QuoteCurrency;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
