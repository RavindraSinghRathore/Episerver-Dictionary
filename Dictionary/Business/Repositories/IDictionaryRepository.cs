using System.Collections.Generic;
using Dictionary.Models.Blocks;

namespace Dictionary.Business.Repositories
{
    public interface IDictionaryRepository
    {
        string GetPhrase(string key);

        IEnumerable<DictionaryEntryBlock> GetAll();
    }
}
