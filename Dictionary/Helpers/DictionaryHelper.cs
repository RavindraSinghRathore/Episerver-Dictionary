using System;
using System.Web.Mvc;
using Dictionary.Business.Repositories;
using EPiServer.ServiceLocation;

namespace Dictionary.Helpers
{
    public static class DictionaryHelper
    {
        public static string DictionaryEntry(this HtmlHelper html, string key, string fallback = "")
        {
            if (string.IsNullOrEmpty(key))
                return string.Empty;

            var _dictionaryService = ServiceLocator.Current.GetInstance<IDictionaryRepository>();

            var phrase = _dictionaryService?.GetPhrase(key)?.Trim();

            return !string.IsNullOrEmpty(phrase) ? phrase : fallback;
        }
    }
}
