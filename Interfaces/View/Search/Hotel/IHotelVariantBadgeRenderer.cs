using JavelinBL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Search.Hotel
{
    public interface IHotelVariantBadgeRenderer : IController
    {
        ActionResult RenderBadge();
    }
}
