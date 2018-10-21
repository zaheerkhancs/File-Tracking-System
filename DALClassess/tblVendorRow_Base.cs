// <fileinfo name="tblVendorRow_Base.cs">
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
	/// The base class for <see cref="tblVendorRow"/> that 
	/// represents a record in the <c>tblVendor</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblVendorRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblVendorRow_Base
	{
		private int _vendor_Id;
		private string _vendor_Name;
		private string _address;
		private int _contact_No;
		private bool _contact_NoNull = true;
		private string _email;
		private int _country;
		private bool _countryNull = true;
		private int _vendor_Type_Id;
		private bool _status;
		private int _currency_Id;
		private bool _currency_IdNull = true;
		private int _gL_Act_Id;
		private bool _gL_Act_IdNull = true;
		private int _created_By;
		private bool _created_ByNull = true;
		private System.DateTime _created_Time;
		private bool _created_TimeNull = true;
		private int _updated_By;
		private bool _updated_ByNull = true;
		private System.DateTime _updated_Time;
		private bool _updated_TimeNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblVendorRow_Base"/> class.
		/// </summary>
		public tblVendorRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Vendor_Id</c> column value.
		/// </summary>
		/// <value>The <c>Vendor_Id</c> column value.</value>
		public int Vendor_Id
		{
			get { return _vendor_Id; }
			set { _vendor_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Vendor_Name</c> column value.
		/// </summary>
		/// <value>The <c>Vendor_Name</c> column value.</value>
		public string Vendor_Name
		{
			get { return _vendor_Name; }
			set { _vendor_Name = value; }
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
		/// Gets or sets the <c>Contact_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Contact_No</c> column value.</value>
		public int Contact_No
		{
			get
			{
				if(IsContact_NoNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _contact_No;
			}
			set
			{
				_contact_NoNull = false;
				_contact_No = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Contact_No"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsContact_NoNull
		{
			get { return _contact_NoNull; }
			set { _contact_NoNull = value; }
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
		/// Gets or sets the <c>Country</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Country</c> column value.</value>
		public int Country
		{
			get
			{
				if(IsCountryNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _country;
			}
			set
			{
				_countryNull = false;
				_country = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Country"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCountryNull
		{
			get { return _countryNull; }
			set { _countryNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Vendor_Type_Id</c> column value.
		/// </summary>
		/// <value>The <c>Vendor_Type_Id</c> column value.</value>
		public int Vendor_Type_Id
		{
			get { return _vendor_Type_Id; }
			set { _vendor_Type_Id = value; }
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
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Currency_Id</c> column value.</value>
		public int Currency_Id
		{
			get
			{
				if(IsCurrency_IdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _currency_Id;
			}
			set
			{
				_currency_IdNull = false;
				_currency_Id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Currency_Id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCurrency_IdNull
		{
			get { return _currency_IdNull; }
			set { _currency_IdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GL_Act_Id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>GL_Act_Id</c> column value.</value>
		public int GL_Act_Id
		{
			get
			{
				if(IsGL_Act_IdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _gL_Act_Id;
			}
			set
			{
				_gL_Act_IdNull = false;
				_gL_Act_Id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="GL_Act_Id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsGL_Act_IdNull
		{
			get { return _gL_Act_IdNull; }
			set { _gL_Act_IdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_By</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Created_By</c> column value.</value>
		public int Created_By
		{
			get
			{
				if(IsCreated_ByNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _created_By;
			}
			set
			{
				_created_ByNull = false;
				_created_By = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Created_By"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCreated_ByNull
		{
			get { return _created_ByNull; }
			set { _created_ByNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Created_Time</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Created_Time</c> column value.</value>
		public System.DateTime Created_Time
		{
			get
			{
				if(IsCreated_TimeNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _created_Time;
			}
			set
			{
				_created_TimeNull = false;
				_created_Time = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Created_Time"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCreated_TimeNull
		{
			get { return _created_TimeNull; }
			set { _created_TimeNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Updated_By</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Updated_By</c> column value.</value>
		public int Updated_By
		{
			get
			{
				if(IsUpdated_ByNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _updated_By;
			}
			set
			{
				_updated_ByNull = false;
				_updated_By = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Updated_By"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsUpdated_ByNull
		{
			get { return _updated_ByNull; }
			set { _updated_ByNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Updated_Time</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Updated_Time</c> column value.</value>
		public System.DateTime Updated_Time
		{
			get
			{
				if(IsUpdated_TimeNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _updated_Time;
			}
			set
			{
				_updated_TimeNull = false;
				_updated_Time = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Updated_Time"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsUpdated_TimeNull
		{
			get { return _updated_TimeNull; }
			set { _updated_TimeNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Vendor_Id=");
			dynStr.Append(Vendor_Id);
			dynStr.Append("  Vendor_Name=");
			dynStr.Append(Vendor_Name);
			dynStr.Append("  Address=");
			dynStr.Append(Address);
			dynStr.Append("  Contact_No=");
			dynStr.Append(IsContact_NoNull ? (object)"<NULL>" : Contact_No);
			dynStr.Append("  Email=");
			dynStr.Append(Email);
			dynStr.Append("  Country=");
			dynStr.Append(IsCountryNull ? (object)"<NULL>" : Country);
			dynStr.Append("  Vendor_Type_Id=");
			dynStr.Append(Vendor_Type_Id);
			dynStr.Append("  Status=");
			dynStr.Append(Status);
			dynStr.Append("  Currency_Id=");
			dynStr.Append(IsCurrency_IdNull ? (object)"<NULL>" : Currency_Id);
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(IsGL_Act_IdNull ? (object)"<NULL>" : GL_Act_Id);
			dynStr.Append("  Created_By=");
			dynStr.Append(IsCreated_ByNull ? (object)"<NULL>" : Created_By);
			dynStr.Append("  Created_Time=");
			dynStr.Append(IsCreated_TimeNull ? (object)"<NULL>" : Created_Time);
			dynStr.Append("  Updated_By=");
			dynStr.Append(IsUpdated_ByNull ? (object)"<NULL>" : Updated_By);
			dynStr.Append("  Updated_Time=");
			dynStr.Append(IsUpdated_TimeNull ? (object)"<NULL>" : Updated_Time);
			return dynStr.ToString();
		}
	} // End of tblVendorRow_Base class
} // End of namespace
