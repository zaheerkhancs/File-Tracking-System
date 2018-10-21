// <fileinfo name="tblDonor_ContactRow_Base.cs">
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
	/// The base class for <see cref="tblDonor_ContactRow"/> that 
	/// represents a record in the <c>tblDonor_Contact</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblDonor_ContactRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblDonor_ContactRow_Base
	{
		private int _donor_Contact_Id;
		private string _contact_Name;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblDonor_ContactRow_Base"/> class.
		/// </summary>
		public tblDonor_ContactRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Donor_Contact_Id</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Contact_Id</c> column value.</value>
		public int Donor_Contact_Id
		{
			get { return _donor_Contact_Id; }
			set { _donor_Contact_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Contact_Name</c> column value.
		/// </summary>
		/// <value>The <c>Contact_Name</c> column value.</value>
		public string Contact_Name
		{
			get { return _contact_Name; }
			set { _contact_Name = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Donor_Contact_Id=");
			dynStr.Append(Donor_Contact_Id);
			dynStr.Append("  Contact_Name=");
			dynStr.Append(Contact_Name);
			return dynStr.ToString();
		}
	} // End of tblDonor_ContactRow_Base class
} // End of namespace
