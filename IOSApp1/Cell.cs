using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace IOSApp1
{
    [Register("DMCell")]
    public partial class Cell : UICollectionViewCell
    {
        public Cell(IntPtr handle) : base(handle)
        {
        }
        
        [Export("awakeFromNib")]
        public override void AwakeFromNib() {
            try {
                base.AwakeFromNib();
            } catch (Exception ex) {}
        }
    }
}