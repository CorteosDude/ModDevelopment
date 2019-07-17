using JavelinModelV2.Orders.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    public interface IComplexReserveBlockAboveTable
    {
        /// <summary>
        /// рисует некий блок над командировкой, если его рисовать не нужно, то возвращает пустой текст Content("")
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        ActionResult RenderBlockAbove(ComplexReserve complex);
    }
}
