// <fileinfo name="tblExchange_RateCollection_Base.cs">
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
	/// The base class for <see cref="tblExchange_RateCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblExchange_RateCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblExchange_RateCollection_Base
	{
		// Constants
		public const string IDColumnName = "ID";
		public const string Exchange_DateColumnName = "Exchange_Date";
		public const string Currency_IdColumnName = "Currency_Id";
		public const string Exchange_RateColumnName = "Exchange_Rate";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_TimeColumnName = "Created_Time";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_TimeColumnName = "Updated_Time";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblExchange_RateCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblExchange_RateCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		public virtual tblExchange_RateRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblExchange_Rate_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblExchange_RateRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblExchange_RateRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblExchange_RateRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblExchange_RateRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblExchange_RateRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		public tblExchange_RateRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblExchange_RateRow"/> objects that 
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
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		public virtual tblExchange_RateRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblExchange_Rate]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblExchange_RateRow"/> by the primary key.
		/// </summary>
		/// <param name="id">The <c>ID</c> column value.</param>
		/// <returns>An instance of <see cref="tblExchange_RateRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblExchange_RateRow GetByPrimaryKey(int id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblExchange_Rate_GetByPrimaryKey", true);
			AddParameter(cmd, "ID", id);
			tblExchange_RateRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblExchange_RateRow"/> objects 
		/// by the <c>FK_tblExchange_Rate_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		public virtual tblExchange_RateRow[] GetByCurrency_Id(int currency_Id)
		{
			return MapRecords(CreateGetByCurrency_IdCommand(currency_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblExchange_Rate_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByCurrency_IdAsDataTable(int currency_Id)
		{
			return MapRecordsToDataTable(CreateGetByCurrency_IdCommand(currency_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblExchange_Rate_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByCurrency_IdCommand(int currency_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblExchange_Rate_GetBy_Currency_Id", true);
			AddParameter(cmd, "Currency_Id", currency_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblExchange_RateRow"/> object to be inserted.</param>
		public virtual void Insert(tblExchange_RateRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblExchange_Rate_Insert", true);
			AddParameter(cmd, "Exchange_Date", value.Exchange_Date);
			AddParameter(cmd, "Currency_Id", value.Currency_Id);
			AddParameter(cmd, "Exchange_Rate", value.Exchange_Rate);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			value.ID = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblExchange_RateRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblExchange_RateRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblExchange_Rate_Update", true);
			AddParameter(cmd, "Exchange_Date", value.Exchange_Date);
			AddParameter(cmd, "Currency_Id", value.Currency_Id);
			AddParameter(cmd, "Exchange_Rate", value.Exchange_Rate);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			AddParameter(cmd, "ID", value.ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblExchange_Rate</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblExchange_Rate</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["ID"]);
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
		/// Deletes the specified object from the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblExchange_RateRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblExchange_RateRow value)
		{
			return DeleteByPrimaryKey(value.ID);
		}

		/// <summary>
		/// Deletes a record from the <c>tblExchange_Rate</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="id">The <c>ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblExchange_Rate_DeleteByPrimaryKey", true);
			AddParameter(cmd, "ID", id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblExchange_Rate</c> table using the 
		/// <c>FK_tblExchange_Rate_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByCurrency_Id(int currency_Id)
		{
			return CreateDeleteByCurrency_IdCommand(currency_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblExchange_Rate_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByCurrency_IdCommand(int currency_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblExchange_Rate_DeleteBy_Currency_Id", true);
			AddParameter(cmd, "Currency_Id", currency_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblExchange_Rate</c> records that match the specified criteria.
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
		/// to delete <c>tblExchange_Rate</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblExchange_Rate]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblExchange_Rate_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		protected tblExchange_RateRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		protected tblExchange_RateRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblExchange_RateRow"/> objects.</returns>
		protected virtual tblExchange_RateRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("ID");
			int exchange_DateColumnIndex = reader.GetOrdinal("Exchange_Date");
			int currency_IdColumnIndex = reader.GetOrdinal("Currency_Id");
			int exchange_RateColumnIndex = reader.GetOrdinal("Exchange_Rate");
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
					tblExchange_RateRow record = new tblExchange_RateRow();
					recordList.Add(record);

					record.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
					record.Exchange_Date = Convert.ToDateTime(reader.GetValue(exchange_DateColumnIndex));
					record.Currency_Id = Convert.ToInt32(reader.GetValue(currency_IdColumnIndex));
					record.Exchange_Rate = Convert.ToInt32(reader.GetValue(exchange_RateColumnIndex));
					record.Created_By = Convert.ToInt32(reader.GetValue(created_ByColumnIndex));
					record.Created_Time = Convert.ToDateTime(reader.GetValue(created_TimeColumnIndex));
					record.Updated_By = Convert.ToInt32(reader.GetValue(updated_ByColumnIndex));
					record.Updated_Time = Convert.ToDateTime(reader.GetValue(updated_TimeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblExchange_RateRow[])(recordList.ToArray(typeof(tblExchange_RateRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblExchange_RateRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblExchange_RateRow"/> object.</returns>
		protected virtual tblExchange_RateRow MapRow(DataRow row)
		{
			tblExchange_RateRow mappedObject = new tblExchange_RateRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "ID"
			dataColumn = dataTable.Columns["ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.ID = (int)row[dataColumn];
			// Column "Exchange_Date"
			dataColumn = dataTable.Columns["Exchange_Date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Exchange_Date = (System.DateTime)row[dataColumn];
			// Column "Currency_Id"
			dataColumn = dataTable.Columns["Currency_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Currency_Id = (int)row[dataColumn];
			// Column "Exchange_Rate"
			dataColumn = dataTable.Columns["Exchange_Rate"];
			if(!row.IsNull(dataColumn))
				mappedObject.Exchange_Rate = (int)row[dataColumn];
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
		/// the <c>tblExchange_Rate</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblExchange_Rate";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("ID", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Exchange_Date", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Currency_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Exchange_Rate", typeof(int));
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
				case "ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Exchange_Date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Currency_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Exchange_Rate":
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

				case "Updated_Time":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of tblExchange_RateCollection_Base class
}  // End of namespace
