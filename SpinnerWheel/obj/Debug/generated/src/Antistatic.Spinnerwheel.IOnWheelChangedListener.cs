using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath interface reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelChangedListener']"
	[Register ("antistatic/spinnerwheel/OnWheelChangedListener", "", "Antistatic.Spinnerwheel.IOnWheelChangedListenerInvoker")]
	public partial interface IOnWheelChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/interface[@name='OnWheelChangedListener']/method[@name='onChanged' and count(parameter)=3 and parameter[1][@type='antistatic.spinnerwheel.AbstractWheel'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onChanged", "(Lantistatic/spinnerwheel/AbstractWheel;II)V", "GetOnChanged_Lantistatic_spinnerwheel_AbstractWheel_IIHandler:Antistatic.Spinnerwheel.IOnWheelChangedListenerInvoker, SpinnerWheel")]
		void OnChanged (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/OnWheelChangedListener", DoNotGenerateAcw=true)]
	internal class IOnWheelChangedListenerInvoker : global::Java.Lang.Object, IOnWheelChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("antistatic/spinnerwheel/OnWheelChangedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnWheelChangedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnWheelChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnWheelChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "antistatic.spinnerwheel.OnWheelChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnWheelChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II;
#pragma warning disable 0169
		static Delegate GetOnChanged_Lantistatic_spinnerwheel_AbstractWheel_IIHandler ()
		{
			if (cb_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II == null)
				cb_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnChanged_Lantistatic_spinnerwheel_AbstractWheel_II);
			return cb_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II;
		}

		static void n_OnChanged_Lantistatic_spinnerwheel_AbstractWheel_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Antistatic.Spinnerwheel.IOnWheelChangedListener __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.AbstractWheel p0 = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II;
		public unsafe void OnChanged (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1, int p2)
		{
			if (id_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II == IntPtr.Zero)
				id_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II = JNIEnv.GetMethodID (class_ref, "onChanged", "(Lantistatic/spinnerwheel/AbstractWheel;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChanged_Lantistatic_spinnerwheel_AbstractWheel_II, __args);
		}

	}

	public partial class WheelChangedEventArgs : global::System.EventArgs {

		public WheelChangedEventArgs (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Antistatic.Spinnerwheel.AbstractWheel p0;
		public global::Antistatic.Spinnerwheel.AbstractWheel P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/antistatic/spinnerwheel/OnWheelChangedListenerImplementor")]
	internal sealed partial class IOnWheelChangedListenerImplementor : global::Java.Lang.Object, IOnWheelChangedListener {

		object sender;

		public IOnWheelChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/antistatic/spinnerwheel/OnWheelChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<WheelChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnChanged (global::Antistatic.Spinnerwheel.AbstractWheel p0, int p1, int p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new WheelChangedEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IOnWheelChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
