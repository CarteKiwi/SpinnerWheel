using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/AbstractWheelCustomAdapter", DoNotGenerateAcw=true)]
	public abstract partial class AbstractWheelCustomAdapter : global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/field[@name='NO_RESOURCE']"
		[Register ("NO_RESOURCE")]
		protected const int NoResource = (int) 0;

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr emptyItemResourceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/field[@name='emptyItemResourceId']"
		[Register ("emptyItemResourceId")]
		protected int EmptyItemResourceId {
			get {
				if (emptyItemResourceId_jfieldId == IntPtr.Zero)
					emptyItemResourceId_jfieldId = JNIEnv.GetFieldID (class_ref, "emptyItemResourceId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, emptyItemResourceId_jfieldId);
			}
			set {
				if (emptyItemResourceId_jfieldId == IntPtr.Zero)
					emptyItemResourceId_jfieldId = JNIEnv.GetFieldID (class_ref, "emptyItemResourceId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, emptyItemResourceId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr inflater_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/field[@name='inflater']"
		[Register ("inflater")]
		protected global::Android.Views.LayoutInflater Inflater {
			get {
				if (inflater_jfieldId == IntPtr.Zero)
					inflater_jfieldId = JNIEnv.GetFieldID (class_ref, "inflater", "Landroid/view/LayoutInflater;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, inflater_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (inflater_jfieldId == IntPtr.Zero)
					inflater_jfieldId = JNIEnv.GetFieldID (class_ref, "inflater", "Landroid/view/LayoutInflater;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, inflater_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr itemResourceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/field[@name='itemResourceId']"
		[Register ("itemResourceId")]
		protected int ItemResourceId {
			get {
				if (itemResourceId_jfieldId == IntPtr.Zero)
					itemResourceId_jfieldId = JNIEnv.GetFieldID (class_ref, "itemResourceId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, itemResourceId_jfieldId);
			}
			set {
				if (itemResourceId_jfieldId == IntPtr.Zero)
					itemResourceId_jfieldId = JNIEnv.GetFieldID (class_ref, "itemResourceId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, itemResourceId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/AbstractWheelCustomAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelCustomAdapter); }
		}

		protected AbstractWheelCustomAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_LayoutInflater_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/constructor[@name='AbstractWheelCustomAdapter' and count(parameter)=2 and parameter[1][@type='android.view.LayoutInflater'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/view/LayoutInflater;I)V", "")]
		protected unsafe AbstractWheelCustomAdapter (global::Android.Views.LayoutInflater p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AbstractWheelCustomAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/LayoutInflater;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/LayoutInflater;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_LayoutInflater_I == IntPtr.Zero)
					id_ctor_Landroid_view_LayoutInflater_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/LayoutInflater;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_LayoutInflater_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_LayoutInflater_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_view_LayoutInflater_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/constructor[@name='AbstractWheelCustomAdapter' and count(parameter)=1 and parameter[1][@type='android.view.LayoutInflater']]"
		[Register (".ctor", "(Landroid/view/LayoutInflater;)V", "")]
		protected unsafe AbstractWheelCustomAdapter (global::Android.Views.LayoutInflater p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AbstractWheelCustomAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/LayoutInflater;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/LayoutInflater;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_LayoutInflater_ == IntPtr.Zero)
					id_ctor_Landroid_view_LayoutInflater_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/LayoutInflater;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_LayoutInflater_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_LayoutInflater_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/constructor[@name='AbstractWheelCustomAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		protected unsafe AbstractWheelCustomAdapter (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AbstractWheelCustomAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/constructor[@name='AbstractWheelCustomAdapter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe AbstractWheelCustomAdapter (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AbstractWheelCustomAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getEmptyItemResource;
#pragma warning disable 0169
		static Delegate GetGetEmptyItemResourceHandler ()
		{
			if (cb_getEmptyItemResource == null)
				cb_getEmptyItemResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEmptyItemResource);
			return cb_getEmptyItemResource;
		}

		static int n_GetEmptyItemResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EmptyItemResource;
		}
#pragma warning restore 0169

		static Delegate cb_setEmptyItemResource_I;
#pragma warning disable 0169
		static Delegate GetSetEmptyItemResource_IHandler ()
		{
			if (cb_setEmptyItemResource_I == null)
				cb_setEmptyItemResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEmptyItemResource_I);
			return cb_setEmptyItemResource_I;
		}

		static void n_SetEmptyItemResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmptyItemResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmptyItemResource;
		static IntPtr id_setEmptyItemResource_I;
		public virtual unsafe int EmptyItemResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='getEmptyItemResource' and count(parameter)=0]"
			[Register ("getEmptyItemResource", "()I", "GetGetEmptyItemResourceHandler")]
			get {
				if (id_getEmptyItemResource == IntPtr.Zero)
					id_getEmptyItemResource = JNIEnv.GetMethodID (class_ref, "getEmptyItemResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEmptyItemResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmptyItemResource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='setEmptyItemResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEmptyItemResource", "(I)V", "GetSetEmptyItemResource_IHandler")]
			set {
				if (id_setEmptyItemResource_I == IntPtr.Zero)
					id_setEmptyItemResource_I = JNIEnv.GetMethodID (class_ref, "setEmptyItemResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmptyItemResource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmptyItemResource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemResource;
#pragma warning disable 0169
		static Delegate GetGetItemResourceHandler ()
		{
			if (cb_getItemResource == null)
				cb_getItemResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemResource);
			return cb_getItemResource;
		}

		static int n_GetItemResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemResource;
		}
#pragma warning restore 0169

		static Delegate cb_setItemResource_I;
#pragma warning disable 0169
		static Delegate GetSetItemResource_IHandler ()
		{
			if (cb_setItemResource_I == null)
				cb_setItemResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemResource_I);
			return cb_setItemResource_I;
		}

		static void n_SetItemResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemResource;
		static IntPtr id_setItemResource_I;
		public virtual unsafe int ItemResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='getItemResource' and count(parameter)=0]"
			[Register ("getItemResource", "()I", "GetGetItemResourceHandler")]
			get {
				if (id_getItemResource == IntPtr.Zero)
					id_getItemResource = JNIEnv.GetMethodID (class_ref, "getItemResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemResource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='setItemResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemResource", "(I)V", "GetSetItemResource_IHandler")]
			set {
				if (id_setItemResource_I == IntPtr.Zero)
					id_setItemResource_I = JNIEnv.GetMethodID (class_ref, "setItemResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemResource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemResource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_configureItemView_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetConfigureItemView_Landroid_view_View_IHandler ()
		{
			if (cb_configureItemView_Landroid_view_View_I == null)
				cb_configureItemView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ConfigureItemView_Landroid_view_View_I);
			return cb_configureItemView_Landroid_view_View_I;
		}

		static void n_ConfigureItemView_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureItemView (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='configureItemView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("configureItemView", "(Landroid/view/View;I)V", "GetConfigureItemView_Landroid_view_View_IHandler")]
		protected abstract void ConfigureItemView (global::Android.Views.View p0, int p1);

		static Delegate cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetGetItem_ILandroid_view_View_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I == null)
				cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr>) n_GetItem_ILandroid_view_View_Landroid_view_ViewGroup_I);
			return cb_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_GetItem_ILandroid_view_View_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelCustomAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetItem (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='getItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup'] and parameter[4][@type='int']]"
		[Register ("getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;", "GetGetItem_ILandroid_view_View_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::Android.Views.View GetItem (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2, int p3)
		{
			if (id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(ILandroid/view/View;Landroid/view/ViewGroup;I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/AbstractWheelCustomAdapter", DoNotGenerateAcw=true)]
	internal partial class AbstractWheelCustomAdapterInvoker : AbstractWheelCustomAdapter {

		public AbstractWheelCustomAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelCustomAdapterInvoker); }
		}

		static IntPtr id_configureItemView_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelCustomAdapter']/method[@name='configureItemView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("configureItemView", "(Landroid/view/View;I)V", "GetConfigureItemView_Landroid_view_View_IHandler")]
		protected override unsafe void ConfigureItemView (global::Android.Views.View p0, int p1)
		{
			if (id_configureItemView_Landroid_view_View_I == IntPtr.Zero)
				id_configureItemView_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "configureItemView", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configureItemView_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_getItemsCount;
		public override unsafe int ItemsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelAdapter']/method[@name='getItemsCount' and count(parameter)=0]"
			[Register ("getItemsCount", "()I", "GetGetItemsCountHandler")]
			get {
				if (id_getItemsCount == IntPtr.Zero)
					id_getItemsCount = JNIEnv.GetMethodID (class_ref, "getItemsCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemsCount);
				} finally {
				}
			}
		}

	}

}
