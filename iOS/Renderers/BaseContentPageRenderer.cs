using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamFontAwesome.iOS.Renderers;

[assembly: ExportRenderer(typeof(ContentPage), typeof(BaseContentPageRenderer))]
namespace XamFontAwesome.iOS.Renderers
{
    public class BaseContentPageRenderer: PageRenderer
    {
        public BaseContentPageRenderer()
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var contentPage = this.Element as ContentPage;
            if (contentPage == null || NavigationController == null)
                return;

            var LeftNavList = new List<UIBarButtonItem>();
            var rightNavList = new List<UIBarButtonItem>();

            var navigationItem = this.NavigationController.TopViewController.NavigationItem;

            var rightNativeButtons = (navigationItem.RightBarButtonItems ?? new UIBarButtonItem[] { }).ToList();

            rightNativeButtons.ForEach(nativeItem =>
            {
                
                // [Hack] Get Xamarin private field "item"
                //var field = nativeItem.GetType().GetField("item", BindingFlags.NonPublic | BindingFlags.Instance);
                //if (field == null)
                //{
                //    return;
                //}

                UITextAttributes normalTextAttributes = new UITextAttributes();
                normalTextAttributes.Font = UIFont.FromName("FontAwesome5ProLight", 20F);
                //  UITabBarItem.Appearance.SetTitleTextAttributes(normalTextAttributes, UIControlState.Normal);

                nativeItem.SetTitleTextAttributes(normalTextAttributes, UIControlState.Normal);
                nativeItem.SetTitleTextAttributes(normalTextAttributes, UIControlState.Application);


               
            });

           


            //navigationItem.SetLeftBarButtonItems(LeftNavList.ToArray(), false);
            //navigationItem.SetRightBarButtonItems(rightNavList.ToArray(), false);

        }
    }
}
