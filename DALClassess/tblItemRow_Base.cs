// <fileinfo name="tblItemRow_Base.cs">
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
	/// The base class for <see cref="tblItemRow"/> that 
	/// represents a record in the <c>tblItem</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblItemRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblItemRow_Base
	{
		private int _item_Id;
		private string _item_Name;
		private int _item_Type_Id;
		private bool _status;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblItemRow_Base"/> class.
		/// </summary>
		public tblItemRow_Base()
		{
			// EMPTY
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
		/// Gets or sets the <c>Item_Name</c> column value.
		/// </summary>
		/// <value>The <c>Item_Name</c> column value.</value>
		public string Item_Name
		{
			get { return _item_Name; }
			set { _item_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Item_Type_Id</c> column value.
		/// </summary>
		/// <value>The <c>Item_Type_Id</c> column value.</value>
		public int Item_Type_Id
		{
			get { return _item_Type_Id; }
			set { _item_Type_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Status</c> column value.
		/// </summary>
		/// <value>The <c>Status</c> column value.</value>
		public bool Status
		{
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Item_Id=");
			dynStr.Append(Item_Id);
			dynStr.Append("  Item_Name=");
			dynStr.Append(Item_Name);
			dynStr.Append("  Item_Type_Id=");
			dynStr.Append(Item_Type_Id);
			dynStr.Append("  Status=");
			dynStr.Append(Status);
			return dynStr.ToString();
		}
	} // End of tblItemRow_Base class
} // End of namespace
