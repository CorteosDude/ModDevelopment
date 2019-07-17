using CommonHelpers.Interfaces;

namespace JavelinView3.Base.InterfacesForOverride.Mailing
{
    /// <summary>
    /// интерфейс отправки предложений по эл почте
    /// </summary>
    public interface IMailingOfferController
    {
        /// <summary>
        /// возвращает маршрут партлиалки отправки заказа по почте
        /// </summary>
        /// <param name="offer"></param>
        /// <returns></returns>
        string GetMailingOfferPartialViewPath(IXmlConvertible offer);
    }
}
