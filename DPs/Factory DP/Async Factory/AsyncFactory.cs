using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Async_Factory
{
    internal class AsyncFactory
    {
        private AsyncFactory()
        {

        }
        private async Task<AsyncFactory> InitAsync() 
        {
            await Task.Delay(1000);
            return this;
        }
        public static async Task<AsyncFactory> CreateInstanceAsync()
        {
            var res = new AsyncFactory();
            
            return await res.InitAsync();
        }
    }
}
