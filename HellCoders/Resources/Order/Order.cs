using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HellCoders.Interface;

namespace HellCoders.Entity
{
	class Order : IOrder
	{
		public int id
		{
			get { return id; }
			set { id = value; }
		}

		public string variableSymbol
		{
			get { return variableSymbol; }
			set { variableSymbol = value; }
		}

		public int day
		{
			get { return day; }
			set { day = value; }
		}

		public int month
		{
			get { return month; }
			set { month = value; }
		}

		public int year
		{
			get { return this.year; }
			set { this.year = value; }
		}


		public string getFullDate() { return this.year + "/" + this.month + "/" + this.day; }


		public int numberInYear
		{
			get { return this.numberInYear; }
			set { this.numberInYear = value; }
		}

		public string getVariableSymbol() { return this.numberInYear + "/" + this.variableSymbol; }


		public Interface.ICompany company
		{
			get { return this.company; }
			set { this.company = value; }
		}
	}
}
