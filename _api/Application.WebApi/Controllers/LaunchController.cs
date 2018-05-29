using Application.Entities;
using Application.Repository;
using Application.Repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Application.WebApi.Controllers
{
    [RoutePrefix("api")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LaunchController : ApiController
    {

        private static LunchRepository repository = RepositoryFactory.GetLunchRepository();

        [HttpPost, Route("launch")]
        public IHttpActionResult CreateLunch([FromBody]Lunch lunch) => Ok(repository.CreateLunch(lunch));
        
        [HttpDelete, Route("launch/{lunchID}")]
        public IHttpActionResult DeleteLunch(string lunchID) => Ok(repository.DeleteLunch(Guid.Parse(lunchID)));
        
        [HttpGet, Route("launch/{lunchID}")]
        public IHttpActionResult GetByIdLunch(string lunchID) => Ok(repository.GetByIdLunch(Guid.Parse(lunchID)));
        
        [HttpGet, Route("launch")]
        public IHttpActionResult GetLunch(int? PageNumber = 1, int? PageSize = 5) => Ok(repository.GetLunch(PageNumber, PageSize));
        
        [HttpPut, Route("launch/{ID}")]
        public IHttpActionResult UpdateLunch(string ID, [FromBody]Lunch lunch) => Ok(repository.UpdateLunch(Guid.Parse(ID), lunch));
        
    }
}
