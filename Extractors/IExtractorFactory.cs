namespace Extractor.Extractors
{
    /// <summary>
    /// Фабрика для создания извлекателя изменений.
    /// </summary>
    public interface IExtractorFactory
    {
        /// <summary>
        /// Метод, обеспечивающий создание извлекателя.
        /// </summary>
        /// <param name="extractingType">Тип извлечения изменений.</param>
        /// <returns>Извлекатель изменений.</returns>
        IExtractor Create(string extractingType);
    }
}