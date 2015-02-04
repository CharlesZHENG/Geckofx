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
// Generated by IDLImporter from file nsIJSON.idl
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
	
	
	/// <summary>
    /// Don't use this!  Use JSON.parse and JSON.stringify directly.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("083aebb0-7790-43b2-ae81-9e404e626236")]
	public interface nsIJSON
	{
		
		/// <summary>
        /// New users should use JSON.stringify!
        /// The encode() method is only present for backward compatibility.
        /// encode() is not a conforming JSON stringify implementation!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Encode(ref Gecko.JsVal value, System.IntPtr jsContext, int argc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// New users should use JSON.stringify.
        /// You may also want to have a look at nsIConverterOutputStream.
        ///
        /// The encodeToStream() method is only present for backward compatibility.
        /// encodeToStream() is not a conforming JSON stringify implementation!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.U1)] bool writeBOM, ref Gecko.JsVal value, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// New users should use JSON.parse!
        /// The decode() method is only present for backward compatibility.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal Decode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal DecodeFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, int contentLength, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeFromJSVal(System.IntPtr value, System.IntPtr cx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Make sure you GCroot the result of this function before using it.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal DecodeToJSVal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, System.IntPtr cx);
	}
}
