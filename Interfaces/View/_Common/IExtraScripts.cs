using JavelinBL2;
using System.Collections.Generic;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    /// <summary>
    /// интерфейс для добавления дополнительных скриптов на страницу
    /// </summary>
    public interface IExtraScripts
    {
        List<string> GetExtraScriptsForPage(ControllerContainer bl, string page);
    }
}
