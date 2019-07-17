using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride._Common
{
    public interface IBundledScript
    {
        List<string> GetScriptUrl(string bundleName);
    }
}
