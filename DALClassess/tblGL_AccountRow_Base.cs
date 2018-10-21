// <fileinfo name="tblGL_AccountRow_Base.cs">
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
	/// The base class for <see cref="tblGL_AccountRow"/> that 
	/// represents a record in the <c>tblGL_Account</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="tblGL_AccountRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblGL_AccountRow_Base
	{
		private int _gL_Act_Id;
		private int _gL_Act_Code;
		private string _gL_Act_Name;
		private int _gL_Act_Type_Id;
		private bool _status;
		private int _created_By;
		private System.DateTime _created_Time;
		private int _updated_By;
		private System.DateTime _updated_Time;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblGL_AccountRow_Base"/> class.
		/// </summary>
		public tblGL_AccountRow_Base()
		{
			// EMPTY
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
		/// Gets or sets the <c>GL_Act_Code</c> column value.
		/// </summary>
		/// <value>The <c>GL_Act_Code</c> column value.</value>
		public int GL_Act_Code
		{
			get { return _gL_Act_Code; }
			set { _gL_Act_Code = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GL_Act_Name</c> column value.
		/// </summary>
		/// <value>The <c>GL_Act_Name</c> column value.</value>
		public string GL_Act_Name
		{
			get { return _gL_Act_Name; }
			set { _gL_Act_Name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>GL_Act_Type_Id</c> column value.
		/// </summary>
		/// <value>The <c>GL_Act_Type_Id</c> column value.</value>
		public int GL_Act_Type_Id
		{
			get { return _gL_Act_Type_Id; }
			set { _gL_Act_Type_Id = value; }
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
			dynStr.Append("  GL_Act_Id=");
			dynStr.Append(GL_Act_Id);
			dynStr.Append("  GL_Act_Code=");
			dynStr.Append(GL_Act_Code);
			dynStr.Append("  GL_Act_Name=");
			dynStr.Append(GL_Act_Name);
			dynStr.Append("  GL_Act_Type_Id=");
			dynStr.Append(GL_Act_Type_Id);
			dynStr.Append("  Status=");
			dynStr.Append(Status);
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
	} // End of tblGL_AccountRow_Base class
} // End of namespace
