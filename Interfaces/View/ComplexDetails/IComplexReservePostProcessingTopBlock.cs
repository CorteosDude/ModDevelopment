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
    /// <summary>
    /// рисует некие блоки над портлетом постпроцессинга в JavelinView3\Pages\Orders\ComplexReserves\Actions\_Common\Views\Desktop\Partial\_PostProcessingButtons.cshtml
    /// </summary>
    public interface IComplexReservePostProcessingTopBlock
    {
        /// <summary>
        /// рисует блок над чеклистом действий в постпроцессинге командировки
        /// </summary>
        /// <param name="complex"></param>
        /// <returns></returns>
        ActionResult RenderTopBlock(ComplexReserve complex);
    }
}
