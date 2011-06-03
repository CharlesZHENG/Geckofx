// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIUpdateTimerManager.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIUpdateTimerManager.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIUpdateTimerManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0765c92c-6145-4253-9db4-594d8023087e")]
	public interface nsIUpdateTimerManager
	{
		
		/// <summary>Member RegisterTimer </summary>
		/// <param name='id'> </param>
		/// <param name='callback'> </param>
		/// <param name='interval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterTimer([MarshalAs(UnmanagedType.LPStruct)] nsAString id, [MarshalAs(UnmanagedType.Interface)] nsITimerCallback  callback, System.UInt32  interval);
	}
}
