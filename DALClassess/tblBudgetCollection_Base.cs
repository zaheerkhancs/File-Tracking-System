// <fileinfo name="tblBudgetCollection_Base.cs">
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
	/// The base class for <see cref="tblBudgetCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblBudgetCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblBudgetCollection_Base
	{
		// Constants
		public const string Budget_IdColumnName = "Budget_Id";
		public const string YearColumnName = "Year";
		public const string GL_Act_IdColumnName = "GL_Act_Id";
		public const string AmountColumnName = "Amount";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_TimeColumnName = "Created_Time";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_timeColumnName = "Updated_time";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblBudgetCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblBudgetCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblBudget</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		public virtual tblBudgetRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblBudget</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblBudget</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblBudget_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblBudgetRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblBudgetRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblBudgetRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblBudgetRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblBudgetRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		public tblBudgetRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblBudgetRow"/> objects that 
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
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		public virtual tblBudgetRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblBudget]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblBudgetRow"/> by the primary key.
		/// </summary>
		/// <param name="budget_Id">The <c>Budget_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblBudgetRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblBudgetRow GetByPrimaryKey(int budget_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblBudget_GetByPrimaryKey", true);
			AddParameter(cmd, "Budget_Id", budget_Id);
			tblBudgetRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblBudgetRow"/> objects 
		/// by the <c>FK_tblBudget_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		public virtual tblBudgetRow[] GetByGL_Act_Id(int gL_Act_Id)
		{
			return MapRecords(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblBudget_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByGL_Act_IdAsDataTable(int gL_Act_Id)
		{
			return MapRecordsToDataTable(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblBudget_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblBudget_GetBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblBudget</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblBudgetRow"/> object to be inserted.</param>
		public virtual void Insert(tblBudgetRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblBudget_Insert", true);
			AddParameter(cmd, "Year", value.Year);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Amount", value.Amount);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_time", value.Updated_time);
			value.Budget_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblBudget</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblBudgetRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblBudgetRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblBudget_Update", true);
			AddParameter(cmd, "Year", value.Year);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Amount", value.Amount);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_time", value.Updated_time);
			AddParameter(cmd, "Budget_Id", value.Budget_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblBudget</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblBudget</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Budget_Id"]);
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
		/// Deletes the specified object from the <c>tblBudget</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblBudgetRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblBudgetRow value)
		{
			return DeleteByPrimaryKey(value.Budget_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblBudget</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="budget_Id">The <c>Budget_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int budget_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblBudget_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Budget_Id", budget_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblBudget</c> table using the 
		/// <c>FK_tblBudget_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByGL_Act_Id(int gL_Act_Id)
		{
			return CreateDeleteByGL_Act_IdCommand(gL_Act_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblBudget_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblBudget_DeleteBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblBudget</c> records that match the specified criteria.
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
		/// to delete <c>tblBudget</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblBudget]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblBudget</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblBudget_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		protected tblBudgetRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		protected tblBudgetRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblBudgetRow"/> objects.</returns>
		protected virtual tblBudgetRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int budget_IdColumnIndex = reader.GetOrdinal("Budget_Id");
			int yearColumnIndex = reader.GetOrdinal("Year");
			int gL_Act_IdColumnIndex = reader.GetOrdinal("GL_Act_Id");
			int amountColumnIndex = reader.GetOrdinal("Amount");
			int created_ByColumnIndex = reader.GetOrdinal("Created_By");
			int created_TimeColumnIndex = reader.GetOrdinal("Created_Time");
			int updated_ByColumnIndex = reader.GetOrdinal("Updated_By");
			int updated_timeColumnIndex = reader.GetOrdinal("Updated_time");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					tblBudgetRow record = new tblBudgetRow();
					recordList.Add(record);

					record.Budget_Id = Convert.ToInt32(reader.GetValue(budget_IdColumnIndex));
					record.Year = Convert.ToDateTime(reader.GetValue(yearColumnIndex));
					record.GL_Act_Id = Convert.ToInt32(reader.GetValue(gL_Act_IdColumnIndex));
					record.Amount = Convert.ToInt32(reader.GetValue(amountColumnIndex));
					record.Created_By = Convert.ToInt32(reader.GetValue(created_ByColumnIndex));
					record.Created_Time = Convert.ToDateTime(reader.GetValue(created_TimeColumnIndex));
					record.Updated_By = Convert.ToInt32(reader.GetValue(updated_ByColumnIndex));
					record.Updated_time = Convert.ToDateTime(reader.GetValue(updated_timeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblBudgetRow[])(recordList.ToArray(typeof(tblBudgetRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblBudgetRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblBudgetRow"/> object.</returns>
		protected virtual tblBudgetRow MapRow(DataRow row)
		{
			tblBudgetRow mappedObject = new tblBudgetRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Budget_Id"
			dataColumn = dataTable.Columns["Budget_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Budget_Id = (int)row[dataColumn];
			// Column "Year"
			dataColumn = dataTable.Columns["Year"];
			if(!row.IsNull(dataColumn))
				mappedObject.Year = (System.DateTime)row[dataColumn];
			// Column "GL_Act_Id"
			dataColumn = dataTable.Columns["GL_Act_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Act_Id = (int)row[dataColumn];
			// Column "Amount"
			dataColumn = dataTable.Columns["Amount"];
			if(!row.IsNull(dataColumn))
				mappedObject.Amount = (int)row[dataColumn];
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
			// Column "Updated_time"
			dataColumn = dataTable.Columns["Updated_time"];
			if(!row.IsNull(dataColumn))
				mappedObject.Updated_time = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>tblBudget</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblBudget";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Budget_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Year", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("GL_Act_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Amount", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Created_By", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Created_Time", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Updated_By", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Updated_time", typeof(System.DateTime));
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
				case "Budget_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Year":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "GL_Act_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Amount":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
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

				case "Updated_time":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblBudgetCollection_Base class
}  // End of namespace
