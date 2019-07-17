using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavelinBL2.Interfaces.MetaDictionary.Structures
{
    /// <summary>
    /// для формирования пар код-описания тэгов для метасправочника
    /// </summary>
    public class MetaDictionaryTagInfo
    {
        public MetaDictionaryTagInfo(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
