// <fileinfo name="tblFundRow_Base.cs">
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
	/// The base class for <see cref="tblFundRow"/> that 
	/// represents a record in the <c>tblFund</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblFundRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblFundRow_Base
	{
		private int _fund_Id;
		private System.DateTime _receipt_Date;
		private string _receiptNo;
		private string _reference;
		private int _donor_Id;
		private int _amount;
		private int _gL_Act_Id;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblFundRow_Base"/> class.
		/// </summary>
		public tblFundRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Fund_Id</c> column value.
		/// </summary>
		/// <value>The <c>Fund_Id</c> column value.</value>
		public int Fund_Id
		{
			get { return _fund_Id; }
			set { _fund_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Receipt_Date</c> column value.
		/// </summary>
		/// <value>The <c>Receipt_Date</c> column value.</value>
		public System.DateTime Receipt_Date
		{
			get { return _receipt_Date; }
			set { _receipt_Date = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ReceiptNo</c> column value.
		/// </summary>
		/// <value>The <c>ReceiptNo</c> column value.</value>
		public string ReceiptNo
		{
			get { return _receiptNo; }
			set { _receiptNo = value; }
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
		/// Gets or sets the <c>Donor_Id</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Id</c> column value.</value>
		public int Donor_Id
		{
			get { return _donor_Id; }
			set { _donor_Id = value; }
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
			dynStr.Append("  Fund_Id=");
			dynStr.Append(Fund_Id);
			dynStr.Append("  Receipt_Date=");
			dynStr.Append(Receipt_Date);
			dynStr.Append("  ReceiptNo=");
			dynStr.Append(ReceiptNo);
			dynStr.Append("  Reference=");
			dynStr.Append(Reference);
			dynStr.Append("  Donor_Id=");
			dynStr.Append(Donor_Id);
			dynStr.Append("  Amount=");
			dynStr.Append(Amount);
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
	} // End of tblFundRow_Base class
} // End of namespace
