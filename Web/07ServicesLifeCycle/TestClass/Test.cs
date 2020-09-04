using System;

namespace _07ServicesLifeCycle.TestClass
{
    public class ServicesBase
    {
        public Guid ID { get; }

        protected ServicesBase()
        {
            ID = Guid.NewGuid();
        }
    }

    public sealed class ServiceA : ServicesBase { }
    public sealed class ServiceB : ServicesBase { }
    public sealed class ServiceC : ServicesBase { }

    public class ServiceDependencyAll
    {
        public readonly ServicesBase Service_A;
        public readonly ServicesBase Service_B;
        public readonly ServicesBase Service_C;
        public ServiceDependencyAll(ServiceA sva,ServiceB svb,ServiceC svc)
        {
            Service_A = sva;
            Service_B = svb;
            Service_C = svc;
        }
    }
}