using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        public IDataResult<List<Model>> GetModels()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Model model)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
