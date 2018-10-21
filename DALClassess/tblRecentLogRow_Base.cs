// <fileinfo name="tblRecentLogRow_Base.cs">
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
	/// The base class for <see cref="tblRecentLogRow"/> that 
	/// represents a record in the <c>tblRecentLog</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblRecentLogRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblRecentLogRow_Base
	{
		private int _recent_Log_Id;
		private int _entity_Id;
		private int _recent_Log_Type;
		private System.DateTime _recent_Log_Time;
		private int _userId;
		private string _action;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblRecentLogRow_Base"/> class.
		/// </summary>
		public tblRecentLogRow_Base()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>Recent_Log_Id</c> column value.
		/// </summary>
		/// <value>The <c>Recent_Log_Id</c> column value.</value>
		public int Recent_Log_Id
		{
			get { return _recent_Log_Id; }
			set { _recent_Log_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Entity_Id</c> column value.
		/// </summary>
		/// <value>The <c>Entity_Id</c> column value.</value>
		public int Entity_Id
		{
			get { return _entity_Id; }
			set { _entity_Id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Recent_Log_Type</c> column value.
		/// </summary>
		/// <value>The <c>Recent_Log_Type</c> column value.</value>
		public int Recent_Log_Type
		{
			get { return _recent_Log_Type; }
			set { _recent_Log_Type = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Recent_Log_Time</c> column value.
		/// </summary>
		/// <value>The <c>Recent_Log_Time</c> column value.</value>
		public System.DateTime Recent_Log_Time
		{
			get { return _recent_Log_Time; }
			set { _recent_Log_Time = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UserId</c> column value.
		/// </summary>
		/// <value>The <c>UserId</c> column value.</value>
		public int UserId
		{
			get { return _userId; }
			set { _userId = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Action</c> column value.
		/// </summary>
		/// <value>The <c>Action</c> column value.</value>
		public string Action
		{
			get { return _action; }
			set { _action = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Recent_Log_Id=");
			dynStr.Append(Recent_Log_Id);
			dynStr.Append("  Entity_Id=");
			dynStr.Append(Entity_Id);
			dynStr.Append("  Recent_Log_Type=");
			dynStr.Append(Recent_Log_Type);
			dynStr.Append("  Recent_Log_Time=");
			dynStr.Append(Recent_Log_Time);
			dynStr.Append("  UserId=");
			dynStr.Append(UserId);
			dynStr.Append("  Action=");
			dynStr.Append(Action);
			return dynStr.ToString();
		}
	} // End of tblRecentLogRow_Base class
} // End of namespace
