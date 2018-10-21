// <fileinfo name="tblItem_TypeRow_Base.cs">
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
	/// The base class for <see cref="tblItem_TypeRow"/> that 
	/// represents a record in the <c>tblItem_Type</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblItem_TypeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblItem_TypeRow_Base
	{
		private int _item_Type_Id;
		private string _item_Type_Name;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblItem_TypeRow_Base"/> class.
		/// </summary>
		public tblItem_TypeRow_Base()
		{
			// EMPTY
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
		/// Gets or sets the <c>Item_Type_Name</c> column value.
		/// </summary>
		/// <value>The <c>Item_Type_Name</c> column value.</value>
		public string Item_Type_Name
		{
			get { return _item_Type_Name; }
			set { _item_Type_Name = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Item_Type_Id=");
			dynStr.Append(Item_Type_Id);
			dynStr.Append("  Item_Type_Name=");
			dynStr.Append(Item_Type_Name);
			return dynStr.ToString();
		}
	} // End of tblItem_TypeRow_Base class
} // End of namespace
