// <fileinfo name="tblDonorCollection_Base.cs">
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
	/// The base class for <see cref="tblDonorCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="tblDonorCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class tblDonorCollection_Base
	{
		// Constants
		public const string Donor_IdColumnName = "Donor_Id";
		public const string Donor_NameColumnName = "Donor_Name";
		public const string AddressColumnName = "Address";
		public const string Donor_Contact_IdColumnName = "Donor_Contact_Id";
		public const string Contact_NoColumnName = "Contact_No";
		public const string EmailColumnName = "Email";
		public const string Country_IdColumnName = "Country_Id";
		public const string Donor_Type_IdColumnName = "Donor_Type_Id";
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
		/// Initializes a new instance of the <see cref="tblDonorCollection_Base"/> 
		/// class with the specified <see cref="FMSDB"/>.
		/// </summary>
		/// <param name="db">The <see cref="FMSDB"/> object.</param>
		public tblDonorCollection_Base(FMSDB db)
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
		/// Gets an array of all records from the <c>tblDonor</c> table.
		/// </summary>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public virtual tblDonorRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>tblDonor</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.IDbCommand"/> object that is used
		/// to retrieve all records from the <c>tblDonor</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo._tblDonor_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="tblDonorRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="tblDonorRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public tblDonorRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			tblDonorRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public tblDonorRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects that 
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
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public virtual tblDonorRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[tblDonor]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="tblDonorRow"/> by the primary key.
		/// </summary>
		/// <param name="donor_Id">The <c>Donor_Id</c> column value.</param>
		/// <returns>An instance of <see cref="tblDonorRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual tblDonorRow GetByPrimaryKey(int donor_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_GetByPrimaryKey", true);
			AddParameter(cmd, "Donor_Id", donor_Id);
			tblDonorRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects 
		/// by the <c>FK_tblDonor_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public virtual tblDonorRow[] GetByCurrency_Id(int currency_Id)
		{
			return MapRecords(CreateGetByCurrency_IdCommand(currency_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblDonor_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByCurrency_IdAsDataTable(int currency_Id)
		{
			return MapRecordsToDataTable(CreateGetByCurrency_IdCommand(currency_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblDonor_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByCurrency_IdCommand(int currency_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_GetBy_Currency_Id", true);
			AddParameter(cmd, "Currency_Id", currency_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects 
		/// by the <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public tblDonorRow[] GetByDonor_Contact_Id(int donor_Contact_Id)
		{
			return GetByDonor_Contact_Id(donor_Contact_Id, false);
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects 
		/// by the <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <param name="donor_Contact_IdNull">true if the method ignores the donor_Contact_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public virtual tblDonorRow[] GetByDonor_Contact_Id(int donor_Contact_Id, bool donor_Contact_IdNull)
		{
			return MapRecords(CreateGetByDonor_Contact_IdCommand(donor_Contact_Id, donor_Contact_IdNull));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetByDonor_Contact_IdAsDataTable(int donor_Contact_Id)
		{
			return GetByDonor_Contact_IdAsDataTable(donor_Contact_Id, false);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <param name="donor_Contact_IdNull">true if the method ignores the donor_Contact_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByDonor_Contact_IdAsDataTable(int donor_Contact_Id, bool donor_Contact_IdNull)
		{
			return MapRecordsToDataTable(CreateGetByDonor_Contact_IdCommand(donor_Contact_Id, donor_Contact_IdNull));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <param name="donor_Contact_IdNull">true if the method ignores the donor_Contact_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByDonor_Contact_IdCommand(int donor_Contact_Id, bool donor_Contact_IdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_GetBy_Donor_Contact_Id", true);
			AddParameter(cmd, "Donor_Contact_Id", donor_Contact_IdNull ? null : (object)donor_Contact_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects 
		/// by the <c>FK_tblDonor_tblDonor_Type</c> foreign key.
		/// </summary>
		/// <param name="donor_Type_Id">The <c>Donor_Type_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public virtual tblDonorRow[] GetByDonor_Type_Id(int donor_Type_Id)
		{
			return MapRecords(CreateGetByDonor_Type_IdCommand(donor_Type_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblDonor_tblDonor_Type</c> foreign key.
		/// </summary>
		/// <param name="donor_Type_Id">The <c>Donor_Type_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByDonor_Type_IdAsDataTable(int donor_Type_Id)
		{
			return MapRecordsToDataTable(CreateGetByDonor_Type_IdCommand(donor_Type_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblDonor_tblDonor_Type</c> foreign key.
		/// </summary>
		/// <param name="donor_Type_Id">The <c>Donor_Type_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByDonor_Type_IdCommand(int donor_Type_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_GetBy_Donor_Type_Id", true);
			AddParameter(cmd, "Donor_Type_Id", donor_Type_Id);
			return cmd;
		}

		/// <summary>
		/// Gets an array of <see cref="tblDonorRow"/> objects 
		/// by the <c>FK_tblDonor_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		public virtual tblDonorRow[] GetByGL_Act_Id(int gL_Act_Id)
		{
			return MapRecords(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object 
		/// by the <c>FK_tblDonor_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetByGL_Act_IdAsDataTable(int gL_Act_Id)
		{
			return MapRecordsToDataTable(CreateGetByGL_Act_IdCommand(gL_Act_Id));
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to 
		/// return records by the <c>FK_tblDonor_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateGetByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_GetBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Adds a new record into the <c>tblDonor</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblDonorRow"/> object to be inserted.</param>
		public virtual void Insert(tblDonorRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_Insert", true);
			AddParameter(cmd, "Donor_Name", value.Donor_Name);
			AddParameter(cmd, "Address", value.Address);
			AddParameter(cmd, "Donor_Contact_Id",
				value.IsDonor_Contact_IdNull ? DBNull.Value : (object)value.Donor_Contact_Id);
			AddParameter(cmd, "Contact_No", value.Contact_No);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Country_Id", value.Country_Id);
			AddParameter(cmd, "Donor_Type_Id", value.Donor_Type_Id);
			AddParameter(cmd, "Status", value.Status);
			AddParameter(cmd, "Currency_Id", value.Currency_Id);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			value.Donor_Id = Convert.ToInt32(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>tblDonor</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblDonorRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(tblDonorRow value)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_Update", true);
			AddParameter(cmd, "Donor_Name", value.Donor_Name);
			AddParameter(cmd, "Address", value.Address);
			AddParameter(cmd, "Donor_Contact_Id",
				value.IsDonor_Contact_IdNull ? DBNull.Value : (object)value.Donor_Contact_Id);
			AddParameter(cmd, "Contact_No", value.Contact_No);
			AddParameter(cmd, "Email", value.Email);
			AddParameter(cmd, "Country_Id", value.Country_Id);
			AddParameter(cmd, "Donor_Type_Id", value.Donor_Type_Id);
			AddParameter(cmd, "Status", value.Status);
			AddParameter(cmd, "Currency_Id", value.Currency_Id);
			AddParameter(cmd, "GL_Act_Id", value.GL_Act_Id);
			AddParameter(cmd, "Created_By", value.Created_By);
			AddParameter(cmd, "Created_Time", value.Created_Time);
			AddParameter(cmd, "Updated_By", value.Updated_By);
			AddParameter(cmd, "Updated_Time", value.Updated_Time);
			AddParameter(cmd, "Donor_Id", value.Donor_Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>tblDonor</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>tblDonor</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((int)row["Donor_Id"]);
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
		/// Deletes the specified object from the <c>tblDonor</c> table.
		/// </summary>
		/// <param name="value">The <see cref="tblDonorRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(tblDonorRow value)
		{
			return DeleteByPrimaryKey(value.Donor_Id);
		}

		/// <summary>
		/// Deletes a record from the <c>tblDonor</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="donor_Id">The <c>Donor_Id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(int donor_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Donor_Id", donor_Id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes records from the <c>tblDonor</c> table using the 
		/// <c>FK_tblDonor_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByCurrency_Id(int currency_Id)
		{
			return CreateDeleteByCurrency_IdCommand(currency_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblDonor_tblCurrency</c> foreign key.
		/// </summary>
		/// <param name="currency_Id">The <c>Currency_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByCurrency_IdCommand(int currency_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_DeleteBy_Currency_Id", true);
			AddParameter(cmd, "Currency_Id", currency_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblDonor</c> table using the 
		/// <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByDonor_Contact_Id(int donor_Contact_Id)
		{
			return DeleteByDonor_Contact_Id(donor_Contact_Id, false);
		}

		/// <summary>
		/// Deletes records from the <c>tblDonor</c> table using the 
		/// <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <param name="donor_Contact_IdNull">true if the method ignores the donor_Contact_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByDonor_Contact_Id(int donor_Contact_Id, bool donor_Contact_IdNull)
		{
			return CreateDeleteByDonor_Contact_IdCommand(donor_Contact_Id, donor_Contact_IdNull).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblDonor_tblDonor_Contact</c> foreign key.
		/// </summary>
		/// <param name="donor_Contact_Id">The <c>Donor_Contact_Id</c> column value.</param>
		/// <param name="donor_Contact_IdNull">true if the method ignores the donor_Contact_Id
		/// parameter value and uses DbNull instead of it; otherwise, false.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByDonor_Contact_IdCommand(int donor_Contact_Id, bool donor_Contact_IdNull)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_DeleteBy_Donor_Contact_Id", true);
			AddParameter(cmd, "Donor_Contact_Id", donor_Contact_IdNull ? null : (object)donor_Contact_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblDonor</c> table using the 
		/// <c>FK_tblDonor_tblDonor_Type</c> foreign key.
		/// </summary>
		/// <param name="donor_Type_Id">The <c>Donor_Type_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByDonor_Type_Id(int donor_Type_Id)
		{
			return CreateDeleteByDonor_Type_IdCommand(donor_Type_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblDonor_tblDonor_Type</c> foreign key.
		/// </summary>
		/// <param name="donor_Type_Id">The <c>Donor_Type_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByDonor_Type_IdCommand(int donor_Type_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_DeleteBy_Donor_Type_Id", true);
			AddParameter(cmd, "Donor_Type_Id", donor_Type_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes records from the <c>tblDonor</c> table using the 
		/// <c>FK_tblDonor_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>The number of records deleted from the table.</returns>
		public int DeleteByGL_Act_Id(int gL_Act_Id)
		{
			return CreateDeleteByGL_Act_IdCommand(gL_Act_Id).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.IDbCommand"/> object that can be used to
		/// delete records using the <c>FK_tblDonor_tblGL_Account</c> foreign key.
		/// </summary>
		/// <param name="gL_Act_Id">The <c>GL_Act_Id</c> column value.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteByGL_Act_IdCommand(int gL_Act_Id)
		{
			IDbCommand cmd = _db.CreateCommand("dbo._tblDonor_DeleteBy_GL_Act_Id", true);
			AddParameter(cmd, "GL_Act_Id", gL_Act_Id);
			return cmd;
		}

		/// <summary>
		/// Deletes <c>tblDonor</c> records that match the specified criteria.
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
		/// to delete <c>tblDonor</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.IDbCommand"/> object.</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[tblDonor]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>tblDonor</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo._tblDonor_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.IDbCommand"/> object.</param>
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		protected tblDonorRow[] MapRecords(IDbCommand command)
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
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		protected tblDonorRow[] MapRecords(IDataReader reader)
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
		/// <returns>An array of <see cref="tblDonorRow"/> objects.</returns>
		protected virtual tblDonorRow[] MapRecords(IDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int donor_IdColumnIndex = reader.GetOrdinal("Donor_Id");
			int donor_NameColumnIndex = reader.GetOrdinal("Donor_Name");
			int addressColumnIndex = reader.GetOrdinal("Address");
			int donor_Contact_IdColumnIndex = reader.GetOrdinal("Donor_Contact_Id");
			int contact_NoColumnIndex = reader.GetOrdinal("Contact_No");
			int emailColumnIndex = reader.GetOrdinal("Email");
			int country_IdColumnIndex = reader.GetOrdinal("Country_Id");
			int donor_Type_IdColumnIndex = reader.GetOrdinal("Donor_Type_Id");
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
					tblDonorRow record = new tblDonorRow();
					recordList.Add(record);

					record.Donor_Id = Convert.ToInt32(reader.GetValue(donor_IdColumnIndex));
					record.Donor_Name = Convert.ToString(reader.GetValue(donor_NameColumnIndex));
					if(!reader.IsDBNull(addressColumnIndex))
						record.Address = Convert.ToString(reader.GetValue(addressColumnIndex));
					if(!reader.IsDBNull(donor_Contact_IdColumnIndex))
						record.Donor_Contact_Id = Convert.ToInt32(reader.GetValue(donor_Contact_IdColumnIndex));
					if(!reader.IsDBNull(contact_NoColumnIndex))
						record.Contact_No = Convert.ToString(reader.GetValue(contact_NoColumnIndex));
					if(!reader.IsDBNull(emailColumnIndex))
						record.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
					if(!reader.IsDBNull(country_IdColumnIndex))
						record.Country_Id = Convert.ToString(reader.GetValue(country_IdColumnIndex));
					record.Donor_Type_Id = Convert.ToInt32(reader.GetValue(donor_Type_IdColumnIndex));
					record.Status = Convert.ToBoolean(reader.GetValue(statusColumnIndex));
					record.Currency_Id = Convert.ToInt32(reader.GetValue(currency_IdColumnIndex));
					record.GL_Act_Id = Convert.ToInt32(reader.GetValue(gL_Act_IdColumnIndex));
					record.Created_By = Convert.ToInt32(reader.GetValue(created_ByColumnIndex));
					record.Created_Time = Convert.ToDateTime(reader.GetValue(created_TimeColumnIndex));
					record.Updated_By = Convert.ToInt32(reader.GetValue(updated_ByColumnIndex));
					record.Updated_Time = Convert.ToDateTime(reader.GetValue(updated_TimeColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (tblDonorRow[])(recordList.ToArray(typeof(tblDonorRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="tblDonorRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="tblDonorRow"/> object.</returns>
		protected virtual tblDonorRow MapRow(DataRow row)
		{
			tblDonorRow mappedObject = new tblDonorRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Donor_Id"
			dataColumn = dataTable.Columns["Donor_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Id = (int)row[dataColumn];
			// Column "Donor_Name"
			dataColumn = dataTable.Columns["Donor_Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Name = (string)row[dataColumn];
			// Column "Address"
			dataColumn = dataTable.Columns["Address"];
			if(!row.IsNull(dataColumn))
				mappedObject.Address = (string)row[dataColumn];
			// Column "Donor_Contact_Id"
			dataColumn = dataTable.Columns["Donor_Contact_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Contact_Id = (int)row[dataColumn];
			// Column "Contact_No"
			dataColumn = dataTable.Columns["Contact_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Contact_No = (string)row[dataColumn];
			// Column "Email"
			dataColumn = dataTable.Columns["Email"];
			if(!row.IsNull(dataColumn))
				mappedObject.Email = (string)row[dataColumn];
			// Column "Country_Id"
			dataColumn = dataTable.Columns["Country_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Country_Id = (string)row[dataColumn];
			// Column "Donor_Type_Id"
			dataColumn = dataTable.Columns["Donor_Type_Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Donor_Type_Id = (int)row[dataColumn];
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
		/// the <c>tblDonor</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "tblDonor";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Donor_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Donor_Name", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Address", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Donor_Contact_Id", typeof(int));
			dataColumn = dataTable.Columns.Add("Contact_No", typeof(string));
			dataColumn.MaxLength = 10;
			dataColumn = dataTable.Columns.Add("Email", typeof(string));
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Country_Id", typeof(string));
			dataColumn.MaxLength = 25;
			dataColumn = dataTable.Columns.Add("Donor_Type_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Status", typeof(bool));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Currency_Id", typeof(int));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("GL_Act_Id", typeof(int));
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
				case "Donor_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Donor_Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Address":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Donor_Contact_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Contact_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.StringFixedLength, value);
					break;

				case "Email":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Country_Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Donor_Type_Id":
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
	} // End of tblDonorCollection_Base class
}  // End of namespace
