﻿/***************************************************************************************************
 *
 *  Copyright © 2015 Flatcode.net
 *
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 *  and associated documentation files (the "Software"), to deal in the Software without
 *  restriction, including without limitation the rights to use, copy, modify, merge, publish,
 *  distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 *  Software is furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in all copies or
 *  substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 *  BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 *  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 *  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *
 **************************************************************************************************/

#region Using Directives

using System;
using System.ComponentModel;

#endregion

namespace Flatcode.VSEssentials.Extensions.DocumentInsights
{
    sealed class DocumentInsightsOptions : INotifyPropertyChanged
    {
        #region Singleton Class

        static class Singleton
        {
            internal static readonly DocumentInsightsOptions Instance = new DocumentInsightsOptions();
            static Singleton() { }
        }

        #endregion

        #region Fields

        Boolean enableCharInfo;
        Boolean enableLineInfo;
        Boolean showMargin;

        #endregion

        #region Constructors

        DocumentInsightsOptions()
        {
            // Default instance initialization
            enableCharInfo = true;
            enableLineInfo = true;
            showMargin = true;
        }

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public Boolean EnableCharInfo {
            get { return enableCharInfo; }
            set {
                if (enableCharInfo != value) {
                    enableCharInfo = value;
                    OnPropertyChanged(nameof(EnableCharInfo));
                }
            }
        }

        public Boolean EnableLineInfo {
            get { return enableLineInfo; }
            set {
                if (enableLineInfo != value) {
                    enableLineInfo = value;
                    OnPropertyChanged(nameof(EnableLineInfo));
                }
            }
        }

        public Boolean ShowMargin {
            get { return showMargin; }
            set {
                if (showMargin != value) {
                    showMargin = value;
                    OnPropertyChanged(nameof(ShowMargin));
                }
            }
        }

        #endregion

        #region Properties: Current

        public static DocumentInsightsOptions Current {
            get { return Singleton.Instance; }
        }

        #endregion

        #region Methods
        #endregion

        #region Methods: Event Handler

        void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
