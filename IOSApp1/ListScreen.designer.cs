// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace IOSApp1
{
	partial class ListScreen
	{
		[Outlet]
		UIKit.UICollectionView List { get; set; }

		[Outlet]
		UIKit.UILabel Test { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (List != null) {
				List.Dispose ();
				List = null;
			}

			if (Test != null) {
				Test.Dispose ();
				Test = null;
			}

		}
	}
}
