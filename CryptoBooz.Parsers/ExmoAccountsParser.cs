namespace CryptoBooz.Parsers
{
    public class ExmoAccountsParser : AccountsParser
    {
        public ExmoAccountsParser(string parserUrl) : base(parserUrl)
        {
        }

        protected override void StartAccountsParser(object state)
        {
            base.StartAccountsParser(state);
        }
    }
}
