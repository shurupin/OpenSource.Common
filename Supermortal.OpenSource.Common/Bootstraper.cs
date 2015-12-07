using Supermortal.OpenSource.Common.Abstract;
using Supermortal.OpenSource.Common.Helpers;
using Supermortal.OpenSource.Common.Helpers.Log;

namespace Supermortal.OpenSource.Common
{
  public static class Bootstraper
  {

    public static void Start(IIoCHelper iocHelper, string log4NetConfigFilePath, bool useEncryption = false)
    {
      if (iocHelper != null)
      {
        IoCHelper.Instance = iocHelper;
        AddBindings();
      }

      if (!string.IsNullOrEmpty(log4NetConfigFilePath))
        LogHelper.Configure(log4NetConfigFilePath, useEncryption);
    }

    private static void AddBindings()
    {

    }

  }
}
