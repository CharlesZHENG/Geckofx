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
// Generated by IDLImporter from file nsIHTMLInlineTableEditor.idl
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
	
	
	/// <summary>nsIHTMLInlineTableEditor </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eda2e65c-a758-451f-9b05-77cb8de74ed2")]
	public interface nsIHTMLInlineTableEditor
	{
		
		/// <summary>
        /// boolean indicating if inline table editing is enabled in the editor.
        /// When inline table editing is enabled, and when the selection is
        /// contained in a table cell, special buttons allowing to add/remove
        /// a line/column are available on the cell's border.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInlineTableEditingEnabledAttribute();
		
		/// <summary>
        /// boolean indicating if inline table editing is enabled in the editor.
        /// When inline table editing is enabled, and when the selection is
        /// contained in a table cell, special buttons allowing to add/remove
        /// a line/column are available on the cell's border.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInlineTableEditingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aInlineTableEditingEnabled);
		
		/// <summary>
        /// Shows inline table editing UI around a table cell
        /// @param aCell [IN] a DOM Element being a table cell, td or th
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowInlineTableEditingUI([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aCell);
		
		/// <summary>
        /// Hide all inline table editing UI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HideInlineTableEditingUI();
		
		/// <summary>
        /// Modifies the table containing the selection according to the
        /// activation of an inline table editing UI element
        /// @param aUIAnonymousElement [IN] the inline table editing UI element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoInlineTableEditingAction([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aUIAnonymousElement);
		
		/// <summary>
        /// Refresh already visible inline table editing UI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RefreshInlineTableEditingUI();
	}
}
