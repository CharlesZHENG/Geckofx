// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: inISearchProcess.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file inISearchProcess.idl
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
	
	
	/// <summary>inISearchProcess </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D5FA765B-2448-4686-B7C1-5FF13ACB0FC9")]
	public interface inISearchProcess
	{
		
		/// <summary>Member GetIsActiveAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsActiveAttribute();
		
		/// <summary>Member GetResultCountAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetResultCountAttribute();
		
		/// <summary>Member GetHoldResultsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetHoldResultsAttribute();
		
		/// <summary>Member SetHoldResultsAttribute </summary>
		/// <param name='aHoldResults'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHoldResultsAttribute(System.Boolean  aHoldResults);
		
		/// <summary>Member SearchSync </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SearchSync();
		
		/// <summary>Member SearchAsync </summary>
		/// <param name='aObserver'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SearchAsync(inISearchObserver  aObserver);
		
		/// <summary>Member SearchStop </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SearchStop();
		
		/// <summary>Member SearchStep </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SearchStep();
		
		/// <summary>Member GetStringResultAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetStringResultAt(System.Int32  aIndex);
		
		/// <summary>Member GetIntResultAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIntResultAt(System.Int32  aIndex);
		
		/// <summary>Member GetUIntResultAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetUIntResultAt(System.Int32  aIndex);
	}
}
