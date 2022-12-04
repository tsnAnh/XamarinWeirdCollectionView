using System;
using CoreGraphics;
using UIKit;
using Foundation;

namespace IOSApp1
{
    [Register("ListScreen")]
    public partial class ListScreen : UIViewController
    {
        public ListScreen() : base()
        {
        }

        public ListScreen(IntPtr handle) : base(handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Test.Text = "CAC";
            if (List != null)
            {
                var layout = new UICollectionViewFlowLayout();
                var itemsPerRow = 3;
                var paddingSapce = layout.SectionInset.Left * (itemsPerRow + 1);
                var availableWidth = View.Frame.Width - paddingSapce;
                var WidthPerItem = availableWidth / itemsPerRow;
                layout.SectionInset = new UIEdgeInsets(5, 5, 5, 5);
                layout.MinimumInteritemSpacing = 0;
                layout.MinimumLineSpacing = 15;
                layout.ItemSize = new CGSize(width: WidthPerItem + 35, height: WidthPerItem);
                List.CollectionViewLayout = layout;
                List.DataSource = new DataSource();
                List.Delegate = new Delegate();
            } else Console.WriteLine("CAC");
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public class Delegate : UICollectionViewDelegateFlowLayout
    {
        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new CGSize(collectionView.Bounds.Width - 32, 200);
        }
    }

    public class DataSource : UICollectionViewDataSource
    {
        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 10;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (Cell) collectionView.DequeueReusableCell(new NSString("cell"), indexPath);
            return cell;
        }
    }
}