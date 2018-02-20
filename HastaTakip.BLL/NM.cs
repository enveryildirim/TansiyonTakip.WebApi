using HastaTakip.DAL.Abstract;
using HastaTakip.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaTakip.Util.Logging;

namespace HastaTakip.BLL
{
    public class NM:NinjectModule
    {
        public override void Load()
        {
            //Kernel.Intercept(p => (true)).With(new Logger());
            Bind<IDoktor>().To<EF_Doktor>();
            Bind<IKontrol>().To<EF_Kontrol>();
            Bind<IHasta>().To<EF_Hasta>();
            Bind<IMesaj>().To<EF_Mesaj>();
            
        }
    }
}
