using Application.Repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public static class RepositoryFactory
    {
        public static LunchRepository GetLunchRepository() => new LunchRepository();       
    }
}
