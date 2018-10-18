using BizManagementModel;
using System.Collections.Generic;
using System.Data.Entity;

namespace BizManagementRepository
{
	class BizManagementContext: DbContext
	{
		//public DbSet<HelloWorld> DbHelloWorld { get; set; }
		public List<Entity> HelloWorld { get; set; } = new List<Entity>();


		public BizManagementContext()
			: base(System.Configuration.ConfigurationManager.ConnectionStrings["dev"].ConnectionString)
		{

			this.Configuration.ProxyCreationEnabled = false;
		}
	}
}
