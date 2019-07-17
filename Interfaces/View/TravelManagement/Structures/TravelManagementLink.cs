using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinView3.Base.InterfacesForOverride.TravelManagement.Structures
{
    /// <summary>
    /// ссылка для перехода из раздела тревел-менеджмент под агентом
    /// </summary>
    public class TravelManagementLink
    {
        public TravelManagementLink(string caption, string url)
        {
            Caption = caption;
            Url = url;
        }

        /// <summary>
        /// текст ссылки
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// адрес для редиректа
        /// </summary>
        public string Url { get; set; }
    }
}
