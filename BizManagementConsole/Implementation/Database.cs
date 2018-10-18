using System;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace BizManagementConsole
{
	public class Database : IOperation
	{
		public IRestClient Client { get; set; }

		public string Read()
		{
			var client = new RestClient("http://localhost:2106");
			var request = new RestRequest("api/Entity/", Method.GET);
			var queryResult = client.Execute<List<Entity>>(request).Data.FirstOrDefault();
			return queryResult.Name;
		}

		public void Write(string value)
		{
			var client = new RestClient("http://localhost:2106");
			var request = new RestRequest("api/Entity/", Method.POST);
			request.RequestFormat = DataFormat.Json;
			request.AddBody(new Entity
			{
				Name = "Hello World"
			});
			client.Execute(request);

		}
	}
}
