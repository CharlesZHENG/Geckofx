﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class WindowUtilsTests
	{
		private GeckoWebBrowser browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			browser = new GeckoWebBrowser();
			var unused = browser.Handle;
			Assert.IsNotNull(browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			browser.Dispose();
		}

		[Test]
		public void ImageAnimationMode()
		{
			Assert.AreEqual(0, browser.Window.WindowUtils.ImageAnimationMode);

			browser.Window.WindowUtils.ImageAnimationMode = 1;
			Assert.AreEqual(1, browser.Window.WindowUtils.ImageAnimationMode);
		}

		[Test]
		public void DocCharsetIsForced()
		{
			Assert.AreEqual(false, browser.Window.WindowUtils.DocCharsetIsForced);
		}

		[Test]
		public void GetCursorType()
		{
			// enums defined in nsWidget.h
			const int eCursor_none = 34;
			
			Assert.AreEqual(eCursor_none, browser.Window.WindowUtils.GetCursorType());
		}

		[Test]
		public void GetDocumentMetadata()
		{
			Assert.AreEqual(String.Empty, browser.Window.WindowUtils.GetDocumentMetadata("var"));
		}

		[Test]
		public void Redraw()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			Assert.Less(browser.Window.WindowUtils.Redraw(1), 1000);
		}

		[Test]
		public void SetCSSViewport()
		{
			browser.Window.WindowUtils.SetCSSViewport(100f, 100f);
		}

		[Test]
		public void SetDisplayPortForElement()
		{
			browser.Window.WindowUtils.SetDisplayPortForElement(100, 100, 100, 100, browser.Document.Body);
		}

		[Test]
		public void SetResolution()
		{
			browser.Window.WindowUtils.SetResolution(100, 100);
		}

		[Test]
		public void SendMouseEvent()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			browser.Window.WindowUtils.SendMouseEvent("mousedown", 10, 10, 1, 1, 0, false);
		}

		[Test]
		public void SendMouseEventToWindow()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			browser.Window.WindowUtils.SendMouseEventToWindow("mousedown", 10, 10, 1, 1, 0, false);
		}

		[Test]
		public void SendKeyEvent()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			Assert.AreEqual(true, browser.Window.WindowUtils.SendKeyEvent("keypress", 0, 68, 0, false));
		}

		[Test]
		public void SendNativeKeyEvent()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			browser.Window.WindowUtils.SendNativeKeyEvent(0, 0, 0, "a", "a");
		}

		[Test]
		public void SendNativeMouseEvent()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			browser.Window.WindowUtils.SendNativeMouseEvent(0, 0, 0, 0, browser.Document.Body);
		}

		[Test]
		public void ActivateNativeMenuItemAt_ThrowsNotImplementedException()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			Assert.Throws<NotImplementedException>(() => browser.Window.WindowUtils.ActivateNativeMenuItemAt("0"));				
		}

		[Test]
		public void IMEIsOpen()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			Assert.IsFalse(browser.Window.WindowUtils.IMEIsOpen);
		}

		private class TestCycleCollectorListener : nsICycleCollectorListener
		{
			public int _allTraces;
			public int _wantAllTraces;
			public int _begin;
			public int _noteRefCountedOject;
			public int _noteGCedObject;
			public int _noteEdge;
			public int _beginResults;
			public int _describeRoot;
			public int _describeGarbage;
			public int _end;

			public nsICycleCollectorListener AllTraces()
			{
				_allTraces++;
				return null;
			}

			public bool GetWantAllTracesAttribute()
			{
				_wantAllTraces++;
				return false;
			}

			public void Begin()
			{
				_begin++;
			}

			public void NoteRefCountedObject(ulong aAddress, uint aRefCount, string aObjectDescription)
			{
				_noteRefCountedOject++;
			}

			public void NoteGCedObject(ulong aAddress, bool aMarked, string aObjectDescription)
			{
				_noteGCedObject++;
			}

			public void NoteEdge(ulong aToAddress, string aEdgeName)
			{
				_noteEdge++;
			}

			public void BeginResults()
			{
				_beginResults++;
			}

			public void DescribeRoot(ulong aAddress, uint aKnownEdges)
			{
				_describeRoot++;
			}

			public void DescribeGarbage(ulong aAddress)
			{
				_describeGarbage++;
			}

			public void End()
			{
				_end++;
			}
		}

		[Test]
		public void GarbageCollect()
		{
			var listener = new TestCycleCollectorListener();
			browser.Window.WindowUtils.GarbageCollect(listener, 0);

			Assert.AreEqual(1, listener._begin);
			Assert.AreEqual(1, listener._end);
		}

		[Test]
		public void CycleCollect()
		{
			var listener = new TestCycleCollectorListener();
			browser.Window.WindowUtils.CycleCollect(listener, 0);

			Assert.AreEqual(1, listener._begin);
			Assert.AreEqual(1, listener._end);
		}

		[Test]
		public void ProcessUpdates()
		{
			browser.Window.WindowUtils.ProcessUpdates();				
		}

		[Test]
		public void ElementFromPoint()
		{
			browser.TestLoadHtml("<body>hello world</body>");

			GeckoDomElement element = browser.Window.WindowUtils.ElementFromPoint(1, 1, true, false);

			Assert.AreEqual("HTML", element.TagName);
		}
	}
}