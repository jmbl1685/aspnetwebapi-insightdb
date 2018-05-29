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
        public Lunch CreateLunch(Lunch lunch) =>_repo.CreateLunch(lunch);
        
        public Lunch DeleteLunch(Guid lunchID)
        {
            throw new NotImplementedException();
        }

        public Lunch GetByIdLunch(Lunch body)
        {
            throw new NotImplementedException();
        }

        public List<Lunch> GetLunch(Lunch body)
        {
            throw new NotImplementedException();
        }

        public Lunch UpdateLunch(Guid lunchID, Lunch lunch)
        {
            throw new NotImplementedException();
        }
    }
}
