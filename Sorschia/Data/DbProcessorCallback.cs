using System.Data.Common;

namespace Sorschia
{
    public delegate T DbProcessorCallback<T, TCommand>(int affectedRows, TCommand command) where TCommand : DbCommand;
}
