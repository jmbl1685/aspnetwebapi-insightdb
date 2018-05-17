using Application.Entities;
using Insight.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface ILunchRepository
    {
        [Sql("SP_CREATE_LUNCH", CommandType.StoredProcedure)]
        Lunch CreateLunch (Lunch lunch);

        [Sql("SP_DELETE_LUNCH", CommandType.StoredProcedure)]
        Lunch DeleteLunch (Guid lunchID);

        [Sql("SP_UPDATE_LUNCH", CommandType.StoredProcedure)]
        Lunch UpdateLunch (Guid lunchID, Lunch lunch);

        [Sql("SP_GETBYID_LUNCH", CommandType.StoredProcedure)]
        Lunch GetByIdLunch (Lunch body);

        [Sql("SP_GET_LUNCH", CommandType.StoredProcedure)]
        List<Lunch> GetLunch (Lunch body);
    }
}
