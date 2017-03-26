using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelScrollListener']"
	[Register ("antistatic/spinnerwheel/OnWheelScrollListener", "", "Antistatic.Spinnerwheel.IOnWheelScrollListenerInvoker")]
	public partial interface IOnWheelScrollListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelScrollListener']/method[@name='onScrollingFinished' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.AbstractWheel']]"
		[Register ("onScrollingFinished", "(Lantistatic/spinnerwheel/AbstractWheel;)V", "GetOnScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_Handler:Antistatic.Spinnerwheel.IOnWheelScrollListenerInvoker, SpinnerWheel")]
		void OnScrollingFinished (global::Antistatic.Spinnerwheel.AbstractWheel p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelScrollListener']/method[@name='onScrollingStarted' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.AbstractWheel']]"
		[Register ("onScrollingStarted", "(Lantistatic/spinnerwheel/AbstractWheel;)V", "GetOnScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_Handler:Antistatic.Spinnerwheel.IOnWheelScrollListenerInvoker, SpinnerWheel")]
		void OnScrollingStarted (global::Antistatic.Spinnerwheel.AbstractWheel p0);

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/OnWheelScrollListener", DoNotGenerateAcw=true)]
	internal class IOnWheelScrollListenerInvoker : global::Java.Lang.Object, IOnWheelScrollListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("antistatic/spinnerwheel/OnWheelScrollListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnWheelScrollListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnWheelScrollListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnWheelScrollListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "antistatic.spinnerwheel.OnWheelScrollListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnWheelScrollListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_;
#pragma warning disable 0169
		static Delegate GetOnScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_Handler ()
		{
			if (cb_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_ == null)
				cb_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_);
			return cb_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_;
		}

		static void n_OnScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.IOnWheelScrollListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.AbstractWheel p0 = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollingFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_;
		public unsafe void OnScrollingFinished (global::Antistatic.Spinnerwheel.AbstractWheel p0)
		{
			if (id_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_ == IntPtr.Zero)
				id_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_ = JNIEnv.GetMethodID (class_ref, "onScrollingFinished", "(Lantistatic/spinnerwheel/AbstractWheel;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollingFinished_Lantistatic_spinnerwheel_AbstractWheel_, __args);
		}

		static Delegate cb_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_;
#pragma warning disable 0169
		static Delegate GetOnScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_Handler ()
		{
			if (cb_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_ == null)
				cb_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_);
			return cb_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_;
		}

		static void n_OnScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.IOnWheelScrollListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.AbstractWheel p0 = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollingStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_;
		public unsafe void OnScrollingStarted (global::Antistatic.Spinnerwheel.AbstractWheel p0)
		{
			if (id_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_ == IntPtr.Zero)
				id_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_ = JNIEnv.GetMethodID (class_ref, "onScrollingStarted", "(Lantistatic/spinnerwheel/AbstractWheel;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollingStarted_Lantistatic_spinnerwheel_AbstractWheel_, __args);
		}

	}

	public partial class ScrollingFinishedEventArgs : global::System.EventArgs {

		public ScrollingFinishedEventArgs (global::Antistatic.Spinnerwheel.AbstractWheel p0)
		{
			this.p0 = p0;
		}

		global::Antistatic.Spinnerwheel.AbstractWheel p0;
		public global::Antistatic.Spinnerwheel.AbstractWheel P0 {
			get { return p0; }
		}
	}

	public partial class ScrollingStartedEventArgs : global::System.EventArgs {

		public ScrollingStartedEventArgs (global::Antistatic.Spinnerwheel.AbstractWheel p0)
		{
			this.p0 = p0;
		}

		global::Antistatic.Spinnerwheel.AbstractWheel p0;
		public global::Antistatic.Spinnerwheel.AbstractWheel P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/antistatic/spinnerwheel/OnWheelScrollListenerImplementor")]
	internal sealed partial class IOnWheelScrollListenerImplementor : global::Java.Lang.Object, IOnWheelScrollListener {

		object sender;

		public IOnWheelScrollListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/antistatic/spinnerwheel/OnWheelScrollListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ScrollingFinishedEventArgs> OnScrollingFinishedHandler;
#pragma warning restore 0649

		public void OnScrollingFinished (global::Antistatic.Spinnerwheel.AbstractWheel p0)
		{
			var __h = OnScrollingFinishedHandler;
			if (__h != null)
				__h (sender, new ScrollingFinishedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ScrollingStartedEventArgs> OnScrollingStartedHandler;
#pragma warning restore 0649

		public void OnScrollingStarted (global::Antistatic.Spinnerwheel.AbstractWheel p0)
		{
			var __h = OnScrollingStartedHandler;
			if (__h != null)
				__h (sender, new ScrollingStartedEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnWheelScrollListenerImplementor value)
		{
			return value.OnScrollingFinishedHandler == null && value.OnScrollingStartedHandler == null;
		}
	}

}
