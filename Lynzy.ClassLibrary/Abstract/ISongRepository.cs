using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lynzy.Domain;
using Lynzy.Domain.Entities;

namespace Lynzy.Domain.Abstract
{
    public interface ISongRepository
    {
        IEnumerable<SongFiles> Song { get; }
    }
}
