using BizManagementInterface;
using BizManagementModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace BizManagementRepository
{

	public class EntityRespository : IEntityService
	{
		public async Task<List<Entity>> GetEntityAsync()
		{
			using (BizManagementContext context = new BizManagementContext())
			{
				context.HelloWorld.Add(new Entity { Name = "Hello Word" });
				return await Task.FromResult(context.HelloWorld);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public void AddEntityAsync()
		{		


		}


	}


}
