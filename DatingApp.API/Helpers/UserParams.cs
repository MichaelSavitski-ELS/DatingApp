using System;
using System.Collections.Generic;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int UserId { get; set; }
        public string GenderIdentity { get; set; }

        internal IIncludableQueryable<User, ICollection<Photo>> Where(object p)
        {
            throw new NotImplementedException();
        }
    }
}