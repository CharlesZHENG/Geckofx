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
// Generated by IDLImporter from file nsIASN1Sequence.idl
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
    /// This represents a sequence of ASN.1 objects,
    /// where ASN.1 is "Abstract Syntax Notation number One".
    ///
    /// Overview of how this ASN1 interface is intended to
    /// work.
    ///
    /// First off, the nsIASN1Sequence is any type in ASN1
    /// that consists of sub-elements (ie SEQUENCE, SET)
    /// nsIASN1Printable Items are all the other types that
    /// can be viewed by themselves without interpreting further.
    /// Examples would include INTEGER, UTF-8 STRING, OID.
    /// These are not intended to directly reflect the numberous
    /// types that exist in ASN1, but merely an interface to ease
    /// producing a tree display the ASN1 structure of any DER
    /// object.
    ///
    /// The additional state information carried in this interface
    /// makes it fit for being used as the data structure
    /// when working with visual reprenstation of ASN.1 objects
    /// in a human user interface, like in a tree widget
    /// where open/close state of nodes must be remembered.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b6b957e6-1dd1-11b2-89d7-e30624f50b00")]
	public interface nsIASN1Sequence : nsIASN1Object
	{
		
		/// <summary>
        /// "type" will be equal to one of the defined object identifiers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetTypeAttribute();
		
		/// <summary>
        /// "type" will be equal to one of the defined object identifiers.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTypeAttribute(uint aType);
		
		/// <summary>
        /// This contains a tag as explained in ASN.1 standards documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetTagAttribute();
		
		/// <summary>
        /// This contains a tag as explained in ASN.1 standards documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTagAttribute(uint aTag);
		
		/// <summary>
        /// "displayName" contains a human readable explanatory label.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayName);
		
		/// <summary>
        /// "displayName" contains a human readable explanatory label.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayName);
		
		/// <summary>
        /// "displayValue" contains the human readable value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayValue);
		
		/// <summary>
        /// "displayValue" contains the human readable value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDisplayValue);
		
		/// <summary>
        /// The array of objects stored in the sequence.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMutableArray GetASN1ObjectsAttribute();
		
		/// <summary>
        /// The array of objects stored in the sequence.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetASN1ObjectsAttribute([MarshalAs(UnmanagedType.Interface)] nsIMutableArray aASN1Objects);
		
		/// <summary>
        /// Whether the node at this position in the ASN.1 data structure
        /// sequence contains sub elements understood by the
        /// application.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsValidContainerAttribute();
		
		/// <summary>
        /// Whether the node at this position in the ASN.1 data structure
        /// sequence contains sub elements understood by the
        /// application.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsValidContainerAttribute([MarshalAs(UnmanagedType.U1)] bool aIsValidContainer);
		
		/// <summary>
        /// Whether the contained objects should be shown or hidden.
        /// A UI implementation can use this flag to store the current
        /// expansion state when shown in a tree widget.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsExpandedAttribute();
		
		/// <summary>
        /// Whether the contained objects should be shown or hidden.
        /// A UI implementation can use this flag to store the current
        /// expansion state when shown in a tree widget.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsExpandedAttribute([MarshalAs(UnmanagedType.U1)] bool aIsExpanded);
	}
}
