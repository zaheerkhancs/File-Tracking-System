// <fileinfo name="tblCurrencyRow_Base.cs">
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
	/// The base class for <see cref="tblCurrencyRow"/> that 
	/// represents a record in the <c>tblCurrency</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblCurrencyRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblCurrencyRow_Base
	{
		private int _currency_Id;
		private string _currency_Name;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblCurrencyRow_Base"/> class.
		/// </summary>
		public tblCurrencyRow_Base()
		{
			// EMPTY
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
		/// Gets or sets the <c>Currency_Name</c> column value.
		/// </summary>
		/// <value>The <c>Currency_Name</c> column value.</value>
		public string Currency_Name
		{
			get { return _currency_Name; }
			set { _currency_Name = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Currency_Id=");
			dynStr.Append(Currency_Id);
			dynStr.Append("  Currency_Name=");
			dynStr.Append(Currency_Name);
			return dynStr.ToString();
		}
	} // End of tblCurrencyRow_Base class
} // End of namespace
