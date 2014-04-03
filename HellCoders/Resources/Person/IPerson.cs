using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellCoders.Interface
{
	interface IPerson
	{
		string firstName { get; set; }
		string lastName { get; set; }
		string titlePrefix { get; set; }
		string titleSuffix { get; set; }
		string getFullName();
	}
}
