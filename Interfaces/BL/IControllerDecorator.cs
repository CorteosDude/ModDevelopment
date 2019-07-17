using JavelinBL2.Controllers.Base;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интрефейс для декоратора контроллеров
    /// </summary>
    public interface IControllerDecorator<TController> : IDecorator<TController> where TController: BaseController
    {
        
    }
}
