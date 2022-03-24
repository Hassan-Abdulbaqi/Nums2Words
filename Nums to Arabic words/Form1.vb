Public Class Form1
    Dim English As Boolean
    Dim only As Boolean = False
    Private RGBMon As Core.RGBManager = New Core.RGBManager
    Dim hundreds As Boolean = False

    '  Dim finalstr As String = String.Empty




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            If TextBox1.Text IsNot String.Empty Then

                If English = False Then

                    TextBox2.Text = NumberToarb(TextBox1.Text)
                    ' TextBox2.Text = TextBox2.Text.Replace(",", " و ")

                    Orginize()
                    If only = True Then
                        TextBox2.Text += " فقط لا غير "
                    End If





                Else
                    TextBox2.Text = NumberToText(TextBox1.Text)
                End If

            Else
                TextBox2.Clear()
            End If
        Catch ex As Exception
            TextBox1.Clear()
            TextBox2.Clear()
            If English = True Then
                MsgBox("Error if The Problem Continues please Contact the Developer... ", Title:="Error")
                'ToolStripStatusLabel1.Text = "Error if The Problem Continues please Contact the Developer... information in myinfo"
            Else
                MsgBox(ex.Message)
                MsgBox("حدث خطأ اذا استمرت المشكلة الرجاء التواصل مع المطور...", Title:="حدث خطأ")
                ' ToolStripStatusLabel1.Text = "حدث خطأ اذا استمرت المشكلة الرجاء التواصل مع المطور...المعلومات في معلوماتي"
            End If
        End Try


    End Sub
    Private Sub Orginize()



        If TextBox2.Text.EndsWith(" و  ") Then
            TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.LastIndexOf(" و "))
        ElseIf TextBox2.Text.EndsWith(" و  ") Then
            TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.LastIndexOf(" و  "))
        ElseIf TextBox2.Text.EndsWith("و") Then
            TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.LastIndexOf("و"))

        End If
        If TextBox2.Text.Contains("ةم") Then
            '  MsgBox("ةم")
            TextBox2.Text = TextBox2.Text.Replace("ةم", "م")
            'ةم
        End If
        If TextBox2.Text.Contains("يه") Then
            '  MsgBox("ةم")
            TextBox2.Text = TextBox2.Text.Replace("يه", "")
            'ةم
        End If
        'يه
        If TextBox2.Text.StartsWith(" و ") Then
            TextBox2.Text = TextBox2.Text.Remove(0, 3)
        End If
        If TextBox2.Text.Contains(" و   و ") Then
            TextBox2.Text = TextBox2.Text.Replace(" و   و ", " و ")
        End If
        If TextBox2.Text.Contains(" و و ") Then
            TextBox2.Text = TextBox2.Text.Replace(" و و ", " و ")
        End If
        If TextBox2.Text.Contains("  ") Then
            TextBox2.Text = TextBox2.Text.Replace("  ", " ")
        End If

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True
                If English = False Then
                    ToolStripStatusLabel1.Text = "الرجاء ادخال ارقام فقط"
                    wait(5)
                    ToolStripStatusLabel1.Text = "اللغة : العربية"
                Else
                    ToolStripStatusLabel1.Text = "Please Enter Integers Only"
                    wait(5)
                    ToolStripStatusLabel1.Text = "Language:English"
                End If

            End If
        End If

    End Sub

    Private Sub العربيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles العربيةToolStripMenuItem.Click
        toarabic()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "اللغة : العربية"
        ToolStripStatusLabel1.ForeColor = Color.White
        StartRGB()
    End Sub

    Private Sub نسخالنصToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نسخالنصToolStripMenuItem.Click
        If TextBox2.Text IsNot String.Empty Then
            Clipboard.SetText(TextBox2.Text)
        End If
    End Sub
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = Microsoft.VisualBasic.Timer()
        Do While Microsoft.VisualBasic.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub
    Sub toenglish()
        ToolStripStatusLabel1.Text = "Language:English"
        اللغةToolStripMenuItem.Text = "Language"
        نسخالنصToolStripMenuItem.Text = "Copy Text"
        ايقافالألوانToolStripMenuItem.Text = "Stop RGB"
        Me.Text = "Nums2Words"
        English = True
        TextBox1.Clear()
        TextBox2.Clear()
        CheckBox1.Visible = False

    End Sub
    Sub toarabic()
        ToolStripStatusLabel1.Text = "اللغة : العربية"
        اللغةToolStripMenuItem.Text = "اللغة"
        نسخالنصToolStripMenuItem.Text = "نسخ النص"
        ايقافالألوانToolStripMenuItem.Text = "ايقاف الألوان"
        Me.Text = "تفقيط الأرقام"
        TextBox1.Clear()
        TextBox2.Clear()
        English = False
        CheckBox1.Visible = True

    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        toenglish()
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        If English = True Then
            toarabic()
        Else
            toenglish()
        End If
    End Sub

#Region "Functions"
    Function NumberToarb(ByVal n As Int64) As String
        '    Dim n As Double = Fix(m / 1000000000)


        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                ' If hundreds = True Then

                Dim arr() As String = {"واحد", "اثنان", "ثلاثة", "اربعة", "خمسة", "ستة", "سبعة",
                                     "ثمانيه", "تسعة", "عشرة", "احد عشر", "اثني عشر", "ثلاثة عشر", "اربعة عشر",
                                       "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر"}

                Return arr(n - 1)



            Case 20 To 99
                Dim arr() As String = {"عشرون", "ثلاثون", "اربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون"}
                'textbox1.text.Length

                Return NumberToarb(n Mod 10) & " و " & arr(n \ 10 - 2)







            Case 100 To 199
                If n Mod 100 = 0 AndAlso TextBox1.Text.Length > 5 Then
                    hundreds = False
                    Return " مئة " & " " & NumberToarb(n Mod 100)
                Else
                    hundreds = False
                    Return " مئة و " & " " & NumberToarb(n Mod 100)
                End If



            Case 200 To 299
                If n Mod 100 = 0 AndAlso TextBox1.Text.Length > 3 Then
                    Return " مئتا " & "" & NumberToarb(n Mod 100)
                Else

                    Return " مئتان و " & " " & NumberToarb(n Mod 100)
                End If



            Case 300 To 999


                If n Mod 100 = 0 AndAlso TextBox1.Text.Length > 5 Then
                    hundreds = True
                    Return NumberToarb(n \ 100) & "مئة" & "" & NumberToarb(n Mod 100)
                Else
                    hundreds = True
                    Return NumberToarb(n \ 100) & "مئة و" & "" & NumberToarb(n Mod 100)
                End If



            Case 1000 To 1999
                If TextBox1.Text.Length > 5 Then
                    Return " الف  " & " " & NumberToarb(n Mod 1000)
                Else

                    Return " الف و " & " " & NumberToarb(n Mod 1000)
                End If



            Case 2000 To 2999

                Return " الفان و " & " " & NumberToarb(n Mod 1000)


            Case 3000 To 10999

                Return NumberToarb(n \ 1000) & " الاف و " & " " & NumberToarb(n Mod 1000)





            Case 11000 To 99999

                Return NumberToarb(n \ 1000) & " الفاً و " & " " & NumberToarb(n Mod 1000)

            Case 100000 To 199999
                Return NumberToarb(n \ 1000) & " الف و " & " " & NumberToarb(n Mod 1000)

            Case 200000 To 999999
                Return NumberToarb(n \ 1000) & " الف و " & " " & NumberToarb(n Mod 1000)
            'Case 110000 To 999999
            '    Return NumberToarb(n \ 1000) & " الفاً و " & " " & NumberToarb(n Mod 1000)
            '    '999999
            Case 1000000 To 1999999

                Return " مليون و " & " " & NumberToarb(n Mod 1000000)


            Case 2000000 To 2999999

                Return " مليونان و " & " " & NumberToarb(n Mod 1000000)


            Case 3000000 To 10999999

                Return NumberToarb(n \ 1000000) & " ملايين و " & " " & NumberToarb(n Mod 1000000)


            Case 11000000 To 99999999
                '999999999
                Return NumberToarb(n \ 1000000) & " مليوناً و " & " " & NumberToarb(n Mod 1000000)
            Case 100000000 To 999999999
                Return NumberToarb(n \ 1000000) & " مليون و " & " " & NumberToarb(n Mod 1000000)
                '999999999
            Case 1000000000 To 1999999999

                Return " مليار و " & " " & NumberToarb(n Mod 1000000000)
            Case 2000000000 To 2999999999
                Return " ملياران و " & " " & NumberToarb(n Mod 1000000000)
            Case 3000000000 To 11000000000
                Return NumberToarb(n \ 1000000000) & " مليارات و " & " " & NumberToarb(n Mod 1000000000)
            Case 11000000000 To 99999999999
                '999999999999
                Return NumberToarb(n \ 1000000000) & " ملياراً و " & " " & NumberToarb(n Mod 1000000000)
            Case 10000000000 To 999999999999
                Return NumberToarb(n \ 1000000000) & " مليار و " & " " & NumberToarb(n Mod 1000000000)
            Case 1000000000000 To 1999999999999
                Return " تريليون و " & " " & NumberToarb(n Mod 1000000000000)
            Case 2000000000000 To 2999999999999
                Return " تريليونان و " & " " & NumberToarb(n Mod 1000000000000)
            Case 3000000000000 To 10999999999999
                Return NumberToarb(n \ 1000000000000) & " تريليونات و " & " " & NumberToarb(n Mod 1000000000000)
            Case 11000000000000 To 999999999999999
                Return NumberToarb(n \ 1000000000000) & " ترليوناً و " & " " & NumberToarb(n Mod 1000000000000)
            Case Else

                MsgBox("الرجاء ادخال رقم اقل من كوادرليون!")

                Exit Function
                'Return NumberToarb(n \ 1000000000) & "بليون" _
                '  & NumberToarb(n Mod 1000000000)
        End Select

    End Function

    Function NumberToText(ByVal n As Int64) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundreds " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousands " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Millions " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

#End Region


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged



        If CheckBox1.Checked Then
            only = True
            TextBox2.Text += " فقط لا غير "
        Else
            only = False
        End If




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text IsNot String.Empty Then
            Clipboard.SetText(TextBox2.Text)
        End If

    End Sub
    Private Sub StartRGB()
        RGBMon.SetStatus(True) ' enable RGBMon , equivalend to  .Start()
        RGBMon.SetInterval(2) ' Change color interval, Increase it slower change color
        RGBTimer.Start() ' Enable RGBTimer
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RGBTimer.Tick
        Dim RGBColor As Color = RGBMon.RGBColor ' Current Color
        Label1.ForeColor = RGBColor ' Set color to control
        Label2.ForeColor = RGBColor
        Label3.ForeColor = RGBColor
        'Panel2.BackColor = RGBColor

    End Sub

    Private Sub ايقافالألوانToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ايقافالألوانToolStripMenuItem.Click
        RGBTimer.Stop()
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TextBox2.Text.Contains("اً د") Then

            TextBox2.Text = TextBox2.Text.Replace("اً د", " د")
            'عشرون الفاً ديناراً عراقياً 
        End If

    End Sub
End Class
