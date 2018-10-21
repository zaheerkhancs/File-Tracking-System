// <fileinfo name="tblExchange_RateRow_Base.cs">
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
	/// The base class for <see cref="tblExchange_RateRow"/> that 
	/// represents a record in the <c>tblExchange_Rate</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblExchange_RateRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblExchange_RateRow_Base
	{
		private int _id;
		private System.DateTime _exchange_Date;
		private int _currency_Id;
		private int _exchange_Rate;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblExchange_RateRow_Base"/> class.
		/// </summary>
		public tblExchange_RateRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ID</c> column value.
		/// </summary>
		/// <value>The <c>ID</c> column value.</value>
		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Exchange_Date</c> column value.
		/// </summary>
		/// <value>The <c>Exchange_Date</c> column value.</value>
		public System.DateTime Exchange_Date
		{
			get { return _exchange_Date; }
			set { _exchange_Date = value; }
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
		/// Gets or sets the <c>Exchange_Rate</c> column value.
		/// </summary>
		/// <value>The <c>Exchange_Rate</c> column value.</value>
		public int Exchange_Rate
		{
			get { return _exchange_Rate; }
			set { _exchange_Rate = value; }
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
			dynStr.Append("  ID=");
			dynStr.Append(ID);
			dynStr.Append("  Exchange_Date=");
			dynStr.Append(Exchange_Date);
			dynStr.Append("  Currency_Id=");
			dynStr.Append(Currency_Id);
			dynStr.Append("  Exchange_Rate=");
			dynStr.Append(Exchange_Rate);
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
	} // End of tblExchange_RateRow_Base class
} // End of namespace
