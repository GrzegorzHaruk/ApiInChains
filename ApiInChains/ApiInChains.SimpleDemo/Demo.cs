using ApiInChains.TestData;

namespace ApiInChains.SimpleDemo
{
    public class Demo
    {
        public void Go()
        {
            var result1 = ApiInChains.FromMany<User>().GetMany().Fetch();

            var result2 = ApiInChains.FromMany<User>().GetMany().OrderBy(x => x.OrderBy(x => x.Id)).Fetch();

            var result3 = ApiInChains.FromMany<User>().GetMany().Where(x => x.Id > 0).Fetch();

            var result4 = ApiInChains.FromMany<User>().GetMany().Where(x => x.Id > 1).OrderBy(x => x.OrderBy(x => x.Id)).Fetch();

            var result5 = ApiInChains.FromMany<User>().GetMany().Where(x => x.Id > 2).AndWhere(x => x.Pets.Count() > 0).Fetch();

            var result6 = ApiInChains.FromMany<User>().GetMany().Where(x => x.Id > 0).AndWhere(x => x.LastName == "Does").OrderBy(x => x.OrderBy(x => x.Id)).Fetch();

            var result7 = ApiInChains.FromMany<User>().GetMany().Include().Fetch();

            var result8 = ApiInChains.FromMany<User>().GetMany().Include().OrderBy("Id").Fetch();

            var result10 = ApiInChains.FromMany<User>().GetMany().Include().AndInclude().Fetch();

            var result11 = ApiInChains.FromMany<User>().GetMany().Include().AndInclude().OrderBy(x => x.OrderBy(x => x.FirstName)).Fetch();

            var result12 = ApiInChains.FromMany<User>().GetMany().Where(x => x.Id > 0).Include().Fetch();

            var result13 = ApiInChains.FromMany<User>().GetMany().Where(x => x.Id > 0).AndWhere(x => x.FirstName == "Harry").Include().AndInclude().Fetch();

            // To do
            //var result14 = ApiInChains.FromMany<User>().GetMany().Include().Where().Fetch();
        }
    }
}