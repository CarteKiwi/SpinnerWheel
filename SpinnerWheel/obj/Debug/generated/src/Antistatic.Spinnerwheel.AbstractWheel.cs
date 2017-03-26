using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Antistatic.Spinnerwheel {

	// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']"
	[global::Android.Runtime.Register ("antistatic/spinnerwheel/AbstractWheel", DoNotGenerateAcw=true)]
	public abstract partial class AbstractWheel : global::Android.Views.View {


		static IntPtr mCurrentItemIdx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mCurrentItemIdx']"
		[Register ("mCurrentItemIdx")]
		protected int MCurrentItemIdx {
			get {
				if (mCurrentItemIdx_jfieldId == IntPtr.Zero)
					mCurrentItemIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentItemIdx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCurrentItemIdx_jfieldId);
			}
			set {
				if (mCurrentItemIdx_jfieldId == IntPtr.Zero)
					mCurrentItemIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentItemIdx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCurrentItemIdx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFirstItemIdx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mFirstItemIdx']"
		[Register ("mFirstItemIdx")]
		protected int MFirstItemIdx {
			get {
				if (mFirstItemIdx_jfieldId == IntPtr.Zero)
					mFirstItemIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "mFirstItemIdx", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFirstItemIdx_jfieldId);
			}
			set {
				if (mFirstItemIdx_jfieldId == IntPtr.Zero)
					mFirstItemIdx_jfieldId = JNIEnv.GetFieldID (class_ref, "mFirstItemIdx", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFirstItemIdx_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mIsAllVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mIsAllVisible']"
		[Register ("mIsAllVisible")]
		protected bool MIsAllVisible {
			get {
				if (mIsAllVisible_jfieldId == IntPtr.Zero)
					mIsAllVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsAllVisible", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsAllVisible_jfieldId);
			}
			set {
				if (mIsAllVisible_jfieldId == IntPtr.Zero)
					mIsAllVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsAllVisible", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsAllVisible_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mIsCyclic_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mIsCyclic']"
		[Register ("mIsCyclic")]
		protected bool MIsCyclic {
			get {
				if (mIsCyclic_jfieldId == IntPtr.Zero)
					mIsCyclic_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsCyclic", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsCyclic_jfieldId);
			}
			set {
				if (mIsCyclic_jfieldId == IntPtr.Zero)
					mIsCyclic_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsCyclic", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsCyclic_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mIsScrollingPerformed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mIsScrollingPerformed']"
		[Register ("mIsScrollingPerformed")]
		protected bool MIsScrollingPerformed {
			get {
				if (mIsScrollingPerformed_jfieldId == IntPtr.Zero)
					mIsScrollingPerformed_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsScrollingPerformed", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsScrollingPerformed_jfieldId);
			}
			set {
				if (mIsScrollingPerformed_jfieldId == IntPtr.Zero)
					mIsScrollingPerformed_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsScrollingPerformed", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsScrollingPerformed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mItemsLayout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mItemsLayout']"
		[Register ("mItemsLayout")]
		protected global::Android.Widget.LinearLayout MItemsLayout {
			get {
				if (mItemsLayout_jfieldId == IntPtr.Zero)
					mItemsLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemsLayout", "Landroid/widget/LinearLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mItemsLayout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItemsLayout_jfieldId == IntPtr.Zero)
					mItemsLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemsLayout", "Landroid/widget/LinearLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mItemsLayout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLastTempDirection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mLastTempDirection']"
		[Register ("mLastTempDirection")]
		public int MLastTempDirection {
			get {
				if (mLastTempDirection_jfieldId == IntPtr.Zero)
					mLastTempDirection_jfieldId = JNIEnv.GetFieldID (class_ref, "mLastTempDirection", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mLastTempDirection_jfieldId);
			}
			set {
				if (mLastTempDirection_jfieldId == IntPtr.Zero)
					mLastTempDirection_jfieldId = JNIEnv.GetFieldID (class_ref, "mLastTempDirection", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLastTempDirection_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLayoutHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mLayoutHeight']"
		[Register ("mLayoutHeight")]
		protected int MLayoutHeight {
			get {
				if (mLayoutHeight_jfieldId == IntPtr.Zero)
					mLayoutHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mLayoutHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mLayoutHeight_jfieldId);
			}
			set {
				if (mLayoutHeight_jfieldId == IntPtr.Zero)
					mLayoutHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mLayoutHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLayoutHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLayoutWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mLayoutWidth']"
		[Register ("mLayoutWidth")]
		protected int MLayoutWidth {
			get {
				if (mLayoutWidth_jfieldId == IntPtr.Zero)
					mLayoutWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mLayoutWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mLayoutWidth_jfieldId);
			}
			set {
				if (mLayoutWidth_jfieldId == IntPtr.Zero)
					mLayoutWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mLayoutWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLayoutWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mScroller_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mScroller']"
		[Register ("mScroller")]
		protected global::Antistatic.Spinnerwheel.WheelScroller MScroller {
			get {
				if (mScroller_jfieldId == IntPtr.Zero)
					mScroller_jfieldId = JNIEnv.GetFieldID (class_ref, "mScroller", "Lantistatic/spinnerwheel/WheelScroller;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mScroller_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mScroller_jfieldId == IntPtr.Zero)
					mScroller_jfieldId = JNIEnv.GetFieldID (class_ref, "mScroller", "Lantistatic/spinnerwheel/WheelScroller;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mScroller_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mScrollingOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mScrollingOffset']"
		[Register ("mScrollingOffset")]
		protected int MScrollingOffset {
			get {
				if (mScrollingOffset_jfieldId == IntPtr.Zero)
					mScrollingOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollingOffset", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mScrollingOffset_jfieldId);
			}
			set {
				if (mScrollingOffset_jfieldId == IntPtr.Zero)
					mScrollingOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollingOffset", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mScrollingOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mViewAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mViewAdapter']"
		[Register ("mViewAdapter")]
		protected global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter MViewAdapter {
			get {
				if (mViewAdapter_jfieldId == IntPtr.Zero)
					mViewAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mViewAdapter", "Lantistatic/spinnerwheel/adapters/WheelViewAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mViewAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mViewAdapter_jfieldId == IntPtr.Zero)
					mViewAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mViewAdapter", "Lantistatic/spinnerwheel/adapters/WheelViewAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mViewAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mVisibleItems_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/field[@name='mVisibleItems']"
		[Register ("mVisibleItems")]
		protected int MVisibleItems {
			get {
				if (mVisibleItems_jfieldId == IntPtr.Zero)
					mVisibleItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mVisibleItems", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mVisibleItems_jfieldId);
			}
			set {
				if (mVisibleItems_jfieldId == IntPtr.Zero)
					mVisibleItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mVisibleItems", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mVisibleItems_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel.SavedState']"
		[global::Android.Runtime.Register ("antistatic/spinnerwheel/AbstractWheel$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("antistatic/spinnerwheel/AbstractWheel$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("antistatic/spinnerwheel/AbstractWheel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheel); }
		}

		protected AbstractWheel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/constructor[@name='AbstractWheel' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AbstractWheel (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AbstractWheel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_getBaseDimension;
#pragma warning disable 0169
		static Delegate GetGetBaseDimensionHandler ()
		{
			if (cb_getBaseDimension == null)
				cb_getBaseDimension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBaseDimension);
			return cb_getBaseDimension;
		}

		static int n_GetBaseDimension (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BaseDimension;
		}
#pragma warning restore 0169

		protected abstract int BaseDimension {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getBaseDimension' and count(parameter)=0]"
			[Register ("getBaseDimension", "()I", "GetGetBaseDimensionHandler")] get;
		}

		static Delegate cb_getCurrentItem;
#pragma warning disable 0169
		static Delegate GetGetCurrentItemHandler ()
		{
			if (cb_getCurrentItem == null)
				cb_getCurrentItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentItem);
			return cb_getCurrentItem;
		}

		static int n_GetCurrentItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentItem;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentItem_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentItem_IHandler ()
		{
			if (cb_setCurrentItem_I == null)
				cb_setCurrentItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentItem_I);
			return cb_setCurrentItem_I;
		}

		static void n_SetCurrentItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentItem = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentItem;
		static IntPtr id_setCurrentItem_I;
		public virtual unsafe int CurrentItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getCurrentItem' and count(parameter)=0]"
			[Register ("getCurrentItem", "()I", "GetGetCurrentItemHandler")]
			get {
				if (id_getCurrentItem == IntPtr.Zero)
					id_getCurrentItem = JNIEnv.GetMethodID (class_ref, "getCurrentItem", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentItem);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentItem", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler")]
			set {
				if (id_setCurrentItem_I == IntPtr.Zero)
					id_setCurrentItem_I = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentItem_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentItem", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCyclic;
#pragma warning disable 0169
		static Delegate GetIsCyclicHandler ()
		{
			if (cb_isCyclic == null)
				cb_isCyclic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCyclic);
			return cb_isCyclic;
		}

		static bool n_IsCyclic (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cyclic;
		}
#pragma warning restore 0169

		static Delegate cb_setCyclic_Z;
#pragma warning disable 0169
		static Delegate GetSetCyclic_ZHandler ()
		{
			if (cb_setCyclic_Z == null)
				cb_setCyclic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCyclic_Z);
			return cb_setCyclic_Z;
		}

		static void n_SetCyclic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cyclic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCyclic;
		static IntPtr id_setCyclic_Z;
		public virtual unsafe bool Cyclic {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='isCyclic' and count(parameter)=0]"
			[Register ("isCyclic", "()Z", "GetIsCyclicHandler")]
			get {
				if (id_isCyclic == IntPtr.Zero)
					id_isCyclic = JNIEnv.GetMethodID (class_ref, "isCyclic", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCyclic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCyclic", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCyclic", "(Z)V", "GetSetCyclic_ZHandler")]
			set {
				if (id_setCyclic_Z == IntPtr.Zero)
					id_setCyclic_Z = JNIEnv.GetMethodID (class_ref, "setCyclic", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCyclic_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCyclic", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemDimension;
#pragma warning disable 0169
		static Delegate GetGetItemDimensionHandler ()
		{
			if (cb_getItemDimension == null)
				cb_getItemDimension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemDimension);
			return cb_getItemDimension;
		}

		static int n_GetItemDimension (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemDimension;
		}
#pragma warning restore 0169

		protected abstract int ItemDimension {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getItemDimension' and count(parameter)=0]"
			[Register ("getItemDimension", "()I", "GetGetItemDimensionHandler")] get;
		}

		static Delegate cb_getMaxOverScrollDimension;
#pragma warning disable 0169
		static Delegate GetGetMaxOverScrollDimensionHandler ()
		{
			if (cb_getMaxOverScrollDimension == null)
				cb_getMaxOverScrollDimension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxOverScrollDimension);
			return cb_getMaxOverScrollDimension;
		}

		static int n_GetMaxOverScrollDimension (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxOverScrollDimension;
		}
#pragma warning restore 0169

		protected abstract int MaxOverScrollDimension {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getMaxOverScrollDimension' and count(parameter)=0]"
			[Register ("getMaxOverScrollDimension", "()I", "GetGetMaxOverScrollDimensionHandler")] get;
		}

		static Delegate cb_getViewAdapter;
#pragma warning disable 0169
		static Delegate GetGetViewAdapterHandler ()
		{
			if (cb_getViewAdapter == null)
				cb_getViewAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewAdapter);
			return cb_getViewAdapter;
		}

		static IntPtr n_GetViewAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewAdapter);
		}
#pragma warning restore 0169

		static Delegate cb_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_;
#pragma warning disable 0169
		static Delegate GetSetViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_Handler ()
		{
			if (cb_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_ == null)
				cb_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_);
			return cb_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_;
		}

		static void n_SetViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter p0 = (global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ViewAdapter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getViewAdapter;
		static IntPtr id_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_;
		public virtual unsafe global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter ViewAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getViewAdapter' and count(parameter)=0]"
			[Register ("getViewAdapter", "()Lantistatic/spinnerwheel/adapters/WheelViewAdapter;", "GetGetViewAdapterHandler")]
			get {
				if (id_getViewAdapter == IntPtr.Zero)
					id_getViewAdapter = JNIEnv.GetMethodID (class_ref, "getViewAdapter", "()Lantistatic/spinnerwheel/adapters/WheelViewAdapter;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.Adapters.IWheelViewAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewAdapter", "()Lantistatic/spinnerwheel/adapters/WheelViewAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setViewAdapter' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.adapters.WheelViewAdapter']]"
			[Register ("setViewAdapter", "(Lantistatic/spinnerwheel/adapters/WheelViewAdapter;)V", "GetSetViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_Handler")]
			set {
				if (id_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_ == IntPtr.Zero)
					id_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_ = JNIEnv.GetMethodID (class_ref, "setViewAdapter", "(Lantistatic/spinnerwheel/adapters/WheelViewAdapter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewAdapter_Lantistatic_spinnerwheel_adapters_WheelViewAdapter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewAdapter", "(Lantistatic/spinnerwheel/adapters/WheelViewAdapter;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisibleItems;
#pragma warning disable 0169
		static Delegate GetGetVisibleItemsHandler ()
		{
			if (cb_getVisibleItems == null)
				cb_getVisibleItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVisibleItems);
			return cb_getVisibleItems;
		}

		static int n_GetVisibleItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VisibleItems;
		}
#pragma warning restore 0169

		static Delegate cb_setVisibleItems_I;
#pragma warning disable 0169
		static Delegate GetSetVisibleItems_IHandler ()
		{
			if (cb_setVisibleItems_I == null)
				cb_setVisibleItems_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVisibleItems_I);
			return cb_setVisibleItems_I;
		}

		static void n_SetVisibleItems_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VisibleItems = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleItems;
		static IntPtr id_setVisibleItems_I;
		public virtual unsafe int VisibleItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getVisibleItems' and count(parameter)=0]"
			[Register ("getVisibleItems", "()I", "GetGetVisibleItemsHandler")]
			get {
				if (id_getVisibleItems == IntPtr.Zero)
					id_getVisibleItems = JNIEnv.GetMethodID (class_ref, "getVisibleItems", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVisibleItems);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisibleItems", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setVisibleItems' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVisibleItems", "(I)V", "GetSetVisibleItems_IHandler")]
			set {
				if (id_setVisibleItems_I == IntPtr.Zero)
					id_setVisibleItems_I = JNIEnv.GetMethodID (class_ref, "setVisibleItems", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisibleItems_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisibleItems", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_Handler ()
		{
			if (cb_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ == null)
				cb_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_);
			return cb_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_;
		}

		static void n_AddChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.IOnWheelChangedListener p0 = (global::Antistatic.Spinnerwheel.IOnWheelChangedListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChangingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='addChangingListener' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.OnWheelChangedListener']]"
		[Register ("addChangingListener", "(Lantistatic/spinnerwheel/OnWheelChangedListener;)V", "GetAddChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_Handler")]
		public virtual unsafe void AddChangingListener (global::Antistatic.Spinnerwheel.IOnWheelChangedListener p0)
		{
			if (id_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ == IntPtr.Zero)
				id_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ = JNIEnv.GetMethodID (class_ref, "addChangingListener", "(Lantistatic/spinnerwheel/OnWheelChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChangingListener", "(Lantistatic/spinnerwheel/OnWheelChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_;
#pragma warning disable 0169
		static Delegate GetAddClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_Handler ()
		{
			if (cb_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ == null)
				cb_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_);
			return cb_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_;
		}

		static void n_AddClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.IOnWheelClickedListener p0 = (global::Antistatic.Spinnerwheel.IOnWheelClickedListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelClickedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddClickingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='addClickingListener' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.OnWheelClickedListener']]"
		[Register ("addClickingListener", "(Lantistatic/spinnerwheel/OnWheelClickedListener;)V", "GetAddClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_Handler")]
		public virtual unsafe void AddClickingListener (global::Antistatic.Spinnerwheel.IOnWheelClickedListener p0)
		{
			if (id_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ == IntPtr.Zero)
				id_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ = JNIEnv.GetMethodID (class_ref, "addClickingListener", "(Lantistatic/spinnerwheel/OnWheelClickedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addClickingListener", "(Lantistatic/spinnerwheel/OnWheelClickedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_;
#pragma warning disable 0169
		static Delegate GetAddScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_Handler ()
		{
			if (cb_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ == null)
				cb_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_);
			return cb_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_;
		}

		static void n_AddScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.IOnWheelScrollListener p0 = (global::Antistatic.Spinnerwheel.IOnWheelScrollListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelScrollListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddScrollingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='addScrollingListener' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.OnWheelScrollListener']]"
		[Register ("addScrollingListener", "(Lantistatic/spinnerwheel/OnWheelScrollListener;)V", "GetAddScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_Handler")]
		public virtual unsafe void AddScrollingListener (global::Antistatic.Spinnerwheel.IOnWheelScrollListener p0)
		{
			if (id_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ == IntPtr.Zero)
				id_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ = JNIEnv.GetMethodID (class_ref, "addScrollingListener", "(Lantistatic/spinnerwheel/OnWheelScrollListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addScrollingListener", "(Lantistatic/spinnerwheel/OnWheelScrollListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createItemsLayout;
#pragma warning disable 0169
		static Delegate GetCreateItemsLayoutHandler ()
		{
			if (cb_createItemsLayout == null)
				cb_createItemsLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateItemsLayout);
			return cb_createItemsLayout;
		}

		static void n_CreateItemsLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateItemsLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='createItemsLayout' and count(parameter)=0]"
		[Register ("createItemsLayout", "()V", "GetCreateItemsLayoutHandler")]
		protected abstract void CreateItemsLayout ();

		static Delegate cb_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_;
#pragma warning disable 0169
		static Delegate GetCreateScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_Handler ()
		{
			if (cb_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ == null)
				cb_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_);
			return cb_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_;
		}

		static IntPtr n_CreateScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener p0 = (global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateScroller (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='createScroller' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.WheelScroller.ScrollingListener']]"
		[Register ("createScroller", "(Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)Lantistatic/spinnerwheel/WheelScroller;", "GetCreateScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_Handler")]
		protected abstract global::Antistatic.Spinnerwheel.WheelScroller CreateScroller (global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener p0);

		static Delegate cb_doItemsLayout;
#pragma warning disable 0169
		static Delegate GetDoItemsLayoutHandler ()
		{
			if (cb_doItemsLayout == null)
				cb_doItemsLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoItemsLayout);
			return cb_doItemsLayout;
		}

		static void n_DoItemsLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoItemsLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='doItemsLayout' and count(parameter)=0]"
		[Register ("doItemsLayout", "()V", "GetDoItemsLayoutHandler")]
		protected abstract void DoItemsLayout ();

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
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetMotionEventPosition (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getMotionEventPosition' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("getMotionEventPosition", "(Landroid/view/MotionEvent;)F", "GetGetMotionEventPosition_Landroid_view_MotionEvent_Handler")]
		protected abstract float GetMotionEventPosition (global::Android.Views.MotionEvent p0);

		static Delegate cb_initAttributes_Landroid_util_AttributeSet_I;
#pragma warning disable 0169
		static Delegate GetInitAttributes_Landroid_util_AttributeSet_IHandler ()
		{
			if (cb_initAttributes_Landroid_util_AttributeSet_I == null)
				cb_initAttributes_Landroid_util_AttributeSet_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_InitAttributes_Landroid_util_AttributeSet_I);
			return cb_initAttributes_Landroid_util_AttributeSet_I;
		}

		static void n_InitAttributes_Landroid_util_AttributeSet_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet p0 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitAttributes (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initAttributes_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='initAttributes' and count(parameter)=2 and parameter[1][@type='android.util.AttributeSet'] and parameter[2][@type='int']]"
		[Register ("initAttributes", "(Landroid/util/AttributeSet;I)V", "GetInitAttributes_Landroid_util_AttributeSet_IHandler")]
		protected virtual unsafe void InitAttributes (global::Android.Util.IAttributeSet p0, int p1)
		{
			if (id_initAttributes_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_initAttributes_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "initAttributes", "(Landroid/util/AttributeSet;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initAttributes_Landroid_util_AttributeSet_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initAttributes", "(Landroid/util/AttributeSet;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initData_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitData_Landroid_content_Context_Handler ()
		{
			if (cb_initData_Landroid_content_Context_ == null)
				cb_initData_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitData_Landroid_content_Context_);
			return cb_initData_Landroid_content_Context_;
		}

		static void n_InitData_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initData_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='initData' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initData", "(Landroid/content/Context;)V", "GetInitData_Landroid_content_Context_Handler")]
		protected virtual unsafe void InitData (global::Android.Content.Context p0)
		{
			if (id_initData_Landroid_content_Context_ == IntPtr.Zero)
				id_initData_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "initData", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initData_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initData", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_invalidateItemsLayout_Z;
#pragma warning disable 0169
		static Delegate GetInvalidateItemsLayout_ZHandler ()
		{
			if (cb_invalidateItemsLayout_Z == null)
				cb_invalidateItemsLayout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_InvalidateItemsLayout_Z);
			return cb_invalidateItemsLayout_Z;
		}

		static void n_InvalidateItemsLayout_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateItemsLayout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_invalidateItemsLayout_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='invalidateItemsLayout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("invalidateItemsLayout", "(Z)V", "GetInvalidateItemsLayout_ZHandler")]
		public virtual unsafe void InvalidateItemsLayout (bool p0)
		{
			if (id_invalidateItemsLayout_Z == IntPtr.Zero)
				id_invalidateItemsLayout_Z = JNIEnv.GetMethodID (class_ref, "invalidateItemsLayout", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invalidateItemsLayout_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateItemsLayout", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isValidItemIndex_I;
#pragma warning disable 0169
		static Delegate GetIsValidItemIndex_IHandler ()
		{
			if (cb_isValidItemIndex_I == null)
				cb_isValidItemIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsValidItemIndex_I);
			return cb_isValidItemIndex_I;
		}

		static bool n_IsValidItemIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValidItemIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isValidItemIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='isValidItemIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isValidItemIndex", "(I)Z", "GetIsValidItemIndex_IHandler")]
		protected virtual unsafe bool IsValidItemIndex (int p0)
		{
			if (id_isValidItemIndex_I == IntPtr.Zero)
				id_isValidItemIndex_I = JNIEnv.GetMethodID (class_ref, "isValidItemIndex", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValidItemIndex_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValidItemIndex", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyChangingListeners_II;
#pragma warning disable 0169
		static Delegate GetNotifyChangingListeners_IIHandler ()
		{
			if (cb_notifyChangingListeners_II == null)
				cb_notifyChangingListeners_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_NotifyChangingListeners_II);
			return cb_notifyChangingListeners_II;
		}

		static void n_NotifyChangingListeners_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyChangingListeners (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_notifyChangingListeners_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='notifyChangingListeners' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notifyChangingListeners", "(II)V", "GetNotifyChangingListeners_IIHandler")]
		protected virtual unsafe void NotifyChangingListeners (int p0, int p1)
		{
			if (id_notifyChangingListeners_II == IntPtr.Zero)
				id_notifyChangingListeners_II = JNIEnv.GetMethodID (class_ref, "notifyChangingListeners", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyChangingListeners_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyChangingListeners", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyClickListenersAboutClick_I;
#pragma warning disable 0169
		static Delegate GetNotifyClickListenersAboutClick_IHandler ()
		{
			if (cb_notifyClickListenersAboutClick_I == null)
				cb_notifyClickListenersAboutClick_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_NotifyClickListenersAboutClick_I);
			return cb_notifyClickListenersAboutClick_I;
		}

		static void n_NotifyClickListenersAboutClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyClickListenersAboutClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyClickListenersAboutClick_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='notifyClickListenersAboutClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyClickListenersAboutClick", "(I)V", "GetNotifyClickListenersAboutClick_IHandler")]
		protected virtual unsafe void NotifyClickListenersAboutClick (int p0)
		{
			if (id_notifyClickListenersAboutClick_I == IntPtr.Zero)
				id_notifyClickListenersAboutClick_I = JNIEnv.GetMethodID (class_ref, "notifyClickListenersAboutClick", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyClickListenersAboutClick_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyClickListenersAboutClick", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyScrollingListenersAboutEnd;
#pragma warning disable 0169
		static Delegate GetNotifyScrollingListenersAboutEndHandler ()
		{
			if (cb_notifyScrollingListenersAboutEnd == null)
				cb_notifyScrollingListenersAboutEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyScrollingListenersAboutEnd);
			return cb_notifyScrollingListenersAboutEnd;
		}

		static void n_NotifyScrollingListenersAboutEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyScrollingListenersAboutEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyScrollingListenersAboutEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='notifyScrollingListenersAboutEnd' and count(parameter)=0]"
		[Register ("notifyScrollingListenersAboutEnd", "()V", "GetNotifyScrollingListenersAboutEndHandler")]
		protected virtual unsafe void NotifyScrollingListenersAboutEnd ()
		{
			if (id_notifyScrollingListenersAboutEnd == IntPtr.Zero)
				id_notifyScrollingListenersAboutEnd = JNIEnv.GetMethodID (class_ref, "notifyScrollingListenersAboutEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyScrollingListenersAboutEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyScrollingListenersAboutEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifyScrollingListenersAboutStart;
#pragma warning disable 0169
		static Delegate GetNotifyScrollingListenersAboutStartHandler ()
		{
			if (cb_notifyScrollingListenersAboutStart == null)
				cb_notifyScrollingListenersAboutStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyScrollingListenersAboutStart);
			return cb_notifyScrollingListenersAboutStart;
		}

		static void n_NotifyScrollingListenersAboutStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyScrollingListenersAboutStart ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyScrollingListenersAboutStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='notifyScrollingListenersAboutStart' and count(parameter)=0]"
		[Register ("notifyScrollingListenersAboutStart", "()V", "GetNotifyScrollingListenersAboutStartHandler")]
		protected virtual unsafe void NotifyScrollingListenersAboutStart ()
		{
			if (id_notifyScrollingListenersAboutStart == IntPtr.Zero)
				id_notifyScrollingListenersAboutStart = JNIEnv.GetMethodID (class_ref, "notifyScrollingListenersAboutStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyScrollingListenersAboutStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyScrollingListenersAboutStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		protected override unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		protected override unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onScrollFinished;
#pragma warning disable 0169
		static Delegate GetOnScrollFinishedHandler ()
		{
			if (cb_onScrollFinished == null)
				cb_onScrollFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnScrollFinished);
			return cb_onScrollFinished;
		}

		static void n_OnScrollFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_onScrollFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='onScrollFinished' and count(parameter)=0]"
		[Register ("onScrollFinished", "()V", "GetOnScrollFinishedHandler")]
		protected virtual unsafe void OnScrollFinished ()
		{
			if (id_onScrollFinished == IntPtr.Zero)
				id_onScrollFinished = JNIEnv.GetMethodID (class_ref, "onScrollFinished", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollFinished);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollFinished", "()V"));
			} finally {
			}
		}

		static Delegate cb_onScrollStarted;
#pragma warning disable 0169
		static Delegate GetOnScrollStartedHandler ()
		{
			if (cb_onScrollStarted == null)
				cb_onScrollStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnScrollStarted);
			return cb_onScrollStarted;
		}

		static void n_OnScrollStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_onScrollStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='onScrollStarted' and count(parameter)=0]"
		[Register ("onScrollStarted", "()V", "GetOnScrollStartedHandler")]
		protected virtual unsafe void OnScrollStarted ()
		{
			if (id_onScrollStarted == IntPtr.Zero)
				id_onScrollStarted = JNIEnv.GetMethodID (class_ref, "onScrollStarted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onScrollTouched;
#pragma warning disable 0169
		static Delegate GetOnScrollTouchedHandler ()
		{
			if (cb_onScrollTouched == null)
				cb_onScrollTouched = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnScrollTouched);
			return cb_onScrollTouched;
		}

		static void n_OnScrollTouched (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollTouched ();
		}
#pragma warning restore 0169

		static IntPtr id_onScrollTouched;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='onScrollTouched' and count(parameter)=0]"
		[Register ("onScrollTouched", "()V", "GetOnScrollTouchedHandler")]
		protected virtual unsafe void OnScrollTouched ()
		{
			if (id_onScrollTouched == IntPtr.Zero)
				id_onScrollTouched = JNIEnv.GetMethodID (class_ref, "onScrollTouched", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollTouched);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollTouched", "()V"));
			} finally {
			}
		}

		static Delegate cb_onScrollTouchedUp;
#pragma warning disable 0169
		static Delegate GetOnScrollTouchedUpHandler ()
		{
			if (cb_onScrollTouchedUp == null)
				cb_onScrollTouchedUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnScrollTouchedUp);
			return cb_onScrollTouchedUp;
		}

		static void n_OnScrollTouchedUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollTouchedUp ();
		}
#pragma warning restore 0169

		static IntPtr id_onScrollTouchedUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='onScrollTouchedUp' and count(parameter)=0]"
		[Register ("onScrollTouchedUp", "()V", "GetOnScrollTouchedUpHandler")]
		protected virtual unsafe void OnScrollTouchedUp ()
		{
			if (id_onScrollTouchedUp == IntPtr.Zero)
				id_onScrollTouchedUp = JNIEnv.GetMethodID (class_ref, "onScrollTouchedUp", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollTouchedUp);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollTouchedUp", "()V"));
			} finally {
			}
		}

		static Delegate cb_rebuildItems;
#pragma warning disable 0169
		static Delegate GetRebuildItemsHandler ()
		{
			if (cb_rebuildItems == null)
				cb_rebuildItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RebuildItems);
			return cb_rebuildItems;
		}

		static bool n_RebuildItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RebuildItems ();
		}
#pragma warning restore 0169

		static IntPtr id_rebuildItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='rebuildItems' and count(parameter)=0]"
		[Register ("rebuildItems", "()Z", "GetRebuildItemsHandler")]
		protected virtual unsafe bool RebuildItems ()
		{
			if (id_rebuildItems == IntPtr.Zero)
				id_rebuildItems = JNIEnv.GetMethodID (class_ref, "rebuildItems", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_rebuildItems);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rebuildItems", "()Z"));
			} finally {
			}
		}

		static Delegate cb_recreateAssets_II;
#pragma warning disable 0169
		static Delegate GetRecreateAssets_IIHandler ()
		{
			if (cb_recreateAssets_II == null)
				cb_recreateAssets_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_RecreateAssets_II);
			return cb_recreateAssets_II;
		}

		static void n_RecreateAssets_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecreateAssets (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='recreateAssets' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("recreateAssets", "(II)V", "GetRecreateAssets_IIHandler")]
		protected abstract void RecreateAssets (int p0, int p1);

		static Delegate cb_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_Handler ()
		{
			if (cb_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ == null)
				cb_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_);
			return cb_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_;
		}

		static void n_RemoveChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.IOnWheelChangedListener p0 = (global::Antistatic.Spinnerwheel.IOnWheelChangedListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveChangingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='removeChangingListener' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.OnWheelChangedListener']]"
		[Register ("removeChangingListener", "(Lantistatic/spinnerwheel/OnWheelChangedListener;)V", "GetRemoveChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_Handler")]
		public virtual unsafe void RemoveChangingListener (global::Antistatic.Spinnerwheel.IOnWheelChangedListener p0)
		{
			if (id_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ == IntPtr.Zero)
				id_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_ = JNIEnv.GetMethodID (class_ref, "removeChangingListener", "(Lantistatic/spinnerwheel/OnWheelChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeChangingListener_Lantistatic_spinnerwheel_OnWheelChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeChangingListener", "(Lantistatic/spinnerwheel/OnWheelChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_Handler ()
		{
			if (cb_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ == null)
				cb_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_);
			return cb_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_;
		}

		static void n_RemoveClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.IOnWheelClickedListener p0 = (global::Antistatic.Spinnerwheel.IOnWheelClickedListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelClickedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveClickingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='removeClickingListener' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.OnWheelClickedListener']]"
		[Register ("removeClickingListener", "(Lantistatic/spinnerwheel/OnWheelClickedListener;)V", "GetRemoveClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_Handler")]
		public virtual unsafe void RemoveClickingListener (global::Antistatic.Spinnerwheel.IOnWheelClickedListener p0)
		{
			if (id_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ == IntPtr.Zero)
				id_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_ = JNIEnv.GetMethodID (class_ref, "removeClickingListener", "(Lantistatic/spinnerwheel/OnWheelClickedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeClickingListener_Lantistatic_spinnerwheel_OnWheelClickedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeClickingListener", "(Lantistatic/spinnerwheel/OnWheelClickedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_;
#pragma warning disable 0169
		static Delegate GetRemoveScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_Handler ()
		{
			if (cb_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ == null)
				cb_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_);
			return cb_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_;
		}

		static void n_RemoveScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Antistatic.Spinnerwheel.IOnWheelScrollListener p0 = (global::Antistatic.Spinnerwheel.IOnWheelScrollListener)global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.IOnWheelScrollListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveScrollingListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='removeScrollingListener' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.OnWheelScrollListener']]"
		[Register ("removeScrollingListener", "(Lantistatic/spinnerwheel/OnWheelScrollListener;)V", "GetRemoveScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_Handler")]
		public virtual unsafe void RemoveScrollingListener (global::Antistatic.Spinnerwheel.IOnWheelScrollListener p0)
		{
			if (id_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ == IntPtr.Zero)
				id_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_ = JNIEnv.GetMethodID (class_ref, "removeScrollingListener", "(Lantistatic/spinnerwheel/OnWheelScrollListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeScrollingListener_Lantistatic_spinnerwheel_OnWheelScrollListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeScrollingListener", "(Lantistatic/spinnerwheel/OnWheelScrollListener;)V"), __args);
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
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scroll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_scroll_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='scroll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_setAllItemsVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetAllItemsVisible_ZHandler ()
		{
			if (cb_setAllItemsVisible_Z == null)
				cb_setAllItemsVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllItemsVisible_Z);
			return cb_setAllItemsVisible_Z;
		}

		static void n_SetAllItemsVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllItemsVisible (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllItemsVisible_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setAllItemsVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllItemsVisible", "(Z)V", "GetSetAllItemsVisible_ZHandler")]
		public virtual unsafe void SetAllItemsVisible (bool p0)
		{
			if (id_setAllItemsVisible_Z == IntPtr.Zero)
				id_setAllItemsVisible_Z = JNIEnv.GetMethodID (class_ref, "setAllItemsVisible", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllItemsVisible_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllItemsVisible", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentItem_IZ;
#pragma warning disable 0169
		static Delegate GetSetCurrentItem_IZHandler ()
		{
			if (cb_setCurrentItem_IZ == null)
				cb_setCurrentItem_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetCurrentItem_IZ);
			return cb_setCurrentItem_IZ;
		}

		static void n_SetCurrentItem_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItem_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setCurrentItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setCurrentItem", "(IZ)V", "GetSetCurrentItem_IZHandler")]
		public virtual unsafe void SetCurrentItem (int p0, bool p1)
		{
			if (id_setCurrentItem_IZ == IntPtr.Zero)
				id_setCurrentItem_IZ = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentItem_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentItem", "(IZ)V"), __args);
			} finally {
			}
		}

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
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFriction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFriction_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setFriction' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInterpolator_Landroid_view_animation_Interpolator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
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
			global::Antistatic.Spinnerwheel.AbstractWheel __this = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.AbstractWheel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScrolling ();
		}
#pragma warning restore 0169

		static IntPtr id_stopScrolling;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='stopScrolling' and count(parameter)=0]"
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

#region "Event implementation for Antistatic.Spinnerwheel.IOnWheelChangedListener"
		public event EventHandler<global::Antistatic.Spinnerwheel.WheelChangedEventArgs> Changing {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Antistatic.Spinnerwheel.IOnWheelChangedListener, global::Antistatic.Spinnerwheel.IOnWheelChangedListenerImplementor>(
						ref weak_implementor_AddChangingListener,
						__CreateIOnWheelChangedListenerImplementor,
						AddChangingListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Antistatic.Spinnerwheel.IOnWheelChangedListener, global::Antistatic.Spinnerwheel.IOnWheelChangedListenerImplementor>(
						ref weak_implementor_AddChangingListener,
						global::Antistatic.Spinnerwheel.IOnWheelChangedListenerImplementor.__IsEmpty,
						__v => RemoveChangingListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddChangingListener;

		global::Antistatic.Spinnerwheel.IOnWheelChangedListenerImplementor __CreateIOnWheelChangedListenerImplementor ()
		{
			return new global::Antistatic.Spinnerwheel.IOnWheelChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Antistatic.Spinnerwheel.IOnWheelClickedListener"
		public event EventHandler<global::Antistatic.Spinnerwheel.WheelClickedEventArgs> Clicking {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Antistatic.Spinnerwheel.IOnWheelClickedListener, global::Antistatic.Spinnerwheel.IOnWheelClickedListenerImplementor>(
						ref weak_implementor_AddClickingListener,
						__CreateIOnWheelClickedListenerImplementor,
						AddClickingListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Antistatic.Spinnerwheel.IOnWheelClickedListener, global::Antistatic.Spinnerwheel.IOnWheelClickedListenerImplementor>(
						ref weak_implementor_AddClickingListener,
						global::Antistatic.Spinnerwheel.IOnWheelClickedListenerImplementor.__IsEmpty,
						__v => RemoveClickingListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddClickingListener;

		global::Antistatic.Spinnerwheel.IOnWheelClickedListenerImplementor __CreateIOnWheelClickedListenerImplementor ()
		{
			return new global::Antistatic.Spinnerwheel.IOnWheelClickedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Antistatic.Spinnerwheel.IOnWheelScrollListener"
		public event EventHandler<global::Antistatic.Spinnerwheel.ScrollingFinishedEventArgs> ScrollingFinished {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Antistatic.Spinnerwheel.IOnWheelScrollListener, global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor>(
						ref weak_implementor_AddScrollingListener,
						__CreateIOnWheelScrollListenerImplementor,
						AddScrollingListener,
						__h => __h.OnScrollingFinishedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Antistatic.Spinnerwheel.IOnWheelScrollListener, global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor>(
						ref weak_implementor_AddScrollingListener,
						global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor.__IsEmpty,
						__v => RemoveScrollingListener (__v),
						__h => __h.OnScrollingFinishedHandler -= value);
			}
		}

		public event EventHandler<global::Antistatic.Spinnerwheel.ScrollingStartedEventArgs> ScrollingStarted {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Antistatic.Spinnerwheel.IOnWheelScrollListener, global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor>(
						ref weak_implementor_AddScrollingListener,
						__CreateIOnWheelScrollListenerImplementor,
						AddScrollingListener,
						__h => __h.OnScrollingStartedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Antistatic.Spinnerwheel.IOnWheelScrollListener, global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor>(
						ref weak_implementor_AddScrollingListener,
						global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor.__IsEmpty,
						__v => RemoveScrollingListener (__v),
						__h => __h.OnScrollingStartedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddScrollingListener;

		global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor __CreateIOnWheelScrollListenerImplementor ()
		{
			return new global::Antistatic.Spinnerwheel.IOnWheelScrollListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("antistatic/spinnerwheel/AbstractWheel", DoNotGenerateAcw=true)]
	internal partial class AbstractWheelInvoker : AbstractWheel {

		public AbstractWheelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWheelInvoker); }
		}

		static IntPtr id_getBaseDimension;
		protected override unsafe int BaseDimension {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getBaseDimension' and count(parameter)=0]"
			[Register ("getBaseDimension", "()I", "GetGetBaseDimensionHandler")]
			get {
				if (id_getBaseDimension == IntPtr.Zero)
					id_getBaseDimension = JNIEnv.GetMethodID (class_ref, "getBaseDimension", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBaseDimension);
				} finally {
				}
			}
		}

		static IntPtr id_getItemDimension;
		protected override unsafe int ItemDimension {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getItemDimension' and count(parameter)=0]"
			[Register ("getItemDimension", "()I", "GetGetItemDimensionHandler")]
			get {
				if (id_getItemDimension == IntPtr.Zero)
					id_getItemDimension = JNIEnv.GetMethodID (class_ref, "getItemDimension", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemDimension);
				} finally {
				}
			}
		}

		static IntPtr id_getMaxOverScrollDimension;
		protected override unsafe int MaxOverScrollDimension {
			// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getMaxOverScrollDimension' and count(parameter)=0]"
			[Register ("getMaxOverScrollDimension", "()I", "GetGetMaxOverScrollDimensionHandler")]
			get {
				if (id_getMaxOverScrollDimension == IntPtr.Zero)
					id_getMaxOverScrollDimension = JNIEnv.GetMethodID (class_ref, "getMaxOverScrollDimension", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxOverScrollDimension);
				} finally {
				}
			}
		}

		static IntPtr id_createItemsLayout;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='createItemsLayout' and count(parameter)=0]"
		[Register ("createItemsLayout", "()V", "GetCreateItemsLayoutHandler")]
		protected override unsafe void CreateItemsLayout ()
		{
			if (id_createItemsLayout == IntPtr.Zero)
				id_createItemsLayout = JNIEnv.GetMethodID (class_ref, "createItemsLayout", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createItemsLayout);
			} finally {
			}
		}

		static IntPtr id_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='createScroller' and count(parameter)=1 and parameter[1][@type='antistatic.spinnerwheel.WheelScroller.ScrollingListener']]"
		[Register ("createScroller", "(Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)Lantistatic/spinnerwheel/WheelScroller;", "GetCreateScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_Handler")]
		protected override unsafe global::Antistatic.Spinnerwheel.WheelScroller CreateScroller (global::Antistatic.Spinnerwheel.WheelScroller.IScrollingListener p0)
		{
			if (id_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ == IntPtr.Zero)
				id_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_ = JNIEnv.GetMethodID (class_ref, "createScroller", "(Lantistatic/spinnerwheel/WheelScroller$ScrollingListener;)Lantistatic/spinnerwheel/WheelScroller;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Antistatic.Spinnerwheel.WheelScroller __ret = global::Java.Lang.Object.GetObject<global::Antistatic.Spinnerwheel.WheelScroller> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createScroller_Lantistatic_spinnerwheel_WheelScroller_ScrollingListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_doItemsLayout;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='doItemsLayout' and count(parameter)=0]"
		[Register ("doItemsLayout", "()V", "GetDoItemsLayoutHandler")]
		protected override unsafe void DoItemsLayout ()
		{
			if (id_doItemsLayout == IntPtr.Zero)
				id_doItemsLayout = JNIEnv.GetMethodID (class_ref, "doItemsLayout", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doItemsLayout);
			} finally {
			}
		}

		static IntPtr id_getMotionEventPosition_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='getMotionEventPosition' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
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

		static IntPtr id_recreateAssets_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='antistatic.spinnerwheel']/class[@name='AbstractWheel']/method[@name='recreateAssets' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("recreateAssets", "(II)V", "GetRecreateAssets_IIHandler")]
		protected override unsafe void RecreateAssets (int p0, int p1)
		{
			if (id_recreateAssets_II == IntPtr.Zero)
				id_recreateAssets_II = JNIEnv.GetMethodID (class_ref, "recreateAssets", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recreateAssets_II, __args);
			} finally {
			}
		}

	}

}
