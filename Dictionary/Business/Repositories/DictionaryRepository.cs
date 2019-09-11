using System;
using System.Collections.Generic;
using System.Linq;
using Dictionary.Models.Blocks;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Globalization;

namespace Dictionary.Business.Repositories
{
    public class DictionaryRepository : IDictionaryRepository
    {
        private readonly IClient _findClient;

        public DictionaryRepository(IClient findClient)
        {
            _findClient = findClient ?? throw new ArgumentNullException(nameof(findClient));
        }

        public string GetPhrase(string key)
        {
            var queryBuilder = this._findClient
                .Search<DictionaryEntryBlock>()
                .ExcludeDeleted().InLanguageBranch(ContentLanguage.PreferredCulture.Name)
                .Filter(x => x.Key.MatchCaseInsensitive(key));

            var result = queryBuilder.GetContentResult().Items.FirstOrDefault();

            return result?.Phrase ?? "";
        }

        public IEnumerable<DictionaryEntryBlock> GetAll()
        {
            var queryBuilder = this._findClient
                .Search<DictionaryEntryBlock>()
                .ExcludeDeleted();

            var result = queryBuilder.GetContentResult().Items;

            return result;
        }
    }
}
