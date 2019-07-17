using JavelinView3.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Mailing
{
    /// <summary>
    /// то, что рисуем в подвале письма комплексного заказа
    /// </summary>
    public interface IMailingComplexReserveBottomBlock : IController
    {
        ActionResult RenderBottomBlock(MailComplexReserveModel data);

        int GetPriority();
    }
}
