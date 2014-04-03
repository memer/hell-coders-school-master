using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellCoders.Interface
{
	interface IAddress
	{
		string street { get; set; }
		string city { get; set; }
		string zip { get; set; }
		string country { get; set; }
	}
}
