// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIJetpack.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIJetpack </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("61A5BE65-FAF2-4FD1-96DF-B13A7AD7D88D")]
	public interface nsIJetpack
	{
		
		/// <summary>
        ///[optional] in jsval v1,
        ///                      [optional] in jsval v2,
        ///                      ... </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessageName);
		
		/// <summary>Member RegisterReceiver </summary>
		/// <param name='aMessageName'> </param>
		/// <param name='aReceiver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterReceiver([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessageName, System.IntPtr aReceiver);
		
		/// <summary>Member UnregisterReceiver </summary>
		/// <param name='aMessageName'> </param>
		/// <param name='aReceiver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterReceiver([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessageName, System.IntPtr aReceiver);
		
		/// <summary>Member UnregisterReceivers </summary>
		/// <param name='aMessageName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterReceivers([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessageName);
		
		/// <summary>Member EvalScript </summary>
		/// <param name='aScript'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvalScript([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aScript);
		
		/// <summary>Member CreateHandle </summary>
		/// <returns>A nsIVariant</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant CreateHandle();
		
		/// <summary>Member Destroy </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Destroy();
	}
}
