using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Moose_Manor.Models
{
	public class People
	{
		public int ID { get; set; }
	}

	public class PeopleContext : DbContext
	{
		public DbSet<People> MooseManorDB { get; set; }
	}	
}