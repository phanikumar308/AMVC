using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Abstract.Repositories
{
    public interface IRepoHelloWorld
    {
        Task<List<string>> repohelloWorld();

    }
}
