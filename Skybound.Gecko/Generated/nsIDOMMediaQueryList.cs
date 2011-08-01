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
// Generated by IDLImporter from file nsIDOMMediaQueryList.idl
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
    ///see http://dev.w3.org/csswg/cssom-view/#the-mediaquerylist-interface </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0e49c52-915b-40f9-9cba-6026305cdf3e")]
	public interface nsIDOMMediaQueryList
	{
		
		/// <summary>
        ///see http://dev.w3.org/csswg/cssom-view/#the-mediaquerylist-interface </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMediaAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMedia);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMatchesAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsIDOMMediaQueryListListener listener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIDOMMediaQueryListListener listener);
	}
	
	/// <summary>nsIDOMMediaQueryListListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("279a5cbd-5c15-475d-847b-e0de1624eb77")]
	public interface nsIDOMMediaQueryListListener
	{
		
		/// <summary>Member HandleChange </summary>
		/// <param name='mql'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleChange([MarshalAs(UnmanagedType.Interface)] nsIDOMMediaQueryList mql);
	}
}