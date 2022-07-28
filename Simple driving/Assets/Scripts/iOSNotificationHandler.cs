using System.Collections;
using System.Collections.Generic;

#if UNITY_IOS
using Unity.Notifications.iOS;
#endif

using UnityEngine;

public class iOSNotificationHandler : MonoBehaviour
{
    #if UNITY_IOS
    public void ScheduleNotification(int min)
    {
        iOSNotification notification = new iOSNotification
        {
            Title = "Energy Recharged",
            Subtitle = "Your energy has been recharged",
            Body = "Your energy has been recharged. Come back to play!",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a",
            ThreadIdentifier = "thread1",
            Trigger = new iOSNotificationTimeIntervalTrigger
            {
                TimeInterval = new System.TimeSpan(0, min, 0),
                Repeats = false
            }
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }
    
    #endif
}
