// Type: System.Threading.ParameterizedThreadStart
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime.InteropServices;

namespace System.Threading
{
  /// <summary>
  /// Represents the method that executes on a <see cref="T:System.Threading.Thread"/>.
  /// </summary>
  /// <param name="obj">An object that contains data for the thread procedure.</param><filterpriority>1</filterpriority>
  [ComVisible(false)]
  public delegate void ParameterizedThreadStart(object obj);
}
