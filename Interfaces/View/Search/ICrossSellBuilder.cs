using JavelinBL2;
using JavelinModelV2.Orders.Complex;
using JavelinView3.Base.Structures.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    /// <summary>
    /// интерфейс, который должны имплементировать контроллеры, предоставляющие доступ к командировке
    /// </summary>
    public interface ICrossSellBuilder : ISearchServiceControllerMenu
    {
        /// <summary>
        /// получить доступные кросселы для данного типа услуги по командировке, если таковых нет - возвращает список без элементов(но не нулл!)
        /// </summary>
        /// <param name="complex"></param>
        /// <param name="bl"></param>
        /// <returns></returns>
        List<CrossSellOffer> GetCrossSellsForComplexReserve(ComplexReserve complex, ControllerContainer bl);
    }
}
