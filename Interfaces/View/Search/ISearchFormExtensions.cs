using JavelinBL2;
using JavelinBL2.Controllers.ClientControllers.Subcontrollers.Booking.Base.Structures.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    /// <summary>
    /// расширения поисковой формы
    /// </summary>
    public interface ISearchFormExtensions : IBaseSearchTransformation
    {
        /// <summary>
        /// рисует дополнительные поля на поисковой форме
        /// </summary>
        /// <returns></returns>
        ActionResult Render(JavelinBL2.Models.FormModels.ComplexFormModels.BaseSearchFormLayout layout);

        /// <summary>
        /// добавляет поля к входным данным поисковой формы, специфичные для данного мода
        /// </summary>
        /// <returns></returns>
        object ToModFormDataObject(object src, string json);
    }
}
