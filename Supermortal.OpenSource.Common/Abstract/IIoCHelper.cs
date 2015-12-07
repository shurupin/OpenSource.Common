using Supermortal.OpenSource.Common.Models.Enums;

namespace Supermortal.OpenSource.Common.Abstract
{
  public interface IIoCHelper
  {
      T GetService<T>();
      void BindService<T1, T2>(IoCBindingType bindingType = IoCBindingType.Normal, string name = null) where T2 : T1;
      T GetNamedBinding<T>(string name);
  }
}