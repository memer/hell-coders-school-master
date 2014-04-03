using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellCoders.Resources.Contact
{
	class Contact : IContanct
	{
		public string email
		{
			get { return email; }
			set { email = value; }
		}

		public string mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		public string phone
		{
			get { return phone; }
			set { phone = value; }
		}

		public string fax
		{
			get { return fax; }
			set { fax = value; }
		}
	}
}
