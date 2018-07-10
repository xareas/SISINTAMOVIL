using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SISINTA.View
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView 
        {
            get
            {
                return listView;
            }
        }
        public MasterPage()
        {
            InitializeComponent();
  
        }
    }
}
