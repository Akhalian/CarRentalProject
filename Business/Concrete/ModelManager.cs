using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        IModelDal _modelDal;

        public ModelManager(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public IDataResult<List<Model>> GetModels()
        {
            return new SuccessDataResult<List<Model>>(_modelDal.GetAll(), ModelMessages.ModelsListed);
        }

        public IResult Add(Model model)
        {
            _modelDal.Add(model);
            return new SuccesResult(ModelMessages.ModelAdded);
        }

        public IResult Delete(Model model)
        {
            _modelDal.Delete(model);
            return new SuccesResult(ModelMessages.ModelDeleted);
        }

        public IResult Update(Model model)
        {
            _modelDal.Update(model);
            return new SuccesResult(ModelMessages.ModelUpdated);
        }
    }
}
