using RestSharp;

namespace CryptoBooz.Parsers
{
    public class YobitAccountsParser : AccountsParser
    {
        public YobitAccountsParser(string parserUrl) : base(parserUrl)
        {
        }

        protected override void StartAccountsParser(object state)
        {
            base.StartAccountsParser(state);

            var request = new RestRequest("", Method.POST);
            request.AddBody("method=change_chat_locale&csrf_token=&locale=ru&locale_chat=ru");

            var content = RestClientExecute(request).Content;

        }
    }
}
