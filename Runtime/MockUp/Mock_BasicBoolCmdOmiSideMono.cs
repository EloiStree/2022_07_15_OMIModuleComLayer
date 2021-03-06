using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mock_BasicBoolCmdOmiSideMono : MonoBehaviour {

    public Mock_BasicBoolCmdOmiSide m_mock = new Mock_BasicBoolCmdOmiSide();
    private void Awake()
    {
        FacadeComLayerOMI.m_omiSide = m_mock;
        m_mock.m_setBooleanTo.AddListener(m_mock.SetRegisterWithBoolean);
    }
    private void OnDestroy()
    {
        m_mock.m_setBooleanTo.RemoveListener(m_mock.SetRegisterWithBoolean);
    }
}
[System.Serializable]
public class Mock_BasicBoolCmdOmiSide : AbstractBasicBoolCmdOmiSide
{
    public Dictionary<string, bool> m_registerBooleans = new Dictionary<string, bool>();

    [TextArea(0, 8)]
    public string m_booleanState = "";
    public void SetRegisterWithBoolean( string name,  bool value) {

        if (m_registerBooleans.ContainsKey(name))
            m_registerBooleans[name] = value;
        else m_registerBooleans.Add(name, value);

        m_booleanState = "";
        foreach (var item in m_registerBooleans.Keys)
        {
            m_booleanState +=string.Format("{0} {1}\n",item, m_registerBooleans[item]);
        }
    }
    public override bool IsBooleanExists(in string name) {
       return m_registerBooleans.ContainsKey(name.ToLower());
    }
    public override void GetBooleanValue(in string name, out bool value, in bool defaultIfNotDefined)
    {
        string n = name.ToLower();
        if (m_registerBooleans.ContainsKey(n))
            value = m_registerBooleans[n];
        else value = defaultIfNotDefined;
    }

    public override bool GetBooleanValue(in string name, in bool defaultIfNotDefined)
    {
        GetBooleanValue(in name, out bool result, defaultIfNotDefined);
        return result;
    }
}
