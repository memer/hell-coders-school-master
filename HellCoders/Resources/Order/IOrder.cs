using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellCoders.Interface
{
	interface IOrder
	{
		int id { get; set; }
		string variableSymbol { get; set; }
		int numberInYear { get; set; }
		int day { get; set; }
		int month { get; set; }
		int year { get; set; }
		ICompany company { get; set; }
		string getFullDate();
		string getVariableSymbol();
	}
}
