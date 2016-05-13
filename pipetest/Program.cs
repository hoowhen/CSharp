using System;
using System.IO.Pipes;
using System.Text;

namespace pipetest
{
    class Program
    {
        #region Private Fields

        private const int PipeInBufferSize = 4096;
        private const string PipeName = "PipeSample";
        private const int PipeOutBufferSize = 65535;
        private static NamedPipeServerStream _pipe;
        private static Encoding encoding = Encoding.UTF8;

        #endregion Private Fields



        #region Private Methods

        private static void Main(string[] args)
        {
            _pipe = new NamedPipeServerStream
              (
                PipeName,
                PipeDirection.InOut,
                1,
                PipeTransmissionMode.Message,
                PipeOptions.Asynchronous | PipeOptions.WriteThrough,
                PipeInBufferSize,
                PipeOutBufferSize
               );
            _pipe.BeginWaitForConnection(WaitForConnectionCallback, _pipe);
            while (true) ;
        }

        private static void WaitForConnectionCallback(IAsyncResult ar)
        {
            var pipeServer = (NamedPipeServerStream)ar.AsyncState;
            pipeServer.EndWaitForConnection(ar);
            byte[] b = new byte[4] { 48, 49, 50, 10 };

            while (true)
            {
                pipeServer.Write(b, 0, 4);
                Console.ReadKey();
            }
        }

        #endregion Private Methods
    }
}
