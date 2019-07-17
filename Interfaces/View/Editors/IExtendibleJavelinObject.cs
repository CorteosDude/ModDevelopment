using JavelinModelV2;
using JavelinModelV2.RealWorld.Personal;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Editors
{
    /// <summary>
    /// интерфейс рендеринга расширения представлений объектов наследников JavelinObject
    /// </summary>
    public interface IExtendibleJavelinObject : _Common.IViewControllerApplicable
    {
        ActionResult RenderExtension(JavelinObject source);
    }
}
