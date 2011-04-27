

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf9092-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLOptionElement : nsIDOMHTMLElement
	{
		#region Inherited Intefaces
        // nsIDOMNode:
        new void GetNodeName(nsAString aNodeName);
        new void GetNodeValue(nsAString aNodeValue);
        new void SetNodeValue(nsAString aNodeValue);
        new ushort GetNodeType();
        new nsIDOMNode GetParentNode();
        new nsIDOMNodeList GetChildNodes();
        new nsIDOMNode GetFirstChild();
        new nsIDOMNode GetLastChild();
        new nsIDOMNode GetPreviousSibling();
        new nsIDOMNode GetNextSibling();
        new nsIDOMNamedNodeMap GetAttributes();
        new nsIDOMDocument GetOwnerDocument();
        new nsIDOMNode InsertBefore(nsIDOMNode newChild, nsIDOMNode refChild);
        new nsIDOMNode ReplaceChild(nsIDOMNode newChild, nsIDOMNode oldChild);
        new nsIDOMNode RemoveChild(nsIDOMNode oldChild);
        new nsIDOMNode AppendChild(nsIDOMNode newChild);
        new bool HasChildNodes();
        new nsIDOMNode CloneNode(bool deep);
        new void Normalize();
        new bool IsSupported(nsAString feature, nsAString version);
        new void GetNamespaceURI(nsAString aNamespaceURI);
        new void GetPrefix(nsAString aPrefix);
        new void SetPrefix(nsAString aPrefix);
        new void GetLocalName(nsAString aLocalName);
        new bool HasAttributes();

        // nsIDOMElement:
        new void GetTagName(nsAString aTagName);
        new void GetAttribute(nsAString name, nsAString _retval);
        new void SetAttribute(nsAString name, nsAString value);
        new void RemoveAttribute(nsAString name);
        new nsIDOMAttr GetAttributeNode(nsAString name);
        new nsIDOMAttr SetAttributeNode(nsIDOMAttr newAttr);
        new nsIDOMAttr RemoveAttributeNode(nsIDOMAttr oldAttr);
        new nsIDOMNodeList GetElementsByTagName(nsAString name);
        new void GetAttributeNS(nsAString namespaceURI, nsAString localName, nsAString _retval);
        new void SetAttributeNS(nsAString namespaceURI, nsAString qualifiedName, nsAString value);
        new void RemoveAttributeNS(nsAString namespaceURI, nsAString localName);
        new nsIDOMAttr GetAttributeNodeNS(nsAString namespaceURI, nsAString localName);
        new nsIDOMAttr SetAttributeNodeNS(nsIDOMAttr newAttr);
        new nsIDOMNodeList GetElementsByTagNameNS(nsAString namespaceURI, nsAString localName);
        new bool HasAttribute(nsAString name);
        new bool HasAttributeNS(nsAString namespaceURI, nsAString localName);

        // nsIDOMHTMLElement:
        new void GetId(nsAString aId);
        new void SetId(nsAString aId);
        new void GetTitle(nsAString aTitle);
        new void SetTitle(nsAString aTitle);
        new void GetLang(nsAString aLang);
        new void SetLang(nsAString aLang);
        new void GetDir(nsAString aDir);
        new void SetDir(nsAString aDir);
        new void GetClassName(nsAString aClassName);
        new void SetClassName(nsAString aClassName);
        #endregion
		nsIDOMHTMLFormElement GetForm();

		bool GetDefaultSelected();
		void SetDefaultSelected(bool aDefaultSelected);

		void GetText(nsAString aText);

		int GetIndex();

		bool GetDisabled();
		void SetDisabled(bool aDisabled);

		void GetLabel(nsAString aLabel);
		void SetLabel(nsAString aLabel);

		bool GetSelected();
		void SetSelected(bool aSelected);

		void GetValue(nsAString aValue);
		void SetValue(nsAString aValue);

	}
	public class GeckoOptionElement : GeckoElement
	{
		nsIDOMHTMLOptionElement DOMHTMLElement;
		internal GeckoOptionElement(nsIDOMHTMLOptionElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoOptionElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLOptionElement;
		}
		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetForm()); }
		}

		public bool DefaultSelected {
			get { return DOMHTMLElement.GetDefaultSelected(); }
			set { DOMHTMLElement.SetDefaultSelected(value); }
		}

		public string Text {
			get { return nsString.Get(DOMHTMLElement.GetText); }
		}

		public int Index {
			get { return DOMHTMLElement.GetIndex(); }
		}

		public bool Disabled {
			get { return DOMHTMLElement.GetDisabled(); }
			set { DOMHTMLElement.SetDisabled(value); }
		}

		public string Label {
			get { return nsString.Get(DOMHTMLElement.GetLabel); }
			set { DOMHTMLElement.SetLabel(new nsAString(value)); }
		}

		public bool Selected {
			get { return DOMHTMLElement.GetSelected(); }
			set { DOMHTMLElement.SetSelected(value); }
		}

		public string Value {
			get { return nsString.Get(DOMHTMLElement.GetValue); }
			set { DOMHTMLElement.SetValue(new nsAString(value)); }
		}

	}
}