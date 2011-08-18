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
// Generated by IDLImporter from file nsIDOMNSEvent.idl
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
	
	
	/// <summary>nsIDOMNSEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9be8096b-f795-4045-9664-0c275f36fe5b")]
	public interface nsIDOMNSEvent
	{
		
		/// <summary>
        ///The original target of the event, before any retargetings. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetOriginalTargetAttribute();
		
		/// <summary>
        /// The explicit original target of the event.  If the event was retargeted
        /// for some reason other than an anonymous boundary crossing, this will be set
        /// to the target before the retargeting occurs.  For example, mouse events
        /// are retargeted to their parent node when they happen over text nodes (bug
        /// 185889), and in that case .target will show the parent and
        /// .explicitOriginalTarget will show the text node.
        /// .explicitOriginalTarget differs from .originalTarget in that it will never
        /// contain anonymous content.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetExplicitOriginalTargetAttribute();
		
		/// <summary>
        ///XXX This is TEMPORARY.
        /// The original target, without any retargeting (like textnode retargeting).
        /// This really needs to be in .originalTarget, but this is a less risky way of
        /// fixing it.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetTmpRealOriginalTargetAttribute();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::stopPropagation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreventBubble();
		
		/// <summary>
        /// @deprecated Use nsIDOMEvent::stopPropagation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreventCapture();
		
		/// <summary>Member GetPreventDefault </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPreventDefault();
		
		/// <summary>Member GetIsTrustedAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsTrustedAttribute();
	}
}
