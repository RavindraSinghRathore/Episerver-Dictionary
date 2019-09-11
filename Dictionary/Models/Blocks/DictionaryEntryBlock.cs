using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Dictionary.Models.Blocks
{
    [ContentType(DisplayName = "DictionaryEntry", GUID = "5199528c-6220-4b39-83b5-f1816df85ac8", Description = "Add dictionary value entry for static text")]
    public class DictionaryEntryBlock : BlockData
    {
        [Display(
            Name = "Key",
            Description = "Dictionary key name",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Key { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Phrase",
            Description = "Dictionary key pharse value",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Phrase { get; set; }
    }
}