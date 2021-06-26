using System;
using UnityEngine;

namespace Flavo
{
    public static class Logger
    {
        private static bool _isInitialized;
        private static bool _logAllowed;

        static Logger()
        {
            _isInitialized = false;
            _logAllowed = false;
        }

        public static void Initialize(bool allowLog)
        {
            _logAllowed = allowLog;
            _isInitialized = true;
        }

        public static void Log(string log)
        {
            InternalLog(LogType.Log, log);
        }

        public static void Log(LogType logType, string log)
        {
            InternalLog(logType, log);
        }

        private static void InternalLog(LogType logType, string log)
        {
            if (_isInitialized && _logAllowed)
            {
                switch (logType)
                {
                    case LogType.Error:
                        Debug.LogError(log);
                        break;

                    case LogType.Assert:
                        Debug.LogAssertion(log);
                        break;

                    case LogType.Warning:
                        Debug.LogWarning(log);
                        break;

                    case LogType.Log:
                        Debug.Log(log);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
                }
            }
        }
    }
}
