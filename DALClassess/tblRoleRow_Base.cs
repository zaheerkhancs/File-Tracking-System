// <fileinfo name="tblRoleRow_Base.cs">
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
	/// The base class for <see cref="tblRoleRow"/> that 
	/// represents a record in the <c>tblRole</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblRoleRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblRoleRow_Base
	{
		private int _role_Id;
		private string _role;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblRoleRow_Base"/> class.
		/// </summary>
		public tblRoleRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Role_Id</c> column value.
		/// </summary>
		/// <value>The <c>Role_Id</c> column value.</value>
		public int Role_Id
		{
			get { return _role_Id; }
			set { _role_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Role</c> column value.
		/// </summary>
		/// <value>The <c>Role</c> column value.</value>
		public string Role
		{
			get { return _role; }
			set { _role = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Role_Id=");
			dynStr.Append(Role_Id);
			dynStr.Append("  Role=");
			dynStr.Append(Role);
			return dynStr.ToString();
		}
	} // End of tblRoleRow_Base class
} // End of namespace
