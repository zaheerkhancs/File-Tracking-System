// <fileinfo name="tblDonor_TypeRow_Base.cs">
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
	/// The base class for <see cref="tblDonor_TypeRow"/> that 
	/// represents a record in the <c>tblDonor_Type</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblDonor_TypeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblDonor_TypeRow_Base
	{
		private int _donor_Type_Id;
		private string _donor_Type_Name;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblDonor_TypeRow_Base"/> class.
		/// </summary>
		public tblDonor_TypeRow_Base()
		{
			// EMPTY
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
		/// Gets or sets the <c>Donor_Type_Name</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Type_Name</c> column value.</value>
		public string Donor_Type_Name
		{
			get { return _donor_Type_Name; }
			set { _donor_Type_Name = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Donor_Type_Id=");
			dynStr.Append(Donor_Type_Id);
			dynStr.Append("  Donor_Type_Name=");
			dynStr.Append(Donor_Type_Name);
			return dynStr.ToString();
		}
	} // End of tblDonor_TypeRow_Base class
} // End of namespace
