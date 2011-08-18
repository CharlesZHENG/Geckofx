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
// Generated by IDLImporter from file nsIXPCScriptable.idl
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
	
	
	/// <summary>
    /// Note: This is not really an XPCOM interface.  For example, callers must
    /// guarantee that they set the *_retval of the various methods that return a
    /// boolean to PR_TRUE before making the call.  Implementations may skip writing
    /// to *_retval unless they want to return PR_FALSE.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a40ce52e-2d8c-400f-9af2-f8784a656070")]
	public interface nsIXPCScriptable
	{
		
		/// <summary>
        /// with this bit set.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetClassNameAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetScriptableFlagsAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreCreate([MarshalAs(UnmanagedType.Interface)] nsISupports nativeObj, System.IntPtr cx, System.IntPtr globalObj, ref System.IntPtr parentObj);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AddProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DelProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		/// <summary>
        /// this method does something.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		/// <summary>
        /// this method does something.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SetProperty([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Enumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewEnumerate([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint enum_op, System.IntPtr statep, ref System.IntPtr idp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NewResolve([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, uint flags, ref System.IntPtr objp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Convert([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint type, System.IntPtr vp);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finalize([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckAccess([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr id, uint mode, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Call([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint argc, System.IntPtr argv, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Construct([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, uint argc, System.IntPtr argv, System.IntPtr vp);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasInstance([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr val, [MarshalAs(UnmanagedType.Bool)] ref bool bp);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Trace([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr trc, System.IntPtr obj);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equality([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj, System.IntPtr val);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OuterObject([MarshalAs(UnmanagedType.Interface)] nsIXPConnectWrappedNative wrapper, System.IntPtr cx, System.IntPtr obj);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PostCreatePrototype(System.IntPtr cx, System.IntPtr proto);
	}
}
