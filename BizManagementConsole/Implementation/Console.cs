using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizManagementConsole
{
	public class Console : IOperation
	{
		public string Read()
		{
			return System.Console.ReadLine();
		}

		public void Write(string value)
		{
			System.Console.WriteLine(value);
		}
	}
}
