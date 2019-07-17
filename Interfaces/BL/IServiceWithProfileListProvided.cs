using System.Collections.Generic;
using JavelinBL2.Controllers.CommonControllers.Structures;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интерфейс, который позволяет получать финансовые профили по услуге контроллера
    /// Должен определять в админке договора подключение одной из основных услуг, и привязку к финпрофилю по ней
    /// </summary>
    interface IServiceWithProfileListProvided
    {
        /// <summary>
        /// получить идентификатор типа заказа для услуги - чтобы понять, к какому из сервисов привязывать профили
        /// </summary>
        /// <returns></returns>
        int id_ReserveType { get; }

        /// <summary>
        /// Получить список профилей для агентства клиента
        /// </summary>
        /// <returns></returns>
        List<ServiceProfile> GetProfiles(int id_Agreement);
    }
}
