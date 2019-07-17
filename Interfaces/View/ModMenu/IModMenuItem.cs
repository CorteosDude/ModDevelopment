using JavelinBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.ModMenu
{
    /// <summary>
    /// этот интерфейс должны имплементировать вью-контроллеры, чтобы попасть в меню расширения
    /// </summary>
    public interface IModMenuItem
    {
        /// <summary>
        /// возвращает true, если мод применим в контексте данного юзера - определяется через контроллер
        /// </summary>
        /// <param name="controller"></param>
        /// <returns></returns>
        bool IsApplicable(ControllerContainer controller);

        /// <summary>
        /// возвращает элемент меню - key - урл, value - название
        /// </summary>
        /// <returns></returns>
        KeyValuePair<string, string> GetMenuUrl(ControllerContainer controller);
    }
}
