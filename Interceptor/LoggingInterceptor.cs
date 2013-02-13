using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace Interceptor
{
    public class LoggingInterceptor : IInterceptor
    {
        #region IInterceptor Members

        public void Intercept(IInvocation invocation)
        {
            //var logger = LogManager.GetLogger(invocation.TargetType);
            try
            {
                Console.WriteLine("Logging On Start"); 
                
                invocation.Proceed();
                Console.WriteLine("Logging On Success");
            }
            catch (Exception e)
            {
                Console.WriteLine("Logging an exception has occurred");
                throw;
            }
            finally
            {
                Console.WriteLine("Logging on Exit");
            }
        }

        #endregion
    }
}
