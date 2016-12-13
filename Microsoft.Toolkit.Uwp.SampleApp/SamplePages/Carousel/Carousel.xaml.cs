﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Microsoft.Toolkit.Uwp.SampleApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    /// <summary>
    /// A page that shows how to use the DropShadowPanel control.
    /// </summary>
    public sealed partial class Carousel : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carousel"/> class.
        /// </summary>
        public Carousel()
        {
            InitializeComponent();
        }

        public ObservableCollection<CarouselData> Datas { get; set; }

        /// <summary>
        /// Invoked when the Page is loaded and becomes the current source of a parent Frame.
        /// </summary>
        /// <param name="e">Event data that can be examined by overriding code. The event data is representative of the pending navigation that will load the current Page. Usually the most relevant property to examine is Parameter.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var propertyDesc = e.Parameter as PropertyDescriptor;

            if (propertyDesc != null)
            {
                DataContext = propertyDesc.Expando;
            }

            var datas = new ObservableCollection<CarouselData>();
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/BigFourSummerHeat.png", UriKind.Absolute)), Title = "01" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/BisonBadlandsChillin.png", UriKind.Absolute)), Title = "02" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/ColumbiaRiverGorge.png", UriKind.Absolute)), Title = "03" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/SnowyInterbayt.png", UriKind.Absolute)), Title = "04" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/GrandTetons.png", UriKind.Absolute)), Title = "05" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/LakeAnnMushroom.png", UriKind.Absolute)), Title = "06" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/LunchBreak.png", UriKind.Absolute)), Title = "07" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/MilkyWayStHelensHikePurple.png", UriKind.Absolute)), Title = "08" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/LunchBreak.png", UriKind.Absolute)), Title = "09" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/MilkyWayStHelensHikePurple.png", UriKind.Absolute)), Title = "10" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/MitchellButtes.png", UriKind.Absolute)), Title = "11" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/MultnomahFalls.png", UriKind.Absolute)), Title = "12" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/NorthernCascadesReflection.png", UriKind.Absolute)), Title = "13" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/NovemberHikeWaterfall.png", UriKind.Absolute)), Title = "14" });
            datas.Add(new CarouselData { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/Photos/Owl.png", UriKind.Absolute)), Title = "15" });

            this.Datas = datas;

            carouselControl.ItemsSource = Datas;
        }
    }

    public class CarouselData
    {
        public BitmapImage BitmapImage { get; set; }

        public string Title { get; set; }
    }
}
