using System.Collections.Generic;
using System.Dynamic;
using Extractor.Changes;

namespace Extractor.Extractors
{
    /// <inheritdoc />
    public class UserUpdatedExtractor : IExtractor
    {
        /// <inheritdoc />
        public AttributeChanges ExtractChanges(ExpandoObject payload)
        {
            dynamic values = payload;
            var userEnabledClear = new Change("Enabled", "clear", string.Empty);
            var userEnabledSet = new Change("Enabled", "add", values.User.Enabled.ToString());
            return new UserAttributeChanges(values.User.Id, new List<Change> { userEnabledClear, userEnabledSet });
        }
    }
}