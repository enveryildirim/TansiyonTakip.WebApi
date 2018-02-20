using Ninject.Extensions.Interception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HastaTakip.Util.Logging
{

    public enum LogSeviye {Trace,Error,Info,Warn,Fatal}
    public static class Logger 
    {

    }


    /*public class Log : IInterceptor
    {
       Logger logger = LogManager.GetCurrentClassLogger();

      /* protected override void AfterInvoke(IInvocation invocation)
       {
           logger.Log(LogLevel.Trace,invocation.Request.Method.Name+" çalıştı");
           base.AfterInvoke(invocation);
       }
        
       public void Intercept(IInvocation invocation)
       {
           logger.Log(LogLevel.Trace, invocation.Request.Method.Name + " çalıştı");
         
       }*/
    
}
