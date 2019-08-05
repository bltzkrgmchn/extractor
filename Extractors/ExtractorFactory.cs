using System;
using System.Collections.Generic;

namespace Extractor.Extractors
{
    /// <inheritdoc />
    public class ExtractorFactory : IExtractorFactory
    {
        private Dictionary<string, IExtractor> extractors;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ExtractorFactory"/>.
        /// </summary>
        /// <param name="extractors">Словарь, содержащий конфигурацию фабрики, где ключ - тип извлекаемых данных, а значение - извлекатель.</param>
        public ExtractorFactory(Dictionary<string, IExtractor> extractors)
        {
            this.extractors = extractors;
        }

        /// <inheritdoc />
        public IExtractor Create(string extractingType)
        {
            return this.extractors.ContainsKey(extractingType) ? this.extractors[extractingType] : new NullExtractor();
        }
    }
}