// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monotouch_SoundRecording {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MainViewController")]
	public partial class MainViewController {
		
		private MainView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt__playBackButton;
		
		private MonoTouch.UIKit.UIButton __mt__recordingButton;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MainView view {
			get {
				this.__mt_view = ((MainView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("_playBackButton")]
		private MonoTouch.UIKit.UIButton _playBackButton {
			get {
				this.__mt__playBackButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("_playBackButton")));
				return this.__mt__playBackButton;
			}
			set {
				this.__mt__playBackButton = value;
				this.SetNativeField("_playBackButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("_recordingButton")]
		private MonoTouch.UIKit.UIButton _recordingButton {
			get {
				this.__mt__recordingButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("_recordingButton")));
				return this.__mt__recordingButton;
			}
			set {
				this.__mt__recordingButton = value;
				this.SetNativeField("_recordingButton", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIView or subclass
	[MonoTouch.Foundation.Register("MainView")]
	public partial class MainView {
	}
}
