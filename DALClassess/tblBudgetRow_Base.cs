// <fileinfo name="tblBudgetRow_Base.cs">
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
	/// The base class for <see cref="tblBudgetRow"/> that 
	/// represents a record in the <c>tblBudget</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblBudgetRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblBudgetRow_Base
	{
		private int _budget_Id;
		private System.DateTime _year;
		private int _gL_Act_Id;
		private int _amount;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblBudgetRow_Base"/> class.
		/// </summary>
		public tblBudgetRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Budget_Id</c> column value.
		/// </summary>
		/// <value>The <c>Budget_Id</c> column value.</value>
		public int Budget_Id
		{
			get { return _budget_Id; }
			set { _budget_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Year</c> column value.
		/// </summary>
		/// <value>The <c>Year</c> column value.</value>
		public System.DateTime Year
		{
			get { return _year; }
			set { _year = value; }
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
		/// Gets or sets the <c>Amount</c> column value.
		/// </summary>
		/// <value>The <c>Amount</c> column value.</value>
		public int Amount
		{
			get { return _amount; }
			set { _amount = value; }
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
		/// Gets or sets the <c>Updated_time</c> column value.
		/// </summary>
		/// <value>The <c>Updated_time</c> column value.</value>
		public System.DateTime Updated_time
		{
			get { return _updated_time; }
			set { _updated_time = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Budget_Id=");
			dynStr.Append(Budget_Id);
			dynStr.Append("  Year=");
			dynStr.Append(Year);
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(GL_Act_Id);
			dynStr.Append("  Amount=");
			dynStr.Append(Amount);
			dynStr.Append("  Created_By=");
			dynStr.Append(Created_By);
			dynStr.Append("  Created_Time=");
			dynStr.Append(Created_Time);
			dynStr.Append("  Updated_By=");
			dynStr.Append(Updated_By);
			dynStr.Append("  Updated_time=");
			dynStr.Append(Updated_time);
			return dynStr.ToString();
		}
	} // End of tblBudgetRow_Base class
} // End of namespace
