using JavelinBL2;
using JavelinBL2.Controllers.Base.Models;
using JavelinBL2.Utils;
using JavelinModelV2;
using JavelinModelV2.Users;
using JavelinView3.Base;
using JavelinView3.Base.InterfacesForOverride.Editors;
using ModAuthorizationException.PluginLogics.BLControllers;
using ModAuthorizationException.PluginLogics.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModAuthorizationException.Controllers
{
    /// <summary>
    /// Контроллер
    /// </summary>
    public class ModAuthorizationExceptionClientEdtorController : BaseViewController, IExtendibleJavelinObject
    {
        protected AuthorizationExceptionLogicsController LogicsController =>
            ReflectiveEnumerator.FindChildControllersOfType<AuthorizationExceptionLogicsController>(root: BL).FirstOrDefault();

        /// <summary>
        /// проверка применения мода
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        public bool IsApplicable(ControllerContainer bl)
        {
            return bl.ServicesCommon.Mods.IsApplied(Definitions.MOD_NAME);
        }

        /// <summary>
        /// загружает настройку "Исключить авторизацию"
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult RenderExtension(JavelinObject source)
        {
            if (source is Client client)
            {
                var clientWithAuthorizationException = new ClientWithAuthorizationException(client.id.GetValueOrDefault());
                return View("~/PortableViews/ModAuthorizationExceptionViews/Editor/ClientSettingsEditor.cshtml", clientWithAuthorizationException);
            }
            return Content("");
        }

        /// <summary>
        /// Сохраняет настройку "Исключить авторизацию"
        /// </summary>
        /// <param name="currentClientAuthSettings"></param>
        /// <returns></returns>
        public ActionResult ToggleAuthorizationIsNotRequired(int id)
        {
            var currentClientWithAuthorizationException = LogicsController.GetClientSettings(id);
            currentClientWithAuthorizationException.ExtensionData.AuthorizationIsNotRequired = !currentClientWithAuthorizationException.ExtensionData.AuthorizationIsNotRequired;
            currentClientWithAuthorizationException.Save();
            return Content("ok");
        }
    }
}