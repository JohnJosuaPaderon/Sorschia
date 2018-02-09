using System.Data.Common;

namespace Sorschia.Data
{
    public delegate T DbProcessorCallback<T, TCommand>(int affectedRows, TCommand command) where TCommand : DbCommand;
}
