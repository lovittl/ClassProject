using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lynzy.Domain;

namespace Lynzy.ClassLibrary.Abstract
{
    interface ISongRepository
    {
        IEnumerable<SongFiles> Song { get; }
    }
}
