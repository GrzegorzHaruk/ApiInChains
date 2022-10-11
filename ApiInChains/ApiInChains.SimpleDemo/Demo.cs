using ApiInChains.TestData;

namespace ApiInChains.SimpleDemo
{
    public class Demo
    {
        public void Go()
        {
            var result1 = ApiInChains.FromMany<User>().GetMany().Fetch();

            var result2 = ApiInChains.FromMany<User>().GetMany().OrderBy().Fetch();

            var result3 = ApiInChains.FromMany<User>().GetMany().Where().Fetch();

            var result4 = ApiInChains.FromMany<User>().GetMany().Where().OrderBy().Fetch();

            var result5 = ApiInChains.FromMany<User>().GetMany().Where().AndWhere().Fetch();

            var result6 = ApiInChains.FromMany<User>().GetMany().Where().AndWhere().OrderBy().Fetch();

            var result7 = ApiInChains.FromMany<User>().GetMany().Include().Fetch();

            var result8 = ApiInChains.FromMany<User>().GetMany().Include().OrderBy().Fetch();

            var result10 = ApiInChains.FromMany<User>().GetMany().Include().AndInclude().Fetch();

            var result11 = ApiInChains.FromMany<User>().GetMany().Include().AndInclude().OrderBy().Fetch();

            var result12 = ApiInChains.FromMany<User>().GetMany().Where().Include().Fetch();

            var result13 = ApiInChains.FromMany<User>().GetMany().Where().AndWhere().Include().AndInclude().Fetch();

            // To do
            //var result14 = ApiInChains.FromMany<User>().GetMany().Include().Where().Fetch();
        }
    }
}