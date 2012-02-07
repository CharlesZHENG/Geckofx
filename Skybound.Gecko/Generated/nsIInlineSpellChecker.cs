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
// Generated by IDLImporter from file nsIInlineSpellChecker.idl
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
	
	
	/// <summary>nsIInlineSpellChecker </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f456dda1-965d-470c-8c55-e51b38e45212")]
	public interface nsIInlineSpellChecker
	{
		
		/// <summary>Member GetSpellCheckerAttribute </summary>
		/// <returns>A nsIEditorSpellCheck</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEditorSpellCheck GetSpellCheckerAttribute();
		
		/// <summary>Member Init </summary>
		/// <param name='aEditor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIEditor aEditor);
		
		/// <summary>Member Cleanup </summary>
		/// <param name='aDestroyingFrames'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cleanup([MarshalAs(UnmanagedType.U1)] bool aDestroyingFrames);
		
		/// <summary>Member GetEnableRealTimeSpellAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnableRealTimeSpellAttribute();
		
		/// <summary>Member SetEnableRealTimeSpellAttribute </summary>
		/// <param name='aEnableRealTimeSpell'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnableRealTimeSpellAttribute([MarshalAs(UnmanagedType.U1)] bool aEnableRealTimeSpell);
		
		/// <summary>Member SpellCheckAfterEditorChange </summary>
		/// <param name='aAction'> </param>
		/// <param name='aSelection'> </param>
		/// <param name='aPreviousSelectedNode'> </param>
		/// <param name='aPreviousSelectedOffset'> </param>
		/// <param name='aStartNode'> </param>
		/// <param name='aStartOffset'> </param>
		/// <param name='aEndNode'> </param>
		/// <param name='aEndOffset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SpellCheckAfterEditorChange(int aAction, [MarshalAs(UnmanagedType.Interface)] nsISelection aSelection, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aPreviousSelectedNode, int aPreviousSelectedOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aStartNode, int aStartOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aEndNode, int aEndOffset);
		
		/// <summary>Member SpellCheckRange </summary>
		/// <param name='aSelection'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SpellCheckRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aSelection);
		
		/// <summary>Member GetMisspelledWord </summary>
		/// <param name='aNode'> </param>
		/// <param name='aOffset'> </param>
		/// <returns>A nsIDOMRange</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange GetMisspelledWord([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, int aOffset);
		
		/// <summary>Member ReplaceWord </summary>
		/// <param name='aNode'> </param>
		/// <param name='aOffset'> </param>
		/// <param name='aNewword'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceWord([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, int aOffset, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNewword);
		
		/// <summary>Member AddWordToDictionary </summary>
		/// <param name='aWord'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWordToDictionary([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aWord);
		
		/// <summary>Member IgnoreWord </summary>
		/// <param name='aWord'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IgnoreWord([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aWord);
		
		/// <summary>Member IgnoreWords </summary>
		/// <param name='aWordsToIgnore'> </param>
		/// <param name='aCount'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IgnoreWords([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] System.IntPtr[] aWordsToIgnore, uint aCount);
		
		/// <summary>Member UpdateCurrentDictionary </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateCurrentDictionary();
	}
}
