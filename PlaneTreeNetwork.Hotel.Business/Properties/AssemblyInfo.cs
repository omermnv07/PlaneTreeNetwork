using PlaneTreeNetwork.Core.Aspects.Postsharp.LogAspects;
using System.Reflection;
using System.Runtime.CompilerServices;
using PlaneTreeNetwork.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using System.Runtime.InteropServices;
using PlaneTreeNetwork.Core.Aspects.Postsharp.ExceptionAspects;
using PlaneTreeNetwork.Core.Aspects.Postsharp.PerformanceAspects;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("PlaneTreeNetwork.Hotel.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("PlaneTreeNetwork.Hotel.Business")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ExceptionLogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "PlaneTreeNetwork.Hotel.Business.Concrete.Managers.*")]
[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "PlaneTreeNetwork.Hotel.Business.Concrete.Managers.*")]//sondaki * ile bütün namespacedeki yani managers içindeki bütün clas içindekileri logluyoruz.
[assembly: PerformanceCounterAspect(typeof(DatabaseLogger), AttributeTargetTypes = "PlaneTreeNetwork.Hotel.Business.Concrete.Managers.*")]//sondaki * ile bütün namespacedeki yani managers içindeki bütün clas içindekileri logluyoruz.

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("26f988c1-56c5-4290-bf6e-4be1d38c98a5")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
