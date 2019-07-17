using JavelinModelV2.Orders.Simple;
using JavelinView3.Base.InterfacesForOverride._Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Finalization
{
    public interface IFinalizationViewController : IViewControllerApplicable
    {
        ActionResult BookSimpleReserve(int id_Reserve);

        bool IsValidForReserve(SimpleReserve reserve);
    }
}
