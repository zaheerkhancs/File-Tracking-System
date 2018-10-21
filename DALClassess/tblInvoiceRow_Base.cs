// <fileinfo name="tblInvoiceRow_Base.cs">
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
	/// The base class for <see cref="tblInvoiceRow"/> that 
	/// represents a record in the <c>tblInvoice</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblInvoiceRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblInvoiceRow_Base
	{
		private int _invoice_Id;
		private string _invoice_No;
		private System.DateTime _invoice_Date;
		private int _vendor_Id;
		private bool _vendor_IdNull = true;
		private string _reference;
		private string _purchase_No;
		private int _gross_Total;
		private int _discount;
		private int _net_Total;
		private int _donor_Id;
		private int _company_Id;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblInvoiceRow_Base"/> class.
		/// </summary>
		public tblInvoiceRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Invoice_Id</c> column value.
		/// </summary>
		/// <value>The <c>Invoice_Id</c> column value.</value>
		public int Invoice_Id
		{
			get { return _invoice_Id; }
			set { _invoice_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Invoice_No</c> column value.
		/// </summary>
		/// <value>The <c>Invoice_No</c> column value.</value>
		public string Invoice_No
		{
			get { return _invoice_No; }
			set { _invoice_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Invoice_Date</c> column value.
		/// </summary>
		/// <value>The <c>Invoice_Date</c> column value.</value>
		public System.DateTime Invoice_Date
		{
			get { return _invoice_Date; }
			set { _invoice_Date = value; }
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
		/// Gets or sets the <c>Purchase_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Purchase_No</c> column value.</value>
		public string Purchase_No
		{
			get { return _purchase_No; }
			set { _purchase_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Gross_Total</c> column value.
		/// </summary>
		/// <value>The <c>Gross_Total</c> column value.</value>
		public int Gross_Total
		{
			get { return _gross_Total; }
			set { _gross_Total = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Discount</c> column value.
		/// </summary>
		/// <value>The <c>Discount</c> column value.</value>
		public int Discount
		{
			get { return _discount; }
			set { _discount = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Net_Total</c> column value.
		/// </summary>
		/// <value>The <c>Net_Total</c> column value.</value>
		public int Net_Total
		{
			get { return _net_Total; }
			set { _net_Total = value; }
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
			dynStr.Append("  Invoice_Id=");
			dynStr.Append(Invoice_Id);
			dynStr.Append("  Invoice_No=");
			dynStr.Append(Invoice_No);
			dynStr.Append("  Invoice_Date=");
			dynStr.Append(Invoice_Date);
			dynStr.Append("  Vendor_Id=");
			dynStr.Append(IsVendor_IdNull ? (object)"<NULL>" : Vendor_Id);
			dynStr.Append("  Reference=");
			dynStr.Append(Reference);
			dynStr.Append("  Purchase_No=");
			dynStr.Append(Purchase_No);
			dynStr.Append("  Gross_Total=");
			dynStr.Append(Gross_Total);
			dynStr.Append("  Discount=");
			dynStr.Append(Discount);
			dynStr.Append("  Net_Total=");
			dynStr.Append(Net_Total);
			dynStr.Append("  Donor_Id=");
			dynStr.Append(Donor_Id);
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
	} // End of tblInvoiceRow_Base class
} // End of namespace
