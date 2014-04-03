using System;
using HellCoders.Interface;

namespace HellCoders.Entity
{
	class Person : Interface.IPerson
	{
		public string firstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string lastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string titlePrefix
		{
			get { return titlePrefix; }
			set { titlePrefix = value; }
		}
		public string titleSuffix
		{
			get { return titleSuffix; }
			set { titleSuffix = value; }
		}

		public string getFullName()
		{
			string fullName = "";
			if (!string.IsNullOrEmpty(titlePrefix) && !string.IsNullOrWhiteSpace(titlePrefix))
				fullName += titlePrefix + ", ";

			if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
				throw new ArgumentNullException("Person first name can not be null, empty or whitespace");
			fullName += this.firstName;

			if (string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
				throw new ArgumentNullException("Person last name can not be null, empty or whitespace");
			fullName += " " + this.lastName;

			if (!string.IsNullOrEmpty(titleSuffix) && !string.IsNullOrWhiteSpace(titleSuffix))
				fullName += ", " + this.titleSuffix;

			return fullName;
		}
	}
}
