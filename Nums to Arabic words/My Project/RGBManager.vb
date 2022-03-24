Namespace Core
    Public Class RGBManager
        Private h_temp As Single = 0
        Private WithEvents timer_global_rgb As Timer = New Timer() With {
            .Interval = 300
        }

        Public Property RGBColor As Color = Color.White

        Public Sub New()

        End Sub

        Public Sub SetStatus(ByVal Status As Boolean)
            If Status = True Then
                timer_global_rgb.Start()
            Else
                timer_global_rgb.Stop()
            End If
        End Sub

        Public Sub SetInterval(ByVal interval As Integer)
            timer_global_rgb.Interval = interval
        End Sub

        Private Sub timer_global_rgb_Tick(sender As Object, e As EventArgs) Handles timer_global_rgb.Tick
            h_temp += 1
            If h_temp >= 360 Then h_temp = 0
            RGBColor = HSV_To_RGB(h_temp, 1.0F, 1.0F)
        End Sub

        Private Function HSV_To_RGB(ByVal hue As Single, ByVal saturation As Single, ByVal value As Single) As Color
            If saturation < Single.Epsilon Then
                Dim c As Integer = CInt((value * 255))
                Return Color.FromArgb(c, c, c)
            End If
            If timer_global_rgb.Enabled Then hue = h_temp
            Dim r, g, b, f, p, q, t As Single
            Dim i As Integer

            hue /= 60
            i = CInt(Math.Floor(hue))
            f = hue - i
            p = value * (1 - saturation)
            q = value * (1 - saturation * f)
            t = value * (1 - saturation * (1 - f))

            Select Case i
                Case 0
                    r = value
                    g = t
                    b = p
                Case 1
                    r = q
                    g = value
                    b = p
                Case 2
                    r = p
                    g = value
                    b = t
                Case 3
                    r = p
                    g = q
                    b = value
                Case 4
                    r = t
                    g = p
                    b = value
                Case Else
                    r = value
                    g = p
                    b = q
            End Select

            Return Color.FromArgb(255, CInt((r * 255)), CInt((g * 255)), CInt((b * 255)))

        End Function
    End Class
End Namespace