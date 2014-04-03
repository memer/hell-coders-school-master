using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellCoders.Resources;
using HellCoders.Interface;

namespace HellCoders.Interface
{
	interface ICompany
	{
		int id { get; set; }
		string custom_id { get; set; }
		string name { get; set; }
		string ico { get; set; }
		string dic { get; set; }
		CorporatePerson corporatePerson { get; set; }
		string icDph { get; set; }
		Interface.IPerson person { get; set; }
		Interface.IAddress address { get; set; }
        Interface.IContact contact { get; set; }
	}
	enum CorporatePerson
	{
		PO,
		FO
	}
}
