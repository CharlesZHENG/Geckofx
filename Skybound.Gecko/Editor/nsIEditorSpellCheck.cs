﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko.Editor
{	
	[Guid("90c93610-c116-44ab-9793-62dccb9f43ce"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIEditorSpellCheck
	{
		/**
		  * Returns true if we can enable spellchecking. If there are no available
		  * dictionaries, this will return false.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool canSpellCheck();

		/**
		 * Turns on the spell checker for the given editor. enableSelectionChecking
		 * set means that we only want to check the current selection in the editor,
		 * (this controls the behavior of GetNextMisspelledWord). For spellchecking
		 * clients with no modal UI (such as inline spellcheckers), this flag doesn't
		 * matter
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InitSpellChecker([MarshalAs(UnmanagedType.Interface)]nsIEditor editor, bool enableSelectionChecking);

		/**
		 * When interactively spell checking the document, this will return the
		 * value of the next word that is misspelled. This also computes the
		 * suggestions which you can get by calling GetSuggestedWord.
		 *
		 * @see nsISpellChecker::GetNextMisspelledWord
		 */
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetNextMisspelledWord();

		/**
		 * Used to get suggestions for the last word that was checked and found to
		 * be misspelled. The first call will give you the first (best) suggestion.
		 * Subsequent calls will iterate through all the suggestions, allowing you
		 * to build a list. When there are no more suggestions, an empty string
		 * (not a null pointer) will be returned.
		 *
		 * @see nsISpellChecker::GetSuggestedWord
		 */
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetSuggestedWord();

		/**
		 * Check a given word. In spite of the name, this function checks the word
		 * you give it, returning true if the word is misspelled. If the word is
		 * misspelled, it will compute the suggestions which you can get from
		 * GetSuggestedWord().
		 *
		 * @see nsISpellChecker::CheckCurrentWord
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CheckCurrentWord([MarshalAs(UnmanagedType.LPWStr)] string suggestedWord);

		/**
		 * Use when modally checking the document to replace a word.
		 *
		 * @see nsISpellChecker::CheckCurrentWord
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReplaceWord([MarshalAs(UnmanagedType.LPWStr)] string misspelledWord, [MarshalAs(UnmanagedType.LPWStr)] nsAString replaceWord, bool allOccurrences);

		/**
		 * @see nsISpellChecker::IgnoreAll
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void IgnoreWordAllOccurrences([MarshalAs(UnmanagedType.LPWStr)] string word);

		/**
		 * Fills an internal list of words added to the personal dictionary. These
		 * words can be retrieved using GetPersonalDictionaryWord()
		 *
		 * @see nsISpellChecker::GetPersonalDictionary
		 * @see GetPersonalDictionaryWord
		 */
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetPersonalDictionary();

		/**
		 * Used after you call GetPersonalDictionary() to iterate through all the
		 * words added to the personal dictionary. Will return the empty string when
		 * there are no more words.
		 */
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetPersonalDictionaryWord();

		/**
		 * Adds a word to the current personal dictionary.
		 *
		 * @see nsISpellChecker::AddWordToDictionary
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddWordToDictionary([MarshalAs(UnmanagedType.LPWStr)] string word);

		/**
		 * Removes a word from the current personal dictionary.
		 *
		 * @see nsISpellChecker::RemoveWordFromPersonalDictionary
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveWordFromDictionary([MarshalAs(UnmanagedType.LPWStr)] string word);

		/**
		 * Retrieves a list of the currently available dictionaries. The strings will
		 * typically be language IDs, like "en-US".
		 *
		 * @see mozISpellCheckingEngine::GetDictionaryList
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetDictionaryList([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)]string[] dictionaryList, out int count);

		/**
		 * @see nsISpellChecker::GetCurrentDictionary
		 */
		[return: MarshalAs(UnmanagedType.LPWStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetCurrentDictionary();

		/**
		 * @see nsISpellChecker::SetCurrentDictionary
		 */		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCurrentDictionary([MarshalAs(UnmanagedType.LPWStr)] string dictionary);

		/**
		 * Call to save the currently selected dictionary as the default. The
		 * function UninitSpellChecker will also do this, but that function may not
		 * be called in some situations. This function allows the caller to force the
		 * default right now.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SaveDefaultDictionary();

		/**
		 * Call this to free up the spell checking object. It will also save the
		 * current selected language as the default for future use.
		 *
		 * If you have called CanSpellCheck but not InitSpellChecker, you can still
		 * call this function to clear the cached spell check object, and no
		 * preference saving will happen.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UninitSpellChecker();

		/**
		 * Used to filter the content (for example, to skip blockquotes in email from
		 * spellchecking. Call this before calling InitSpellChecker; calling it
		 * after initialization will have no effect.
		 *
		 * @see nsITextServicesDocument::setFilter
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetFilter(IntPtr/*nsITextServicesFilter*/ filter);

		/**
		 * Like CheckCurrentWord, checks the word you give it, returning true if it's
		 * misspelled. This is faster than CheckCurrentWord because it does not
		 * compute any suggestions.
		 *
		 * Watch out: this does not clear any suggestions left over from previous
		 * calls to CheckCurrentWord, so there may be suggestions, but they will be
		 * invalid.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CheckCurrentWordNoSuggest([MarshalAs(UnmanagedType.LPStruct)] nsAString suggestedWord);
	};
}

