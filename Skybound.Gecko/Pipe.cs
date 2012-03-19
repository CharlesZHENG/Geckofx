using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko
{
	/// <summary>
	/// Pipe transfers data from nsIAsyncOutputStream to nsIAsyncInputStream
	/// Can be used for transfer data between threads
	/// WARNING it seems that this class can be created only one time :(
	/// </summary>
	public sealed class Pipe
		:IDisposable 
	{
		internal InstanceWrapper<nsIPipe> _pipe;

		public Pipe()
		{
			_pipe = new InstanceWrapper<nsIPipe>( Contracts.Pipe );
			_pipe.Instance.Init(true, true,0, 0, null);
		}

		~Pipe()
		{
			Release();
		}

		public void Dispose()
		{
			Release();
			GC.SuppressFinalize( this );
		}

		private void Release()
		{
			if (_pipe == null) return;
			var obj = Interlocked.Exchange(ref _pipe, null);
			obj.Dispose();
		}

		public Gecko.IO.InputStream InputStream
		{
			get { return IO.InputStream.Create(_pipe.Instance.GetInputStreamAttribute()); }
		}


		public Gecko.IO.OutputStream OutputStream
		{
			get { return IO.OutputStream.Create(_pipe.Instance.GetOutputStreamAttribute()); }
		}


	}
}