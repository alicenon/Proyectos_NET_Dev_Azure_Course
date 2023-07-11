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

namespace _09LINQ_TO_SQL_PROCEDIMIENTOS_ALM_PLANTILLA
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
	public partial class DbEmpleadosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertPLANTILLA(PLANTILLA instance);
    partial void UpdatePLANTILLA(PLANTILLA instance);
    partial void DeletePLANTILLA(PLANTILLA instance);
    #endregion
		
		public DbEmpleadosDataContext() : 
				base(global::_09LINQ_TO_SQL_PROCEDIMIENTOS_ALM_PLANTILLA.Properties.Settings.Default.HospitalConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbEmpleadosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbEmpleadosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbEmpleadosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbEmpleadosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PLANTILLA> PLANTILLA
		{
			get
			{
				return this.GetTable<PLANTILLA>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.MODIFICARPLANTILLA")]
		public int MODIFICARPLANTILLA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CODIGO", DbType="Int")] System.Nullable<int> cODIGO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="APELLIDO", DbType="NVarChar(30)")] string aPELLIDO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FUNCION", DbType="NVarChar(30)")] string fUNCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cODIGO, aPELLIDO, fUNCION);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PLANTILLA")]
	public partial class PLANTILLA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HOSPITAL_COD;
		
		private string _SALA_COD;
		
		private string _EMPLEADO_NO;
		
		private string _APELLIDO;
		
		private string _FUNCION;
		
		private string _T;
		
		private System.Nullable<int> _SALARIO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(string value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnSALA_CODChanging(string value);
    partial void OnSALA_CODChanged();
    partial void OnEMPLEADO_NOChanging(string value);
    partial void OnEMPLEADO_NOChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnFUNCIONChanging(string value);
    partial void OnFUNCIONChanged();
    partial void OnTChanging(string value);
    partial void OnTChanged();
    partial void OnSALARIOChanging(System.Nullable<int> value);
    partial void OnSALARIOChanged();
    #endregion
		
		public PLANTILLA()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALA_COD", DbType="NVarChar(50)")]
		public string SALA_COD
		{
			get
			{
				return this._SALA_COD;
			}
			set
			{
				if ((this._SALA_COD != value))
				{
					this.OnSALA_CODChanging(value);
					this.SendPropertyChanging();
					this._SALA_COD = value;
					this.SendPropertyChanged("SALA_COD");
					this.OnSALA_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMPLEADO_NO", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EMPLEADO_NO
		{
			get
			{
				return this._EMPLEADO_NO;
			}
			set
			{
				if ((this._EMPLEADO_NO != value))
				{
					this.OnEMPLEADO_NOChanging(value);
					this.SendPropertyChanging();
					this._EMPLEADO_NO = value;
					this.SendPropertyChanged("EMPLEADO_NO");
					this.OnEMPLEADO_NOChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FUNCION", DbType="NVarChar(50)")]
		public string FUNCION
		{
			get
			{
				return this._FUNCION;
			}
			set
			{
				if ((this._FUNCION != value))
				{
					this.OnFUNCIONChanging(value);
					this.SendPropertyChanging();
					this._FUNCION = value;
					this.SendPropertyChanged("FUNCION");
					this.OnFUNCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T", DbType="NVarChar(50)")]
		public string T
		{
			get
			{
				return this._T;
			}
			set
			{
				if ((this._T != value))
				{
					this.OnTChanging(value);
					this.SendPropertyChanging();
					this._T = value;
					this.SendPropertyChanged("T");
					this.OnTChanged();
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
