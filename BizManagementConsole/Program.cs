using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizManagementConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			IOperation dbOperation = new Database();
			String value = dbOperation.Read();
			dbOperation.Write("Hello World");

			IOperation consoleOperation = new Console();
			consoleOperation.Write("Hello World");
			string result = consoleOperation.Read();

		}
	}
}
