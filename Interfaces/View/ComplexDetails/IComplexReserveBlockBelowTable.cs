using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using JavelinModelV2.Orders.Complex;

namespace JavelinView3.Base.InterfacesForOverride.ComplexDetails
{
    public interface IComplexReserveBlockBelowTable
    {
        /// <summary>
        /// рисует некий блок под командировкой, если его рисовать не нужно, то возвращает пустой текст Content("")
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        ActionResult RenderBlockBelow(ComplexReserve complex);
    }
}
