using ITUniver.Calc.Core.Interfaces;
using ITUniver.Calc.DB.Models;
using System.Collections.Generic;


namespace ITUniver.Calc.DB.Repositories
{
    public interface IHistoryRepository : IBaseRepository<IHistoryItem>
    {
    }

    public interface IOperationRepository : IBaseRepository<IOperation>
    {
    }
}
