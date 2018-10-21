// <fileinfo name="tblPaymentRow_Base.cs">
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
	/// The base class for <see cref="tblPaymentRow"/> that 
	/// represents a record in the <c>tblPayment</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblPaymentRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblPaymentRow_Base
	{
		private int _payment_Id;
		private System.DateTime _payment_Date;
		private string _reference;
		private int _vendor_Id;
		private bool _vendor_IdNull = true;
		private bool _cashBank;
		private string _chequeNo;
		private int _payment_Type_Id;
		private int _invoice_Id;
		private bool _invoice_IdNull = true;
		private int _amount;
		private int _donor_Id;
		private int _gL_Act_Id;
		private int _currency_Id;
		private int _company_Id;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblPaymentRow_Base"/> class.
		/// </summary>
		public tblPaymentRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Payment_Id</c> column value.
		/// </summary>
		/// <value>The <c>Payment_Id</c> column value.</value>
		public int Payment_Id
		{
			get { return _payment_Id; }
			set { _payment_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Payment_Date</c> column value.
		/// </summary>
		/// <value>The <c>Payment_Date</c> column value.</value>
		public System.DateTime Payment_Date
		{
			get { return _payment_Date; }
			set { _payment_Date = value; }
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
		/// Gets or sets the <c>Vendor_Id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Vendor_Id</c> column value.</value>
		public int Vendor_Id
		{
			get
			{
				if(IsVendor_IdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _vendor_Id;
			}
			set
			{
				_vendor_IdNull = false;
				_vendor_Id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Vendor_Id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsVendor_IdNull
		{
			get { return _vendor_IdNull; }
			set { _vendor_IdNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CashBank</c> column value.
		/// </summary>
		/// <value>The <c>CashBank</c> column value.</value>
		public bool CashBank
		{
			get { return _cashBank; }
			set { _cashBank = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ChequeNo</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ChequeNo</c> column value.</value>
		public string ChequeNo
		{
			get { return _chequeNo; }
			set { _chequeNo = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Payment_Type_Id</c> column value.
		/// </summary>
		/// <value>The <c>Payment_Type_Id</c> column value.</value>
		public int Payment_Type_Id
		{
			get { return _payment_Type_Id; }
			set { _payment_Type_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Invoice_Id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Invoice_Id</c> column value.</value>
		public int Invoice_Id
		{
			get
			{
				if(IsInvoice_IdNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _invoice_Id;
			}
			set
			{
				_invoice_IdNull = false;
				_invoice_Id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Invoice_Id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsInvoice_IdNull
		{
			get { return _invoice_IdNull; }
			set { _invoice_IdNull = value; }
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
		/// Gets or sets the <c>Donor_Id</c> column value.
		/// </summary>
		/// <value>The <c>Donor_Id</c> column value.</value>
		public int Donor_Id
		{
			get { return _donor_Id; }
			set { _donor_Id = value; }
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
		/// Gets or sets the <c>Currency_Id</c> column value.
		/// </summary>
		/// <value>The <c>Currency_Id</c> column value.</value>
		public int Currency_Id
		{
			get { return _currency_Id; }
			set { _currency_Id = value; }
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
			dynStr.Append("  Payment_Id=");
			dynStr.Append(Payment_Id);
			dynStr.Append("  Payment_Date=");
			dynStr.Append(Payment_Date);
			dynStr.Append("  Reference=");
			dynStr.Append(Reference);
			dynStr.Append("  Vendor_Id=");
			dynStr.Append(IsVendor_IdNull ? (object)"<NULL>" : Vendor_Id);
			dynStr.Append("  CashBank=");
			dynStr.Append(CashBank);
			dynStr.Append("  ChequeNo=");
			dynStr.Append(ChequeNo);
			dynStr.Append("  Payment_Type_Id=");
			dynStr.Append(Payment_Type_Id);
			dynStr.Append("  Invoice_Id=");
			dynStr.Append(IsInvoice_IdNull ? (object)"<NULL>" : Invoice_Id);
			dynStr.Append("  Amount=");
			dynStr.Append(Amount);
			dynStr.Append("  Donor_Id=");
			dynStr.Append(Donor_Id);
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(GL_Act_Id);
			dynStr.Append("  Currency_Id=");
			dynStr.Append(Currency_Id);
			dynStr.Append("  Company_Id=");
			dynStr.Append(Company_Id);
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
	} // End of tblPaymentRow_Base class
} // End of namespace
