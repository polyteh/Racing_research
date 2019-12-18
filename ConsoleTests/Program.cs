using RacingDAL;
using RacingDAL.Interfaces;
using RacingDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //db tests
            IGeneralDBRepository<Engine> engineRepo = new GenericRacingRepository<Engine>(new RacingDBContext());
            Engine myFirstEngine = new Engine() { Name = "R10", HP = 250, Turbine = false, Manufacurer="Renault",Price=1000 };
            engineRepo.Create(myFirstEngine);
        }
    }
}
