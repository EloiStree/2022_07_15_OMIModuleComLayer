using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface I_PushToOMI
{
    /// <summary>
    /// Push a line that will be interpreted to be a command to an interpreter. "\n" is used to split line You can't use it in a command line.
    /// </summary>
    /// <param name="line"></param>
    public void PushCommandLine(in string line);
    /// <summary>
    /// All the application is based on boolean value that are named. Read the tutorial or documenation if you did not have yet.
    /// https://github.com/EloiStree/OpenMacroInputDocumentation
    /// </summary>
    /// <param name="name">Name of the boolean value not case sensitive</param>
    /// <param name="newValue">the new value you want. If the same as previous one it will be ignore</param>
    public void SetBooleanValue(in string name,in bool newValue);
    /// <summary>
    /// Shortcut are small blocks of text split by space. (You can't have space in your shortcut)
    /// </summary>
    /// <param name="line">A line of text composed of one to many short cut split by space</param>
    /// <param name="groupSensitive"></param>
    public void PushShortcut(in string line, in bool groupSensitive);


    ///// NOT CODE YET
    ///// <summary>
    ///// As you can't have space in short cut and you can't have '\n' in command line maybe you want to store it in memory to recover it in the command.
    ///// </summary>
    ///// <param name="textStorageId"></param>
    ///// <param name="textToStore"></param>
    //public void SetTextInRamMemory(string textStorageId, string textToStore);
    ///// NOT CODE YET
    ///// <summary>
    ///// As you can't have space in short cut and you can't have '\n' in command line maybe you want to store it in a permanent memory to recover it in the command.
    ///// </summary>
    ///// <param name="textStorageId"></param>
    ///// <param name="textToStore"></param>
    //public void SetTextInFileMemory(string textStorageId, string textToStore);

}
