// <fileinfo name="tblInvoice_DetailRow_Base.cs">
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
	/// The base class for <see cref="tblInvoice_DetailRow"/> that 
	/// represents a record in the <c>tblInvoice_Detail</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblInvoice_DetailRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblInvoice_DetailRow_Base
	{
		private int _invoice_Det_Id;
		private int _invoice_Id;
		private int _item_Id;
		private int _price;
		private int _quantity;
		private int _total;
		private int _gL_Act_Id;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblInvoice_DetailRow_Base"/> class.
		/// </summary>
		public tblInvoice_DetailRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Invoice_Det_Id</c> column value.
		/// </summary>
		/// <value>The <c>Invoice_Det_Id</c> column value.</value>
		public int Invoice_Det_Id
		{
			get { return _invoice_Det_Id; }
			set { _invoice_Det_Id = value; }
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
		/// Gets or sets the <c>Item_Id</c> column value.
		/// </summary>
		/// <value>The <c>Item_Id</c> column value.</value>
		public int Item_Id
		{
			get { return _item_Id; }
			set { _item_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Price</c> column value.
		/// </summary>
		/// <value>The <c>Price</c> column value.</value>
		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Quantity</c> column value.
		/// </summary>
		/// <value>The <c>Quantity</c> column value.</value>
		public int Quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Total</c> column value.
		/// </summary>
		/// <value>The <c>Total</c> column value.</value>
		public int Total
		{
			get { return _total; }
			set { _total = value; }
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
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Invoice_Det_Id=");
			dynStr.Append(Invoice_Det_Id);
			dynStr.Append("  Invoice_Id=");
			dynStr.Append(Invoice_Id);
			dynStr.Append("  Item_Id=");
			dynStr.Append(Item_Id);
			dynStr.Append("  Price=");
			dynStr.Append(Price);
			dynStr.Append("  Quantity=");
			dynStr.Append(Quantity);
			dynStr.Append("  Total=");
			dynStr.Append(Total);
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(GL_Act_Id);
			return dynStr.ToString();
		}
	} // End of tblInvoice_DetailRow_Base class
} // End of namespace
