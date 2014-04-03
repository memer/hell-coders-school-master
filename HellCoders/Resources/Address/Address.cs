using HellCoders.Interface;

namespace HellCoders.Entity
{
	class Address : IAddress
	{
		public string street
		{
			get { return street; }
			set { street = value; }
		}

		public string city
		{
			get { return city; }
			set { city = value; }
		}

		public string zip
		{
			get { return zip; }
			set { zip = value; }
		}

		public string country
		{
			get { return country; }
			set { country = value; }
		}
		public string toString() { return street + ", " + zip + "  " + city + ", " + country; }
	}
}
