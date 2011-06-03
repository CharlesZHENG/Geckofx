// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIComponentRegistrar.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIComponentRegistrar.idl
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
	
	
	/// <summary>nsIComponentRegistrar </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2417cbfe-65ad-48a6-b4b6-eb84db174392")]
	public interface nsIComponentRegistrar
	{
		
		/// <summary>Member AutoRegister </summary>
		/// <param name='aSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoRegister([MarshalAs(UnmanagedType.Interface)] nsIFile  aSpec);
		
		/// <summary>Member AutoUnregister </summary>
		/// <param name='aSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoUnregister([MarshalAs(UnmanagedType.Interface)] nsIFile  aSpec);
		
		/// <summary>Member RegisterFactory </summary>
		/// <param name='aClass'> </param>
		/// <param name='aClassName'> </param>
		/// <param name='aContractID'> </param>
		/// <param name='aFactory'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactory(ref System.Guid aClass, [MarshalAs(UnmanagedType.LPStr)] System.String  aClassName, [MarshalAs(UnmanagedType.LPStr)] System.String  aContractID, [MarshalAs(UnmanagedType.Interface)] nsIFactory  aFactory);
		
		/// <summary>Member UnregisterFactory </summary>
		/// <param name='aClass'> </param>
		/// <param name='aFactory'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactory(ref System.Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsIFactory  aFactory);
		
		/// <summary>Member RegisterFactoryLocation </summary>
		/// <param name='aClass'> </param>
		/// <param name='aClassName'> </param>
		/// <param name='aContractID'> </param>
		/// <param name='aFile'> </param>
		/// <param name='aLoaderStr'> </param>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactoryLocation(ref System.Guid aClass, [MarshalAs(UnmanagedType.LPStr)] System.String  aClassName, [MarshalAs(UnmanagedType.LPStr)] System.String  aContractID, [MarshalAs(UnmanagedType.Interface)] nsIFile  aFile, [MarshalAs(UnmanagedType.LPStr)] System.String  aLoaderStr, [MarshalAs(UnmanagedType.LPStr)] System.String  aType);
		
		/// <summary>Member UnregisterFactoryLocation </summary>
		/// <param name='aClass'> </param>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactoryLocation(ref System.Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsIFile  aFile);
		
		/// <summary>Member IsCIDRegistered </summary>
		/// <param name='aClass'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCIDRegistered(ref System.Guid aClass);
		
		/// <summary>Member IsContractIDRegistered </summary>
		/// <param name='aContractID'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsContractIDRegistered([MarshalAs(UnmanagedType.LPStr)] System.String  aContractID);
		
		/// <summary>Member EnumerateCIDs </summary>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateCIDs();
		
		/// <summary>Member EnumerateContractIDs </summary>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateContractIDs();
		
		/// <summary>Member CIDToContractID </summary>
		/// <param name='aClass'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string CIDToContractID(ref System.Guid aClass);
		
		/// <summary>Member ContractIDToCID </summary>
		/// <param name='aContractID'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr ContractIDToCID([MarshalAs(UnmanagedType.LPStr)] System.String  aContractID);
	}
}
