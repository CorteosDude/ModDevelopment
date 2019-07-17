using JavelinBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    /// <summary>
    /// интерфейс для выгрузки дополнительных стилей 
    /// </summary>
    public interface IExtraStyles
    {
        List<string> GetExtraStylesForPage(ControllerContainer bl, string page);
    }
}
