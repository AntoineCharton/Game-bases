using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

public static class ReflectionUtils {

	public static object createObject (string name, params object[] constructorargs) {
		foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies ()) {
			foreach (Type typ in asm.GetExportedTypes ()) {
				if (typ.FullName == name)
					return Activator.CreateInstance (typ, constructorargs);
			}
		}
		return null;
	}

	public static string[] GetEnumerableOfType<T> (params object[] constructorArgs) where T : class {
		List<string> objects = new List<string> ();
		foreach (Type type in
			Assembly.GetAssembly (typeof (T)).GetTypes ()
			.Where (myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf (typeof (T)))) {
			objects.Add (type.Name);
		}
		objects.Sort ();
		return objects.ToArray();
	}
}