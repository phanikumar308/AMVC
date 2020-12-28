using Sample.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Entities
{
    public class HelloWorldMessage : IHelloWorldMessage
    {
        public string HelloWorld()
        {
            return "hello world";
        }
    }
}
