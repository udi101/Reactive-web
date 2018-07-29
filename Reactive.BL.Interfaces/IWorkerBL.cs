﻿using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive.BL.Interfaces
{
    public interface IWorkerBL
    {
        IEnumerable<Worker> GetWorkers();

        Task<IEnumerable<Worker>> GetData();
    }
}
