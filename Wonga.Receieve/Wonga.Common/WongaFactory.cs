
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Wonga.Common
{
    /// <summary>
    /// Wonga Factory Class which is incorporated factory pattern using Unity Container based on IOC(Inversion of Control principle)
    /// </summary>
    public static class WongaFactory
    {
        public static T CreateInstance<T>()
        {
            var container = new UnityContainer();
            container.LoadConfiguration();
            var resolvedObject = container.Resolve<T>();
            return resolvedObject;
        }
    }
}
