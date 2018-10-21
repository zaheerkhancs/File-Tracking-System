// <fileinfo name="tblGeneral_JournalRow_Base.cs">
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
	/// The base class for <see cref="tblGeneral_JournalRow"/> that 
	/// represents a record in the <c>tblGeneral_Journal</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblGeneral_JournalRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblGeneral_JournalRow_Base
	{
		private int _gL_Id;
		private System.DateTime _gL_Date;
		private string _reference;
		private int _gL_Act_Id;
		private int _debit;
		private int _credit;
		private int _donor_Id;
		private int _company_Id;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblGeneral_JournalRow_Base"/> class.
		/// </summary>
		public tblGeneral_JournalRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>GL_Id</c> column value.
		/// </summary>
		/// <value>The <c>GL_Id</c> column value.</value>
		public int GL_Id
		{
			get { return _gL_Id; }
			set { _gL_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GL_Date</c> column value.
		/// </summary>
		/// <value>The <c>GL_Date</c> column value.</value>
		public System.DateTime GL_Date
		{
			get { return _gL_Date; }
			set { _gL_Date = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Reference</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Reference</c> column value.</value>
		public string Reference
		{
			get { return _reference; }
			set { _reference = value; }
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
		/// Gets or sets the <c>Debit</c> column value.
		/// </summary>
		/// <value>The <c>Debit</c> column value.</value>
		public int Debit
		{
			get { return _debit; }
			set { _debit = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Credit</c> column value.
		/// </summary>
		/// <value>The <c>Credit</c> column value.</value>
		public int Credit
		{
			get { return _credit; }
			set { _credit = value; }
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
		/// Gets or sets the <c>Company_Id</c> column value.
		/// </summary>
		/// <value>The <c>Company_Id</c> column value.</value>
		public int Company_Id
		{
			get { return _company_Id; }
			set { _company_Id = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  GL_Id=");
			dynStr.Append(GL_Id);
			dynStr.Append("  GL_Date=");
			dynStr.Append(GL_Date);
			dynStr.Append("  Reference=");
			dynStr.Append(Reference);
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(GL_Act_Id);
			dynStr.Append("  Debit=");
			dynStr.Append(Debit);
			dynStr.Append("  Credit=");
			dynStr.Append(Credit);
			dynStr.Append("  Donor_Id=");
			dynStr.Append(Donor_Id);
			dynStr.Append("  Company_Id=");
			dynStr.Append(Company_Id);
			return dynStr.ToString();
		}
	} // End of tblGeneral_JournalRow_Base class
} // End of namespace
