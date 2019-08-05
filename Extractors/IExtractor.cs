using System.Dynamic;
using Extractor.Changes;

namespace Extractor.Extractors
{
    /// <summary>
    /// Извлекатель изменений.
    /// </summary>
    public interface IExtractor
    {
        /// <summary>
        /// Метод, предназначенный для извлечения изменений атрибутов.
        /// </summary>
        /// <param name="payload">Содержимое сообщения.</param>
        /// <returns>Изменения атрибутов.</returns>
        AttributeChanges ExtractChanges(ExpandoObject payload);
    }
}