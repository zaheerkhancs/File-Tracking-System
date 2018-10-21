// <fileinfo name="tblDonorRow_Base.cs">
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
	/// The base class for <see cref="tblDonorRow"/> that 
	/// represents a record in the <c>tblDonor</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblDonorRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblDonorRow_Base
	{
		private int _donor_Id;
		private string _donor_Name;
		private string _address;
		private int _donor_Contact_Id;
		private bool _donor_Contact_IdNull = true;
		private string _contact_No;
		private string _email;
		private string _country_Id;
		private int _donor_Type_Id;
		private bool _status;
		private int _currency_Id;
		private int _gL_Act_Id;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblDonorRow_Base"/> class.
		/// </summary>
		public tblDonorRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Donor_Id</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Id</c> column value.</value>
		public int Donor_Id
		{
			get { return _donor_Id; }
			set { _donor_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Donor_Name</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Name</c> column value.</value>
		public string Donor_Name
		{
			get { return _donor_Name; }
			set { _donor_Name = value; }
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
		/// Gets or sets the <c>Donor_Contact_Id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Donor_Contact_Id</c> column value.</value>
		public int Donor_Contact_Id
		{
			get
			{
				if(IsDonor_Contact_IdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _donor_Contact_Id;
			}
			set
			{
				_donor_Contact_IdNull = false;
				_donor_Contact_Id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Donor_Contact_Id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDonor_Contact_IdNull
		{
			get { return _donor_Contact_IdNull; }
			set { _donor_Contact_IdNull = value; }
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
		/// Gets or sets the <c>Country_Id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Country_Id</c> column value.</value>
		public string Country_Id
		{
			get { return _country_Id; }
			set { _country_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Donor_Type_Id</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Type_Id</c> column value.</value>
		public int Donor_Type_Id
		{
			get { return _donor_Type_Id; }
			set { _donor_Type_Id = value; }
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
		/// Gets or sets the <c>Currency_Id</c> column value.
		/// </summary>
		/// <value>The <c>Currency_Id</c> column value.</value>
		public int Currency_Id
		{
			get { return _currency_Id; }
			set { _currency_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GL_Act_Id</c> column value.
		/// </summary>
		/// <value>The <c>GL_Act_Id</c> column value.</value>
		public int GL_Act_Id
		{
			get { return _gL_Act_Id; }
			set { _gL_Act_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_By</c> column value.
		/// </summary>
		/// <value>The <c>Created_By</c> column value.</value>
		public int Created_By
		{
			get { return _created_By; }
			set { _created_By = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_Time</c> column value.
		/// </summary>
		/// <value>The <c>Created_Time</c> column value.</value>
		public System.DateTime Created_Time
		{
			get { return _created_Time; }
			set { _created_Time = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Updated_By</c> column value.
		/// </summary>
		/// <value>The <c>Updated_By</c> column value.</value>
		public int Updated_By
		{
			get { return _updated_By; }
			set { _updated_By = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Updated_Time</c> column value.
		/// </summary>
		/// <value>The <c>Updated_Time</c> column value.</value>
		public System.DateTime Updated_Time
		{
			get { return _updated_Time; }
			set { _updated_Time = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Donor_Id=");
			dynStr.Append(Donor_Id);
			dynStr.Append("  Donor_Name=");
			dynStr.Append(Donor_Name);
			dynStr.Append("  Address=");
			dynStr.Append(Address);
			dynStr.Append("  Donor_Contact_Id=");
			dynStr.Append(IsDonor_Contact_IdNull ? (object)"<NULL>" : Donor_Contact_Id);
			dynStr.Append("  Contact_No=");
			dynStr.Append(Contact_No);
			dynStr.Append("  Email=");
			dynStr.Append(Email);
			dynStr.Append("  Country_Id=");
			dynStr.Append(Country_Id);
			dynStr.Append("  Donor_Type_Id=");
			dynStr.Append(Donor_Type_Id);
			dynStr.Append("  Status=");
			dynStr.Append(Status);
			dynStr.Append("  Currency_Id=");
			dynStr.Append(Currency_Id);
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(GL_Act_Id);
			dynStr.Append("  Created_By=");
			dynStr.Append(Created_By);
			dynStr.Append("  Created_Time=");
			dynStr.Append(Created_Time);
			dynStr.Append("  Updated_By=");
			dynStr.Append(Updated_By);
			dynStr.Append("  Updated_Time=");
			dynStr.Append(Updated_Time);
			return dynStr.ToString();
		}
	} // End of tblDonorRow_Base class
} // End of namespace
