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
// Generated by IDLImporter from file nsIRDFLiteral.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// A literal node in the graph, whose value is a string.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E0C493D2-9542-11d2-8EB8-00805F29F370")]
	public interface nsIRDFLiteral : nsIRDFNode
	{
		
		/// <summary>
        /// Determine if two nodes are identical
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);
		
		/// <summary>
        /// The Unicode string value of the literal.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetValueAttribute();
		
		/// <summary>
        /// An unscriptable version used to avoid a string copy. Meant
        /// for use as a performance optimization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueConst([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] ref string aConstValue);
	}
	
	/// <summary>
    /// A literal node in the graph, whose value is a date
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E13A24E1-C77A-11d2-80BE-006097B76B8E")]
	public interface nsIRDFDate : nsIRDFNode
	{
		
		/// <summary>
        /// Determine if two nodes are identical
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);
		
		/// <summary>
        /// The date value of the literal
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetValueAttribute();
	}
	
	/// <summary>
    /// A literal node in the graph, whose value is an integer
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("E13A24E3-C77A-11d2-80BE-006097B76B8E")]
	public interface nsIRDFInt : nsIRDFNode
	{
		
		/// <summary>
        /// Determine if two nodes are identical
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);
		
		/// <summary>
        /// The integer value of the literal
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetValueAttribute();
	}
	
	/// <summary>
    /// A literal node in the graph, whose value is arbitrary
    /// binary data.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("237f85a2-1dd2-11b2-94af-8122582fc45e")]
	public interface nsIRDFBlob : nsIRDFNode
	{
		
		/// <summary>
        /// Determine if two nodes are identical
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool EqualsNode([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNode);
		
		/// <summary>
        /// The binary data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetValueAttribute();
		
		/// <summary>
        /// The data's length.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLengthAttribute();
	}
}
