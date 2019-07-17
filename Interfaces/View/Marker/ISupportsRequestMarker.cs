using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.Marker
{
    /// <summary>
    /// определяет, поддерживает ли контроллер переданный маркер
    /// </summary>
    public interface ISupportsRequestMarker
    {
        bool IsRequestMarkerSupported(string marker);
    }
}
