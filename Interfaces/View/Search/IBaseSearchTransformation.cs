using JavelinBL2;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Base.Structures.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    public interface IBaseSearchTransformation
    {
        /// <summary>
        /// применима ли данная трансформация поисковой формы к этому запросу?
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        bool IsApplicable(ControllerContainer bl, BaseRequest request);
    }
}
