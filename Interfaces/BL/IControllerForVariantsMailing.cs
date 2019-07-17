using CommonHelpers.Interfaces;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Base.Structures.Artifacts;
using JavelinModelV2.Offers;

namespace JavelinBL2.Interfaces
{
    /// <summary>
    /// интерфейс для контроллера с мейлингом вариантов
    /// </summary>
    public interface IControllerForVariantsMailing
    {
        /// <summary>
        /// возвращает вариант по идентификатору в базе
        /// </summary>
        /// <param name="id_Variant"></param>
        /// <returns></returns>
        object GetStoredVariant(int id_Variant);

        VersionInfo GetVersionInfo();

        IXmlConvertible ExtractOfferData(EmailOfferVariant variant);

        EmailOfferVariant PushOfferToContainer(string requestId, string keyForAnOffer, int id_Container);

        EmailOfferContainer CreateNewOfferContainer(string requestId, string keyForAnOffer, string containerName);

        //bool DeleteOfferFromContainer(int id_Offer);
    }
}