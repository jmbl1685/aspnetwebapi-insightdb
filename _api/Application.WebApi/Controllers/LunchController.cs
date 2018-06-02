using Application.Entities;
using Application.Repository;
using Application.Repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Application.WebApi.Controllers
{
    [RoutePrefix("api")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LunchController : ApiController
    {

         private static LunchRepository repository = RepositoryFactory.GetLunchRepository();

        [HttpGet, Route("lunch")]
        public async Task<IHttpActionResult> GetLunch(int? PageNumber = 1, int? PageSize = 5)
            => Ok(await repository.GetLunch(PageNumber, PageSize));

        [HttpPost, Route("lunch")]
        public async Task<IHttpActionResult> CreateLunch([FromBody]Lunch lunch)
            => Ok(await repository.CreateLunch(lunch));

        [HttpDelete, Route("lunch/{lunchID}")]
        public async Task<IHttpActionResult> DeleteLunch(string lunchID)
            => Ok(await repository.DeleteLunch(Guid.Parse(lunchID)));

        [HttpGet, Route("lunch/{lunchID}")]
        public async Task<IHttpActionResult> GetByIdLunch(string lunchID)
            => Ok(await repository.GetByIdLunch(Guid.Parse(lunchID)));

        [HttpPut, Route("lunch/{ID}")]
        public async Task<IHttpActionResult> UpdateLunch(string ID, [FromBody]Lunch lunch)
            => Ok(await repository.UpdateLunch(Guid.Parse(ID), lunch));

    }
}
