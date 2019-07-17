using JavelinBL2;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Services.Hotel.Structures.BLExtended;
using JavelinView3.Base.InterfacesForOverride._Common;
using Newtonsoft.Json.Linq;

namespace JavelinView3.Base.InterfacesForOverride.Search.Hotel
{
    /// <summary>
    /// модифицирует сериализацию вариантов отелей
    /// </summary>
    public interface IHotelVariantsSerializerTransformer : IModApplicable
    {
        JObject TransformHotelTreeItem(JObject source, BLHotelTreeItem hotelTreeItem, ControllerContainer bl);
    }
}
