using JavelinBL2;
using JavelinModelV2.Orders.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    public interface IComplexReserveOverrideRouting : IController
    {
        /// <summary>
        /// проверяет, есть ли перегруженные маршруты для данного заказа, выполняет переадресацию
        /// </summary>
        /// <param name="from">query string from из ComplexDetails</param>
        /// <param name="complex">созданная командировка</param>
        /// <param name="bl">контекст бизнес-логики</param>
        /// <returns></returns>
        ActionResult GetOverriddeRoute(string from, ComplexReserve complex, ControllerContainer bl);
    }
}
