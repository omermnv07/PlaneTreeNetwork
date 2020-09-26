using PlaneTreeNetwork.Core.CrossCuttingConcerns.Logging;
using PlaneTreeNetwork.Core.CrossCuttingConcerns.Logging.Log4Net;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Core.Aspects.Postsharp.PerformanceAspects
{
    [Serializable]
    public class PerformanceCounterAspect : OnMethodBoundaryAspect
    {
        private int _interVal;
        [NonSerialized]
        private Stopwatch _stopwatch;
        private LoggerService _loggerService;
        private Type _loggerType;

        public PerformanceCounterAspect(Type loggerType, int interVal = 5)//, Type loggerType
        {
            _interVal = interVal;
            _loggerType = loggerType;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            if (_loggerType != null)
            {
                if (_loggerType.BaseType != typeof(LoggerService))
                {
                    throw new Exception("Wrong logger type");
                }
                _loggerService = (LoggerService)Activator.CreateInstance(_loggerType);
            }
            base.RuntimeInitialize(method);
            _stopwatch = Activator.CreateInstance<Stopwatch>();
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch.Stop();
            if (_stopwatch.Elapsed.TotalSeconds > _interVal)
            {
                if (_loggerService != null)
                {
                    try
                    {
                        var logPerformance = new LogPerformance
                        {
                            WhereClass = args.Method.DeclaringType.FullName,
                            WhichMethod = args.Method.Name,
                            TotalSeconds = _stopwatch.Elapsed.TotalSeconds
                        };
                        _loggerService.Warn(logPerformance);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            _stopwatch.Reset();
            base.OnExit(args);
        }
    }
}
