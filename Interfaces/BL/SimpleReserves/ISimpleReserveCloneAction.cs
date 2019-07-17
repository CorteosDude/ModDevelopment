using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Base.Structures.Artifacts;

namespace JavelinBL2.Interfaces.SimpleReserves.Specific
{
    /// <summary>
    /// интерфейс, который должен имплементировать контроллер BaseSimpleReserveCloneController для удобного 
    /// получения его методов на слое представления
    /// </summary>
    public interface ISimpleReserveCloneAction : ISimpleReserveAction
    {
        PrebookingPersonSelectorModel GetSinglePassenger(int id_Reserve, int id_Person);
    }
}
