using System;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace JVFloatLabeledTextFieldBinding {

	[BaseType (typeof (UITextField))]
	public partial interface JVFloatLabeledTextField {

		[Export ("floatingLabel", ArgumentSemantic.Retain)]
		UILabel FloatingLabel { get; }

		[Export ("floatingLabelYPadding", ArgumentSemantic.Retain)]
		NSNumber FloatingLabelYPadding { get; set; }

		[Export ("floatingLabelFont", ArgumentSemantic.Retain)]
		UIFont FloatingLabelFont { get; set; }

		[Export ("floatingLabelTextColor", ArgumentSemantic.Retain)]
		UIColor FloatingLabelTextColor { get; set; }

		[Export ("floatingLabelActiveTextColor", ArgumentSemantic.Retain)]
		UIColor FloatingLabelActiveTextColor { get; set; }

		[Export ("animateEvenIfNotFirstResponder")]
		int AnimateEvenIfNotFirstResponder { get; set; }

		[Export ("floatingLabelShowAnimationDuration")]
		double FloatingLabelShowAnimationDuration { get; set; }

		[Export ("floatingLabelHideAnimationDuration")]
		double FloatingLabelHideAnimationDuration { get; set; }

		[Export ("setPlaceholder:floatingTitle:")]
		void SetPlaceholder (string placeholder, string floatingTitle);
	}

	[BaseType (typeof (UITextView))]
	public partial interface JVFloatLabeledTextView {

		[Export ("placeholder", ArgumentSemantic.Copy)]
		string Placeholder { get; set; }

		[Export ("floatingLabel", ArgumentSemantic.Retain)]
		UILabel FloatingLabel { get; }

		[Export ("floatingLabelYPadding", ArgumentSemantic.Retain)]
		NSNumber FloatingLabelYPadding { get; set; }

		[Export ("floatingLabelFont", ArgumentSemantic.Retain)]
		UIFont FloatingLabelFont { get; set; }

		[Export ("floatingLabelTextColor", ArgumentSemantic.Retain)]
		UIColor FloatingLabelTextColor { get; set; }

		[Export ("floatingLabelActiveTextColor", ArgumentSemantic.Retain)]
		UIColor FloatingLabelActiveTextColor { get; set; }

		[Export ("autoHidesFLoatLabelWhenOverlaps")]
		int AutoHidesFLoatLabelWhenOverlaps { get; set; }

		[Export ("animateEvenIfNotFirstResponder")]
		int AnimateEvenIfNotFirstResponder { get; set; }

		[Export ("floatingLabelShowAnimationDuration")]
		double FloatingLabelShowAnimationDuration { get; set; }

		[Export ("floatingLabelHideAnimationDuration")]
		double FloatingLabelHideAnimationDuration { get; set; }

		[Export ("setPlaceholder:floatingTitle:")]
		void SetPlaceholder (string placeholder, string floatingTitle);
	}

//	[Category, BaseType (typeof (NSString))]
//	public partial interface TextDirectionality_NSString {
//
//		[Export ("getBaseDirection"), Verify ("ObjC method massaged into getter property", "/Users/dementrock/Sellegit/peach_mobile/Lib/JVFloatLabeledTextField/JVFloatLabeledTextField/JVFloatLabeledTextField/NSString+TextDirectionality.h", Line = 26)]
//		JVTextDirection GetBaseDirection { get; }
//	}
}
