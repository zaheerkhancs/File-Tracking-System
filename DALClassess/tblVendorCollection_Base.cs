// <fileinfo name="tblVendorCollection_Base.cs">
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
	/// The base class for <see cref="tblVendorCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblVendorCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblVendorCollection_Base
	{
		// Constants
		public const string Vendor_IdColumnName = "Vendor_Id";
		public const string Vendor_NameColumnName = "Vendor_Name";
		public const string AddressColumnName = "Address";
		public const string Contact_NoColumnName = "Contact_No";
		public const string EmailColumnName = "Email";
		public const string CountryColumnName = "Country";
		public const string Vendor_Type_IdColumnName = "Vendor_Type_Id";
		public const string StatusColumnName = "Status";
		public const string Currency_IdColumnName = "Currency_Id";
		public const string GL_Act_IdColumnName = "GL_Act_Id";
		public const string Created_ByColumnName = "Created_By";
		public const string Created_TimeColumnName = "Created_Time";
		public const string Updated_ByColumnName = "Updated_By";
		public const string Updated_TimeColumnName = "Updated_Time";

		// Instance fields
		private FMSDB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="tblVendorCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblVendorCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblVendor</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		public virtual tblVendorRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblVendor</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblVendor</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblVendor_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblVendorRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblVendorRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblVendorRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblVendorRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblVendorRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		public tblVendorRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblVendorRow"/> objects that 
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
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		public virtual tblVendorRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblVendor]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblVendorRow"/> by the primary key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblVendorRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblVendorRow GetByPrimaryKey(int vendor_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblVendor_GetByPrimaryKey", true);
			AddParameter(cmd, "Vendor_Id", vendor_Id);
			tblVendorRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblVendorRow"/> objects 
		/// by the <c>FK_tblVendor_tblVendor_Type</c> foreign key.
		/// </summary>
		/// <param name="vendor_Type_Id">The <c>Vendor_Type_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		public virtual tblVendorRow[] GetByVendor_Type_Id(int vendor_Type_Id)
		{
			return MapRecords(CreateGetByVendor_Type_IdCommand(vendor_Type_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblVendor_tblVendor_Type</c> foreign key.
		/// </summary>
		/// <param name="vendor_Type_Id">The <c>Vendor_Type_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByVendor_Type_IdAsDataTable(int vendor_Type_Id)
		{
			return MapRecordsToDataTable(CreateGetByVendor_Type_IdCommand(vendor_Type_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblVendor_tblVendor_Type</c> foreign key.
		/// </summary>
		/// <param name="vendor_Type_Id">The <c>Vendor_Type_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByVendor_Type_IdCommand(int vendor_Type_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblVendor_GetBy_Vendor_Type_Id", true);
			AddParameter(cmd, "Vendor_Type_Id", vendor_Type_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblVendor</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblVendorRow"/> object to be inserted.</param>
		public virtual void Insert(tblVendorRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblVendor_Insert", true);
			AddParameter(cmd, "Vendor_Name", value.Vendor_Name);
			AddParameter(cmd, "Address", value.Address);
			AddParameter(cmd, "Contact_No",
				value.IsContact_NoNull ? DBNull.Value : (object)value.Contact_No);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Country",
				value.IsCountryNull ? DBNull.Value : (object)value.Country);
			AddParameter(cmd, "Vendor_Type_Id", value.Vendor_Type_Id);
			AddParameter(cmd, "Status", value.Status);
			AddParameter(cmd, "Currency_Id",
				value.IsCurrency_IdNull ? DBNull.Value : (object)value.Currency_Id);
			AddParameter(cmd, "GL_Act_Id",
				value.IsGL_Act_IdNull ? DBNull.Value : (object)value.GL_Act_Id);
			AddParameter(cmd, "Created_By",
				value.IsCreated_ByNull ? DBNull.Value : (object)value.Created_By);
			AddParameter(cmd, "Created_Time",
				value.IsCreated_TimeNull ? DBNull.Value : (object)value.Created_Time);
			AddParameter(cmd, "Updated_By",
				value.IsUpdated_ByNull ? DBNull.Value : (object)value.Updated_By);
			AddParameter(cmd, "Updated_Time",
				value.IsUpdated_TimeNull ? DBNull.Value : (object)value.Updated_Time);
			value.Vendor_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblVendor</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblVendorRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblVendorRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblVendor_Update", true);
			AddParameter(cmd, "Vendor_Name", value.Vendor_Name);
			AddParameter(cmd, "Address", value.Address);
			AddParameter(cmd, "Contact_No",
				value.IsContact_NoNull ? DBNull.Value : (object)value.Contact_No);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Country",
				value.IsCountryNull ? DBNull.Value : (object)value.Country);
			AddParameter(cmd, "Vendor_Type_Id", value.Vendor_Type_Id);
			AddParameter(cmd, "Status", value.Status);
			AddParameter(cmd, "Currency_Id",
				value.IsCurrency_IdNull ? DBNull.Value : (object)value.Currency_Id);
			AddParameter(cmd, "GL_Act_Id",
				value.IsGL_Act_IdNull ? DBNull.Value : (object)value.GL_Act_Id);
			AddParameter(cmd, "Created_By",
				value.IsCreated_ByNull ? DBNull.Value : (object)value.Created_By);
			AddParameter(cmd, "Created_Time",
				value.IsCreated_TimeNull ? DBNull.Value : (object)value.Created_Time);
			AddParameter(cmd, "Updated_By",
				value.IsUpdated_ByNull ? DBNull.Value : (object)value.Updated_By);
			AddParameter(cmd, "Updated_Time",
				value.IsUpdated_TimeNull ? DBNull.Value : (object)value.Updated_Time);
			AddParameter(cmd, "Vendor_Id", value.Vendor_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblVendor</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblVendor</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Vendor_Id"]);
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
		/// Deletes the specified object from the <c>tblVendor</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblVendorRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblVendorRow value)
		{
			return DeleteByPrimaryKey(value.Vendor_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblVendor</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="vendor_Id">The <c>Vendor_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int vendor_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblVendor_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Vendor_Id", vendor_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblVendor</c> table using the 
		/// <c>FK_tblVendor_tblVendor_Type</c> foreign key.
		/// </summary>
		/// <param name="vendor_Type_Id">The <c>Vendor_Type_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByVendor_Type_Id(int vendor_Type_Id)
		{
			return CreateDeleteByVendor_Type_IdCommand(vendor_Type_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblVendor_tblVendor_Type</c> foreign key.
		/// </summary>
		/// <param name="vendor_Type_Id">The <c>Vendor_Type_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByVendor_Type_IdCommand(int vendor_Type_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblVendor_DeleteBy_Vendor_Type_Id", true);
			AddParameter(cmd, "Vendor_Type_Id", vendor_Type_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblVendor</c> records that match the specified criteria.
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
		/// to delete <c>tblVendor</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblVendor]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblVendor</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblVendor_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		protected tblVendorRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		protected tblVendorRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblVendorRow"/> objects.</returns>
		protected virtual tblVendorRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int vendor_IdColumnIndex = reader.GetOrdinal("Vendor_Id");
			int vendor_NameColumnIndex = reader.GetOrdinal("Vendor_Name");
			int addressColumnIndex = reader.GetOrdinal("Address");
			int contact_NoColumnIndex = reader.GetOrdinal("Contact_No");
			int emailColumnIndex = reader.GetOrdinal("Email");
			int countryColumnIndex = reader.GetOrdinal("Country");
			int vendor_Type_IdColumnIndex = reader.GetOrdinal("Vendor_Type_Id");
			int statusColumnIndex = reader.GetOrdinal("Status");
			int currency_IdColumnIndex = reader.GetOrdinal("Currency_Id");
			int gL_Act_IdColumnIndex = reader.GetOrdinal("GL_Act_Id");
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
					tblVendorRow record = new tblVendorRow();
					recordList.Add(record);

					record.Vendor_Id = Convert.ToInt32(reader.GetValue(vendor_IdColumnIndex));
					record.Vendor_Name = Convert.ToString(reader.GetValue(vendor_NameColumnIndex));
					if(!reader.IsDBNull(addressColumnIndex))
						record.Address = Convert.ToString(reader.GetValue(addressColumnIndex));
					if(!reader.IsDBNull(contact_NoColumnIndex))
						record.Contact_No = Convert.ToInt32(reader.GetValue(contact_NoColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					if(!reader.IsDBNull(countryColumnIndex))
						record.Country = Convert.ToInt32(reader.GetValue(countryColumnIndex));
					record.Vendor_Type_Id = Convert.ToInt32(reader.GetValue(vendor_Type_IdColumnIndex));
					record.Status = Convert.ToBoolean(reader.GetValue(statusColumnIndex));
					if(!reader.IsDBNull(currency_IdColumnIndex))
						record.Currency_Id = Convert.ToInt32(reader.GetValue(currency_IdColumnIndex));
					if(!reader.IsDBNull(gL_Act_IdColumnIndex))
						record.GL_Act_Id = Convert.ToInt32(reader.GetValue(gL_Act_IdColumnIndex));
					if(!reader.IsDBNull(created_ByColumnIndex))
						record.Created_By = Convert.ToInt32(reader.GetValue(created_ByColumnIndex));
					if(!reader.IsDBNull(created_TimeColumnIndex))
						record.Created_Time = Convert.ToDateTime(reader.GetValue(created_TimeColumnIndex));
					if(!reader.IsDBNull(updated_ByColumnIndex))
						record.Updated_By = Convert.ToInt32(reader.GetValue(updated_ByColumnIndex));
					if(!reader.IsDBNull(updated_TimeColumnIndex))
						record.Updated_Time = Convert.ToDateTime(reader.GetValue(updated_TimeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblVendorRow[])(recordList.ToArray(typeof(tblVendorRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblVendorRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblVendorRow"/> object.</returns>
		protected virtual tblVendorRow MapRow(DataRow row)
		{
			tblVendorRow mappedObject = new tblVendorRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Vendor_Id"
			dataColumn = dataTable.Columns["Vendor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Vendor_Id = (int)row[dataColumn];
			// Column "Vendor_Name"
			dataColumn = dataTable.Columns["Vendor_Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Vendor_Name = (string)row[dataColumn];
			// Column "Address"
			dataColumn = dataTable.Columns["Address"];
			if(!row.IsNull(dataColumn))
				mappedObject.Address = (string)row[dataColumn];
			// Column "Contact_No"
			dataColumn = dataTable.Columns["Contact_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contact_No = (int)row[dataColumn];
			// Column "Email"
			dataColumn = dataTable.Columns["Email"];
			if(!row.IsNull(dataColumn))
				mappedObject.Email = (string)row[dataColumn];
			// Column "Country"
			dataColumn = dataTable.Columns["Country"];
			if(!row.IsNull(dataColumn))
				mappedObject.Country = (int)row[dataColumn];
			// Column "Vendor_Type_Id"
			dataColumn = dataTable.Columns["Vendor_Type_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Vendor_Type_Id = (int)row[dataColumn];
			// Column "Status"
			dataColumn = dataTable.Columns["Status"];
			if(!row.IsNull(dataColumn))
				mappedObject.Status = (bool)row[dataColumn];
			// Column "Currency_Id"
			dataColumn = dataTable.Columns["Currency_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Currency_Id = (int)row[dataColumn];
			// Column "GL_Act_Id"
			dataColumn = dataTable.Columns["GL_Act_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.GL_Act_Id = (int)row[dataColumn];
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
		/// the <c>tblVendor</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblVendor";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Vendor_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Vendor_Name", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Address", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Contact_No", typeof(int));
			dataColumn = dataTable.Columns.Add("Email", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Country", typeof(int));
			dataColumn = dataTable.Columns.Add("Vendor_Type_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Status", typeof(bool));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Currency_Id", typeof(int));
			dataColumn = dataTable.Columns.Add("GL_Act_Id", typeof(int));
			dataColumn = dataTable.Columns.Add("Created_By", typeof(int));
			dataColumn = dataTable.Columns.Add("Created_Time", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("Updated_By", typeof(int));
			dataColumn = dataTable.Columns.Add("Updated_Time", typeof(System.DateTime));
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
				case "Vendor_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Vendor_Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Address":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Contact_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Email":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Country":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Vendor_Type_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Status":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Currency_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "GL_Act_Id":
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
	} // End of tblVendorCollection_Base class
}  // End of namespace
