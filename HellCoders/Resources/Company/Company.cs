using HellCoders.Interface;
namespace HellCoders.Entity
{
	class Company : Interface.ICompany
	{
		public int id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public string name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public string ico
		{
			get { return this.ico; }
			set { this.ico = value; }
		}

		public string dic
		{
			get { return this.dic; }
			set { this.dic = value; }
		}

		public string icDph
		{
			get { return this.icDph; }
			set { this.icDph = value; }
		}

		public Interface.IPerson person
		{
			get { return this.person; }
			set { this.person = value; }
		}


		public Interface.IAddress address
		{
			get { return this.address; }
			set { this.address = value; }
		}

        public Interface.IContact contact
        {
            get { return this.contact; }
            set { this.contact = value; }
        }

		public CorporatePerson corporatePerson
		{
			get { return this.corporatePerson; }
			set { this.corporatePerson = value; }
		}


		public string custom_id
		{
			get { return this.custom_id; }
			set { this.custom_id = value; }
		}
	}
}
