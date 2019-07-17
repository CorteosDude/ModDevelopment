using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    public interface IOverrideLockScreen : IModApplicable, IController
    {
        /// <summary>
        /// отрисовывает вьюху для экрана блокировки
        /// </summary>
        /// <returns></returns>
        ActionResult RenderLockScreen();

        /// <summary>
        /// приоритет для отрисовки - если несколько подходят, то выбираем тот, который лучше
        /// </summary>
        int PriorityRate { get; }
    }
}
