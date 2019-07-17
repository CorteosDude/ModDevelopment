using JavelinModelV2.Orders.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    /// <summary>
    /// данный интерфейс надо имплементировать для того, чтобы нарисовать свое представление для краткого описания заказа
    /// </summary>
    public interface ISimpleReserveBriefView
    {
        /// <summary>
        /// Возвращает партиалку для показа коротких деталей заказа - 
        /// передавать сам заказ здесь не нужно, так как бриф рисуется при помощи vue
        /// </summary>
        /// <returns></returns>
        ActionResult GetPartialForBriefView();
    }
}
