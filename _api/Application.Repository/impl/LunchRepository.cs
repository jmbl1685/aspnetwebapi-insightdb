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

        public async Task<Lunch> CreateLunch(Lunch lunch) => await _repo.CreateLunch(lunch);
        public async Task<Lunch> DeleteLunch(Guid lunchID) => await _repo.DeleteLunch(lunchID);
        public async Task<Lunch> GetByIdLunch(Guid lunchID) => await _repo.GetByIdLunch(lunchID);
        public async Task<List<Lunch>> GetLunch(int? PageNumber = 1, int? PageSize = 5) => await _repo.GetLunch(PageNumber, PageSize);
        public async Task<Lunch> UpdateLunch(Guid ID, Lunch lunch) => await _repo.UpdateLunch(ID, lunch);

    }
}
