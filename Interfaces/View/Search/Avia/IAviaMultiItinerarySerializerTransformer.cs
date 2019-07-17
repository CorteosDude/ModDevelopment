using JavelinBL2;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Services.Avia.Structures.BLExtended;
using JavelinView3.Base.InterfacesForOverride._Common;
using Newtonsoft.Json.Linq;

namespace JavelinView3.Base.InterfacesForOverride.Search.Avia
{
    /// <summary>
    /// этот интерфейс имплементируют утилиты, дописывающие какие-либо поля в сериализацию MI на шаге вариантов авиа
    /// </summary>
    public interface IAviaMultiItinerarySerializerTransformer : IModApplicable
    {
        JObject TransformMultiItinerary(JObject source, BLMultiItinerary multiItinerary, ControllerContainer bl);
    }
}
