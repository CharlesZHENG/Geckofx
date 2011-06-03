// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIGfxInfo.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIGfxInfo.idl
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
	
	
	/// <summary>nsIGfxInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5c5de1e7-f7f4-46b4-9ced-03ab1f869eaf")]
	public interface nsIGfxInfo
	{
		
		/// <summary>Member GetD2DEnabledAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetD2DEnabledAttribute();
		
		/// <summary>Member GetDWriteEnabledAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDWriteEnabledAttribute();
		
		/// <summary>Member GetDWriteVersionAttribute </summary>
		/// <param name='aDWriteVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDWriteVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDWriteVersion);
		
		/// <summary>Member GetAdapterDescriptionAttribute </summary>
		/// <param name='aAdapterDescription'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDescription);
		
		/// <summary>Member GetAdapterDriverAttribute </summary>
		/// <param name='aAdapterDriver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriver);
		
		/// <summary>Member GetAdapterVendorIDAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetAdapterVendorIDAttribute();
		
		/// <summary>Member GetAdapterDeviceIDAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetAdapterDeviceIDAttribute();
		
		/// <summary>Member GetAdapterRAMAttribute </summary>
		/// <param name='aAdapterRAM'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterRAMAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterRAM);
		
		/// <summary>Member GetAdapterDriverVersionAttribute </summary>
		/// <param name='aAdapterDriverVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriverVersion);
		
		/// <summary>Member GetAdapterDriverDateAttribute </summary>
		/// <param name='aAdapterDriverDate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAdapterDriverDateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAdapterDriverDate);
		
		/// <summary>Member GetFailures </summary>
		/// <param name='failureCount'> </param>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr, SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetFailures(out System.UInt32  failureCount);
		
		/// <summary>Member LogFailure </summary>
		/// <param name='failure'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LogFailure([MarshalAs(UnmanagedType.LPStruct)] nsAString  failure);
		
		/// <summary>Member GetFeatureStatus </summary>
		/// <param name='aFeature'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFeatureStatus(System.Int32  aFeature);
		
		/// <summary>Member GetFeatureSuggestedDriverVersion </summary>
		/// <param name='aFeature'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetFeatureSuggestedDriverVersion(System.Int32  aFeature);
		
		/// <summary>Member GetWebGLParameter </summary>
		/// <param name='aParam'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetWebGLParameter([MarshalAs(UnmanagedType.LPStruct)] nsAString aParam);
	}
}
