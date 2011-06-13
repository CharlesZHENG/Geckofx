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
// Generated by IDLImporter from file nsIIDBVersionChangeRequest.idl
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
    /// IDBReqeust interface.  See
    /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBRequest for more
    /// information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aeaabb0d-594a-4c58-ac5e-68ef3bff927d")]
	public interface nsIIDBVersionChangeRequest
	{
		
		/// <summary>
        /// IDBReqeust interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBRequest for more
        /// information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnblockedAttribute();
		
		/// <summary>
        /// IDBReqeust interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBRequest for more
        /// information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnblockedAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnblocked);
	}
}
