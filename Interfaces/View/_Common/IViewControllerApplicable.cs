using JavelinBL2;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    public interface IViewControllerApplicable : IController
    {
        bool IsApplicable(ControllerContainer bl);
    }
}
