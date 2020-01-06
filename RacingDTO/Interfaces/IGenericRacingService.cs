﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDTO.Interfaces
{
    public interface IGenericRacingService<DTOModel>
        where DTOModel:class
    {
        Task CreateAsync(DTOModel item);
        Task<DTOModel> FindByIdAsync(int id);
        Task<IEnumerable<DTOModel>> GetAllAsync();
        IEnumerable<DTOModel> GetAll(Func<DTOModel, bool> predicate);
        void Remove(DTOModel item);
        Task UpdateAsync(DTOModel item);
    }
}
