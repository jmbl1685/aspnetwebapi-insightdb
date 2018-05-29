using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
using Insight.Database;

namespace Application.Repository.impl
{
    public class LunchRepository : ILunchRepository
    {
        private ILunchRepository _repo = DBConnection.GetConnection().As<ILunchRepository>();

        public Lunch CreateLunch(Lunch lunch) => _repo.CreateLunch(lunch);
        public Lunch DeleteLunch(Guid lunchID) => _repo.DeleteLunch(lunchID);
        public Lunch GetByIdLunch(Guid lunchID) => _repo.GetByIdLunch(lunchID);
        public List<Lunch> GetLunch(int? PageNumber = 1, int? PageSize = 5) => _repo.GetLunch(PageNumber, PageSize);
        public Lunch UpdateLunch(Guid ID, Lunch lunch) => _repo.UpdateLunch(ID, lunch);

    }
}
