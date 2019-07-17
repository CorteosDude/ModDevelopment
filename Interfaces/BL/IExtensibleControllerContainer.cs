using System.Collections.Generic;
using JavelinBL2.Controllers.Base;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// класс для контроллеров-контейнеров, которые могут быть расширены субконтроллерами
    /// </summary>
    public interface IExtensibleControllerContainer
    {
        List<BaseController> ExtensionControllers { get; set; }
    }
}
