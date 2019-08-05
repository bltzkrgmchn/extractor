using System.Collections.Generic;
using System.Dynamic;
using Extractor.Changes;

namespace Extractor.Extractors
{
    /// <inheritdoc />
    public class PartnerAddedExtractor : IExtractor
    {
        /// <inheritdoc />
        public AttributeChanges ExtractChanges(ExpandoObject payload)
        {
            dynamic values = payload;
            return new PartnerAttributeChanges(values.PartnerId, new List<Change>());
        }
    }
}
