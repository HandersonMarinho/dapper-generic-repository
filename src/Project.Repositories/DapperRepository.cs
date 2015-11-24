using DapperExtensions;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Project.Repositories
{
    public abstract class DapperRepository<TModel> where TModel : class
    {
        public DapperRepository(IDatabaseConfig databaseConfig)
        {
            DatabaseConfig = databaseConfig;
        }

        private IDatabaseConfig DatabaseConfig { get; }

        private SqlConnection Context
        {
            get
            {
                var cn = new SqlConnection(DatabaseConfig.ConnectionString);
                cn.Open();
                return cn;
            }
        }

        protected void Create(TModel model)
        {
            using (var db = Context)
            {
                db.Insert(model);
            }
        }

        protected void Update(TModel model)
        {
            using (var db = Context)
            {
                db.Update(model);
            }
        }

        protected void Delete(TModel model)
        {
            using (var db = Context)
            {
                db.Delete(model);
            }
        }

        protected TModel[] RetrieveMany(Expression<Func<TModel, object>> filter, object value)
        {
            using (var db = Context)
            {
                var predicate = Predicates.Field(filter, Operator.Eq, value);
                return db.GetList<TModel>(predicate).ToArray();
            }
        }

        protected TModel RetrieveSingle(Expression<Func<TModel, object>> filter, object value)
        {
            using (var db = Context)
            {
                var predicate = Predicates.Field(filter, Operator.Eq, value);
                return db.GetList<TModel>(predicate).SingleOrDefault();
            }
        }

        protected TModel[] RetrieveAll()
        {
            using (var db = Context)
            {
                return db.GetList<TModel>().ToArray();
            }
        }
    }
}
