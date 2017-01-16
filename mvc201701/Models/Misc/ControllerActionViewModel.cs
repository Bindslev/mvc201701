using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace mvc201701.Models.Misc
{
    public class ControllerActionViewModel
    {

        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ReturnType { get; set; }
        public string Attributes { get; set; }
        public string Arguments { get; set; }

        public static Dictionary<string, List<mvc201701.Models.Misc.ControllerActionViewModel>> GetActionMethods() {
            Assembly asm = Assembly.GetExecutingAssembly();
            var controlleractionlist = asm.GetTypes()
                    .Where(type => typeof(System.Web.Mvc.Controller).IsAssignableFrom(type))
                    .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                    .Where(m => !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), true).Any())
                    .Select(x => new ControllerActionViewModel { ControllerName = x.DeclaringType.Name.Replace("Controller", ""), ActionName = x.Name, Arguments = String.Join(",", x.GetParameters().Select(a => a.ParameterType.ToString())), ReturnType = x.ReturnType.Name, Attributes = String.Join(",", x.GetCustomAttributes().Select(a => a.GetType().Name.Replace("Attribute", ""))) })
                    .OrderBy(x => x.ControllerName).ThenBy(x => x.ActionName).ToList();
            var grp = controlleractionlist.GroupBy(i => i.ControllerName).ToDictionary(i => i.Key, i => i.ToList());
            return grp;
        }

    }
}