using Common.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reactive.BL.Main.Interfaces
{
    interface IWorkers
    {
        IEnumerable<Worker> GetWorkers();

        Task<IEnumerable<Worker>> GetData();

    }
}
