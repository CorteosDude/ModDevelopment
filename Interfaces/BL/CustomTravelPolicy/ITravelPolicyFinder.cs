using JavelinBL2.Utils;
using JavelinModelV2.RealWorld.Personal;
using JavelinModelV2.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.CustomTravelPolicy
{
    /// <summary>
    /// интерфейс, который может подменять логику выбора ТП
    /// </summary>
    public interface ITravelPolicyFinder
    {
        /// <summary>
        /// определяет, применим класс или нет
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool IsApplicable(ControllerContainer root);

        /// <summary>
        /// метод, возвращающий переопределенный выбор тревел-политик
        /// </summary>
        /// <returns></returns>
        List<TravelPolicy> FindAll(TravelPolicyFinderUtil caller, out string comment);

        /// <summary>
        /// приоритет для проверки тревел-политики - чем меньше - тем лучше
        /// </summary>
        int Priority { get; }
    }
}
