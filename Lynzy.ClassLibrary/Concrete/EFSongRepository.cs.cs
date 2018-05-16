using System;
using System.Collections.Generic;
using Lynzy.Domain.Abstract;
using Lynzy.Domain.Entities;

namespace Lynzy.Domain.Concrete
{
    public class EFSongRepository : ISongRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<SongFiles> Song
        {
            get { return context.Song; }
        }
    }
}
