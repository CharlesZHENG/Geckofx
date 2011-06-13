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
// Generated by IDLImporter from file nsISelectElement.idl
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
    /// This interface is used to notify a SELECT when OPTION
    /// elements are added and removed from its subtree.
    /// Note that the nsIDOMHTMLSelectElement and nsIContent
    /// interfaces are the ones to use to access and enumerate
    /// OPTIONs within a SELECT element.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("aa73a61a-8ef2-402d-b86c-3a5c5f2a6027")]
	public interface nsISelectElement
	{
		
		/// <summary>
        /// To be called when stuff is added under a child of the select--but *before*
        /// they are actually added.
        ///
        /// @param aOptions the content that was added (usually just an option, but
        /// could be an optgroup node with many child options)
        /// @param aParent the parent the options were added to (could be an optgroup)
        /// @param aContentIndex the index where the options are being added within the
        /// parent (if the parent is an optgroup, the index within the optgroup)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillAddOptions(System.IntPtr aOptions, System.IntPtr aParent, int aContentIndex, bool aNotify);
		
		/// <summary>
        /// To be called when stuff is removed under a child of the select--but
        /// *before* they are actually removed.
        ///
        /// @param aParent the parent the option(s) are being removed from
        /// @param aContentIndex the index of the option(s) within the parent (if the
        /// parent is an optgroup, the index within the optgroup)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillRemoveOptions(System.IntPtr aParent, int aContentIndex, bool aNotify);
		
		/// <summary>
        /// Checks whether an option is disabled (even if it's part of an optgroup)
        ///
        /// @param aIndex the index of the option to check
        /// @return whether the option is disabled
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsOptionDisabled(int aIndex);
		
		/// <summary>
        /// Sets multiple options (or just sets startIndex if select is single)
        /// and handles notifications and cleanup and everything under the sun.
        /// When this method exits, the select will be in a consistent state.  i.e.
        /// if you set the last option to false, it will select an option anyway.
        ///
        /// @param aStartIndex the first index to set
        /// @param aEndIndex the last index to set (set same as first index for one
        /// option)
        /// @param aIsSelected whether to set the option(s) to true or false
        /// @param aClearAll whether to clear all other options (for example, if you
        /// are normal-clicking on the current option)
        /// @param aSetDisabled whether it is permissible to set disabled options
        /// (for JavaScript)
        /// @param aNotify whether to notify frames and such
        /// @return whether any options were actually changed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SetOptionsSelectedByIndex(int aStartIndex, int aEndIndex, bool aIsSelected, bool aClearAll, bool aSetDisabled, bool aNotify);
		
		/// <summary>
        /// Finds the index of a given option element
        ///
        /// @param aOption the option to get the index of
        /// @param aStartIndex the index to start looking at
        /// @param aForward TRUE to look forward, FALSE to look backward
        /// @return the option index
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOptionIndex([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLOptionElement aOption, int aStartIndex, bool aForward);
		
		/// <summary>
        ///Whether or not there are optgroups in this select </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasOptGroupsAttribute();
	}
}
