using JavelinBL2.Interfaces.MetaDictionary.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.MetaDictionary
{
    /// <summary>
    /// этот интерфейс должны имплементировать контроллеры, которые возвращают список автоподсказок для тэгов справочника
    /// </summary>
    public interface IMetaDictionarySpecialTag
    {
        List<MetaDictionaryTagInfo> GetAvailableTags();
    }
}
