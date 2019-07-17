using System.Xml.Linq;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интерфейс для объектов в с метаданными
    /// </summary>
    public interface IMetaData 
    {
        XElement MetaDataXml { get; set; }

        


    }
}
