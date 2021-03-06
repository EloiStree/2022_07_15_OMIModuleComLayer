using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mock_ManageExecuterCalendarMono : MonoBehaviour
{

    public MockCalendarManageExecuterTime m_timeManager = new MockCalendarManageExecuterTime();
    void Awake()
    {
        StaticCalendarExecutorComBridge.SetTimeExecuter(m_timeManager);
    }

    void OnDestory()
    {
        StaticCalendarExecutorComBridge.RemoveTimeExecuter();
    }
}

[System.Serializable]
public class MockCalendarManageExecuterTime : I_PushCommandToCalendarTime
{
    public bool m_useDebug;
    public ExecuteAtCalendarActionThreadMono m_executeCalendarAction;
    public void ExecuteCalendarAtDate(in ClassicThreadTarget thread, in DateTime date, in string commandLine)
    {
        if(m_useDebug)
        Debug.Log(string.Format("{0}: {1}-{2}-{3}", "Exe ExecuteCalendarAtDate", thread, date.ToString(), commandLine));
        m_executeCalendarAction.AddInQueue(in thread, in date, in commandLine);
    }

    public void ExecuteCalendarEveryDayAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        if (m_useDebug) { 
            Debug.Log(string.Format("Not Code yet: {0}: {1}-{2}-{3}", "Exe ExecuteCalendarEveryDayAt", thread, date.ToString(), commandLine));
            Debug.LogWarning("NotImplementedException");
        }
    
    }
    public void ExecuteCalendarEveryMonthAtIndex(in ClassicThreadTarget thread, in byte index_0_31, in bool startToEndOfMonth, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
    {
        if (m_useDebug)
        {
            Debug.Log(string.Format("Not Code yet: {0}: {1}-{2}-{3}-{4}-{5}", "Exe ExecuteCalendarEveryMonthAtIndex", thread, index_0_31, startToEndOfMonth, date.ToString(), commandLine));
        Debug.LogWarning("NotImplementedException");
        }
    }

    public void ExecuteCalendarEveryWeekAt(in ClassicThreadTarget thread, in I_PushCommandToCalendarTime.DayOfTheWeek dayOfTheWeak, in I_PushCommandToCalendarTime.Executor_TimeOfDay date, in string commandLine)
        {
            if (m_useDebug)
            {
                Debug.Log(string.Format("Not Code yet: {0}: {1}-{2}-{3}-{4}", "Exe ExecuteCalendarEveryWeekAt", thread, dayOfTheWeak, date.ToString(), commandLine));
        Debug.LogWarning("NotImplementedException");
            }
        }

    public void PutCalendarPusherAsActive(in bool isActive)
    {
        m_executeCalendarAction.SetInPauseMode(!isActive);
    }

    public void RepeatExecutionEvery(in ClassicThreadTarget thread, in DateTime date, in long millisecondsBetweenRepeat, in string commandLine)
            {
                if (m_useDebug)
                {
                    Debug.Log(string.Format("Not Code yet: {0}: {1}-{2}-{3}-{4}", "Exe RepeatExecutionEvery", thread, date.ToString(), millisecondsBetweenRepeat, commandLine));
                    Debug.LogWarning("NotImplementedException");
                }
    }
}


