using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, CarRentalDbContext>, IOperationClaimDal
    {
    }
}
