using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/WheelScroller", DoNotGenerateAcw=true)]
	public abstract partial class WheelScroller : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/field[@name='MIN_DELTA_FOR_SCROLLING']"
		[Register ("MIN_DELTA_FOR_SCROLLING")]
		public const int MinDeltaForScrolling = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/field[@name='SCROLL_DIRECTION_DOWN']"
		[Register ("SCROLL_DIRECTION_DOWN")]
		public const int ScrollDirectionDown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/field[@name='SCROLL_DIRECTION_UP']"
		[Register ("SCROLL_DIRECTION_UP")]
		public const int ScrollDirectionUp = (int) 1;

		static IntPtr scroller_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/field[@name='scroller']"
		[Register ("scroller")]
		protected global::Android.Widget.Scroller Scroller {
			get {
				if (scroller_jfieldId == IntPtr.Zero)
					scroller_jfieldId = JNIEnv.GetFieldID (class_ref, "scroller", "Landroid/widget/Scroller;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, scroller_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Scroller> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (scroller_jfieldId == IntPtr.Zero)
					scroller_jfieldId = JNIEnv.GetFieldID (class_ref, "scroller", "Landroid/widget/Scroller;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, scroller_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']"
		[Register ("antistatic/spinnerwheel/WheelScroller$ScrollingListener", "", "Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker")]
		public partial interface IScrollingListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onFinished' and count(parameter)=0]"
			[Register ("onFinished", "()V", "GetOnFinishedHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnFinished ();

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onFling' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onFling", "(I)V", "GetOnFling_IHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnFling (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onJustify' and count(parameter)=0]"
			[Register ("onJustify", "()V", "GetOnJustifyHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnJustify ();

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onScroll' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onScroll", "(I)V", "GetOnScroll_IHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnScroll (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onStarted' and count(parameter)=0]"
			[Register ("onStarted", "()V", "GetOnStartedHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnStarted ();

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onTouch' and count(parameter)=0]"
			[Register ("onTouch", "()V", "GetOnTouchHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnTouch ();

			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='WheelScroller.ScrollingListener']/method[@name='onTouchUp' and count(parameter)=0]"
			[Register ("onTouchUp", "()V", "GetOnTouchUpHandler:Antistatic.Spinnerwheel.WheelScroller/IScrollingListenerInvoker, SpinnerWheel")]
			void OnTouchUp ();

		}

		[global::Android.Runtime.Register ("antistatic/spinnerwheel/WheelScroller$ScrollingListener", DoNotGenerateAcw=true)]
		internal class IScrollingListenerInvoker : global::Java.Lang.Object, IScrollingListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("antistatic/spinnerwheel/WheelScroller$ScrollingListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IScrollingListenerInvoker); }
			}

			IntPtr class_ref;

			public static IScrollingListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IScrollingListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "antistatic.spinnerwheel.WheelScroller.ScrollingListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IScrollingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFinished;
#pragma warning disable 0169
			static Delegate GetOnFinishedHandler ()
			{
				if (cb_onFinished == null)
					cb_onFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinished);
				return cb_onFinished;
			}

			static void n_OnFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onFinished;
			public unsafe void OnFinished ()
			{
				if (id_onFinished == IntPtr.Zero)
					id_onFinished = JNIEnv.GetMethodID (class_ref, "onFinished", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinished);
			}

			static Delegate cb_onFling_I;
#pragma warning disable 0169
			static Delegate GetOnFling_IHandler ()
			{
				if (cb_onFling_I == null)
					cb_onFling_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFling_I);
				return cb_onFling_I;
			}

			static void n_OnFling_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFling (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFling_I;
			public unsafe void OnFling (int p0)
			{
				if (id_onFling_I == IntPtr.Zero)
					id_onFling_I = JNIEnv.GetMethodID (class_ref, "onFling", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFling_I, __args);
			}

			static Delegate cb_onJustify;
#pragma warning disable 0169
			static Delegate GetOnJustifyHandler ()
			{
				if (cb_onJustify == null)
					cb_onJustify = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnJustify);
				return cb_onJustify;
			}

			static void n_OnJustify (IntPtr jnienv, IntPtr native__this)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnJustify ();
			}
#pragma warning restore 0169

			IntPtr id_onJustify;
			public unsafe void OnJustify ()
			{
				if (id_onJustify == IntPtr.Zero)
					id_onJustify = JNIEnv.GetMethodID (class_ref, "onJustify", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onJustify);
			}

			static Delegate cb_onScroll_I;
#pragma warning disable 0169
			static Delegate GetOnScroll_IHandler ()
			{
				if (cb_onScroll_I == null)
					cb_onScroll_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnScroll_I);
				return cb_onScroll_I;
			}

			static void n_OnScroll_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnScroll (p0);
			}
#pragma warning restore 0169

			IntPtr id_onScroll_I;
			public unsafe void OnScroll (int p0)
			{
				if (id_onScroll_I == IntPtr.Zero)
					id_onScroll_I = JNIEnv.GetMethodID (class_ref, "onScroll", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScroll_I, __args);
			}

			static Delegate cb_onStarted;
#pragma warning disable 0169
			static Delegate GetOnStartedHandler ()
			{
				if (cb_onStarted == null)
					cb_onStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStarted);
				return cb_onStarted;
			}

			static void n_OnStarted (IntPtr jnienv, IntPtr native__this)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStarted ();
			}
#pragma warning restore 0169

			IntPtr id_onStarted;
			public unsafe void OnStarted ()
			{
				if (id_onStarted == IntPtr.Zero)
					id_onStarted = JNIEnv.GetMethodID (class_ref, "onStarted", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStarted);
			}

			static Delegate cb_onTouch;
#pragma warning disable 0169
			static Delegate GetOnTouchHandler ()
			{
				if (cb_onTouch == null)
					cb_onTouch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTouch);
				return cb_onTouch;
			}

			static void n_OnTouch (IntPtr jnienv, IntPtr native__this)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTouch ();
			}
#pragma warning restore 0169

			IntPtr id_onTouch;
			public unsafe void OnTouch ()
			{
				if (id_onTouch == IntPtr.Zero)
					id_onTouch = JNIEnv.GetMethodID (class_ref, "onTouch", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouch);
			}

			static Delegate cb_onTouchUp;
#pragma warning disable 0169
			static Delegate GetOnTouchUpHandler ()
			{
				if (cb_onTouchUp == null)
					cb_onTouchUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTouchUp);
				return cb_onTouchUp;
			}

			static void n_OnTouchUp (IntPtr jnienv, IntPtr native__this)
			{
				global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTouchUp ();
			}
#pragma warning restore 0169

			IntPtr id_onTouchUp;
			public unsafe void OnTouchUp ()
			{
				if (id_onTouchUp == IntPtr.Zero)
					id_onTouchUp = JNIEnv.GetMethodID (class_ref, "onTouchUp", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouchUp);
			}

		}

		public partial class FlingEventArgs : global::System.EventArgs {

			public FlingEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class ScrollEventArgs : global::System.EventArgs {

			public ScrollEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/antistatic/spinnerwheel/WheelScroller_ScrollingListenerImplementor")]
		internal sealed partial class IScrollingListenerImplementor : global::Java.Lang.Object, IScrollingListener {

			object sender;

			public IScrollingListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/antistatic/spinnerwheel/WheelScroller_ScrollingListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnFinishedHandler;
#pragma warning restore 0649

			public void OnFinished ()
			{
				var __h = OnFinishedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<FlingEventArgs> OnFlingHandler;
#pragma warning restore 0649

			public void OnFling (int p0)
			{
				var __h = OnFlingHandler;
				if (__h != null)
					__h (sender, new FlingEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnJustifyHandler;
#pragma warning restore 0649

			public void OnJustify ()
			{
				var __h = OnJustifyHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<ScrollEventArgs> OnScrollHandler;
#pragma warning restore 0649

			public void OnScroll (int p0)
			{
				var __h = OnScrollHandler;
				if (__h != null)
					__h (sender, new ScrollEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnStartedHandler;
#pragma warning restore 0649

			public void OnStarted ()
			{
				var __h = OnStartedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnTouchHandler;
#pragma warning restore 0649

			public void OnTouch ()
			{
				var __h = OnTouchHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnTouchUpHandler;
#pragma warning restore 0649

			public void OnTouchUp ()
			{
				var __h = OnTouchUpHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IScrollingListenerImplementor value)
			{
				return value.OnFinishedHandler == null && value.OnFlingHandler == null && value.OnJustifyHandler == null && value.OnScrollHandler == null && value.OnStartedHandler == null && value.OnTouchHandler == null && value.OnTouchUpHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/WheelScroller", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelScroller); }
		}

		protected WheelScroller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/constructor[@name='WheelScroller' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='antistatic.spinnerwheel.WheelScroller.ScrollingListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)V", "")]
		public unsafe WheelScroller (global::Android.Content.Context p0, global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelScroller)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentScrollerPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentScrollerPositionHandler ()
		{
			if (cb_getCurrentScrollerPosition == null)
				cb_getCurrentScrollerPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentScrollerPosition);
			return cb_getCurrentScrollerPosition;
		}

		static int n_GetCurrentScrollerPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScrollerPosition;
		}
#pragma warning restore 0169

		protected abstract int CurrentScrollerPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='getCurrentScrollerPosition' and count(parameter)=0]"
			[Register ("getCurrentScrollerPosition", "()I", "GetGetCurrentScrollerPositionHandler")] get;
		}

		static Delegate cb_getFinalScrollerPosition;
#pragma warning disable 0169
		static Delegate GetGetFinalScrollerPositionHandler ()
		{
			if (cb_getFinalScrollerPosition == null)
				cb_getFinalScrollerPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFinalScrollerPosition);
			return cb_getFinalScrollerPosition;
		}

		static int n_GetFinalScrollerPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalScrollerPosition;
		}
#pragma warning restore 0169

		protected abstract int FinalScrollerPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='getFinalScrollerPosition' and count(parameter)=0]"
			[Register ("getFinalScrollerPosition", "()I", "GetGetFinalScrollerPositionHandler")] get;
		}

		static Delegate cb_finishScrolling;
#pragma warning disable 0169
		static Delegate GetFinishScrollingHandler ()
		{
			if (cb_finishScrolling == null)
				cb_finishScrolling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishScrolling);
			return cb_finishScrolling;
		}

		static void n_FinishScrolling (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishScrolling ();
		}
#pragma warning restore 0169

		static IntPtr id_finishScrolling;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='finishScrolling' and count(parameter)=0]"
		[Register ("finishScrolling", "()V", "GetFinishScrollingHandler")]
		protected virtual unsafe void FinishScrolling ()
		{
			if (id_finishScrolling == IntPtr.Zero)
				id_finishScrolling = JNIEnv.GetMethodID (class_ref, "finishScrolling", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishScrolling);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishScrolling", "()V"));
			} finally {
			}
		}

		static Delegate cb_getMotionEventPosition_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetGetMotionEventPosition_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_getMotionEventPosition_Landroid_view_MotionEvent_ == null)
				cb_getMotionEventPosition_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetMotionEventPosition_Landroid_view_MotionEvent_);
			return cb_getMotionEventPosition_Landroid_view_MotionEvent_;
		}

		static float n_GetMotionEventPosition_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetMotionEventPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='getMotionEventPosition' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("getMotionEventPosition", "(Landroid/view/MotionEvent;)F", "GetGetMotionEventPosition_Landroid_view_MotionEvent_Handler")]
		protected abstract float GetMotionEventPosition (global::Android.Views.MotionEvent p0);

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_scroll_II;
#pragma warning disable 0169
		static Delegate GetScroll_IIHandler ()
		{
			if (cb_scroll_II == null)
				cb_scroll_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Scroll_II);
			return cb_scroll_II;
		}

		static void n_Scroll_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scroll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_scroll_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='scroll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scroll", "(II)V", "GetScroll_IIHandler")]
		public virtual unsafe void Scroll (int p0, int p1)
		{
			if (id_scroll_II == IntPtr.Zero)
				id_scroll_II = JNIEnv.GetMethodID (class_ref, "scroll", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scroll_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scroll", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_scrollerFling_III;
#pragma warning disable 0169
		static Delegate GetScrollerFling_IIIHandler ()
		{
			if (cb_scrollerFling_III == null)
				cb_scrollerFling_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ScrollerFling_III);
			return cb_scrollerFling_III;
		}

		static void n_ScrollerFling_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollerFling (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='scrollerFling' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("scrollerFling", "(III)V", "GetScrollerFling_IIIHandler")]
		protected abstract void ScrollerFling (int p0, int p1, int p2);

		static Delegate cb_scrollerStartScroll_II;
#pragma warning disable 0169
		static Delegate GetScrollerStartScroll_IIHandler ()
		{
			if (cb_scrollerStartScroll_II == null)
				cb_scrollerStartScroll_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ScrollerStartScroll_II);
			return cb_scrollerStartScroll_II;
		}

		static void n_ScrollerStartScroll_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollerStartScroll (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='scrollerStartScroll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollerStartScroll", "(II)V", "GetScrollerStartScroll_IIHandler")]
		protected abstract void ScrollerStartScroll (int p0, int p1);

		static Delegate cb_setFriction_F;
#pragma warning disable 0169
		static Delegate GetSetFriction_FHandler ()
		{
			if (cb_setFriction_F == null)
				cb_setFriction_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFriction_F);
			return cb_setFriction_F;
		}

		static void n_SetFriction_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFriction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFriction_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='setFriction' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setFriction", "(F)V", "GetSetFriction_FHandler")]
		public virtual unsafe void SetFriction (float p0)
		{
			if (id_setFriction_F == IntPtr.Zero)
				id_setFriction_F = JNIEnv.GetMethodID (class_ref, "setFriction", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFriction_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFriction", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public virtual unsafe void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			if (id_setInterpolator_Landroid_view_animation_Interpolator_ == IntPtr.Zero)
				id_setInterpolator_Landroid_view_animation_Interpolator_ = JNIEnv.GetMethodID (class_ref, "setInterpolator", "(Landroid/view/animation/Interpolator;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInterpolator_Landroid_view_animation_Interpolator_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopScrolling;
#pragma warning disable 0169
		static Delegate GetStopScrollingHandler ()
		{
			if (cb_stopScrolling == null)
				cb_stopScrolling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopScrolling);
			return cb_stopScrolling;
		}

		static void n_StopScrolling (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.WheelScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScrolling ();
		}
#pragma warning restore 0169

		static IntPtr id_stopScrolling;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='stopScrolling' and count(parameter)=0]"
		[Register ("stopScrolling", "()V", "GetStopScrollingHandler")]
		public virtual unsafe void StopScrolling ()
		{
			if (id_stopScrolling == IntPtr.Zero)
				id_stopScrolling = JNIEnv.GetMethodID (class_ref, "stopScrolling", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopScrolling);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopScrolling", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/WheelScroller", DoNotGenerateAcw=true)]
	internal partial class WheelScrollerInvoker : WheelScroller {

		public WheelScrollerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelScrollerInvoker); }
		}

		static IntPtr id_getCurrentScrollerPosition;
		protected override unsafe int CurrentScrollerPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='getCurrentScrollerPosition' and count(parameter)=0]"
			[Register ("getCurrentScrollerPosition", "()I", "GetGetCurrentScrollerPositionHandler")]
			get {
				if (id_getCurrentScrollerPosition == IntPtr.Zero)
					id_getCurrentScrollerPosition = JNIEnv.GetMethodID (class_ref, "getCurrentScrollerPosition", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentScrollerPosition);
				} finally {
				}
			}
		}

		static IntPtr id_getFinalScrollerPosition;
		protected override unsafe int FinalScrollerPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='getFinalScrollerPosition' and count(parameter)=0]"
			[Register ("getFinalScrollerPosition", "()I", "GetGetFinalScrollerPositionHandler")]
			get {
				if (id_getFinalScrollerPosition == IntPtr.Zero)
					id_getFinalScrollerPosition = JNIEnv.GetMethodID (class_ref, "getFinalScrollerPosition", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFinalScrollerPosition);
				} finally {
				}
			}
		}

		static IntPtr id_getMotionEventPosition_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='getMotionEventPosition' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("getMotionEventPosition", "(Landroid/view/MotionEvent;)F", "GetGetMotionEventPosition_Landroid_view_MotionEvent_Handler")]
		protected override unsafe float GetMotionEventPosition (global::Android.Views.MotionEvent p0)
		{
			if (id_getMotionEventPosition_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_getMotionEventPosition_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "getMotionEventPosition", "(Landroid/view/MotionEvent;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMotionEventPosition_Landroid_view_MotionEvent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_scrollerFling_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='scrollerFling' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("scrollerFling", "(III)V", "GetScrollerFling_IIIHandler")]
		protected override unsafe void ScrollerFling (int p0, int p1, int p2)
		{
			if (id_scrollerFling_III == IntPtr.Zero)
				id_scrollerFling_III = JNIEnv.GetMethodID (class_ref, "scrollerFling", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scrollerFling_III, __args);
			} finally {
			}
		}

		static IntPtr id_scrollerStartScroll_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelScroller']/method[@name='scrollerStartScroll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollerStartScroll", "(II)V", "GetScrollerStartScroll_IIHandler")]
		protected override unsafe void ScrollerStartScroll (int p0, int p1)
		{
			if (id_scrollerStartScroll_II == IntPtr.Zero)
				id_scrollerStartScroll_II = JNIEnv.GetMethodID (class_ref, "scrollerStartScroll", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scrollerStartScroll_II, __args);
			} finally {
			}
		}

	}

}
