using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MemoryLeakFA5601
{
    public class Function1
    {
        static string myString = String.Empty;

        [Disable]
        [FunctionName("Function1")]
        public void Run([TimerTrigger("*/1 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            for(int i = 0; i < 100000; i++)
            {
                myString = myString + "Testing";
            }
        }
    }
}
