// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIAuthModule.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIAuthModule.idl
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
	
	
	/// <summary>nsIAuthModule </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6e35dbc0-49ef-4e2c-b1ea-b72ec64450a2")]
	public interface nsIAuthModule
	{
		
		/// <summary>Member Init </summary>
		/// <param name='aServiceName'> </param>
		/// <param name='aServiceFlags'> </param>
		/// <param name='aDomain'> </param>
		/// <param name='aUsername'> </param>
		/// <param name='aPassword'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.LPStr)] System.String  aServiceName, System.UInt32  aServiceFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPassword);
		
		/// <summary>Member GetNextToken </summary>
		/// <param name='aInToken'> </param>
		/// <param name='aInTokenLength'> </param>
		/// <param name='aOutToken'> </param>
		/// <param name='aOutTokenLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNextToken(System.IntPtr  aInToken, System.UInt32  aInTokenLength, out System.IntPtr  aOutToken, out System.UInt32  aOutTokenLength);
		
		/// <summary>Member Wrap </summary>
		/// <param name='aInToken'> </param>
		/// <param name='aInTokenLength'> </param>
		/// <param name='confidential'> </param>
		/// <param name='aOutToken'> </param>
		/// <param name='aOutTokenLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Wrap(System.IntPtr  aInToken, System.UInt32  aInTokenLength, System.Boolean  confidential, out System.IntPtr  aOutToken, out System.UInt32  aOutTokenLength);
		
		/// <summary>Member Unwrap </summary>
		/// <param name='aInToken'> </param>
		/// <param name='aInTokenLength'> </param>
		/// <param name='aOutToken'> </param>
		/// <param name='aOutTokenLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unwrap(System.IntPtr  aInToken, System.UInt32  aInTokenLength, out System.IntPtr  aOutToken, out System.UInt32  aOutTokenLength);
	}
}
