using JavelinBL2;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Services.Hotel.Structures.BLExtended;
using JavelinView3.Base.InterfacesForOverride._Common;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JavelinView3.Base.InterfacesForOverride.Search.Hotel
{
    /// <summary>
    /// модифицирует сериализацию рейтов отеля
    /// </summary>
    public interface IExtendedRateTransformer : IModApplicable
    {
        JObject TransformRateGroup(JObject source, List<BLExtendedRate> rateContainer, ControllerContainer bl);
    }
}
