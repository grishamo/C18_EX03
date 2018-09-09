using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using System.Threading;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    // Newsapi documentation: https://newsapi.org/
    public class NewsApi : INews
    {
        private readonly string r_ApiKey = "29eddc60ce2c40f3adcb1f6168422c6c";
        private readonly string r_ApiUrl = "https://newsapi.org/v2/top-headlines";
        string culture = CultureInfo.CurrentCulture.DisplayName;
        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;

        public List<INewsArticle> GetNewsArticles(string i_UrlParameters = "")
        {
            List<Article> newsArticles = new List<Article>();
            List<INewsArticle> returnArticles;

            string requestUrl = buildRequestUrl(i_UrlParameters);
            string responceData = UrlRequest.Get(requestUrl);

            ResponceStructure newsResponce = JsonConvert.DeserializeObject<ResponceStructure>(responceData);
            newsArticles = newsResponce.articles;

            // Cast all Article items in list to INewsArticle
            // TODO: Create adapter for INewsArticle that can accept any Article type and return INewArticle
            returnArticles = newsArticles.ConvertAll(item => item as INewsArticle );
            return returnArticles;
        }

        private string buildRequestUrl(string i_UrlParameters)
        {
            string cultureAbbreviation = cultureInfo.TwoLetterISOLanguageName;
            string language = "&language=" + cultureAbbreviation;

            // remove '&' from language if i_UrlParameters hase a value
            language = i_UrlParameters.Length > 1 ? language : language.Replace("&", "");

            string url = r_ApiUrl + "?" + i_UrlParameters + language + "&apiKey=" + r_ApiKey;

            return url;
        }

        // Main Json Structure
        private class ResponceStructure
        {
            public string status { get; set; }
            public int totalResults { get; set; }
            public List<Article> articles = new List<Article>();
        }

        //Article Json Structure
        private class Article : INewsArticle
        {
            public string author { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string url { get; set; }
        }

    }


}
