using JavelinBL2;
using System.Web.Mvc;

namespace JavelinView3.Base.InterfacesForOverride.Search
{
    /// <summary>
    /// трансформирует страницу вариантов
    /// </summary>
    public interface ISearchVariantsTransformation : IBaseSearchTransformation
    {
        /// <summary>
        /// модифицированное представление списка вариантов
        /// </summary>
        /// <returns></returns>
        ActionResult RenderVariants();
    }
}
