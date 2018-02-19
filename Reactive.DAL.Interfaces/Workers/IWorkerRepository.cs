using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive.DAL.Interfaces.Workers
{
    public interface IWorkerRepository
    {
        Task<IEnumerable<Worker>> GetData();

        Task<Worker> GetWorker();

    }
}
