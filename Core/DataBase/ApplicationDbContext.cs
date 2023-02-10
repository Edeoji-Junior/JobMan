using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataBase
{
	public class ApplicationDbContext:IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{

		}
		public DbSet<ApplicationUser> ApplicationUser { get; set; }
		public DbSet<State> States { get; set; }
		public DbSet<Country> Country { get; set; }
		public DbSet<Userverification> userverifications { get; set; }
		public DbSet<Category> Categorys { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Support> Supports { get; set; }
		public DbSet<CommonDropDown> CommonDropDowns { get; set; }
	}
}
