using BizManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizManagementInterface
{
	public interface IEntityService
	{
		Task<List<Entity>> GetEntityAsync();
		void AddEntityAsync();
	}
}
