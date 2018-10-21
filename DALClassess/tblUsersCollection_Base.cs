// <fileinfo name="tblUsersCollection_Base.cs">
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
using System.Data;

namespace IOM.IECFMS.DAL
{
	/// <summary>
	/// The base class for <see cref="tblUsersCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblUsersCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblUsersCollection_Base
	{
		// Constants
		public const string User_IdColumnName = "User_Id";
		public const string UserNameColumnName = "UserName";
		public const string FullNameColumnName = "FullName";
		public const string PasswordColumnName = "Password";
		public const string EmailColumnName = "Email";
		public const string Role_IdColumnName = "Role_Id";
		public const string IsDeletedColumnName = "IsDeleted";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_TimeColumnName = "Created_Time";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_TimeColumnName = "Updated_Time";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblUsersCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblUsersCollection_Base(FMSDB db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="FMSDB"/> object.</value>
		protected FMSDB Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>tblUsers</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		public virtual tblUsersRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblUsers</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblUsers</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblUsers_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblUsersRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblUsersRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblUsersRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblUsersRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblUsersRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		public tblUsersRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblUsersRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		public virtual tblUsersRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[tblUsers]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblUsersRow"/> by the primary key.
		/// </summary>
		/// <param name="user_Id">The <c>User_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblUsersRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblUsersRow GetByPrimaryKey(int user_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblUsers_GetByPrimaryKey", true);
			AddParameter(cmd, "User_Id", user_Id);
			tblUsersRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblUsersRow"/> objects 
		/// by the <c>FK_tblUsers_tblRole</c> foreign key.
		/// </summary>
		/// <param name="role_Id">The <c>Role_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		public virtual tblUsersRow[] GetByRole_Id(int role_Id)
		{
			return MapRecords(CreateGetByRole_IdCommand(role_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblUsers_tblRole</c> foreign key.
		/// </summary>
		/// <param name="role_Id">The <c>Role_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByRole_IdAsDataTable(int role_Id)
		{
			return MapRecordsToDataTable(CreateGetByRole_IdCommand(role_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblUsers_tblRole</c> foreign key.
		/// </summary>
		/// <param name="role_Id">The <c>Role_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByRole_IdCommand(int role_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblUsers_GetBy_Role_Id", true);
			AddParameter(cmd, "Role_Id", role_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblUsers</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblUsersRow"/> object to be inserted.</param>
		public virtual void Insert(tblUsersRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblUsers_Insert", true);
			AddParameter(cmd, "UserName", value.UserName);
			AddParameter(cmd, "FullName", value.FullName);
			AddParameter(cmd, "Password", value.Password);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Role_Id", value.Role_Id);
			AddParameter(cmd, "IsDeleted", value.IsDeleted);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			value.User_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblUsers</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblUsersRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblUsersRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblUsers_Update", true);
			AddParameter(cmd, "UserName", value.UserName);
			AddParameter(cmd, "FullName", value.FullName);
			AddParameter(cmd, "Password", value.Password);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Role_Id", value.Role_Id);
			AddParameter(cmd, "IsDeleted", value.IsDeleted);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			AddParameter(cmd, "User_Id", value.User_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblUsers</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblUsers</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((int)row["User_Id"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>tblUsers</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblUsersRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblUsersRow value)
		{
			return DeleteByPrimaryKey(value.User_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblUsers</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="user_Id">The <c>User_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int user_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblUsers_DeleteByPrimaryKey", true);
			AddParameter(cmd, "User_Id", user_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblUsers</c> table using the 
		/// <c>FK_tblUsers_tblRole</c> foreign key.
		/// </summary>
		/// <param name="role_Id">The <c>Role_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByRole_Id(int role_Id)
		{
			return CreateDeleteByRole_IdCommand(role_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblUsers_tblRole</c> foreign key.
		/// </summary>
		/// <param name="role_Id">The <c>Role_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByRole_IdCommand(int role_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblUsers_DeleteBy_Role_Id", true);
			AddParameter(cmd, "Role_Id", role_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblUsers</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used 
		/// to delete <c>tblUsers</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblUsers]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblUsers</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblUsers_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		protected tblUsersRow[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		protected tblUsersRow[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="tblUsersRow"/> objects.</returns>
		protected virtual tblUsersRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int user_IdColumnIndex = reader.GetOrdinal("User_Id");
			int userNameColumnIndex = reader.GetOrdinal("UserName");
			int fullNameColumnIndex = reader.GetOrdinal("FullName");
			int passwordColumnIndex = reader.GetOrdinal("Password");
			int emailColumnIndex = reader.GetOrdinal("Email");
			int role_IdColumnIndex = reader.GetOrdinal("Role_Id");
			int isDeletedColumnIndex = reader.GetOrdinal("IsDeleted");
			int created_ByColumnIndex = reader.GetOrdinal("Created_By");
			int created_TimeColumnIndex = reader.GetOrdinal("Created_Time");
			int updated_ByColumnIndex = reader.GetOrdinal("Updated_By");
			int updated_TimeColumnIndex = reader.GetOrdinal("Updated_Time");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblUsersRow record = new tblUsersRow();
					recordList.Add(record);

					record.User_Id = Convert.ToInt32(reader.GetValue(user_IdColumnIndex));
					record.UserName = Convert.ToString(reader.GetValue(userNameColumnIndex));
					if(!reader.IsDBNull(fullNameColumnIndex))
						record.FullName = Convert.ToString(reader.GetValue(fullNameColumnIndex));
					record.Password = Convert.ToString(reader.GetValue(passwordColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					record.Role_Id = Convert.ToInt32(reader.GetValue(role_IdColumnIndex));
					record.IsDeleted = Convert.ToBoolean(reader.GetValue(isDeletedColumnIndex));
					record.Created_By = Convert.ToInt32(reader.GetValue(created_ByColumnIndex));
					record.Created_Time = Convert.ToDateTime(reader.GetValue(created_TimeColumnIndex));
					record.Updated_By = Convert.ToInt32(reader.GetValue(updated_ByColumnIndex));
					record.Updated_Time = Convert.ToDateTime(reader.GetValue(updated_TimeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblUsersRow[])(recordList.ToArray(typeof(tblUsersRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(IDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.IDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblUsersRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblUsersRow"/> object.</returns>
		protected virtual tblUsersRow MapRow(DataRow row)
		{
			tblUsersRow mappedObject = new tblUsersRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "User_Id"
			dataColumn = dataTable.Columns["User_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.User_Id = (int)row[dataColumn];
			// Column "UserName"
			dataColumn = dataTable.Columns["UserName"];
			if(!row.IsNull(dataColumn))
				mappedObject.UserName = (string)row[dataColumn];
			// Column "FullName"
			dataColumn = dataTable.Columns["FullName"];
			if(!row.IsNull(dataColumn))
				mappedObject.FullName = (string)row[dataColumn];
			// Column "Password"
			dataColumn = dataTable.Columns["Password"];
			if(!row.IsNull(dataColumn))
				mappedObject.Password = (string)row[dataColumn];
			// Column "Email"
			dataColumn = dataTable.Columns["Email"];
			if(!row.IsNull(dataColumn))
				mappedObject.Email = (string)row[dataColumn];
			// Column "Role_Id"
			dataColumn = dataTable.Columns["Role_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Role_Id = (int)row[dataColumn];
			// Column "IsDeleted"
			dataColumn = dataTable.Columns["IsDeleted"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsDeleted = (bool)row[dataColumn];
			// Column "Created_By"
			dataColumn = dataTable.Columns["Created_By"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_By = (int)row[dataColumn];
			// Column "Created_Time"
			dataColumn = dataTable.Columns["Created_Time"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_Time = (System.DateTime)row[dataColumn];
			// Column "Updated_By"
			dataColumn = dataTable.Columns["Updated_By"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_By = (int)row[dataColumn];
			// Column "Updated_Time"
			dataColumn = dataTable.Columns["Updated_Time"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_Time = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblUsers</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblUsers";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("User_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("UserName", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("FullName", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Password", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Email", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Role_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("IsDeleted", typeof(bool));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Created_By", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Created_Time", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Updated_By", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Updated_Time", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.IDbCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual IDbDataParameter AddParameter(IDbCommand cmd, string paramName, object value)
		{
			IDbDataParameter parameter;
			switch(paramName)
			{
				case "User_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "UserName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "FullName":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Password":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Email":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Role_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "IsDeleted":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Created_By":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Created_Time":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Updated_By":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Updated_Time":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblUsersCollection_Base class
}  // End of namespace
