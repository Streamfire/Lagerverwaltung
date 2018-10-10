using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Core.Interfaces
{
    interface IBasic //: IEnumerable<IBasic>, IEnumerator<IBasic>, IComparable<IBasic>
    {
        float Height { get; set; }
        float Width { get; set; }
        float Length { get; set; }
    }
}
