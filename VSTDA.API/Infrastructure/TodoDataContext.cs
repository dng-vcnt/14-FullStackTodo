using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VSTDA.API.Infrastructure
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base("TodoDatabase")
        {

        }
        public IDbSet<Models.Todo> Todoes { get; set; }
    }
}