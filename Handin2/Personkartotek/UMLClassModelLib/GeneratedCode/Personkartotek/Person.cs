﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Personkartotek
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Person
	{
		public virtual string FirstName
		{
			get;
			set;
		}

		public virtual string MiddelName
		{
			get;
			set;
		}

		public virtual string LastName
		{
			get;
			set;
		}

		public virtual int PersonId
		{
			get;
			set;
		}

		public virtual string Relation
		{
			get;
			set;
		}

		public virtual IEnumerable<Phone> PersonPhones
		{
			get;
			set;
		}

		public virtual IEnumerable<AddressElement> AlternativeAddress
		{
			get;
			set;
		}

		public virtual Address CivilRefistryAddress
		{
			get;
			set;
		}

	}
}

