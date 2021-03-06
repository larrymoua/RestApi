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

namespace RestApi
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Inventory")]
	public partial class InventoriesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInventory(Inventory instance);
    partial void UpdateInventory(Inventory instance);
    partial void DeleteInventory(Inventory instance);
    #endregion
		
		public InventoriesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public InventoriesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoriesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoriesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public InventoriesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Inventory> Inventories
		{
			get
			{
				return this.GetTable<Inventory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Inventories")]
	public partial class Inventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InventoryId;
		
		private string _ItemName;
		
		private System.Nullable<int> _Quantity;
		
		private string _ItemPartNumber;
		
		private string _Description;
		
		private string _OrderStatus;
		
		private string _ImagePath;
		
		private System.Nullable<int> _MarketValue;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInventoryIdChanging(int value);
    partial void OnInventoryIdChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnItemPartNumberChanging(string value);
    partial void OnItemPartNumberChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnOrderStatusChanging(string value);
    partial void OnOrderStatusChanged();
    partial void OnImagePathChanging(string value);
    partial void OnImagePathChanged();
    partial void OnMarketValueChanging(System.Nullable<int> value);
    partial void OnMarketValueChanged();
    #endregion
		
		public Inventory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InventoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int InventoryId
		{
			get
			{
				return this._InventoryId;
			}
			set
			{
				if ((this._InventoryId != value))
				{
					this.OnInventoryIdChanging(value);
					this.SendPropertyChanging();
					this._InventoryId = value;
					this.SendPropertyChanged("InventoryId");
					this.OnInventoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="VarChar(50)")]
		public string ItemName
		{
			get
			{
				return this._ItemName;
			}
			set
			{
				if ((this._ItemName != value))
				{
					this.OnItemNameChanging(value);
					this.SendPropertyChanging();
					this._ItemName = value;
					this.SendPropertyChanged("ItemName");
					this.OnItemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemPartNumber", DbType="VarChar(50)")]
		public string ItemPartNumber
		{
			get
			{
				return this._ItemPartNumber;
			}
			set
			{
				if ((this._ItemPartNumber != value))
				{
					this.OnItemPartNumberChanging(value);
					this.SendPropertyChanging();
					this._ItemPartNumber = value;
					this.SendPropertyChanged("ItemPartNumber");
					this.OnItemPartNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderStatus", DbType="VarChar(50)")]
		public string OrderStatus
		{
			get
			{
				return this._OrderStatus;
			}
			set
			{
				if ((this._OrderStatus != value))
				{
					this.OnOrderStatusChanging(value);
					this.SendPropertyChanging();
					this._OrderStatus = value;
					this.SendPropertyChanged("OrderStatus");
					this.OnOrderStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="VarChar(MAX)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this.OnImagePathChanging(value);
					this.SendPropertyChanging();
					this._ImagePath = value;
					this.SendPropertyChanged("ImagePath");
					this.OnImagePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MarketValue", DbType="Int")]
		public System.Nullable<int> MarketValue
		{
			get
			{
				return this._MarketValue;
			}
			set
			{
				if ((this._MarketValue != value))
				{
					this.OnMarketValueChanging(value);
					this.SendPropertyChanging();
					this._MarketValue = value;
					this.SendPropertyChanged("MarketValue");
					this.OnMarketValueChanged();
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
}
#pragma warning restore 1591
