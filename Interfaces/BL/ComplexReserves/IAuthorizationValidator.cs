using JavelinModelV2.Orders.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.ComplexReserves
{
    /// <summary>
    /// интрефейс нужен для того, чтобы проверить необходимость запуска авторизации для комплексного заказа
    /// </summary>
    public interface IAuthorizationValidator
    {
        bool CheckAuthorizationSkipPossibility(ComplexReserve complex);
    }
}
