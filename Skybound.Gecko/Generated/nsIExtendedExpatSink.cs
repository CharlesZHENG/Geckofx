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
// Generated by IDLImporter from file nsIExtendedExpatSink.idl
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
    /// This interface provides notification of syntax-level events.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("146E194B-333D-4283-8CF6-4BC3EE9B5DFF")]
	public interface nsIExtendedExpatSink : nsIExpatSink
	{
		
		/// <summary>
        /// Called to handle the opening tag of an element.
        /// @param aName the fully qualified tagname of the element
        /// @param aAtts the array of attribute names and values.  There are
        /// aAttsCount/2 names and aAttsCount/2 values, so the total number of
        /// elements in the array is aAttsCount.  The names and values
        /// alternate.  Thus, if we number attributes starting with 0,
        /// aAtts[2*k] is the name of the k-th attribute and aAtts[2*k+1] is
        /// the value of that attribute  Both explicitly specified attributes
        /// and attributes that are defined to have default values in a DTD are
        /// present in aAtts.
        /// @param aAttsCount the number of elements in aAtts.
        /// @param aIndex If the element has an attribute of type ID, then
        /// aAtts[aIndex] is the name of that attribute.  Otherwise, aIndex
        /// is -1
        /// @param aLineNumber the line number of the start tag in the data stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleStartElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)] string aAtts, uint aAttsCount, int aIndex, uint aLineNumber);
		
		/// <summary>
        /// Called to handle the closing tag of an element.
        /// @param aName the fully qualified tagname of the element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleEndElement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName);
		
		/// <summary>
        /// Called to handle a comment
        /// @param aCommentText the text of the comment (not including the
        /// "<!--" and "-->")
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleComment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aCommentText);
		
		/// <summary>
        /// Called to handle a CDATA section
        /// @param aData the text in the CDATA section.  This is null-terminated.
        /// @param aLength the length of the aData string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleCDataSection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string aData, uint aLength);
		
		/// <summary>
        /// Called to handle the doctype declaration
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleDoctypeDecl([MarshalAs(UnmanagedType.LPStruct)] nsAString aSubset, [MarshalAs(UnmanagedType.LPStruct)] nsAString aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString aSystemId, [MarshalAs(UnmanagedType.LPStruct)] nsAString aPublicId, [MarshalAs(UnmanagedType.Interface)] nsISupports aCatalogData);
		
		/// <summary>
        /// Called to handle character data.  Note that this does NOT get
        /// called for the contents of CDATA sections.
        /// @param aData the data to handle.  aData is NOT NULL-TERMINATED.
        /// @param aLength the length of the aData string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleCharacterData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string aData, uint aLength);
		
		/// <summary>
        /// Called to handle a processing instruction
        /// @param aTarget the PI target (e.g. xml-stylesheet)
        /// @param aData all the rest of the data in the PI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleProcessingInstruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTarget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aData);
		
		/// <summary>
        /// Handle the XML Declaration.
        ///
        /// @param aVersion    The version string, can be null if not specified.
        /// @param aEncoding   The encoding string, can be null if not specified.
        /// @param aStandalone -1, 0, or 1 indicating respectively that there was no
        /// standalone parameter in the declaration, that it was
        /// given as no, or that it was given as yes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleXMLDeclaration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aVersion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aEncoding, int aStandalone);
		
		/// <summary>
        /// Ask the content sink if the expat driver should log an error to the console.
        ///
        /// @param aErrorText  Error message to pass to content sink.
        /// @param aSourceText Source text of the document we're parsing.
        /// @param aError      Script error object with line number & column number
        ///
        /// @retval True if the expat driver should report the error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ReportError([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aErrorText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSourceText, [MarshalAs(UnmanagedType.Interface)] nsIScriptError aError);
		
		/// <summary>
        /// Called at the beginning of the DTD, before any entity or notation
        /// events.
        /// @param aDoctypeName The document type name.
        /// @param aSysid The declared system identifier for the external DTD subset,
        /// or null if none was declared.
        /// @param aPubid The declared public identifier for the external DTD subset,
        /// or null if none was declared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStartDTD([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDoctypeName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSysid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPubid);
		
		/// <summary>
        /// Called when a prefix mapping starts to be in-scope, before any
        /// startElement events.
        /// @param aPrefix The Namespace prefix being declared. An empty string
        /// is used for the default element namespace, which has
        /// no prefix.
        /// @param aUri The Namespace URI the prefix is mapped to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleStartNamespaceDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPrefix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aUri);
		
		/// <summary>
        /// Called when a prefix mapping is no longer in-scope, after any
        /// endElement events.
        /// @param aPrefix The prefix that was being mapped. This is the empty string
        /// when a default mapping scope ends.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEndNamespaceDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPrefix);
		
		/// <summary>
        /// This is called for a declaration of notation.  The base argument is
        /// whatever was set by XML_SetBase. aNotationName will never be
        /// null. The other arguments can be.
        /// @param aNotationName The notation name.
        /// @param aSysId The notation's system identifier, or null if none was given.
        /// @param aPubId The notation's pubilc identifier, or null if none was given.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleNotationDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aNotationName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSysid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPubid);
		
		/// <summary>
        /// This is called for a declaration of an unparsed (NDATA) entity.
        /// aName, aSysid and aNotationName arguments will never be
        /// null. The other arguments may be.
        /// @param aName  The unparsed entity's name.
        /// @param aSysId The notation's system identifier.
        /// @param aPubId The notation's pubilc identifier, or null if none was given.
        /// @param aNotationName The name of the associated notation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleUnparsedEntityDecl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSysid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPubid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aNotationName);
	}
}
