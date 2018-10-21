// <fileinfo name="tblUsersRow_Base.cs">
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
	/// The base class for <see cref="tblUsersRow"/> that 
	/// represents a record in the <c>tblUsers</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblUsersRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblUsersRow_Base
	{
		private int _user_Id;
		private string _userName;
		private string _fullName;
		private string _password;
		private string _email;
		private int _role_Id;
		private bool _isDeleted;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblUsersRow_Base"/> class.
		/// </summary>
		public tblUsersRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>User_Id</c> column value.
		/// </summary>
		/// <value>The <c>User_Id</c> column value.</value>
		public int User_Id
		{
			get { return _user_Id; }
			set { _user_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserName</c> column value.
		/// </summary>
		/// <value>The <c>UserName</c> column value.</value>
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>FullName</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>FullName</c> column value.</value>
		public string FullName
		{
			get { return _fullName; }
			set { _fullName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Password</c> column value.
		/// </summary>
		/// <value>The <c>Password</c> column value.</value>
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
		public string Email
		{
			get { return _email; }
			set { _email = value; }
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
		/// Gets or sets the <c>IsDeleted</c> column value.
		/// </summary>
		/// <value>The <c>IsDeleted</c> column value.</value>
		public bool IsDeleted
		{
			get { return _isDeleted; }
			set { _isDeleted = value; }
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
			dynStr.Append("  User_Id=");
			dynStr.Append(User_Id);
			dynStr.Append("  UserName=");
			dynStr.Append(UserName);
			dynStr.Append("  FullName=");
			dynStr.Append(FullName);
			dynStr.Append("  Password=");
			dynStr.Append(Password);
			dynStr.Append("  Email=");
			dynStr.Append(Email);
			dynStr.Append("  Role_Id=");
			dynStr.Append(Role_Id);
			dynStr.Append("  IsDeleted=");
			dynStr.Append(IsDeleted);
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
	} // End of tblUsersRow_Base class
} // End of namespace
