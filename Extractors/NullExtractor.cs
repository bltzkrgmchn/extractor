using System;
using System.Dynamic;
using Extractor.Changes;

namespace Extractor.Extractors
{
    /// <inheritdoc />
    public class NullExtractor : IExtractor
    {
        /// <inheritdoc />
        public AttributeChanges ExtractChanges(ExpandoObject payload)
        {
            return null;
        }
    }
}