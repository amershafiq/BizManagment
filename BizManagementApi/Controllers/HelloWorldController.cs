using BizManagementInterface;
using BizManagementModel;
using StructureMap.Attributes;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace BizManagementApi.Controllers
{

	public class EntityController : ApiController
	{
		[SetterProperty]
		public IEntityService EntityService { get; set; }

		public EntityController()
		{
			
		}
		[HttpGet()]
		public async Task<IHttpActionResult> Get()
		{
			try
			{						
				List<Entity> entity = (await EntityService.GetEntityAsync());
				if (entity == null || entity.Count == 0)
				{
					var message = string.Format("Not found");
					return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.NotFound, message));
				}
				else
				{

					return Ok(entity);
				}
			}
			catch (Exception e)
			{
				return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message));
			}
		}

		[HttpPost()]
		public async Task<IHttpActionResult> Post(Entity entity)
		{
			// TODO imlementation
			return await Task.FromResult(Ok("Success"));
		}

		[HttpPut()]
		public async Task<IHttpActionResult> Put(int id, Entity entity)
		{
			// TODO imlementation
			return await Task.FromResult(Ok("Success"));
		}

		[HttpDelete()]
		public async Task<IHttpActionResult> Delete(int id)
		{
			// TODO imlementation
			return await Task.FromResult(Ok("Success"));
		}



	}
}