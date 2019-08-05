using System.Collections.Generic;
using System.Dynamic;
using Extractor.Changes;

namespace Extractor.Extractors
{
    /// <inheritdoc />
    public class UserAddedExtractor : IExtractor
    {
        /// <inheritdoc />
        public AttributeChanges ExtractChanges(ExpandoObject payload)
        {
            dynamic values = payload;
            var userEnabled = new Change("Enabled", "add", values.User.Enabled.ToString());
            return new UserAttributeChanges(values.User.Id, new List<Change> { userEnabled });
        }
    }
}