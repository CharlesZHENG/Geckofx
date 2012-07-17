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
// Generated by IDLImporter from file nsIDOMHTMLCanvasElement.idl
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
    /// The nsIDOMHTMLCanvasElement interface is the interface to a HTML
    /// <canvas> element.
    ///
    /// For more information on this interface, please see
    /// http://www.whatwg.org/specs/web-apps/current-work/#graphics
    ///
    /// @status UNDER_DEVELOPMENT
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5929542B-C68E-48AB-84F9-D9642DA39720")]
	public interface nsIDOMHTMLCanvasElement : nsIDOMHTMLElement
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNodeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetParentElementAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocumentAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>
        /// Modified in DOM Level 4:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode([MarshalAs(UnmanagedType.U1)] bool deep, int argc);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase feature, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNamespaceURI);
		
		/// <summary>
        /// Modified in DOM Core
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// nsINode::GetBaseURI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBaseURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBaseURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint CompareDocumentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMNode other);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prefix, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsEqualNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode arg);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant SetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.Interface)] nsIVariant data, [MarshalAs(UnmanagedType.Interface)] nsIDOMUserDataHandler handler);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant GetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aOther);
		
		/// <summary>
        /// The nsIDOMElement interface represents an element in an HTML or
        /// XML document.
        ///
        /// For more information on this interface please see
        /// http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html#interface-element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTagNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTagName);
		
		/// <summary>
        /// Returns a DOMTokenList object reflecting the class attribute.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDOMTokenList GetClassListAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qualifiedName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>
        /// Obsolete methods.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr oldAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>
        /// Retrieve elements matching all classes listed in a
        /// space-separated string.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase classes);
		
		/// <summary>
        /// Returns a live nsIDOMNodeList of the current child elements.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildrenAttribute();
		
		/// <summary>
        /// Similar as the attributes on nsIDOMNode, but navigates just elements
        /// rather than all nodes.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetFirstElementChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetLastElementChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetPreviousElementSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetNextElementSiblingAttribute();
		
		/// <summary>
        /// Returns the number of child nodes that are nsIDOMElements.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetChildElementCountAttribute();
		
		/// <summary>
        /// HTML
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnmouseenterAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// HTML
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnmouseenterAttribute(Gecko.JsVal aOnmouseenter, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnmouseleaveAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnmouseleaveAttribute(Gecko.JsVal aOnmouseleave, System.IntPtr jsContext);
		
		/// <summary>
        /// Retrieve a list of rectangles, one for each CSS border-box associated with
        /// the element. The coordinates are in CSS pixels, and relative to
        /// the top-left of the document's viewport, unless the document
        /// has an SVG foreignobject ancestor, in which case the coordinates are
        /// relative to the top-left of the content box of the nearest SVG foreignobject
        /// ancestor. The coordinates are calculated as if every scrollable element
        /// is scrolled to its default position.
        ///
        /// Note: the boxes of overflowing children do not affect these rectangles.
        /// Note: some elements have empty CSS boxes. Those return empty rectangles,
        /// but the coordinates may still be meaningful.
        /// Note: some elements have no CSS boxes (including display:none elements,
        /// HTML AREA elements, and SVG elements that do not render). Those return
        /// an empty list.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMClientRectList GetClientRects();
		
		/// <summary>
        /// Returns the union of all rectangles in the getClientRects() list. Empty
        /// rectangles are ignored, except that if all rectangles are empty,
        /// we return an empty rectangle positioned at the top-left of the first
        /// rectangle in getClientRects().
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMClientRect GetBoundingClientRect();
		
		/// <summary>
        /// The vertical scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// vertical scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollTopAttribute();
		
		/// <summary>
        /// The vertical scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// vertical scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetScrollTopAttribute(int aScrollTop);
		
		/// <summary>
        /// The horizontal scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// horizontal scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollLeftAttribute();
		
		/// <summary>
        /// The horizontal scroll position of the element, or 0 if the element is not
        /// scrollable. This property may be assigned a value to change the
        /// horizontal scroll position.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetScrollLeftAttribute(int aScrollLeft);
		
		/// <summary>
        /// The width of the scrollable area of the element. If the element is not
        /// scrollable, scrollWidth is equivalent to the offsetWidth.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollWidthAttribute();
		
		/// <summary>
        /// The height of the scrollable area of the element. If the element is not
        /// scrollable, scrollHeight is equivalent to the offsetHeight.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetScrollHeightAttribute();
		
		/// <summary>
        /// The height in CSS pixels of the element's top border.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientTopAttribute();
		
		/// <summary>
        /// The width in CSS pixels of the element's left border and scrollbar
        /// if it is present on the left side.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientLeftAttribute();
		
		/// <summary>
        /// The height in CSS pixels of the element's padding box. If the element is
        /// scrollable, the scroll bars are included inside this width.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientWidthAttribute();
		
		/// <summary>
        /// The width in CSS pixels of the element's padding box. If the element is
        /// scrollable, the scroll bars are included inside this height.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetClientHeightAttribute();
		
		/// <summary>
        /// Returns whether this element would be selected by the given selector
        /// string.
        ///
        /// See <http://dev.w3.org/2006/webapi/selectors-api2/#matchesselector>
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool MozMatchesSelector([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase selector);
		
		/// <summary>
        /// Set this during a mousedown event to grab and retarget all mouse events
        /// to this element until the mouse button is released or releaseCapture is
        /// called. If retargetToElement is true, then all events are targetted at
        /// this element. If false, events can also fire at descendants of this
        /// element.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCapture([MarshalAs(UnmanagedType.U1)] bool retargetToElement);
		
		/// <summary>
        /// If this element has captured the mouse, release the capture. If another
        /// element has captured the mouse, this method has no effect.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ReleaseCapture();
		
		/// <summary>
        /// Requests that this element be made the full-screen element, as per the DOM
        /// full-screen api.
        ///
        /// @see <https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MozRequestFullScreen();
		
		/// <summary>
        /// Requests that this element be made the pointer-locked element, as per the DOM
        /// pointer lock api.
        ///
        /// @see <http://dvcs.w3.org/hg/pointerlock/raw-file/default/index.html>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MozRequestPointerLock();
		
		/// <summary>
        /// metadata attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aId);
		
		/// <summary>
        /// metadata attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLangAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aClassName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aClassName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDOMStringMap GetDatasetAttribute();
		
		/// <summary>
        /// Indicates that the element is not yet, or is no longer, relevant.
        ///
        /// See <http://www.whatwg.org/html5/#the-hidden-attribute>.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetHiddenAttribute();
		
		/// <summary>
        /// Indicates that the element is not yet, or is no longer, relevant.
        ///
        /// See <http://www.whatwg.org/html5/#the-hidden-attribute>.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHiddenAttribute([MarshalAs(UnmanagedType.U1)] bool aHidden);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Click();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetTabIndexAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTabIndexAttribute(int aTabIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Focus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Blur();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAccessKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAccessKey);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAccessKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAccessKey);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAccessKeyLabelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAccessKeyLabel);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetDraggableAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDraggableAttribute([MarshalAs(UnmanagedType.U1)] bool aDraggable);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentEditableAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aContentEditable);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetContentEditableAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aContentEditable);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsContentEditableAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMHTMLMenuElement GetContextMenuAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetSpellcheckAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSpellcheckAttribute([MarshalAs(UnmanagedType.U1)] bool aSpellcheck);
		
		/// <summary>
        /// DOM Parsing and Serialization
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetInnerHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInnerHTML);
		
		/// <summary>
        /// DOM Parsing and Serialization
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetInnerHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInnerHTML);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOuterHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOuterHTML);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOuterHTMLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOuterHTML);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InsertAdjacentHTML([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase position, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase text);
		
		/// <summary>
        /// CSSOM View
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollIntoView([MarshalAs(UnmanagedType.U1)] bool top, int argc);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetOffsetParentAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetOffsetTopAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetOffsetLeftAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetOffsetWidthAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetOffsetHeightAttribute();
		
		/// <summary>
        /// The nsIDOMHTMLCanvasElement interface is the interface to a HTML
        /// <canvas> element.
        ///
        /// For more information on this interface, please see
        /// http://www.whatwg.org/specs/web-apps/current-work/#graphics
        ///
        /// @status UNDER_DEVELOPMENT
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetWidthAttribute();
		
		/// <summary>
        /// The nsIDOMHTMLCanvasElement interface is the interface to a HTML
        /// <canvas> element.
        ///
        /// For more information on this interface, please see
        /// http://www.whatwg.org/specs/web-apps/current-work/#graphics
        ///
        /// @status UNDER_DEVELOPMENT
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWidthAttribute(uint aWidth);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHeightAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeightAttribute(uint aHeight);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMozOpaqueAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozOpaqueAttribute([MarshalAs(UnmanagedType.U1)] bool aMozOpaque);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetContext([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase contextId, Gecko.JsVal contextOptions);
		
		/// <summary>
        ///  toDataURL(type, params);  -- uses given type, and any valid parameters
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToDataURL([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIVariant @params, int argc, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// mozGetAsFile(name, type);        -- uses given type
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFile MozGetAsFile([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type, int argc);
		
		/// <summary>
        /// shared memory. Only privileged callers can call this.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports MozGetIPCContext([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase contextId);
		
		/// <summary>
        /// stream in the desired image format.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozFetchAsStream([MarshalAs(UnmanagedType.Interface)] nsIInputStreamCallback callback, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type);
	}
}
