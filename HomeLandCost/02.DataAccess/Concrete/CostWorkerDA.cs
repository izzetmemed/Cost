using HomeLandCost._01.Core.Concrete;
using HomeLandCost._02.DataAccess.Abstract;
using HomeLandCost._03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLandCost._02.DataAccess.Concrete
{
    public class CostWorkerDA:BaseRepository<CostWorkerModel,MyDbContext>,ICostWorkerDA
    {
    }
}
