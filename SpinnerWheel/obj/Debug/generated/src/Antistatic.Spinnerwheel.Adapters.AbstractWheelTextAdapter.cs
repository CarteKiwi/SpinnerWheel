using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/AbstractWheelTextAdapter", DoNotGenerateAcw=true)]
	public abstract partial class AbstractWheelTextAdapter : global::Antistatic.Spinnerwheel.Adapters.AbstractWheelAdapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='DEFAULT_TEXT_COLOR']"
		[Register ("DEFAULT_TEXT_COLOR")]
		public const int DefaultTextColor = (int) -15724528;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='DEFAULT_TEXT_SIZE']"
		[Register ("DEFAULT_TEXT_SIZE")]
		public const int DefaultTextSize = (int) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='LABEL_COLOR']"
		[Register ("LABEL_COLOR")]
		public const int LabelColor = (int) -9437072;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='NO_RESOURCE']"
		[Register ("NO_RESOURCE")]
		protected const int NoResource = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='TEXT_VIEW_ITEM_RESOURCE']"
		[Register ("TEXT_VIEW_ITEM_RESOURCE")]
		public const int TextViewItemResource = (int) -1;

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='context']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='emptyItemResourceId']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='inflater']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='itemResourceId']"
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

		static IntPtr itemTextResourceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/field[@name='itemTextResourceId']"
		[Register ("itemTextResourceId")]
		protected int ItemTextResourceId {
			get {
				if (itemTextResourceId_jfieldId == IntPtr.Zero)
					itemTextResourceId_jfieldId = JNIEnv.GetFieldID (class_ref, "itemTextResourceId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, itemTextResourceId_jfieldId);
			}
			set {
				if (itemTextResourceId_jfieldId == IntPtr.Zero)
					itemTextResourceId_jfieldId = JNIEnv.GetFieldID (class_ref, "itemTextResourceId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, itemTextResourceId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/adapters/AbstractWheelTextAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelTextAdapter); }
		}

		protected AbstractWheelTextAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/constructor[@name='AbstractWheelTextAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		protected unsafe AbstractWheelTextAdapter (global::Android.Content.Context p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AbstractWheelTextAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/constructor[@name='AbstractWheelTextAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		protected unsafe AbstractWheelTextAdapter (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AbstractWheelTextAdapter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/constructor[@name='AbstractWheelTextAdapter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe AbstractWheelTextAdapter (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AbstractWheelTextAdapter)) {
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

		static Delegate cb_getDefaultTextStyle;
#pragma warning disable 0169
		static Delegate GetGetDefaultTextStyleHandler ()
		{
			if (cb_getDefaultTextStyle == null)
				cb_getDefaultTextStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultTextStyle);
			return cb_getDefaultTextStyle;
		}

		static int n_GetDefaultTextStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultTextStyle;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultTextStyle;
		protected virtual unsafe int DefaultTextStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getDefaultTextStyle' and count(parameter)=0]"
			[Register ("getDefaultTextStyle", "()I", "GetGetDefaultTextStyleHandler")]
			get {
				if (id_getDefaultTextStyle == IntPtr.Zero)
					id_getDefaultTextStyle = JNIEnv.GetMethodID (class_ref, "getDefaultTextStyle", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultTextStyle);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultTextStyle", "()I"));
				} finally {
				}
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
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmptyItemResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmptyItemResource;
		static IntPtr id_setEmptyItemResource_I;
		public virtual unsafe int EmptyItemResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getEmptyItemResource' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='setEmptyItemResource' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemResource;
		static IntPtr id_setItemResource_I;
		public virtual unsafe int ItemResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getItemResource' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='setItemResource' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getItemTextResource;
#pragma warning disable 0169
		static Delegate GetGetItemTextResourceHandler ()
		{
			if (cb_getItemTextResource == null)
				cb_getItemTextResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemTextResource);
			return cb_getItemTextResource;
		}

		static int n_GetItemTextResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemTextResource;
		}
#pragma warning restore 0169

		static Delegate cb_setItemTextResource_I;
#pragma warning disable 0169
		static Delegate GetSetItemTextResource_IHandler ()
		{
			if (cb_setItemTextResource_I == null)
				cb_setItemTextResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemTextResource_I);
			return cb_setItemTextResource_I;
		}

		static void n_SetItemTextResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextResource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemTextResource;
		static IntPtr id_setItemTextResource_I;
		public virtual unsafe int ItemTextResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getItemTextResource' and count(parameter)=0]"
			[Register ("getItemTextResource", "()I", "GetGetItemTextResourceHandler")]
			get {
				if (id_getItemTextResource == IntPtr.Zero)
					id_getItemTextResource = JNIEnv.GetMethodID (class_ref, "getItemTextResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemTextResource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='setItemTextResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextResource", "(I)V", "GetSetItemTextResource_IHandler")]
			set {
				if (id_setItemTextResource_I == IntPtr.Zero)
					id_setItemTextResource_I = JNIEnv.GetMethodID (class_ref, "setItemTextResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextResource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemTextResource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextColor);
			return cb_getTextColor;
		}

		static int n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		static IntPtr id_setTextColor_I;
		public virtual unsafe int TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()I", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
			set {
				if (id_setTextColor_I == IntPtr.Zero)
					id_setTextColor_I = JNIEnv.GetMethodID (class_ref, "setTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextSize);
			return cb_getTextSize;
		}

		static int n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSize_I;
#pragma warning disable 0169
		static Delegate GetSetTextSize_IHandler ()
		{
			if (cb_setTextSize_I == null)
				cb_setTextSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextSize_I);
			return cb_setTextSize_I;
		}

		static void n_SetTextSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextSize;
		static IntPtr id_setTextSize_I;
		public virtual unsafe int TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()I", "GetGetTextSizeHandler")]
			get {
				if (id_getTextSize == IntPtr.Zero)
					id_getTextSize = JNIEnv.GetMethodID (class_ref, "getTextSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTextSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextSize", "(I)V", "GetSetTextSize_IHandler")]
			set {
				if (id_setTextSize_I == IntPtr.Zero)
					id_setTextSize_I = JNIEnv.GetMethodID (class_ref, "setTextSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_configureTextView_Landroid_widget_TextView_Z;
#pragma warning disable 0169
		static Delegate GetConfigureTextView_Landroid_widget_TextView_ZHandler ()
		{
			if (cb_configureTextView_Landroid_widget_TextView_Z == null)
				cb_configureTextView_Landroid_widget_TextView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ConfigureTextView_Landroid_widget_TextView_Z);
			return cb_configureTextView_Landroid_widget_TextView_Z;
		}

		static void n_ConfigureTextView_Landroid_widget_TextView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureTextView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_configureTextView_Landroid_widget_TextView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='configureTextView' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='boolean']]"
		[Register ("configureTextView", "(Landroid/widget/TextView;Z)V", "GetConfigureTextView_Landroid_widget_TextView_ZHandler")]
		protected virtual unsafe void ConfigureTextView (global::Android.Widget.TextView p0, bool p1)
		{
			if (id_configureTextView_Landroid_widget_TextView_Z == IntPtr.Zero)
				id_configureTextView_Landroid_widget_TextView_Z = JNIEnv.GetMethodID (class_ref, "configureTextView", "(Landroid/widget/TextView;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configureTextView_Landroid_widget_TextView_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureTextView", "(Landroid/widget/TextView;Z)V"), __args);
			} finally {
			}
		}

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
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetItem (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getItem_ILandroid_view_View_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup'] and parameter[4][@type='int']]"
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

		static Delegate cb_getItemText_I;
#pragma warning disable 0169
		static Delegate GetGetItemText_IHandler ()
		{
			if (cb_getItemText_I == null)
				cb_getItemText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItemText_I);
			return cb_getItemText_I;
		}

		static IntPtr n_GetItemText_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.GetItemTextFormatted (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getItemText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemText", "(I)Ljava/lang/CharSequence;", "GetGetItemText_IHandler")]
		public abstract global::Java.Lang.ICharSequence GetItemTextFormatted (int p0);

		public string GetItemText (int p0)
		{
			global::Java.Lang.ICharSequence __result = GetItemTextFormatted (p0);
			return __result == null ? null : __result.ToString ();
		}

		static Delegate cb_onConfigureTextView_Landroid_widget_TextView_Z;
#pragma warning disable 0169
		static Delegate GetOnConfigureTextView_Landroid_widget_TextView_ZHandler ()
		{
			if (cb_onConfigureTextView_Landroid_widget_TextView_Z == null)
				cb_onConfigureTextView_Landroid_widget_TextView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnConfigureTextView_Landroid_widget_TextView_Z);
			return cb_onConfigureTextView_Landroid_widget_TextView_Z;
		}

		static void n_OnConfigureTextView_Landroid_widget_TextView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigureTextView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onConfigureTextView_Landroid_widget_TextView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='onConfigureTextView' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='boolean']]"
		[Register ("onConfigureTextView", "(Landroid/widget/TextView;Z)V", "GetOnConfigureTextView_Landroid_widget_TextView_ZHandler")]
		protected virtual unsafe void OnConfigureTextView (global::Android.Widget.TextView p0, bool p1)
		{
			if (id_onConfigureTextView_Landroid_widget_TextView_Z == IntPtr.Zero)
				id_onConfigureTextView_Landroid_widget_TextView_Z = JNIEnv.GetMethodID (class_ref, "onConfigureTextView", "(Landroid/widget/TextView;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfigureTextView_Landroid_widget_TextView_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConfigureTextView", "(Landroid/widget/TextView;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTextTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTextTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTextTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTextTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextTypeface_Landroid_graphics_Typeface_);
			return cb_setTextTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTextTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.AbstractWheelTextAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTextTypeface (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTextTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='setTextTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setTextTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTextTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetTextTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_setTextTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_setTextTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTextTypeface", "(Landroid/graphics/Typeface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextTypeface_Landroid_graphics_Typeface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextTypeface", "(Landroid/graphics/Typeface;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/adapters/AbstractWheelTextAdapter", DoNotGenerateAcw=true)]
	internal partial class AbstractWheelTextAdapterInvoker : AbstractWheelTextAdapter {

		public AbstractWheelTextAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelTextAdapterInvoker); }
		}

		static IntPtr id_getItemText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel.adapters']/class[@name='AbstractWheelTextAdapter']/method[@name='getItemText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemText", "(I)Ljava/lang/CharSequence;", "GetGetItemText_IHandler")]
		public override unsafe global::Java.Lang.ICharSequence GetItemTextFormatted (int p0)
		{
			if (id_getItemText_I == IntPtr.Zero)
				id_getItemText_I = JNIEnv.GetMethodID (class_ref, "getItemText", "(I)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItemText_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string GetItemText (int p0)
		{
			global::Java.Lang.ICharSequence __result = GetItemTextFormatted (p0);
			return __result == null ? null : __result.ToString ();
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
