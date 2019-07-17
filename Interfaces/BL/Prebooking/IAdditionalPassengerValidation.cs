using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Base.Structures.Artifacts;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Base.Structures.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.Prebooking
{
    /// <summary>
    /// этот интерфейс должны имплементировать контроллеры, которые далют доп валидацию пакса на шаге пребукинга
    /// </summary>
    public interface IAdditionalPassengerValidation
    {
        bool IsValid(PrebookingPersonModel person, BaseRequest request, out string errorText);
    }
}
