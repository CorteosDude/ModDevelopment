using JavelinView3.Base.InterfacesForOverride._Common;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Search.Hotel
{
    /// <summary>
    /// интерфейс добавления дополнительных кнопок на всех этапах отельного поиска
    /// </summary>
    public interface IHotelSearchExtraButton : IModApplicable
    {
        ActionResult RenderButton();

        bool CanRenderButton(string page = null);
    }
}
