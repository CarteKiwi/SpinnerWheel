using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/WheelHorizontalScroller", DoNotGenerateAcw=true)]
	public partial class WheelHorizontalScroller : global::Antistatic.Spinnerwheel.WheelScroller {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/WheelHorizontalScroller", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelHorizontalScroller); }
		}

		protected WheelHorizontalScroller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']/constructor[@name='WheelHorizontalScroller' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='antistatic.spinnerwheel.WheelScroller.ScrollingListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)V", "")]
		public unsafe WheelHorizontalScroller (global::Android.Content.Context p0, global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelHorizontalScroller)) {
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
			global::Antistatic.Spinnerwheel.WheelHorizontalScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelHorizontalScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScrollerPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentScrollerPosition;
		protected override unsafe int CurrentScrollerPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']/method[@name='getCurrentScrollerPosition' and count(parameter)=0]"
			[Register ("getCurrentScrollerPosition", "()I", "GetGetCurrentScrollerPositionHandler")]
			get {
				if (id_getCurrentScrollerPosition == IntPtr.Zero)
					id_getCurrentScrollerPosition = JNIEnv.GetMethodID (class_ref, "getCurrentScrollerPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentScrollerPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentScrollerPosition", "()I"));
				} finally {
				}
			}
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
			global::Antistatic.Spinnerwheel.WheelHorizontalScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelHorizontalScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalScrollerPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getFinalScrollerPosition;
		protected override unsafe int FinalScrollerPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']/method[@name='getFinalScrollerPosition' and count(parameter)=0]"
			[Register ("getFinalScrollerPosition", "()I", "GetGetFinalScrollerPositionHandler")]
			get {
				if (id_getFinalScrollerPosition == IntPtr.Zero)
					id_getFinalScrollerPosition = JNIEnv.GetMethodID (class_ref, "getFinalScrollerPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFinalScrollerPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFinalScrollerPosition", "()I"));
				} finally {
				}
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
			global::Antistatic.Spinnerwheel.WheelHorizontalScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelHorizontalScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetMotionEventPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMotionEventPosition_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']/method[@name='getMotionEventPosition' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("getMotionEventPosition", "(Landroid/view/MotionEvent;)F", "GetGetMotionEventPosition_Landroid_view_MotionEvent_Handler")]
		protected override unsafe float GetMotionEventPosition (global::Android.Views.MotionEvent p0)
		{
			if (id_getMotionEventPosition_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_getMotionEventPosition_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "getMotionEventPosition", "(Landroid/view/MotionEvent;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				float __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMotionEventPosition_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMotionEventPosition", "(Landroid/view/MotionEvent;)F"), __args);
				return __ret;
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
			global::Antistatic.Spinnerwheel.WheelHorizontalScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelHorizontalScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollerFling (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_scrollerFling_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']/method[@name='scrollerFling' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scrollerFling_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scrollerFling", "(III)V"), __args);
			} finally {
			}
		}

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
			global::Antistatic.Spinnerwheel.WheelHorizontalScroller __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelHorizontalScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollerStartScroll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_scrollerStartScroll_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='WheelHorizontalScroller']/method[@name='scrollerStartScroll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollerStartScroll", "(II)V", "GetScrollerStartScroll_IIHandler")]
		protected override unsafe void ScrollerStartScroll (int p0, int p1)
		{
			if (id_scrollerStartScroll_II == IntPtr.Zero)
				id_scrollerStartScroll_II = JNIEnv.GetMethodID (class_ref, "scrollerStartScroll", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scrollerStartScroll_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scrollerStartScroll", "(II)V"), __args);
			} finally {
			}
		}

	}
}
