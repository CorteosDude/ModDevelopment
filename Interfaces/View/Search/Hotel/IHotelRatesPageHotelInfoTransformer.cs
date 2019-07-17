using HotelConnectorV4.HotelModels.FlowModels;
using JavelinBL2;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Services.Hotel;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Services.Hotel.Structures.BLExtended;
using JavelinView3.Base.InterfacesForOverride._Common;
using Newtonsoft.Json.Linq;

namespace JavelinView3.Base.InterfacesForOverride.Search.Hotel
{
    /// <summary>
    /// трансформирует инфо по отелю на странице рейтов
    /// </summary>
    public interface IHotelRatesPageHotelInfoTransformer : IModApplicable
    {
        JObject TransformHotelInfo(JObject source, ExtendedHotelInfoBase<BLExtendedRate> hotelInfo, ControllerContainer bl, HotelRequestV5 request);
    }
}
