using System;
using BizManagementApi.Controllers;
using BizManagementInterface;
using BizManagementModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web;
using System.Web.Http;
using System.Net.Http;

namespace BizManagementTest
{
	[TestClass]
	public class EntityUnitTest
	{
		[TestMethod]
		public async void Get_Test()
		{
			// Arrange
			EntityController controller = new EntityController();
			Mock<IEntityService> service = new Mock<IEntityService>();
			controller.EntityService = service.Object;
			controller.Request = new HttpRequestMessage();
			controller.Configuration = new HttpConfiguration();

			// Act
			var response = await controller.Get();

			// Assert
			Entity entity;
			Assert.IsTrue((await response.ExecuteAsync(new System.Threading.CancellationToken())).TryGetContentValue<Entity>(out entity));
			Assert.AreEqual("Hello World", entity.Name);

		}
	}
}
