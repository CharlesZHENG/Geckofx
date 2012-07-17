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
// Generated by IDLImporter from file nsIDOMGeoGeolocation.idl
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
	
	
	/// <summary>nsIDOMGeoGeolocation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b9a301f7-285b-4be9-b739-fb869019c77a")]
	public interface nsIDOMGeoGeolocation
	{
		
		/// <summary>
        ///GeoPositionOptions </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCurrentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionCallback successCallback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionErrorCallback errorCallback, Gecko.JsVal options, System.IntPtr jsContext);
		
		/// <summary>
        ///GeoPositionOptions </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int WatchPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionCallback successCallback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionErrorCallback errorCallback, Gecko.JsVal options, System.IntPtr jsContext);
		
		/// <summary>Member ClearWatch </summary>
		/// <param name='watchId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearWatch(int watchId);
	}
}
