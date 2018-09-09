using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C18_Ex03_Gregory_317612950_Mariya_321373136
{
    public class NewsApiFactory
    { 
        private NewsApiFactory() {}

        public INews Create(string i_ApiSource = "") {
            INews newsApi = null;

            switch (i_ApiSource)
            {
                case "newsapi":
                    newsApi = new NewsApi();
                    break;
                default:
                    newsApi = new NewsApi();
                    break;
            }
            return newsApi;
        }
    }
}
