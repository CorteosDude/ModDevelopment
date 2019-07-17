using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    /// <summary>
    /// контроллер отрисовки дополнительных представлений
    /// </summary>
    public interface IExtraView : IModApplicable
    {
        ActionResult RenderView();

        bool CanRenderView(string page = null);
    }
}
