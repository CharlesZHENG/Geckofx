// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWebSocket.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWebSocket.idl
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
	
	
	/// <summary>nsIWebSocket </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4403cd57-07fc-477f-a062-d6ba7dd0781b")]
	public interface nsIWebSocket
	{
		
		/// <summary>Member GetUrlAttribute </summary>
		/// <param name='aUrl'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUrlAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUrl);
		
		/// <summary>Member GetReadyStateAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetReadyStateAttribute();
		
		/// <summary>Member GetBufferedAmountAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetBufferedAmountAttribute();
		
		/// <summary>Member GetOnopenAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnopenAttribute();
		
		/// <summary>Member SetOnopenAttribute </summary>
		/// <param name='aOnopen'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnopenAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnopen);
		
		/// <summary>Member GetOnmessageAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnmessageAttribute();
		
		/// <summary>Member SetOnmessageAttribute </summary>
		/// <param name='aOnmessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmessageAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnmessage);
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnerrorAttribute();
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnerror);
		
		/// <summary>Member GetOncloseAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOncloseAttribute();
		
		/// <summary>Member SetOncloseAttribute </summary>
		/// <param name='aOnclose'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncloseAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnclose);
		
		/// <summary>Member Send </summary>
		/// <param name='data'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Send([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>Member Close </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>Member Init </summary>
		/// <param name='principal'> </param>
		/// <param name='scriptContext'> </param>
		/// <param name='ownerWindow'> </param>
		/// <param name='url'> </param>
		/// <param name='protocol'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal, System.IntPtr scriptContext, System.IntPtr ownerWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString url, [MarshalAs(UnmanagedType.LPStruct)] nsAString protocol);
	}
}