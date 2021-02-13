using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IModelService
    {
        IDataResult<List<Model>> GetModels();
        IResult Add(Model model);
        IResult Delete(Model model);
        IResult Update(Model model);
    }
}
