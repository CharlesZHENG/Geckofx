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
// Generated by IDLImporter from file nsIDOMNSXPathExpression.idl
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
    /// Interface for Mozilla specific XPathExpression functions.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ce600ca8-e98a-4419-ad61-2f6d0cb0ecc8")]
	public interface nsIDOMNSXPathExpression
	{
		
		/// <summary>
        /// Evaluate the expression with the given context. Similar to
        /// nsIDOMXPathExpression::evaluate(), except that this takes the context
        /// position and size too.
        ///
        /// @param contextNode       The context node
        /// @param contextPosition   The context position
        /// @param contextSize       The context size
        /// @param type              The needed result type
        /// @param result            The result
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports EvaluateWithContext([MarshalAs(UnmanagedType.Interface)] nsIDOMNode contextNode, uint contextPosition, uint contextSize, ushort type, [MarshalAs(UnmanagedType.Interface)] nsISupports result);
	}
}
