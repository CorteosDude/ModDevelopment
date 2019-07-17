using JavelinBL2;
using JavelinView3.Base.InterfacesForOverride._Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Prebooking
{
    public interface IPrebookingUpsellViewController : IController, IModApplicable
    {
        ActionResult RenderUpsell();
    }
}
