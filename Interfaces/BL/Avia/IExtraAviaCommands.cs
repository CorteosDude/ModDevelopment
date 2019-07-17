using AviaEngineV3.AirModels.Common;
using JavelinBL2.Controllers.CommonControllers.Enums;
using JavelinModelV2.Orders.Simple;
using System.Collections.Generic;

namespace JavelinBL2.Interfaces.Avia
{
    /// <summary>
    /// интерфейс, который добавляет дополнительные авиакоманды на действия отмены, выписки, брониронваия
    /// </summary>
    public interface IExtraAviaCommands
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode">шаг, на котором получаем команды - например, бронирование</param>
        /// <param name="reserve"></param>
        /// <param name="commands">команды, которые были выгружены для этого заказа, чтобы не выгружать их повторно</param>
        /// <returns></returns>
        List<CrypticCommand> AddMoreCrypticCommands(AviaCommandMode mode, SimpleReserve reserve, List<CrypticCommand> commands);
    }
}
