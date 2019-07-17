using JavelinBL2;
using JavelinView3.Base.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    /// <summary>
    /// этот интерфейс должен имплементировать поисковый контроллер для того, что быть показанным в меню
    /// </summary>
    public interface ISearchServiceControllerMenu
    {
        SearchControllerMenuItem GetMenuItem(ControllerContainer bl);
    }
}
