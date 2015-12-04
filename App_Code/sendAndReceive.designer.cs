﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SchoolAppForm")]
public partial class sendAndReceiveDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertuserDetail(userDetail instance);
  partial void UpdateuserDetail(userDetail instance);
  partial void DeleteuserDetail(userDetail instance);
  partial void InsertstudentResult(studentResult instance);
  partial void UpdatestudentResult(studentResult instance);
  partial void DeletestudentResult(studentResult instance);
  #endregion
	
	public sendAndReceiveDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SchoolAppFormConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public sendAndReceiveDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public sendAndReceiveDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public sendAndReceiveDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public sendAndReceiveDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<userDetail> userDetails
	{
		get
		{
			return this.GetTable<userDetail>();
		}
	}
	
	public System.Data.Linq.Table<studentResult> studentResults
	{
		get
		{
			return this.GetTable<studentResult>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.userDetails")]
public partial class userDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _surname;
	
	private string _idNumber;
	
	private string _passportNumber;
	
	private string _addressLine1;
	
	private string _addressLine2;
	
	private string _postCode;
	
	private string _cellphoneNumber;
	
	private string _emailAddress;
	
	private string _password;
	
	private EntitySet<studentResult> _studentResults;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    partial void OnidNumberChanging(string value);
    partial void OnidNumberChanged();
    partial void OnpassportNumberChanging(string value);
    partial void OnpassportNumberChanged();
    partial void OnaddressLine1Changing(string value);
    partial void OnaddressLine1Changed();
    partial void OnaddressLine2Changing(string value);
    partial void OnaddressLine2Changed();
    partial void OnpostCodeChanging(string value);
    partial void OnpostCodeChanged();
    partial void OncellphoneNumberChanging(string value);
    partial void OncellphoneNumberChanged();
    partial void OnemailAddressChanging(string value);
    partial void OnemailAddressChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
	
	public userDetail()
	{
		this._studentResults = new EntitySet<studentResult>(new Action<studentResult>(this.attach_studentResults), new Action<studentResult>(this.detach_studentResults));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string surname
	{
		get
		{
			return this._surname;
		}
		set
		{
			if ((this._surname != value))
			{
				this.OnsurnameChanging(value);
				this.SendPropertyChanging();
				this._surname = value;
				this.SendPropertyChanged("surname");
				this.OnsurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idNumber", DbType="NVarChar(13)")]
	public string idNumber
	{
		get
		{
			return this._idNumber;
		}
		set
		{
			if ((this._idNumber != value))
			{
				this.OnidNumberChanging(value);
				this.SendPropertyChanging();
				this._idNumber = value;
				this.SendPropertyChanged("idNumber");
				this.OnidNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passportNumber", DbType="NVarChar(50)")]
	public string passportNumber
	{
		get
		{
			return this._passportNumber;
		}
		set
		{
			if ((this._passportNumber != value))
			{
				this.OnpassportNumberChanging(value);
				this.SendPropertyChanging();
				this._passportNumber = value;
				this.SendPropertyChanged("passportNumber");
				this.OnpassportNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addressLine1", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string addressLine1
	{
		get
		{
			return this._addressLine1;
		}
		set
		{
			if ((this._addressLine1 != value))
			{
				this.OnaddressLine1Changing(value);
				this.SendPropertyChanging();
				this._addressLine1 = value;
				this.SendPropertyChanged("addressLine1");
				this.OnaddressLine1Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addressLine2", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string addressLine2
	{
		get
		{
			return this._addressLine2;
		}
		set
		{
			if ((this._addressLine2 != value))
			{
				this.OnaddressLine2Changing(value);
				this.SendPropertyChanging();
				this._addressLine2 = value;
				this.SendPropertyChanged("addressLine2");
				this.OnaddressLine2Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_postCode", DbType="NChar(10) NOT NULL", CanBeNull=false)]
	public string postCode
	{
		get
		{
			return this._postCode;
		}
		set
		{
			if ((this._postCode != value))
			{
				this.OnpostCodeChanging(value);
				this.SendPropertyChanging();
				this._postCode = value;
				this.SendPropertyChanged("postCode");
				this.OnpostCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cellphoneNumber", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
	public string cellphoneNumber
	{
		get
		{
			return this._cellphoneNumber;
		}
		set
		{
			if ((this._cellphoneNumber != value))
			{
				this.OncellphoneNumberChanging(value);
				this.SendPropertyChanging();
				this._cellphoneNumber = value;
				this.SendPropertyChanged("cellphoneNumber");
				this.OncellphoneNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailAddress", DbType="NVarChar(50)")]
	public string emailAddress
	{
		get
		{
			return this._emailAddress;
		}
		set
		{
			if ((this._emailAddress != value))
			{
				this.OnemailAddressChanging(value);
				this.SendPropertyChanging();
				this._emailAddress = value;
				this.SendPropertyChanged("emailAddress");
				this.OnemailAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userDetail_studentResult", Storage="_studentResults", ThisKey="id", OtherKey="myID")]
	public EntitySet<studentResult> studentResults
	{
		get
		{
			return this._studentResults;
		}
		set
		{
			this._studentResults.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_studentResults(studentResult entity)
	{
		this.SendPropertyChanging();
		entity.userDetail = this;
	}
	
	private void detach_studentResults(studentResult entity)
	{
		this.SendPropertyChanging();
		entity.userDetail = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.studentResults")]
public partial class studentResult : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private int _myID;
	
	private System.Nullable<int> _englishFLMark;
	
	private System.Nullable<int> _endlishFALMark;
	
	private System.Nullable<int> _endlish2ndLMark;
	
	private System.Nullable<int> _mathematicsMark;
	
	private System.Nullable<int> _mathsLiteracyMark;
	
	private System.Nullable<int> _vernercularFLMark;
	
	private System.Nullable<int> _vernecularFALMark;
	
	private System.Nullable<int> _vernecular2ndLMark;
	
	private System.Nullable<int> _lifeOrientationMark;
	
	private System.Nullable<int> _lifeSciencesMark;
	
	private System.Nullable<int> _geographyMark;
	
	private System.Nullable<int> _physicalSciencesMark;
	
	private System.Nullable<int> _accountingMark;
	
	private System.Nullable<int> _businessStudiesMark;
	
	private System.Nullable<int> _economicsMark;
	
	private System.Nullable<int> _historyMark;
	
	private System.Nullable<int> _tourismMark;
	
	private EntityRef<userDetail> _userDetail;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnmyIDChanging(int value);
    partial void OnmyIDChanged();
    partial void OnenglishFLMarkChanging(System.Nullable<int> value);
    partial void OnenglishFLMarkChanged();
    partial void OnendlishFALMarkChanging(System.Nullable<int> value);
    partial void OnendlishFALMarkChanged();
    partial void Onendlish2ndLMarkChanging(System.Nullable<int> value);
    partial void Onendlish2ndLMarkChanged();
    partial void OnmathematicsMarkChanging(System.Nullable<int> value);
    partial void OnmathematicsMarkChanged();
    partial void OnmathsLiteracyMarkChanging(System.Nullable<int> value);
    partial void OnmathsLiteracyMarkChanged();
    partial void OnvernercularFLMarkChanging(System.Nullable<int> value);
    partial void OnvernercularFLMarkChanged();
    partial void OnvernecularFALMarkChanging(System.Nullable<int> value);
    partial void OnvernecularFALMarkChanged();
    partial void Onvernecular2ndLMarkChanging(System.Nullable<int> value);
    partial void Onvernecular2ndLMarkChanged();
    partial void OnlifeOrientationMarkChanging(System.Nullable<int> value);
    partial void OnlifeOrientationMarkChanged();
    partial void OnlifeSciencesMarkChanging(System.Nullable<int> value);
    partial void OnlifeSciencesMarkChanged();
    partial void OngeographyMarkChanging(System.Nullable<int> value);
    partial void OngeographyMarkChanged();
    partial void OnphysicalSciencesMarkChanging(System.Nullable<int> value);
    partial void OnphysicalSciencesMarkChanged();
    partial void OnaccountingMarkChanging(System.Nullable<int> value);
    partial void OnaccountingMarkChanged();
    partial void OnbusinessStudiesMarkChanging(System.Nullable<int> value);
    partial void OnbusinessStudiesMarkChanged();
    partial void OneconomicsMarkChanging(System.Nullable<int> value);
    partial void OneconomicsMarkChanged();
    partial void OnhistoryMarkChanging(System.Nullable<int> value);
    partial void OnhistoryMarkChanged();
    partial void OntourismMarkChanging(System.Nullable<int> value);
    partial void OntourismMarkChanged();
    #endregion
	
	public studentResult()
	{
		this._userDetail = default(EntityRef<userDetail>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_myID", DbType="Int NOT NULL")]
	public int myID
	{
		get
		{
			return this._myID;
		}
		set
		{
			if ((this._myID != value))
			{
				if (this._userDetail.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnmyIDChanging(value);
				this.SendPropertyChanging();
				this._myID = value;
				this.SendPropertyChanged("myID");
				this.OnmyIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_englishFLMark", DbType="Int")]
	public System.Nullable<int> englishFLMark
	{
		get
		{
			return this._englishFLMark;
		}
		set
		{
			if ((this._englishFLMark != value))
			{
				this.OnenglishFLMarkChanging(value);
				this.SendPropertyChanging();
				this._englishFLMark = value;
				this.SendPropertyChanged("englishFLMark");
				this.OnenglishFLMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endlishFALMark", DbType="Int")]
	public System.Nullable<int> endlishFALMark
	{
		get
		{
			return this._endlishFALMark;
		}
		set
		{
			if ((this._endlishFALMark != value))
			{
				this.OnendlishFALMarkChanging(value);
				this.SendPropertyChanging();
				this._endlishFALMark = value;
				this.SendPropertyChanged("endlishFALMark");
				this.OnendlishFALMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endlish2ndLMark", DbType="Int")]
	public System.Nullable<int> endlish2ndLMark
	{
		get
		{
			return this._endlish2ndLMark;
		}
		set
		{
			if ((this._endlish2ndLMark != value))
			{
				this.Onendlish2ndLMarkChanging(value);
				this.SendPropertyChanging();
				this._endlish2ndLMark = value;
				this.SendPropertyChanged("endlish2ndLMark");
				this.Onendlish2ndLMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mathematicsMark", DbType="Int")]
	public System.Nullable<int> mathematicsMark
	{
		get
		{
			return this._mathematicsMark;
		}
		set
		{
			if ((this._mathematicsMark != value))
			{
				this.OnmathematicsMarkChanging(value);
				this.SendPropertyChanging();
				this._mathematicsMark = value;
				this.SendPropertyChanged("mathematicsMark");
				this.OnmathematicsMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mathsLiteracyMark", DbType="Int")]
	public System.Nullable<int> mathsLiteracyMark
	{
		get
		{
			return this._mathsLiteracyMark;
		}
		set
		{
			if ((this._mathsLiteracyMark != value))
			{
				this.OnmathsLiteracyMarkChanging(value);
				this.SendPropertyChanging();
				this._mathsLiteracyMark = value;
				this.SendPropertyChanged("mathsLiteracyMark");
				this.OnmathsLiteracyMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vernercularFLMark", DbType="Int")]
	public System.Nullable<int> vernercularFLMark
	{
		get
		{
			return this._vernercularFLMark;
		}
		set
		{
			if ((this._vernercularFLMark != value))
			{
				this.OnvernercularFLMarkChanging(value);
				this.SendPropertyChanging();
				this._vernercularFLMark = value;
				this.SendPropertyChanged("vernercularFLMark");
				this.OnvernercularFLMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vernecularFALMark", DbType="Int")]
	public System.Nullable<int> vernecularFALMark
	{
		get
		{
			return this._vernecularFALMark;
		}
		set
		{
			if ((this._vernecularFALMark != value))
			{
				this.OnvernecularFALMarkChanging(value);
				this.SendPropertyChanging();
				this._vernecularFALMark = value;
				this.SendPropertyChanged("vernecularFALMark");
				this.OnvernecularFALMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vernecular2ndLMark", DbType="Int")]
	public System.Nullable<int> vernecular2ndLMark
	{
		get
		{
			return this._vernecular2ndLMark;
		}
		set
		{
			if ((this._vernecular2ndLMark != value))
			{
				this.Onvernecular2ndLMarkChanging(value);
				this.SendPropertyChanging();
				this._vernecular2ndLMark = value;
				this.SendPropertyChanged("vernecular2ndLMark");
				this.Onvernecular2ndLMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lifeOrientationMark", DbType="Int")]
	public System.Nullable<int> lifeOrientationMark
	{
		get
		{
			return this._lifeOrientationMark;
		}
		set
		{
			if ((this._lifeOrientationMark != value))
			{
				this.OnlifeOrientationMarkChanging(value);
				this.SendPropertyChanging();
				this._lifeOrientationMark = value;
				this.SendPropertyChanged("lifeOrientationMark");
				this.OnlifeOrientationMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lifeSciencesMark", DbType="Int")]
	public System.Nullable<int> lifeSciencesMark
	{
		get
		{
			return this._lifeSciencesMark;
		}
		set
		{
			if ((this._lifeSciencesMark != value))
			{
				this.OnlifeSciencesMarkChanging(value);
				this.SendPropertyChanging();
				this._lifeSciencesMark = value;
				this.SendPropertyChanged("lifeSciencesMark");
				this.OnlifeSciencesMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_geographyMark", DbType="Int")]
	public System.Nullable<int> geographyMark
	{
		get
		{
			return this._geographyMark;
		}
		set
		{
			if ((this._geographyMark != value))
			{
				this.OngeographyMarkChanging(value);
				this.SendPropertyChanging();
				this._geographyMark = value;
				this.SendPropertyChanged("geographyMark");
				this.OngeographyMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_physicalSciencesMark", DbType="Int")]
	public System.Nullable<int> physicalSciencesMark
	{
		get
		{
			return this._physicalSciencesMark;
		}
		set
		{
			if ((this._physicalSciencesMark != value))
			{
				this.OnphysicalSciencesMarkChanging(value);
				this.SendPropertyChanging();
				this._physicalSciencesMark = value;
				this.SendPropertyChanged("physicalSciencesMark");
				this.OnphysicalSciencesMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accountingMark", DbType="Int")]
	public System.Nullable<int> accountingMark
	{
		get
		{
			return this._accountingMark;
		}
		set
		{
			if ((this._accountingMark != value))
			{
				this.OnaccountingMarkChanging(value);
				this.SendPropertyChanging();
				this._accountingMark = value;
				this.SendPropertyChanged("accountingMark");
				this.OnaccountingMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_businessStudiesMark", DbType="Int")]
	public System.Nullable<int> businessStudiesMark
	{
		get
		{
			return this._businessStudiesMark;
		}
		set
		{
			if ((this._businessStudiesMark != value))
			{
				this.OnbusinessStudiesMarkChanging(value);
				this.SendPropertyChanging();
				this._businessStudiesMark = value;
				this.SendPropertyChanged("businessStudiesMark");
				this.OnbusinessStudiesMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_economicsMark", DbType="Int")]
	public System.Nullable<int> economicsMark
	{
		get
		{
			return this._economicsMark;
		}
		set
		{
			if ((this._economicsMark != value))
			{
				this.OneconomicsMarkChanging(value);
				this.SendPropertyChanging();
				this._economicsMark = value;
				this.SendPropertyChanged("economicsMark");
				this.OneconomicsMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_historyMark", DbType="Int")]
	public System.Nullable<int> historyMark
	{
		get
		{
			return this._historyMark;
		}
		set
		{
			if ((this._historyMark != value))
			{
				this.OnhistoryMarkChanging(value);
				this.SendPropertyChanging();
				this._historyMark = value;
				this.SendPropertyChanged("historyMark");
				this.OnhistoryMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tourismMark", DbType="Int")]
	public System.Nullable<int> tourismMark
	{
		get
		{
			return this._tourismMark;
		}
		set
		{
			if ((this._tourismMark != value))
			{
				this.OntourismMarkChanging(value);
				this.SendPropertyChanging();
				this._tourismMark = value;
				this.SendPropertyChanged("tourismMark");
				this.OntourismMarkChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userDetail_studentResult", Storage="_userDetail", ThisKey="myID", OtherKey="id", IsForeignKey=true)]
	public userDetail userDetail
	{
		get
		{
			return this._userDetail.Entity;
		}
		set
		{
			userDetail previousValue = this._userDetail.Entity;
			if (((previousValue != value) 
						|| (this._userDetail.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._userDetail.Entity = null;
					previousValue.studentResults.Remove(this);
				}
				this._userDetail.Entity = value;
				if ((value != null))
				{
					value.studentResults.Add(this);
					this._myID = value.id;
				}
				else
				{
					this._myID = default(int);
				}
				this.SendPropertyChanged("userDetail");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
