using HastaTakip.DAL.Abstract;
using HastaTakip.DAL.Concrete.EntityFramework;
using HastaTakip.Util.Logging;
using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip.BLL
{
    public class InterceptorAllModule : InterceptionModule
    {
        public override void Load()
        {
            //Kernel.Intercept(p => true).With(new Log());
            Bind<IDoktor>().To<EF_Doktor>();
            Bind<IKontrol>().To<EF_Kontrol>();
            Bind<IHasta>().To<EF_Hasta>();
            Bind<IMesaj>().To<EF_Mesaj>();
            
        }
    }
}
