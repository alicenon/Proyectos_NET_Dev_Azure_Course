﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _06LINQ_TO_SQL_FORM_QUERY_ACCIONES_DOCTORES
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hospital")]
	public partial class DbDoctoresDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDOCTOR(DOCTOR instance);
    partial void UpdateDOCTOR(DOCTOR instance);
    partial void DeleteDOCTOR(DOCTOR instance);
    #endregion
		
		public DbDoctoresDataContext() : 
				base(global::_06LINQ_TO_SQL_FORM_QUERY_ACCIONES_DOCTORES.Properties.Settings.Default.HospitalConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbDoctoresDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDoctoresDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDoctoresDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDoctoresDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DOCTOR> DOCTOR
		{
			get
			{
				return this.GetTable<DOCTOR>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DOCTOR")]
	public partial class DOCTOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HOSPITAL_COD;
		
		private string _DOCTOR_NO;
		
		private string _APELLIDO;
		
		private string _ESPECIALIDAD;
		
		private System.Nullable<int> _SALARIO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(string value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnDOCTOR_NOChanging(string value);
    partial void OnDOCTOR_NOChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnESPECIALIDADChanging(string value);
    partial void OnESPECIALIDADChanged();
    partial void OnSALARIOChanging(System.Nullable<int> value);
    partial void OnSALARIOChanged();
    #endregion
		
		public DOCTOR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="NVarChar(50)")]
		public string HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this.OnHOSPITAL_CODChanging(value);
					this.SendPropertyChanging();
					this._HOSPITAL_COD = value;
					this.SendPropertyChanged("HOSPITAL_COD");
					this.OnHOSPITAL_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOCTOR_NO", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DOCTOR_NO
		{
			get
			{
				return this._DOCTOR_NO;
			}
			set
			{
				if ((this._DOCTOR_NO != value))
				{
					this.OnDOCTOR_NOChanging(value);
					this.SendPropertyChanging();
					this._DOCTOR_NO = value;
					this.SendPropertyChanged("DOCTOR_NO");
					this.OnDOCTOR_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESPECIALIDAD", DbType="NVarChar(50)")]
		public string ESPECIALIDAD
		{
			get
			{
				return this._ESPECIALIDAD;
			}
			set
			{
				if ((this._ESPECIALIDAD != value))
				{
					this.OnESPECIALIDADChanging(value);
					this.SendPropertyChanging();
					this._ESPECIALIDAD = value;
					this.SendPropertyChanged("ESPECIALIDAD");
					this.OnESPECIALIDADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARIO", DbType="Int")]
		public System.Nullable<int> SALARIO
		{
			get
			{
				return this._SALARIO;
			}
			set
			{
				if ((this._SALARIO != value))
				{
					this.OnSALARIOChanging(value);
					this.SendPropertyChanging();
					this._SALARIO = value;
					this.SendPropertyChanged("SALARIO");
					this.OnSALARIOChanged();
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
