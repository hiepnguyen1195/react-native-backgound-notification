using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Background.Notification.RNBackgroundNotification
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBackgroundNotificationModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBackgroundNotificationModule"/>.
        /// </summary>
        internal RNBackgroundNotificationModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBackgroundNotification";
            }
        }
    }
}
