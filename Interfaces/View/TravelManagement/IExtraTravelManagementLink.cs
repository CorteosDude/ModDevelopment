using JavelinView3.Base.InterfacesForOverride.TravelManagement.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.TravelManagement
{
    /// <summary>
    /// интерфейс для дополнительных разделов тревел-менеджмента
    /// </summary>
    public interface IExtraTravelManagementLink : _Common.IViewControllerApplicable
    {
        TravelManagementLink GetTravelManagementLink();
    }
}
