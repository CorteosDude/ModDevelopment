using JavelinBL2.Models.CommonReserveModels;
using JavelinBL2.Models.SimpleReserveModels;
using JavelinModelV2.Orders.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.SimpleReserves
{
    /// <summary>
    /// данные интерфейсы перебираются перед любой операцией с простым заказом
    /// </summary>
    public interface ISimpleReserveActionPreprocessor
    {
        /// <summary>
        /// если возвращается не Null - результат возвращается и действие прерывается
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="actionType"></param>
        /// <returns></returns>
        ReserveActionResult Preprocess(SimpleReserveManagementParameters parameters, SimpleReserve reserve, string actionType);
    }
}
