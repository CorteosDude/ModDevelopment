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
    /// то, что рисуем в шапке письма ОБЫЧНОГО ЗАКАЗА, например, сколько осталось до ТЛ авиа
    /// </summary>
    public interface IMailingSimpleReserveTopBlock : IController
    {
        ActionResult RenderTopBlock(MailSimpleReserveModel data);
    }
}
