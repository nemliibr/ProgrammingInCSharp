using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter2
{
    class Listing2_84 : IExecuter
    {
        public void Execute(string[] args)
        {
            //using can be used for objects implementing the IDispose interface
            using (UnmanagedWrapper uw1 = new UnmanagedWrapper())
            {}

            UnmanagedWrapper uw2 = new UnmanagedWrapper();
        }
    }

    class UnmanagedWrapper : IDisposable
    {
        private IntPtr unmanagedBuffer;
        public FileStream Stream { get; private set; }
        
        public UnmanagedWrapper()
        {
            CreateBuffer();
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }
        
        private void CreateBuffer()
        {
            byte[] data = new byte[1024];
            new Random().NextBytes(data);
            unmanagedBuffer = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, unmanagedBuffer, data.Length);
        }
        
        ~UnmanagedWrapper()
        {
            Console.WriteLine("finalizer has been called");
            Dispose(false);
        }
        
        public void Close()
        {
            Dispose();
        }
        
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Marshal.FreeHGlobal(unmanagedBuffer);
            if (disposing)
            {
                Console.WriteLine("Disposing");
                if (Stream != null)
                {
                    Stream.Close();
                    Console.WriteLine("Stream closed");
                }
            }
        }
    }
}
