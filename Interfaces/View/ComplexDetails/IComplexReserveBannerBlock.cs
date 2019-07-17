using JavelinModelV2.Orders.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    /// <summary>
    /// рисует баннеры над таблицей заказов на странице /ComplexDetails/?id=хххххх
    /// </summary>
    public interface IComplexReserveBannerBlock
    {
        /// <summary>
        /// рисует баннер над командировкой, если баннер рисовать не нужно - возвращает Content("")
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        ActionResult RenderBanner(ComplexReserve complex);
    }
}
