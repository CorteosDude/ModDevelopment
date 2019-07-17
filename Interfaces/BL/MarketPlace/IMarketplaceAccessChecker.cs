using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.MarketPlace
{
    /// <summary>
    /// контролирует доступ к маркетплейсу
    /// </summary>
    public interface IMarketplaceAccessChecker
    {
        bool IsAccessible();
    }
}
