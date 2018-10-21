// <fileinfo name="tblcompanyRow_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;

namespace IOM.IECFMS.DAL
{
	/// <summary>
	/// The base class for <see cref="tblcompanyRow"/> that 
	/// represents a record in the <c>tblcompany</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblcompanyRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblcompanyRow_Base
	{
		private int _company_Id;
		private string _company_Name;
		private string _address;
		private string _contact_Person;
		private string _contact_No;
		private string _email;
		private bool _status;
		private bool _isDeleted;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblcompanyRow_Base"/> class.
		/// </summary>
		public tblcompanyRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Company_Id</c> column value.
		/// </summary>
		/// <value>The <c>Company_Id</c> column value.</value>
		public int Company_Id
		{
			get { return _company_Id; }
			set { _company_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Company_Name</c> column value.
		/// </summary>
		/// <value>The <c>Company_Name</c> column value.</value>
		public string Company_Name
		{
			get { return _company_Name; }
			set { _company_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Address</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Address</c> column value.</value>
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contact_Person</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact_Person</c> column value.</value>
		public string Contact_Person
		{
			get { return _contact_Person; }
			set { _contact_Person = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contact_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact_No</c> column value.</value>
		public string Contact_No
		{
			get { return _contact_No; }
			set { _contact_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
		public bool Status
		{
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Gets or sets the <c>isDeleted</c> column value.
		/// </summary>
		/// <value>The <c>isDeleted</c> column value.</value>
		public bool IsDeleted
		{
			get { return _isDeleted; }
			set { _isDeleted = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Company_Id=");
			dynStr.Append(Company_Id);
			dynStr.Append("  Company_Name=");
			dynStr.Append(Company_Name);
			dynStr.Append("  Address=");
			dynStr.Append(Address);
			dynStr.Append("  Contact_Person=");
			dynStr.Append(Contact_Person);
			dynStr.Append("  Contact_No=");
			dynStr.Append(Contact_No);
			dynStr.Append("  Email=");
			dynStr.Append(Email);
			dynStr.Append("  Status=");
			dynStr.Append(Status);
			dynStr.Append("  IsDeleted=");
			dynStr.Append(IsDeleted);
			return dynStr.ToString();
		}
	} // End of tblcompanyRow_Base class
} // End of namespace
