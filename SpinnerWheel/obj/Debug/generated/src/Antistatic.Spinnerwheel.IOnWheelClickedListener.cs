using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelClickedListener']"
	[Register ("antistatic/spinnerwheel/OnWheelClickedListener", "", "Antistatic.Spinnerwheel.IOnWheelClickedListenerInvoker")]
	public partial interface IOnWheelClickedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelClickedListener']/method[@name='onItemClicked' and count(parameter)=2 and parameter[1][@type='antistatic.spinnerwheel.AbstractWheel'] and parameter[2][@type='int']]"
		[Register ("onItemClicked", "(Lantistatic/spinnerwheel/AbstractWheel;I)V", "GetOnItemClicked_Lantistatic_spinnerwheel_AbstractWheel_IHandler:Antistatic.Spinnerwheel.IOnWheelClickedListenerInvoker, SpinnerWheel")]
		void OnItemClicked (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1);

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/OnWheelClickedListener", DoNotGenerateAcw=true)]
	internal class IOnWheelClickedListenerInvoker : global::Java.Lang.Object, IOnWheelClickedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("antistatic/spinnerwheel/OnWheelClickedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnWheelClickedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnWheelClickedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnWheelClickedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "antistatic.spinnerwheel.OnWheelClickedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnWheelClickedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I;
#pragma warning disable 0169
		static Delegate GetOnItemClicked_Lantistatic_spinnerwheel_AbstractWheel_IHandler ()
		{
			if (cb_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I == null)
				cb_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I);
			return cb_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I;
		}

		static void n_OnItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Antistatic.Spinnerwheel.IOnWheelClickedListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelClickedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.AbstractWheel p0 = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnItemClicked (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I;
		public unsafe void OnItemClicked (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1)
		{
			if (id_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I == IntPtr.Zero)
				id_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I = JNIEnv.GetMethodID (class_ref, "onItemClicked", "(Lantistatic/spinnerwheel/AbstractWheel;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemClicked_Lantistatic_spinnerwheel_AbstractWheel_I, __args);
		}

	}

	public partial class WheelClickedEventArgs : global::System.EventArgs {

		public WheelClickedEventArgs (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Antistatic.Spinnerwheel.AbstractWheel p0;
		public global::Antistatic.Spinnerwheel.AbstractWheel P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/antistatic/spinnerwheel/OnWheelClickedListenerImplementor")]
	internal sealed partial class IOnWheelClickedListenerImplementor : global::Java.Lang.Object, IOnWheelClickedListener {

		object sender;

		public IOnWheelClickedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/antistatic/spinnerwheel/OnWheelClickedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<WheelClickedEventArgs> Handler;
#pragma warning restore 0649

		public void OnItemClicked (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new WheelClickedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnWheelClickedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
