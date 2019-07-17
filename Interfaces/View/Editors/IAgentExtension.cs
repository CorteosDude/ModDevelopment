using JavelinBL2;
using JavelinModelV2.Users;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Editors
{

    public interface IAgentExtension
    {
        /// <summary>
        /// применимо ли действие для данного клиента
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        bool IsApplicable(ControllerContainer bl);

        /// <summary>
        /// рендерим контент расширения, например, таблицу kpi или ремарок
        /// </summary>
        /// <returns></returns>
        ActionResult Render(Agent agent);

    }
}
