using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public  class EfUserDal : EfEntityRepositoryBase<User,CarRentalDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarRentalDbContext())
            {
                var result = from OperationClaim in context.OperationClaims
                    join UserOperationClaim in context.UserOperationClaims
                        on OperationClaim.Id equals UserOperationClaim.OperationClaimId
                    where UserOperationClaim.UserId == user.UserId
                    select new OperationClaim {Id = OperationClaim.Id, Name = OperationClaim.Name};
                return result.ToList();

            }
        }
    }
}
