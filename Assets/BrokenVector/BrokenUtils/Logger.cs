using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BrokenVector.BrokenUtils
{
    /// <summary>
    /// A useful replacement for Debug.Log
    /// </summary>
	public class Logger
    {

        public string Module { get; private set; }

        public Logger(string module)
        {
            Module = module;
        }

        public void Log(string msg)
        {
            StaticLog(Module, msg);
        }

        public void Log(params string[] msgs)
        {
            Log(UnionMessages(msgs));
        }

        public void LogWarning(string msg)
        {
            StaticLogWarning(Module, msg);
        }

        public void LogError(string msg)
        {
            StaticLogError(Module, msg);
        }

        #region statics
        public static void StaticLog(string msg)
        {
            Debug.Log(msg);
        }

        public static void StaticLog(params string[] msgs)
        {
            Debug.Log(UnionMessages(msgs));
        }

        public static void StaticLog(string module, string msg)
        {
            StaticLog(module + ": " + msg);
        }

        public static void StaticLogWarning(string msg)
        {
            Debug.LogWarning(msg);
        }

        public static void StaticLogWarning(string module, string msg)
        {
            StaticLogWarning(module + ": " + msg);
        }

        public static void StaticLogError(string msg)
        {
            Debug.LogError(msg);
        }

        public static void StaticLogError(string module, string msg)
        {
            StaticLogError(module + ": " + msg);
        }
        #endregion

        private static string UnionMessages(string[] msgs)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < msgs.Length; i++)
            {
                sb.Append(msgs[i]);
                if (i + 1 < msgs.Length)
                {
                    sb.Append(" - ");
                }
            }

            return sb.ToString();
        }

    }
}