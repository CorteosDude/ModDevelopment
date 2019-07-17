using JavelinBL2.Models.Meta;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интерфейс для контейнера с метаполями
    /// </summary>
    public interface IHasMetaFields
    {
        /// <summary>
        /// метаданные
        /// </summary>
        MetaDataContainer Meta { get; set; }
    }
}
