// <fileinfo name="tblVendor_TypeRow_Base.cs">
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
	/// The base class for <see cref="tblVendor_TypeRow"/> that 
	/// represents a record in the <c>tblVendor_Type</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblVendor_TypeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblVendor_TypeRow_Base
	{
		private int _vendor_Type_Id;
		private string _type_Name;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblVendor_TypeRow_Base"/> class.
		/// </summary>
		public tblVendor_TypeRow_Base()
		{
			// EMPTY
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
		/// Gets or sets the <c>Type_Name</c> column value.
		/// </summary>
		/// <value>The <c>Type_Name</c> column value.</value>
		public string Type_Name
		{
			get { return _type_Name; }
			set { _type_Name = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Vendor_Type_Id=");
			dynStr.Append(Vendor_Type_Id);
			dynStr.Append("  Type_Name=");
			dynStr.Append(Type_Name);
			return dynStr.ToString();
		}
	} // End of tblVendor_TypeRow_Base class
} // End of namespace
