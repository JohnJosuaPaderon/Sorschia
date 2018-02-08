using Sorschia.Process;
using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.Data
{
    public abstract class DbCommandCreatorBase<TConnection, TTransaction, TCommand, TParameter> : IDbCommandCreator<TCommand>
        where TConnection : DbConnection
        where TTransaction : DbTransaction
        where TCommand : DbCommand
        where TParameter : DbParameter
    {
        public DbCommandCreatorBase(Action<TCommand, TParameter> addParameter)
        {
            _AddParameter = addParameter;
        }

        private readonly IDbConnectionProvider<TConnection> _ConnectionProvider;
        private readonly IDbTransactionProvider<TTransaction> _TransactionProvider;
        private readonly IDbQueryParameterConverter<TParameter> _ParameterConverter;
        private readonly Action<TCommand, TParameter> _AddParameter;

        protected abstract TCommand Construct(TConnection connection, TTransaction transaction);

        private TCommand Create(IDbQuery query, TConnection connection, TTransaction transaction)
        {
            var command = Construct(connection, transaction);

            foreach (var parameter in query.Parameters)
            {
                _AddParameter(command, _ParameterConverter.Convert(parameter));
            }

            return command;
        }

        public TCommand Create(IDbQuery query, IProcessContext context)
        {
            return Create(query, _ConnectionProvider.Get(context), _TransactionProvider.Get(context));
        }

        public async Task<TCommand> CreateAsync(IDbQuery query, IProcessContext context)
        {
            return Create(query, await _ConnectionProvider.GetAsync(context), _TransactionProvider.Get(context));
        }

        public async Task<TCommand> CreateAsync(IDbQuery query, IProcessContext context, CancellationToken cancellationToken)
        {
            return Create(query, await _ConnectionProvider.GetAsync(context, cancellationToken), _TransactionProvider.Get(context));
        }
    }
}
