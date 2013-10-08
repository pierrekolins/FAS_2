﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilverlightSite.Web
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SilverLight")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttbAluno(tbAluno instance);
    partial void UpdatetbAluno(tbAluno instance);
    partial void DeletetbAluno(tbAluno instance);
    partial void InserttbCurso(tbCurso instance);
    partial void UpdatetbCurso(tbCurso instance);
    partial void DeletetbCurso(tbCurso instance);
    partial void InserttbDisciplina(tbDisciplina instance);
    partial void UpdatetbDisciplina(tbDisciplina instance);
    partial void DeletetbDisciplina(tbDisciplina instance);
    partial void InserttbFinanceiro(tbFinanceiro instance);
    partial void UpdatetbFinanceiro(tbFinanceiro instance);
    partial void DeletetbFinanceiro(tbFinanceiro instance);
    partial void InserttbProfessor(tbProfessor instance);
    partial void UpdatetbProfessor(tbProfessor instance);
    partial void DeletetbProfessor(tbProfessor instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SilverLightConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbAluno> tbAlunos
		{
			get
			{
				return this.GetTable<tbAluno>();
			}
		}
		
		public System.Data.Linq.Table<tbCurso> tbCursos
		{
			get
			{
				return this.GetTable<tbCurso>();
			}
		}
		
		public System.Data.Linq.Table<tbDisciplina> tbDisciplinas
		{
			get
			{
				return this.GetTable<tbDisciplina>();
			}
		}
		
		public System.Data.Linq.Table<tbFinanceiro> tbFinanceiros
		{
			get
			{
				return this.GetTable<tbFinanceiro>();
			}
		}
		
		public System.Data.Linq.Table<tbProfessor> tbProfessors
		{
			get
			{
				return this.GetTable<tbProfessor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbAluno")]
	public partial class tbAluno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAluno;
		
		private string _nome;
		
		private System.Nullable<double> _nota;
		
		private System.Nullable<int> _idCurso;
		
		private EntitySet<tbDisciplina> _tbDisciplinas;
		
		private EntitySet<tbFinanceiro> _tbFinanceiros;
		
		private EntityRef<tbCurso> _tbCurso;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAlunoChanging(int value);
    partial void OnidAlunoChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnnotaChanging(System.Nullable<double> value);
    partial void OnnotaChanged();
    partial void OnidCursoChanging(System.Nullable<int> value);
    partial void OnidCursoChanged();
    #endregion
		
		public tbAluno()
		{
			this._tbDisciplinas = new EntitySet<tbDisciplina>(new Action<tbDisciplina>(this.attach_tbDisciplinas), new Action<tbDisciplina>(this.detach_tbDisciplinas));
			this._tbFinanceiros = new EntitySet<tbFinanceiro>(new Action<tbFinanceiro>(this.attach_tbFinanceiros), new Action<tbFinanceiro>(this.detach_tbFinanceiros));
			this._tbCurso = default(EntityRef<tbCurso>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAluno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idAluno
		{
			get
			{
				return this._idAluno;
			}
			set
			{
				if ((this._idAluno != value))
				{
					this.OnidAlunoChanging(value);
					this.SendPropertyChanging();
					this._idAluno = value;
					this.SendPropertyChanged("idAluno");
					this.OnidAlunoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nota", DbType="Float")]
		public System.Nullable<double> nota
		{
			get
			{
				return this._nota;
			}
			set
			{
				if ((this._nota != value))
				{
					this.OnnotaChanging(value);
					this.SendPropertyChanging();
					this._nota = value;
					this.SendPropertyChanged("nota");
					this.OnnotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCurso", DbType="Int")]
		public System.Nullable<int> idCurso
		{
			get
			{
				return this._idCurso;
			}
			set
			{
				if ((this._idCurso != value))
				{
					if (this._tbCurso.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCursoChanging(value);
					this.SendPropertyChanging();
					this._idCurso = value;
					this.SendPropertyChanged("idCurso");
					this.OnidCursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbAluno_tbDisciplina", Storage="_tbDisciplinas", ThisKey="idAluno", OtherKey="idAluno")]
		public EntitySet<tbDisciplina> tbDisciplinas
		{
			get
			{
				return this._tbDisciplinas;
			}
			set
			{
				this._tbDisciplinas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbAluno_tbFinanceiro", Storage="_tbFinanceiros", ThisKey="idAluno", OtherKey="idaluno")]
		public EntitySet<tbFinanceiro> tbFinanceiros
		{
			get
			{
				return this._tbFinanceiros;
			}
			set
			{
				this._tbFinanceiros.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbCurso_tbAluno", Storage="_tbCurso", ThisKey="idCurso", OtherKey="idCurso", IsForeignKey=true)]
		public tbCurso tbCurso
		{
			get
			{
				return this._tbCurso.Entity;
			}
			set
			{
				tbCurso previousValue = this._tbCurso.Entity;
				if (((previousValue != value) 
							|| (this._tbCurso.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbCurso.Entity = null;
						previousValue.tbAlunos.Remove(this);
					}
					this._tbCurso.Entity = value;
					if ((value != null))
					{
						value.tbAlunos.Add(this);
						this._idCurso = value.idCurso;
					}
					else
					{
						this._idCurso = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbCurso");
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
		
		private void attach_tbDisciplinas(tbDisciplina entity)
		{
			this.SendPropertyChanging();
			entity.tbAluno = this;
		}
		
		private void detach_tbDisciplinas(tbDisciplina entity)
		{
			this.SendPropertyChanging();
			entity.tbAluno = null;
		}
		
		private void attach_tbFinanceiros(tbFinanceiro entity)
		{
			this.SendPropertyChanging();
			entity.tbAluno = this;
		}
		
		private void detach_tbFinanceiros(tbFinanceiro entity)
		{
			this.SendPropertyChanging();
			entity.tbAluno = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbCurso")]
	public partial class tbCurso : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCurso;
		
		private string _nome;
		
		private System.Nullable<int> _ano;
		
		private EntitySet<tbAluno> _tbAlunos;
		
		private EntitySet<tbDisciplina> _tbDisciplinas;
		
		private EntitySet<tbProfessor> _tbProfessors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCursoChanging(int value);
    partial void OnidCursoChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnanoChanging(System.Nullable<int> value);
    partial void OnanoChanged();
    #endregion
		
		public tbCurso()
		{
			this._tbAlunos = new EntitySet<tbAluno>(new Action<tbAluno>(this.attach_tbAlunos), new Action<tbAluno>(this.detach_tbAlunos));
			this._tbDisciplinas = new EntitySet<tbDisciplina>(new Action<tbDisciplina>(this.attach_tbDisciplinas), new Action<tbDisciplina>(this.detach_tbDisciplinas));
			this._tbProfessors = new EntitySet<tbProfessor>(new Action<tbProfessor>(this.attach_tbProfessors), new Action<tbProfessor>(this.detach_tbProfessors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCurso", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idCurso
		{
			get
			{
				return this._idCurso;
			}
			set
			{
				if ((this._idCurso != value))
				{
					this.OnidCursoChanging(value);
					this.SendPropertyChanging();
					this._idCurso = value;
					this.SendPropertyChanged("idCurso");
					this.OnidCursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ano", DbType="Int")]
		public System.Nullable<int> ano
		{
			get
			{
				return this._ano;
			}
			set
			{
				if ((this._ano != value))
				{
					this.OnanoChanging(value);
					this.SendPropertyChanging();
					this._ano = value;
					this.SendPropertyChanged("ano");
					this.OnanoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbCurso_tbAluno", Storage="_tbAlunos", ThisKey="idCurso", OtherKey="idCurso")]
		public EntitySet<tbAluno> tbAlunos
		{
			get
			{
				return this._tbAlunos;
			}
			set
			{
				this._tbAlunos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbCurso_tbDisciplina", Storage="_tbDisciplinas", ThisKey="idCurso", OtherKey="idCurso")]
		public EntitySet<tbDisciplina> tbDisciplinas
		{
			get
			{
				return this._tbDisciplinas;
			}
			set
			{
				this._tbDisciplinas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbCurso_tbProfessor", Storage="_tbProfessors", ThisKey="idCurso", OtherKey="idCurso")]
		public EntitySet<tbProfessor> tbProfessors
		{
			get
			{
				return this._tbProfessors;
			}
			set
			{
				this._tbProfessors.Assign(value);
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
		
		private void attach_tbAlunos(tbAluno entity)
		{
			this.SendPropertyChanging();
			entity.tbCurso = this;
		}
		
		private void detach_tbAlunos(tbAluno entity)
		{
			this.SendPropertyChanging();
			entity.tbCurso = null;
		}
		
		private void attach_tbDisciplinas(tbDisciplina entity)
		{
			this.SendPropertyChanging();
			entity.tbCurso = this;
		}
		
		private void detach_tbDisciplinas(tbDisciplina entity)
		{
			this.SendPropertyChanging();
			entity.tbCurso = null;
		}
		
		private void attach_tbProfessors(tbProfessor entity)
		{
			this.SendPropertyChanging();
			entity.tbCurso = this;
		}
		
		private void detach_tbProfessors(tbProfessor entity)
		{
			this.SendPropertyChanging();
			entity.tbCurso = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbDisciplina")]
	public partial class tbDisciplina : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idDisciplina;
		
		private string _nome;
		
		private System.Nullable<int> _idAluno;
		
		private System.Nullable<int> _idCurso;
		
		private System.Nullable<int> _idProfessor;
		
		private EntityRef<tbAluno> _tbAluno;
		
		private EntityRef<tbCurso> _tbCurso;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDisciplinaChanging(int value);
    partial void OnidDisciplinaChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnidAlunoChanging(System.Nullable<int> value);
    partial void OnidAlunoChanged();
    partial void OnidCursoChanging(System.Nullable<int> value);
    partial void OnidCursoChanged();
    partial void OnidProfessorChanging(System.Nullable<int> value);
    partial void OnidProfessorChanged();
    #endregion
		
		public tbDisciplina()
		{
			this._tbAluno = default(EntityRef<tbAluno>);
			this._tbCurso = default(EntityRef<tbCurso>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDisciplina", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idDisciplina
		{
			get
			{
				return this._idDisciplina;
			}
			set
			{
				if ((this._idDisciplina != value))
				{
					this.OnidDisciplinaChanging(value);
					this.SendPropertyChanging();
					this._idDisciplina = value;
					this.SendPropertyChanged("idDisciplina");
					this.OnidDisciplinaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAluno", DbType="Int")]
		public System.Nullable<int> idAluno
		{
			get
			{
				return this._idAluno;
			}
			set
			{
				if ((this._idAluno != value))
				{
					if (this._tbAluno.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAlunoChanging(value);
					this.SendPropertyChanging();
					this._idAluno = value;
					this.SendPropertyChanged("idAluno");
					this.OnidAlunoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCurso", DbType="Int")]
		public System.Nullable<int> idCurso
		{
			get
			{
				return this._idCurso;
			}
			set
			{
				if ((this._idCurso != value))
				{
					if (this._tbCurso.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCursoChanging(value);
					this.SendPropertyChanging();
					this._idCurso = value;
					this.SendPropertyChanged("idCurso");
					this.OnidCursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProfessor", DbType="Int")]
		public System.Nullable<int> idProfessor
		{
			get
			{
				return this._idProfessor;
			}
			set
			{
				if ((this._idProfessor != value))
				{
					this.OnidProfessorChanging(value);
					this.SendPropertyChanging();
					this._idProfessor = value;
					this.SendPropertyChanged("idProfessor");
					this.OnidProfessorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbAluno_tbDisciplina", Storage="_tbAluno", ThisKey="idAluno", OtherKey="idAluno", IsForeignKey=true)]
		public tbAluno tbAluno
		{
			get
			{
				return this._tbAluno.Entity;
			}
			set
			{
				tbAluno previousValue = this._tbAluno.Entity;
				if (((previousValue != value) 
							|| (this._tbAluno.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbAluno.Entity = null;
						previousValue.tbDisciplinas.Remove(this);
					}
					this._tbAluno.Entity = value;
					if ((value != null))
					{
						value.tbDisciplinas.Add(this);
						this._idAluno = value.idAluno;
					}
					else
					{
						this._idAluno = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbAluno");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbCurso_tbDisciplina", Storage="_tbCurso", ThisKey="idCurso", OtherKey="idCurso", IsForeignKey=true)]
		public tbCurso tbCurso
		{
			get
			{
				return this._tbCurso.Entity;
			}
			set
			{
				tbCurso previousValue = this._tbCurso.Entity;
				if (((previousValue != value) 
							|| (this._tbCurso.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbCurso.Entity = null;
						previousValue.tbDisciplinas.Remove(this);
					}
					this._tbCurso.Entity = value;
					if ((value != null))
					{
						value.tbDisciplinas.Add(this);
						this._idCurso = value.idCurso;
					}
					else
					{
						this._idCurso = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbCurso");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbFinanceiro")]
	public partial class tbFinanceiro : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idFinanceiro;
		
		private string _mes;
		
		private string _pago;
		
		private System.Nullable<int> _idaluno;
		
		private EntityRef<tbAluno> _tbAluno;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidFinanceiroChanging(int value);
    partial void OnidFinanceiroChanged();
    partial void OnmesChanging(string value);
    partial void OnmesChanged();
    partial void OnpagoChanging(string value);
    partial void OnpagoChanged();
    partial void OnidalunoChanging(System.Nullable<int> value);
    partial void OnidalunoChanged();
    #endregion
		
		public tbFinanceiro()
		{
			this._tbAluno = default(EntityRef<tbAluno>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idFinanceiro", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idFinanceiro
		{
			get
			{
				return this._idFinanceiro;
			}
			set
			{
				if ((this._idFinanceiro != value))
				{
					this.OnidFinanceiroChanging(value);
					this.SendPropertyChanging();
					this._idFinanceiro = value;
					this.SendPropertyChanged("idFinanceiro");
					this.OnidFinanceiroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mes", DbType="VarChar(50)")]
		public string mes
		{
			get
			{
				return this._mes;
			}
			set
			{
				if ((this._mes != value))
				{
					this.OnmesChanging(value);
					this.SendPropertyChanging();
					this._mes = value;
					this.SendPropertyChanged("mes");
					this.OnmesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pago", DbType="VarChar(1)")]
		public string pago
		{
			get
			{
				return this._pago;
			}
			set
			{
				if ((this._pago != value))
				{
					this.OnpagoChanging(value);
					this.SendPropertyChanging();
					this._pago = value;
					this.SendPropertyChanged("pago");
					this.OnpagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idaluno", DbType="Int")]
		public System.Nullable<int> idaluno
		{
			get
			{
				return this._idaluno;
			}
			set
			{
				if ((this._idaluno != value))
				{
					if (this._tbAluno.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidalunoChanging(value);
					this.SendPropertyChanging();
					this._idaluno = value;
					this.SendPropertyChanged("idaluno");
					this.OnidalunoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbAluno_tbFinanceiro", Storage="_tbAluno", ThisKey="idaluno", OtherKey="idAluno", IsForeignKey=true)]
		public tbAluno tbAluno
		{
			get
			{
				return this._tbAluno.Entity;
			}
			set
			{
				tbAluno previousValue = this._tbAluno.Entity;
				if (((previousValue != value) 
							|| (this._tbAluno.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbAluno.Entity = null;
						previousValue.tbFinanceiros.Remove(this);
					}
					this._tbAluno.Entity = value;
					if ((value != null))
					{
						value.tbFinanceiros.Add(this);
						this._idaluno = value.idAluno;
					}
					else
					{
						this._idaluno = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbAluno");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbProfessor")]
	public partial class tbProfessor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idProfessor;
		
		private string _nome;
		
		private System.Nullable<int> _idCurso;
		
		private EntityRef<tbCurso> _tbCurso;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProfessorChanging(int value);
    partial void OnidProfessorChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnidCursoChanging(System.Nullable<int> value);
    partial void OnidCursoChanged();
    #endregion
		
		public tbProfessor()
		{
			this._tbCurso = default(EntityRef<tbCurso>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProfessor", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idProfessor
		{
			get
			{
				return this._idProfessor;
			}
			set
			{
				if ((this._idProfessor != value))
				{
					this.OnidProfessorChanging(value);
					this.SendPropertyChanging();
					this._idProfessor = value;
					this.SendPropertyChanged("idProfessor");
					this.OnidProfessorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCurso", DbType="Int")]
		public System.Nullable<int> idCurso
		{
			get
			{
				return this._idCurso;
			}
			set
			{
				if ((this._idCurso != value))
				{
					if (this._tbCurso.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCursoChanging(value);
					this.SendPropertyChanging();
					this._idCurso = value;
					this.SendPropertyChanged("idCurso");
					this.OnidCursoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbCurso_tbProfessor", Storage="_tbCurso", ThisKey="idCurso", OtherKey="idCurso", IsForeignKey=true)]
		public tbCurso tbCurso
		{
			get
			{
				return this._tbCurso.Entity;
			}
			set
			{
				tbCurso previousValue = this._tbCurso.Entity;
				if (((previousValue != value) 
							|| (this._tbCurso.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbCurso.Entity = null;
						previousValue.tbProfessors.Remove(this);
					}
					this._tbCurso.Entity = value;
					if ((value != null))
					{
						value.tbProfessors.Add(this);
						this._idCurso = value.idCurso;
					}
					else
					{
						this._idCurso = default(Nullable<int>);
					}
					this.SendPropertyChanged("tbCurso");
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