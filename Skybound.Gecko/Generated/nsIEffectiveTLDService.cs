// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIEffectiveTLDService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIEffectiveTLDService.idl
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
	
	
	/// <summary>nsIEffectiveTLDService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6852369e-baa9-4c9a-bbcd-5123fc54a297")]
	public interface nsIEffectiveTLDService
	{
		
		/// <summary>Member GetPublicSuffix </summary>
		/// <param name='aURI'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetPublicSuffix([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member GetBaseDomain </summary>
		/// <param name='aURI'> </param>
		/// <param name='aAdditionalParts'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetBaseDomain([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, System.UInt32  aAdditionalParts);
		
		/// <summary>Member GetPublicSuffixFromHost </summary>
		/// <param name='aHost'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetPublicSuffixFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHost);
		
		/// <summary>Member GetBaseDomainFromHost </summary>
		/// <param name='aHost'> </param>
		/// <param name='aAdditionalParts'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetBaseDomainFromHost([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHost, System.UInt32  aAdditionalParts);
	}
}
