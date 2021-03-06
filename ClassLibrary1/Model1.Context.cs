﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Currency> Currencies { get; set; }
    
        public virtual int addCurrency(string name, Nullable<double> value, string statuts)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var valueParameter = value.HasValue ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(double));
    
            var statutsParameter = statuts != null ?
                new ObjectParameter("statuts", statuts) :
                new ObjectParameter("statuts", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addCurrency", nameParameter, valueParameter, statutsParameter);
        }
    
        public virtual int DeleteCurrency(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCurrency", idParameter);
        }
    
        public virtual int UpdateCurrency(Nullable<int> id, string name, Nullable<double> value, string statuts)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var valueParameter = value.HasValue ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(double));
    
            var statutsParameter = statuts != null ?
                new ObjectParameter("statuts", statuts) :
                new ObjectParameter("statuts", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCurrency", idParameter, nameParameter, valueParameter, statutsParameter);
        }
    }
}
