using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizManagementConsole
{
	public interface IOperation
	{
		string Read();
		void Write(string value);
	}
}
