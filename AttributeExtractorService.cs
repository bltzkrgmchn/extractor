using System.Collections.Generic;
using System.Dynamic;
using Common.Logging;
using Corns.Messaging;
using Corns.Metrics;
using Extractor.Extractors;

namespace Extractor
{
    /// <inheritdoc />
    public class AttributeExtractorService : IAttributeExtractorService
    {
        private static readonly ILog Log = LogManager.GetLogger<AttributeExtractorService>();

        private readonly IEndpoint publisher;
        private IExtractorFactory extractorFactory;

        /// <summary>
        ///     Инициализирует новый экземпляр класса <see cref="AttributeExtractorService" />.
        /// </summary>
        /// <param name="publisher">Абстракция публикатора сообщений.</param>
        /// <param name="extractorFactory">Фабрика для создания извлекателей изменений.</param>
        public AttributeExtractorService(
            IEndpoint publisher,
            IExtractorFactory extractorFactory)
        {
            this.publisher = publisher;
            this.extractorFactory = extractorFactory;
        }

        /// <inheritdoc />
        public void ForwardChanges(ExpandoObject payload, string extractionType)
        {
                var extractor = extractorFactory.Create(extractionType);
                var changes = extractor.ExtractChanges(payload);
                publisher.EmitAsync(changes);
        }
    }
}