Option Strict On
Imports System.Runtime.InteropServices
Class C
    <DllImport("hid.dll", SetLastError:=False)> _
    Private Shared Sub HidD_GetHidGuid(<MarshalAs(UnmanagedType.LPWStr, SizeParamIndex:=Integer.MaxValue)> ByVal n As Integer)
    End Sub
End Class