using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMenuMVVM
{
    public class Model:IDisposable
    {
        public IntPtr _unManagedResource;
        public string _managedResource;
        private bool _disposed;

        public int Addition(int v1, int v2)
        {
            return v1 + v2;
        }
        public static void AfficherInfo(object obj)
        {
            Console.WriteLine($"type anonyme : {obj}");
        }
        public void mA()
        {
            Console.WriteLine("mA");
        }
        public void mB()
        {
            Console.WriteLine("mB");
        }
        

        public Model()
        {
            _unManagedResource = (IntPtr)42;
            _managedResource = "je suis une ressources managée";
            _disposed = false;
        }
        public void Dispose()
        {
            DisposeBis(true);
            Console.WriteLine("les ressources ont été libérées par la méthode Dispose()!");
            GC.SuppressFinalize(this);
        }
        protected virtual void DisposeBis(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _managedResource = null;
                    Console.WriteLine("La ressource managée est libérée!");
                }
                _unManagedResource = IntPtr.Zero;
                Console.WriteLine("La ressource non managée est libérée!");
            }
            _disposed = true;
        }

        ~Model()
        {
            DisposeBis(false);
        }
    }
}
