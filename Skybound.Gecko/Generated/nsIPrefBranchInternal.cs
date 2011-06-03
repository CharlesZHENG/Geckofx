// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPrefBranchInternal.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPrefBranchInternal.idl
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
	
	
	/// <summary>nsIPrefBranchInternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d1d412d9-15d6-4a6a-9533-b949dc175ff5")]
	public interface nsIPrefBranchInternal : nsIPrefBranch2
	{
		
		/// <summary>Member GetRootAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetRootAttribute();
		
		/// <summary>Member GetPrefType </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPrefType([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member GetBoolPref </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member SetBoolPref </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, System.Int32  aValue);
		
		/// <summary>Member GetCharPref </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetCharPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member SetCharPref </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCharPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, [MarshalAs(UnmanagedType.LPStr)] System.String  aValue);
		
		/// <summary>Member GetIntPref </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetIntPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member SetIntPref </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetIntPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, System.Int32  aValue);
		
		/// <summary>Member GetComplexValue </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aType'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr  GetComplexValue([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, ref System.Guid aType);
		
		/// <summary>Member SetComplexValue </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aType'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName, ref System.Guid aType, [MarshalAs(UnmanagedType.Interface)] nsISupports  aValue);
		
		/// <summary>Member ClearUserPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member LockPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LockPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member PrefHasUserValue </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member PrefIsLocked </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member UnlockPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void UnlockPref([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefName);
		
		/// <summary>Member DeleteBranch </summary>
		/// <param name='aStartingAt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] System.String  aStartingAt);
		
		/// <summary>Member GetChildList </summary>
		/// <param name='aStartingAt'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetChildList([MarshalAs(UnmanagedType.LPStr)] System.String  aStartingAt, out System.UInt32  aCount);
		
		/// <summary>Member ResetBranch </summary>
		/// <param name='aStartingAt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ResetBranch([MarshalAs(UnmanagedType.LPStr)] System.String  aStartingAt);
		
		/// <summary>Member AddObserver </summary>
		/// <param name='aDomain'> </param>
		/// <param name='aObserver'> </param>
		/// <param name='aHoldWeak'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddObserver([MarshalAs(UnmanagedType.LPStr)] System.String  aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver  aObserver, System.Boolean  aHoldWeak);
		
		/// <summary>Member RemoveObserver </summary>
		/// <param name='aDomain'> </param>
		/// <param name='aObserver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveObserver([MarshalAs(UnmanagedType.LPStr)] System.String  aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver  aObserver);
	}
}
