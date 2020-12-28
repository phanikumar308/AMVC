using Sample.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Infrastructure.Repositories
{
    public class RepoHelloWorld : IRepoHelloWorld
    {
        private IHelloWorldMessage _helloWorldMessage;

        public RepoHelloWorld(IHelloWorldMessage helloWorldMessage)
        {
            _helloWorldMessage = helloWorldMessage;
        }
        public async Task<List<string>> repohelloWorld()
        {
            List<string> a = new List<string>();
            Task<List<string>> t = Task<List<string>>.Factory.StartNew(() =>
            {
                int i = 0;
                for (i = 1; i <= 10; i++)
                {
                    string helloWorld = _helloWorldMessage.HelloWorld();
                    a.Add(helloWorld);
                }
                return a;
            });
            return await t;
        }
    }
}
