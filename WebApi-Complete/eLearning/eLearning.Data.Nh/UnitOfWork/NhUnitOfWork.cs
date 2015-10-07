
using Chaos.Core.UnitOfWork;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Nh.UnitOfWork
{
    public class NhUnitOfWork : IUnitOfWork
    {
        [ThreadStatic]
        private static NhUnitOfWork _curret;
        public static NhUnitOfWork Current
        {
            get { return _curret; }
            set { _curret = value; }
        }
        private readonly ISessionFactory _sessionFactory;

        private ITransaction _transaction;
        public ISession Session { get; private set; }
        public NhUnitOfWork(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }
        public void BeginTransaction()
        {
            Session = _sessionFactory.OpenSession();
            _transaction = Session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Session.Close();
            }
        }

        public void Rollback()
        {
            try
            {
                _transaction.Rollback();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Session.Close();
            }
        }
    }
}
