using System.Dynamic;

namespace Extractor
{
    /// <summary>
    ///   Сервисный объект, отвечающий за форвардинг изменений в хранилище атрибутов безопасности.  
    /// </summary>
    public interface IAttributeExtractorService
    {
        /// <summary>
        /// Метод, отвечающий за форвардинг изменений в хранилище атрибутов безопасности.  
        /// </summary>
        /// <param name="payload">Содержимое события.</param>
        /// <param name="extractionType">Тип извлекателя параметров.</param>
        void ForwardChanges(ExpandoObject payload, string extractionType);
    }
}
