# Easy Logger

A helper class for log short messages in ETW (Event Tracing for Windows).

## Why you need this

Sometimes developers are trying to debug applications without a console for outputing logs. Sometimes applications' behavior will change if you attach a debugger on the process. Windows provided ETW for developers to log something. When enabled, developers can see the corresponding log via some ETW comsumers. However, sometimes, ETW providers are not easy to created. And only a few logs need to be added for debug use. We only need to check them just like what we use in output consoles. That's the reason why we need this.

## Usage

1. [Turn on Windows Device Portal(WDP)](https://docs.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-desktop#turn-on-windows-device-portal)
2. [Connect to WDP](https://docs.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-desktop#connect-to-windows-device-portal)
3. Navigate to **[Realtime ETW tracing](https://docs.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-desktop#connect-to-windows-device-portal)**
4. Enable **Custom provider** with GUID **00000000-0000-0000-0000-000000000001**
5. Write some logs within your application and Run. Then the events would appear in the output of WDP.

## Code example
```C#
    Log.V("Verbose");
    Log.I("Informational");
    Log.W("Warning");
    Log.E("Error");
    Log.C("Critical");
```