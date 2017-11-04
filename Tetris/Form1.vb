'***************************
'*TETRIS CODE BY JACK STEEL*
'***************************


Public Class ParentForm
    Dim Grid(199) As System.Windows.Forms.PictureBox
    Dim NextGrid(15) As System.Windows.Forms.PictureBox
    Dim CurrentShapePositions(3) As Integer
    Dim NextShape As Char
    Dim CurrentShape As Char
    Dim CurrentColour As String
    Dim NextColour As String
    Dim Falling As Boolean
    Dim Moveleft As Boolean
    Dim MoveRight As Boolean
    Dim MoveDown As Boolean
    Dim Rotating As Boolean
    Dim State As Byte = 1
    Dim ianchor As Integer
    Dim PreviousPiece As Integer = 0
    Dim Consecutiverows As Integer = 0
    Dim ClearenceCounter As Integer = 0
    Dim ClearenceThisRun As Integer
    Dim Score As Integer
    Dim ShadowPositions(3) As Integer



    Private Sub LoadGameGridArray()
        NextGrid(0) = Next1
        NextGrid(1) = Next2
        NextGrid(2) = Next3
        NextGrid(3) = Next4
        NextGrid(4) = Next5
        NextGrid(5) = Next6
        NextGrid(6) = Next7
        NextGrid(7) = Next8
        NextGrid(8) = Next9
        NextGrid(9) = Next10
        NextGrid(10) = Next11
        NextGrid(11) = Next12
        NextGrid(12) = Next13
        NextGrid(13) = Next14
        NextGrid(14) = Next15
        NextGrid(15) = Next16

        Grid(0) = Grid1
        Grid(1) = Grid2
        Grid(2) = Grid3
        Grid(3) = Grid4
        Grid(4) = Grid5
        Grid(5) = Grid6
        Grid(6) = Grid7
        Grid(7) = Grid8
        Grid(8) = Grid9
        Grid(9) = Grid10
        Grid(10) = Grid11
        Grid(11) = Grid12
        Grid(12) = Grid13
        Grid(13) = Grid14
        Grid(14) = Grid15
        Grid(15) = Grid16
        Grid(16) = Grid17
        Grid(17) = Grid18
        Grid(18) = Grid19
        Grid(19) = Grid20
        Grid(20) = Grid21
        Grid(21) = Grid22
        Grid(22) = Grid23
        Grid(23) = Grid24
        Grid(24) = Grid25
        Grid(25) = Grid26
        Grid(26) = Grid27
        Grid(27) = Grid28
        Grid(28) = Grid29
        Grid(29) = Grid30
        Grid(30) = Grid31
        Grid(31) = Grid32
        Grid(32) = Grid33
        Grid(33) = Grid34
        Grid(34) = Grid35
        Grid(35) = Grid36
        Grid(36) = Grid37
        Grid(37) = Grid38
        Grid(38) = Grid39
        Grid(39) = Grid40
        Grid(40) = Grid41
        Grid(41) = Grid42
        Grid(42) = Grid43
        Grid(43) = Grid44
        Grid(44) = Grid45
        Grid(45) = Grid46
        Grid(46) = Grid47
        Grid(47) = Grid48
        Grid(48) = Grid49
        Grid(49) = Grid50
        Grid(50) = Grid51
        Grid(51) = Grid52
        Grid(52) = Grid53
        Grid(53) = Grid54
        Grid(54) = Grid55
        Grid(55) = Grid56
        Grid(56) = Grid57
        Grid(57) = Grid58
        Grid(58) = Grid59
        Grid(59) = Grid60
        Grid(60) = Grid61
        Grid(61) = Grid62
        Grid(62) = Grid63
        Grid(63) = Grid64
        Grid(64) = Grid65
        Grid(65) = Grid66
        Grid(66) = Grid67
        Grid(67) = Grid68
        Grid(68) = Grid69
        Grid(69) = Grid70
        Grid(70) = Grid71
        Grid(71) = Grid72
        Grid(72) = Grid73
        Grid(73) = Grid74
        Grid(74) = Grid75
        Grid(75) = Grid76
        Grid(76) = Grid77
        Grid(77) = Grid78
        Grid(78) = Grid79
        Grid(79) = Grid80
        Grid(80) = Grid81
        Grid(81) = Grid82
        Grid(82) = Grid83
        Grid(83) = Grid84
        Grid(84) = Grid85
        Grid(85) = Grid86
        Grid(86) = Grid87
        Grid(87) = Grid88
        Grid(88) = Grid89
        Grid(89) = Grid90
        Grid(90) = Grid91
        Grid(91) = Grid92
        Grid(92) = Grid93
        Grid(93) = Grid94
        Grid(94) = Grid95
        Grid(95) = Grid96
        Grid(96) = Grid97
        Grid(97) = Grid98
        Grid(98) = Grid99
        Grid(99) = Grid100
        Grid(100) = Grid101
        Grid(101) = Grid102
        Grid(102) = Grid103
        Grid(103) = Grid104
        Grid(104) = Grid105
        Grid(105) = Grid106
        Grid(106) = Grid107
        Grid(107) = Grid108
        Grid(108) = Grid109
        Grid(109) = Grid110
        Grid(110) = Grid111
        Grid(111) = Grid112
        Grid(112) = Grid113
        Grid(113) = Grid114
        Grid(114) = Grid115
        Grid(115) = Grid116
        Grid(116) = Grid117
        Grid(117) = Grid118
        Grid(118) = Grid119
        Grid(119) = Grid120
        Grid(120) = Grid121
        Grid(121) = Grid122
        Grid(122) = Grid123
        Grid(123) = Grid124
        Grid(124) = Grid125
        Grid(125) = Grid126
        Grid(126) = Grid127
        Grid(127) = Grid128
        Grid(128) = Grid129
        Grid(129) = Grid130
        Grid(130) = Grid131
        Grid(131) = Grid132
        Grid(132) = Grid133
        Grid(133) = Grid134
        Grid(134) = Grid135
        Grid(135) = Grid136
        Grid(136) = Grid137
        Grid(137) = Grid138
        Grid(138) = Grid139
        Grid(139) = Grid140
        Grid(140) = Grid141
        Grid(141) = Grid142
        Grid(142) = Grid143
        Grid(143) = Grid144
        Grid(144) = Grid145
        Grid(145) = Grid146
        Grid(146) = Grid147
        Grid(147) = Grid148
        Grid(148) = Grid149
        Grid(149) = Grid150
        Grid(150) = Grid151
        Grid(151) = Grid152
        Grid(152) = Grid153
        Grid(153) = Grid154
        Grid(154) = Grid155
        Grid(155) = Grid156
        Grid(156) = Grid157
        Grid(157) = Grid158
        Grid(158) = Grid159
        Grid(159) = Grid160
        Grid(160) = Grid161
        Grid(161) = Grid162
        Grid(162) = Grid163
        Grid(163) = Grid164
        Grid(164) = Grid165
        Grid(165) = Grid166
        Grid(166) = Grid167
        Grid(167) = Grid168
        Grid(168) = Grid169
        Grid(169) = Grid170
        Grid(170) = Grid171
        Grid(171) = Grid172
        Grid(172) = Grid173
        Grid(173) = Grid174
        Grid(174) = Grid175
        Grid(175) = Grid176
        Grid(176) = Grid177
        Grid(177) = Grid178
        Grid(178) = Grid179
        Grid(179) = Grid180
        Grid(180) = Grid181
        Grid(181) = Grid182
        Grid(182) = Grid183
        Grid(183) = Grid184
        Grid(184) = Grid185
        Grid(185) = Grid186
        Grid(186) = Grid187
        Grid(187) = Grid188
        Grid(188) = Grid189
        Grid(189) = Grid190
        Grid(190) = Grid191
        Grid(191) = Grid192
        Grid(192) = Grid193
        Grid(193) = Grid194
        Grid(194) = Grid195
        Grid(195) = Grid196
        Grid(196) = Grid197
        Grid(197) = Grid198
        Grid(198) = Grid199
        Grid(199) = Grid200
        For i = 0 To 199
            Grid(i).Tag = "Empty"
        Next
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        Title.Parent = Me
        LoadGameGridArray()
        My.Computer.Audio.Play(My.Resources.Theme, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Startbtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        Title.Hide()
        lblControls.Hide()
        Exitbtn.Hide()
        GamePanel.Show()
        GamePanel.Left = 0
        GamePanel.Top = 0
        GamePanel.Size = Me.Size
        SettingsBtn.Hide()
        GenerateNextShape()
        SpawnCurrentFromNext()
        GenerateNextShape()
        FallingTimer.Enabled = True
        Mover.Enabled = True
        CheckRows.Enabled = True
        Highscoresbtn.Hide()

    End Sub

    Private Sub GenerateNextShape()
        Dim NextRndNum As Integer
        Dim Valid As Boolean = False
        Do Until Valid = True
            Randomize()
            NextRndNum = Int((7 - 1 + 1) * Rnd() + 1)

            If NextRndNum = PreviousPiece Then
                Valid = False
            Else
                Valid = True
                PreviousPiece = NextRndNum
            End If

        Loop

        Select Case NextRndNum
            Case 1
                NextShape = "i"
                NextColour = "cyan"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                For i = 4 To 7
                    NextGrid(i).Image = My.Resources.CyanTetrisBlock
                Next
            Case 2
                NextShape = "o"
                NextColour = "yellow"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                NextGrid(5).Image = My.Resources.YellowTetrisBlock
                NextGrid(6).Image = My.Resources.YellowTetrisBlock
                NextGrid(9).Image = My.Resources.YellowTetrisBlock
                NextGrid(10).Image = My.Resources.YellowTetrisBlock
            Case 3
                NextShape = "t"
                NextColour = "purple"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                NextGrid(13).Image = My.Resources.PurpleTetrisBlock
                NextGrid(8).Image = My.Resources.PurpleTetrisBlock
                NextGrid(9).Image = My.Resources.PurpleTetrisBlock
                NextGrid(10).Image = My.Resources.PurpleTetrisBlock
            Case 4
                NextShape = "s"
                NextColour = "green"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                NextGrid(4).Image = My.Resources.GreenTetrisBlock
                NextGrid(5).Image = My.Resources.GreenTetrisBlock
                NextGrid(9).Image = My.Resources.GreenTetrisBlock
                NextGrid(10).Image = My.Resources.GreenTetrisBlock
            Case 5
                NextShape = "z"
                NextColour = "red"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                NextGrid(8).Image = My.Resources.RedTetrisBlock
                NextGrid(9).Image = My.Resources.RedTetrisBlock
                NextGrid(5).Image = My.Resources.RedTetrisBlock
                NextGrid(6).Image = My.Resources.RedTetrisBlock
            Case 6
                NextShape = "j"
                NextColour = "blue"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                NextGrid(14).Image = My.Resources.BlueTetrisBlock
                NextGrid(10).Image = My.Resources.BlueTetrisBlock
                NextGrid(6).Image = My.Resources.BlueTetrisBlock
                NextGrid(5).Image = My.Resources.BlueTetrisBlock
            Case 7
                NextShape = "l"
                NextColour = "orange"
                For i = 0 To 15
                    NextGrid(i).Image = Nothing
                Next
                NextGrid(13).Image = My.Resources.OrangeTetrisBlock
                NextGrid(9).Image = My.Resources.OrangeTetrisBlock
                NextGrid(5).Image = My.Resources.OrangeTetrisBlock
                NextGrid(6).Image = My.Resources.OrangeTetrisBlock

        End Select

    End Sub

    Private Sub SpawnCurrentFromNext()
        Select Case NextShape
            Case "i"
                If IsNothing(Grid(193).Image) = True And IsNothing(Grid(194).Image) = True And IsNothing(Grid(195).Image) = True And IsNothing(Grid(196).Image) = True Then
                    Grid(193).Image = My.Resources.CyanTetrisBlock
                    Grid(194).Image = My.Resources.CyanTetrisBlock
                    Grid(195).Image = My.Resources.CyanTetrisBlock
                    Grid(196).Image = My.Resources.CyanTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 193
                    CurrentShapePositions(1) = 194
                    CurrentShapePositions(2) = 195
                    CurrentShapePositions(3) = 196
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Falling = True
                    CurrentShape = "i"
                Else
                    gameover()
                End If

            Case "o"
                If IsNothing(Grid(194).Image) = True And IsNothing(Grid(195).Image) = True And IsNothing(Grid(184).Image) = True And IsNothing(Grid(185).Image) = True Then
                    Grid(194).Image = My.Resources.YellowTetrisBlock
                    Grid(195).Image = My.Resources.YellowTetrisBlock
                    Grid(184).Image = My.Resources.YellowTetrisBlock
                    Grid(185).Image = My.Resources.YellowTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 194
                    CurrentShapePositions(1) = 195
                    CurrentShapePositions(2) = 184
                    CurrentShapePositions(3) = 185
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    CurrentShape = "o"
                    Falling = True
                Else
                    gameover()
                End If

            Case "t"
                If IsNothing(Grid(194).Image) = True And IsNothing(Grid(183).Image) = True And IsNothing(Grid(184).Image) = True And IsNothing(Grid(185).Image) = True Then
                    Grid(194).Image = My.Resources.PurpleTetrisBlock
                    Grid(183).Image = My.Resources.PurpleTetrisBlock
                    Grid(184).Image = My.Resources.PurpleTetrisBlock
                    Grid(185).Image = My.Resources.PurpleTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 194
                    CurrentShapePositions(1) = 183
                    CurrentShapePositions(2) = 184
                    CurrentShapePositions(3) = 185
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    CurrentShape = "t"
                    Falling = True
                Else
                    gameover()
                End If

            Case "s"
                If IsNothing(Grid(194).Image) = True And IsNothing(Grid(195).Image) = True And IsNothing(Grid(184).Image) = True And IsNothing(Grid(183).Image) = True Then
                    Grid(194).Image = My.Resources.GreenTetrisBlock
                    Grid(195).Image = My.Resources.GreenTetrisBlock
                    Grid(184).Image = My.Resources.GreenTetrisBlock
                    Grid(183).Image = My.Resources.GreenTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 194
                    CurrentShapePositions(1) = 195
                    CurrentShapePositions(2) = 184
                    CurrentShapePositions(3) = 183
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    CurrentShape = "s"
                    Falling = True
                Else
                    gameover()
                End If

            Case "z"
                If IsNothing(Grid(193).Image) = True And IsNothing(Grid(194).Image) = True And IsNothing(Grid(184).Image) = True And IsNothing(Grid(185).Image) = True Then
                    Grid(193).Image = My.Resources.RedTetrisBlock
                    Grid(194).Image = My.Resources.RedTetrisBlock
                    Grid(184).Image = My.Resources.RedTetrisBlock
                    Grid(185).Image = My.Resources.RedTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 193
                    CurrentShapePositions(1) = 194
                    CurrentShapePositions(2) = 184
                    CurrentShapePositions(3) = 185
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    CurrentShape = "z"
                    Falling = True
                Else
                    gameover()
                End If

            Case "j"
                If IsNothing(Grid(185).Image) = True And IsNothing(Grid(184).Image) = True And IsNothing(Grid(183).Image) = True And IsNothing(Grid(193).Image) = True Then
                    Grid(185).Image = My.Resources.BlueTetrisBlock
                    Grid(184).Image = My.Resources.BlueTetrisBlock
                    Grid(183).Image = My.Resources.BlueTetrisBlock
                    Grid(193).Image = My.Resources.BlueTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 185
                    CurrentShapePositions(1) = 184
                    CurrentShapePositions(2) = 183
                    CurrentShapePositions(3) = 193
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    CurrentShape = "j"
                    Falling = True
                Else
                    gameover()
                End If

            Case "l"
                If IsNothing(Grid(183).Image) = True And IsNothing(Grid(184).Image) = True And IsNothing(Grid(185).Image) = True And IsNothing(Grid(195).Image) = True Then
                    Grid(183).Image = My.Resources.OrangeTetrisBlock
                    Grid(184).Image = My.Resources.OrangeTetrisBlock
                    Grid(185).Image = My.Resources.OrangeTetrisBlock
                    Grid(195).Image = My.Resources.OrangeTetrisBlock
                    State = 1
                    CurrentShapePositions(0) = 183
                    CurrentShapePositions(1) = 184
                    CurrentShapePositions(2) = 185
                    CurrentShapePositions(3) = 195
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    CurrentShape = "l"
                    Falling = True
                Else
                    gameover()

                End If
        End Select
        DisplayFinalDropPos()
    End Sub

    Private Sub FallingTimer_Tick(sender As Object, e As EventArgs) Handles FallingTimer.Tick

        If Falling = True Then

            For i = 0 To 3
                If CurrentShapePositions(i) - 10 < 0 Then
                    Falling = False
                    Grid(CurrentShapePositions(0)).Tag = "Full"
                    Grid(CurrentShapePositions(1)).Tag = "Full"
                    Grid(CurrentShapePositions(2)).Tag = "Full"
                    Grid(CurrentShapePositions(3)).Tag = "Full"

                ElseIf Grid(CurrentShapePositions(i) - 10).Tag = "Full" Then
                    Falling = False
                    Grid(CurrentShapePositions(0)).Tag = "Full"
                    Grid(CurrentShapePositions(1)).Tag = "Full"
                    Grid(CurrentShapePositions(2)).Tag = "Full"
                    Grid(CurrentShapePositions(3)).Tag = "Full"

                End If
            Next

            If Falling = True Then
                For i = 0 To 3
                    Grid(CurrentShapePositions(i)).Image = Nothing
                    Grid(CurrentShapePositions(i)).Tag = "Empty"
                Next
                For i = 0 To 3
                    CurrentShapePositions(i) = (CurrentShapePositions(i) - 10)
                Next




                Select Case CurrentShape
                    Case "i"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "o"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.YellowTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.YellowTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.YellowTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.YellowTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "t"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "s"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "z"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "j"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "l"
                        Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                End Select

            Else
                SpawnCurrentFromNext()
                GenerateNextShape()
            End If
        End If
        DisplayFinalDropPos()
    End Sub


    Private Sub MovePiece(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.ToString = "D" Then
            MoveRight = True
        End If
        If e.KeyCode.ToString = "A" Then
            Moveleft = True
        End If
        If e.KeyCode.ToString = "S" Then
            MoveDown = True
        End If
        If e.KeyCode.ToString = "R" Then
            Rotating = True
        End If
        If e.KeyCode.ToString = "W" Then
            Rotating = True
        End If
        If e.KeyCode = Keys.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub StopPiece(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode.ToString = "D" Then
            MoveRight = False
        End If
        If e.KeyCode.ToString = "A" Then
            Moveleft = False
        End If
        If e.KeyCode.ToString = "R" Then
            Rotating = False
        End If
        If e.KeyCode.ToString = "W" Then
            Rotating = False
        End If
        If e.KeyCode.ToString = "S" Then
            MoveDown = False
        End If
    End Sub

    Private Sub Mover_Tick(sender As Object, e As EventArgs) Handles Mover.Tick
        Dim MoveLeftToFixRotation As Boolean = False
        Dim MoveRightToFixRotation As Boolean = False





        Scorelbl.Text = "Score: " & Score
        If MoveRight = True Then
            Try
                For i = 0 To 3
                    If CurrentShapePositions(i) = 9 Or CurrentShapePositions(i) = 19 Or CurrentShapePositions(i) = 29 Or CurrentShapePositions(i) = 39 Or CurrentShapePositions(i) = 49 Or CurrentShapePositions(i) = 59 Or CurrentShapePositions(i) = 69 Or CurrentShapePositions(i) = 79 Or CurrentShapePositions(i) = 89 Or CurrentShapePositions(i) = 99 Or CurrentShapePositions(i) = 109 Or CurrentShapePositions(i) = 119 Or CurrentShapePositions(i) = 129 Or CurrentShapePositions(i) = 139 Or CurrentShapePositions(i) = 149 Or CurrentShapePositions(i) = 159 Or CurrentShapePositions(i) = 169 Or CurrentShapePositions(i) = 179 Or CurrentShapePositions(i) = 189 Or CurrentShapePositions(i) = 199 Then
                        MoveRight = False
                    End If
                    If Grid(CurrentShapePositions(i) + 1).Tag = "Full" Then
                        If Not CurrentShapePositions(i) = 9 Or CurrentShapePositions(i) = 19 Or CurrentShapePositions(i) = 29 Or CurrentShapePositions(i) = 39 Or CurrentShapePositions(i) = 49 Or CurrentShapePositions(i) = 59 Or CurrentShapePositions(i) = 69 Or CurrentShapePositions(i) = 79 Or CurrentShapePositions(i) = 89 Or CurrentShapePositions(i) = 99 Or CurrentShapePositions(i) = 109 Or CurrentShapePositions(i) = 119 Or CurrentShapePositions(i) = 129 Or CurrentShapePositions(i) = 139 Or CurrentShapePositions(i) = 149 Or CurrentShapePositions(i) = 159 Or CurrentShapePositions(i) = 169 Or CurrentShapePositions(i) = 179 Or CurrentShapePositions(i) = 189 Or CurrentShapePositions(i) = 199 Then
                            MoveRight = False
                        End If
                    End If

                Next
            Catch ex As Exception

            End Try

        End If
        If Moveleft = True Then
            Try
                For i = 0 To 3
                    If CurrentShapePositions(i) = 0 Or CurrentShapePositions(i) = 10 Or CurrentShapePositions(i) = 20 Or CurrentShapePositions(i) = 30 Or CurrentShapePositions(i) = 40 Or CurrentShapePositions(i) = 50 Or CurrentShapePositions(i) = 60 Or CurrentShapePositions(i) = 70 Or CurrentShapePositions(i) = 80 Or CurrentShapePositions(i) = 90 Or CurrentShapePositions(i) = 100 Or CurrentShapePositions(i) = 110 Or CurrentShapePositions(i) = 120 Or CurrentShapePositions(i) = 130 Or CurrentShapePositions(i) = 140 Or CurrentShapePositions(i) = 150 Or CurrentShapePositions(i) = 160 Or CurrentShapePositions(i) = 170 Or CurrentShapePositions(i) = 180 Or CurrentShapePositions(i) = 190 Then
                        Moveleft = False
                    End If
                    If Grid(CurrentShapePositions(i) - 1).Tag = "Full" Then
                        If Not CurrentShapePositions(i) = 0 Or CurrentShapePositions(i) = 10 Or CurrentShapePositions(i) = 20 Or CurrentShapePositions(i) = 30 Or CurrentShapePositions(i) = 40 Or CurrentShapePositions(i) = 50 Or CurrentShapePositions(i) = 60 Or CurrentShapePositions(i) = 70 Or CurrentShapePositions(i) = 80 Or CurrentShapePositions(i) = 90 Or CurrentShapePositions(i) = 100 Or CurrentShapePositions(i) = 110 Or CurrentShapePositions(i) = 120 Or CurrentShapePositions(i) = 130 Or CurrentShapePositions(i) = 140 Or CurrentShapePositions(i) = 150 Or CurrentShapePositions(i) = 160 Or CurrentShapePositions(i) = 170 Or CurrentShapePositions(i) = 180 Or CurrentShapePositions(i) = 190 Then
                            Moveleft = False
                        End If
                    End If
                Next
            Catch ex As Exception

            End Try

        End If

        If MoveDown = True Then
            Try
                For i = 0 To 3
                    If (CurrentShapePositions(i) - 10) < 10 Then
                        MoveDown = False
                    ElseIf Grid(CurrentShapePositions(i) - 10).Tag = "Full" Then
                        MoveDown = False
                    End If

                Next
            Catch ex As Exception

            End Try

        End If


        'CANCEL ROTATION? CHECK ---- VERY IMPORTANT

        If Rotating = True Then
            Select Case CurrentShape
                Case "i"
                    If State = 2 Or State = 4 Then
                        For i = 0 To 3
                            If CurrentShapePositions(i) = 9 Or CurrentShapePositions(i) = 19 Or CurrentShapePositions(i) = 29 Or CurrentShapePositions(i) = 39 Or CurrentShapePositions(i) = 49 Or CurrentShapePositions(i) = 59 Or CurrentShapePositions(i) = 69 Or CurrentShapePositions(i) = 79 Or CurrentShapePositions(i) = 89 Or CurrentShapePositions(i) = 99 Or CurrentShapePositions(i) = 109 Or CurrentShapePositions(i) = 119 Or CurrentShapePositions(i) = 129 Or CurrentShapePositions(i) = 139 Or CurrentShapePositions(i) = 149 Or CurrentShapePositions(i) = 159 Or CurrentShapePositions(i) = 169 Or CurrentShapePositions(i) = 179 Or CurrentShapePositions(i) = 189 Or CurrentShapePositions(i) = 199 Then
                                Rotating = False
                            ElseIf CurrentShapePositions(i) = 0 Or CurrentShapePositions(i) = 10 Or CurrentShapePositions(i) = 20 Or CurrentShapePositions(i) = 30 Or CurrentShapePositions(i) = 40 Or CurrentShapePositions(i) = 50 Or CurrentShapePositions(i) = 60 Or CurrentShapePositions(i) = 70 Or CurrentShapePositions(i) = 80 Or CurrentShapePositions(i) = 90 Or CurrentShapePositions(i) = 100 Or CurrentShapePositions(i) = 110 Or CurrentShapePositions(i) = 120 Or CurrentShapePositions(i) = 130 Or CurrentShapePositions(i) = 140 Or CurrentShapePositions(i) = 150 Or CurrentShapePositions(i) = 160 Or CurrentShapePositions(i) = 170 Or CurrentShapePositions(i) = 180 Or CurrentShapePositions(i) = 190 Then
                                Rotating = False
                            End If
                            If State = 4 And (CurrentShapePositions(2) = 8 Or CurrentShapePositions(2) = 18 Or CurrentShapePositions(2) = 28 Or CurrentShapePositions(2) = 38 Or CurrentShapePositions(2) = 48 Or CurrentShapePositions(2) = 58 Or CurrentShapePositions(2) = 68 Or CurrentShapePositions(2) = 78 Or CurrentShapePositions(2) = 88 Or CurrentShapePositions(2) = 98 Or CurrentShapePositions(2) = 108 Or CurrentShapePositions(2) = 118 Or CurrentShapePositions(2) = 128 Or CurrentShapePositions(2) = 138 Or CurrentShapePositions(2) = 148 Or CurrentShapePositions(2) = 158 Or CurrentShapePositions(2) = 168 Or CurrentShapePositions(2) = 178 Or CurrentShapePositions(2) = 188 Or CurrentShapePositions(2) = 198) Then
                                Rotating = False
                            ElseIf State = 2 And (CurrentShapePositions(2) = 1 Or CurrentShapePositions(2) = 11 Or CurrentShapePositions(2) = 21 Or CurrentShapePositions(2) = 31 Or CurrentShapePositions(2) = 41 Or CurrentShapePositions(2) = 51 Or CurrentShapePositions(2) = 61 Or CurrentShapePositions(2) = 71 Or CurrentShapePositions(2) = 81 Or CurrentShapePositions(2) = 91 Or CurrentShapePositions(2) = 101 Or CurrentShapePositions(2) = 111 Or CurrentShapePositions(2) = 121 Or CurrentShapePositions(2) = 131 Or CurrentShapePositions(2) = 141 Or CurrentShapePositions(2) = 151 Or CurrentShapePositions(2) = 161 Or CurrentShapePositions(2) = 171 Or CurrentShapePositions(2) = 181 Or CurrentShapePositions(2) = 191) Then
                                Rotating = False
                            End If
                        Next
                    End If
                    If State = 1 Or 3 Then
                        For i = 0 To 3
                            If CurrentShapePositions(i) <= 20 Then
                                Rotating = False
                            End If
                        Next
                    End If
                Case "t"
                    If State = 2 Or 4 Then
                        If CurrentShapePositions(2) = 0 Or CurrentShapePositions(2) = 10 Or CurrentShapePositions(2) = 20 Or CurrentShapePositions(2) = 30 Or CurrentShapePositions(2) = 40 Or CurrentShapePositions(2) = 50 Or CurrentShapePositions(2) = 60 Or CurrentShapePositions(2) = 70 Or CurrentShapePositions(2) = 80 Or CurrentShapePositions(2) = 90 Or CurrentShapePositions(2) = 100 Or CurrentShapePositions(2) = 110 Or CurrentShapePositions(2) = 120 Or CurrentShapePositions(2) = 130 Or CurrentShapePositions(2) = 140 Or CurrentShapePositions(2) = 150 Or CurrentShapePositions(2) = 160 Or CurrentShapePositions(2) = 170 Or CurrentShapePositions(2) = 180 Or CurrentShapePositions(2) = 190 Then
                            MoveRightToFixRotation = True
                        ElseIf CurrentShapePositions(2) = 9 Or CurrentShapePositions(2) = 19 Or CurrentShapePositions(2) = 29 Or CurrentShapePositions(2) = 39 Or CurrentShapePositions(2) = 49 Or CurrentShapePositions(2) = 59 Or CurrentShapePositions(2) = 69 Or CurrentShapePositions(2) = 79 Or CurrentShapePositions(2) = 89 Or CurrentShapePositions(2) = 99 Or CurrentShapePositions(2) = 109 Or CurrentShapePositions(2) = 119 Or CurrentShapePositions(2) = 129 Or CurrentShapePositions(2) = 139 Or CurrentShapePositions(2) = 149 Or CurrentShapePositions(2) = 159 Or CurrentShapePositions(2) = 169 Or CurrentShapePositions(2) = 179 Or CurrentShapePositions(2) = 189 Or CurrentShapePositions(2) = 199 Then
                            MoveLeftToFixRotation = True
                        End If

                    End If

                    If MoveRightToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) + 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then

                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) + 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) + 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) + 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) + 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If


                    End If
                    If MoveLeftToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) - 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) - 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) - 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) - 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) - 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If

                    End If

                Case "s"
                    If State = 2 Or 4 Then
                        If CurrentShapePositions(2) = 0 Or CurrentShapePositions(2) = 10 Or CurrentShapePositions(2) = 20 Or CurrentShapePositions(2) = 30 Or CurrentShapePositions(2) = 40 Or CurrentShapePositions(2) = 50 Or CurrentShapePositions(2) = 60 Or CurrentShapePositions(2) = 70 Or CurrentShapePositions(2) = 80 Or CurrentShapePositions(2) = 90 Or CurrentShapePositions(2) = 100 Or CurrentShapePositions(2) = 110 Or CurrentShapePositions(2) = 120 Or CurrentShapePositions(2) = 130 Or CurrentShapePositions(2) = 140 Or CurrentShapePositions(2) = 150 Or CurrentShapePositions(2) = 160 Or CurrentShapePositions(2) = 170 Or CurrentShapePositions(2) = 180 Or CurrentShapePositions(2) = 190 Then
                            MoveRightToFixRotation = True
                        ElseIf CurrentShapePositions(2) = 9 Or CurrentShapePositions(2) = 19 Or CurrentShapePositions(2) = 29 Or CurrentShapePositions(2) = 39 Or CurrentShapePositions(2) = 49 Or CurrentShapePositions(2) = 59 Or CurrentShapePositions(2) = 69 Or CurrentShapePositions(2) = 79 Or CurrentShapePositions(2) = 89 Or CurrentShapePositions(2) = 99 Or CurrentShapePositions(2) = 109 Or CurrentShapePositions(2) = 119 Or CurrentShapePositions(2) = 129 Or CurrentShapePositions(2) = 139 Or CurrentShapePositions(2) = 149 Or CurrentShapePositions(2) = 159 Or CurrentShapePositions(2) = 169 Or CurrentShapePositions(2) = 179 Or CurrentShapePositions(2) = 189 Or CurrentShapePositions(2) = 199 Then
                            MoveLeftToFixRotation = True
                        End If
                    End If
                    If MoveRightToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) + 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) + 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) + 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) + 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) + 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If


                    End If
                    If MoveLeftToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) - 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) - 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) - 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) - 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) - 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If

                    End If
                Case "z"
                    If State = 2 Or 4 Then
                        If CurrentShapePositions(2) = 0 Or CurrentShapePositions(2) = 10 Or CurrentShapePositions(2) = 20 Or CurrentShapePositions(2) = 30 Or CurrentShapePositions(2) = 40 Or CurrentShapePositions(2) = 50 Or CurrentShapePositions(2) = 60 Or CurrentShapePositions(2) = 70 Or CurrentShapePositions(2) = 80 Or CurrentShapePositions(2) = 90 Or CurrentShapePositions(2) = 100 Or CurrentShapePositions(2) = 110 Or CurrentShapePositions(2) = 120 Or CurrentShapePositions(2) = 130 Or CurrentShapePositions(2) = 140 Or CurrentShapePositions(2) = 150 Or CurrentShapePositions(2) = 160 Or CurrentShapePositions(2) = 170 Or CurrentShapePositions(2) = 180 Or CurrentShapePositions(2) = 190 Then
                            MoveRightToFixRotation = True
                        ElseIf CurrentShapePositions(2) = 9 Or CurrentShapePositions(2) = 19 Or CurrentShapePositions(2) = 29 Or CurrentShapePositions(2) = 39 Or CurrentShapePositions(2) = 49 Or CurrentShapePositions(2) = 59 Or CurrentShapePositions(2) = 69 Or CurrentShapePositions(2) = 79 Or CurrentShapePositions(2) = 89 Or CurrentShapePositions(2) = 99 Or CurrentShapePositions(2) = 109 Or CurrentShapePositions(2) = 119 Or CurrentShapePositions(2) = 129 Or CurrentShapePositions(2) = 139 Or CurrentShapePositions(2) = 149 Or CurrentShapePositions(2) = 159 Or CurrentShapePositions(2) = 169 Or CurrentShapePositions(2) = 179 Or CurrentShapePositions(2) = 189 Or CurrentShapePositions(2) = 199 Then
                            MoveLeftToFixRotation = True
                        End If
                    End If
                    If MoveRightToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) + 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) + 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) + 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) + 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) + 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If
                    End If


                    If MoveLeftToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) - 1).Tag = "Full" Then
                                Rotating = False
                            End If

                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) - 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) - 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) - 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) - 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If
                    End If
                Case "j"
                    If State = 2 Or 4 Then
                        If CurrentShapePositions(1) = 0 Or CurrentShapePositions(1) = 10 Or CurrentShapePositions(1) = 20 Or CurrentShapePositions(1) = 30 Or CurrentShapePositions(1) = 40 Or CurrentShapePositions(1) = 50 Or CurrentShapePositions(1) = 60 Or CurrentShapePositions(1) = 70 Or CurrentShapePositions(1) = 80 Or CurrentShapePositions(1) = 90 Or CurrentShapePositions(1) = 100 Or CurrentShapePositions(1) = 110 Or CurrentShapePositions(1) = 120 Or CurrentShapePositions(1) = 130 Or CurrentShapePositions(1) = 140 Or CurrentShapePositions(1) = 150 Or CurrentShapePositions(1) = 160 Or CurrentShapePositions(1) = 170 Or CurrentShapePositions(1) = 180 Or CurrentShapePositions(1) = 190 Then
                            MoveRightToFixRotation = True
                        ElseIf CurrentShapePositions(1) = 9 Or CurrentShapePositions(1) = 19 Or CurrentShapePositions(1) = 29 Or CurrentShapePositions(1) = 39 Or CurrentShapePositions(1) = 49 Or CurrentShapePositions(1) = 59 Or CurrentShapePositions(1) = 69 Or CurrentShapePositions(1) = 79 Or CurrentShapePositions(1) = 89 Or CurrentShapePositions(1) = 99 Or CurrentShapePositions(1) = 109 Or CurrentShapePositions(1) = 119 Or CurrentShapePositions(1) = 129 Or CurrentShapePositions(1) = 139 Or CurrentShapePositions(1) = 149 Or CurrentShapePositions(1) = 159 Or CurrentShapePositions(1) = 169 Or CurrentShapePositions(1) = 179 Or CurrentShapePositions(1) = 189 Or CurrentShapePositions(1) = 199 Then
                            MoveLeftToFixRotation = True
                        End If
                    End If
                    If MoveRightToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) + 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) + 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) + 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) + 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) + 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If
                    End If


                    If MoveLeftToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) - 1).Tag = "Full" Then
                                Rotating = False
                            End If

                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) - 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) - 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) - 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) - 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If
                    End If
                Case "l"
                    If State = 2 Or 4 Then
                        If CurrentShapePositions(1) = 0 Or CurrentShapePositions(1) = 10 Or CurrentShapePositions(1) = 20 Or CurrentShapePositions(1) = 30 Or CurrentShapePositions(1) = 40 Or CurrentShapePositions(1) = 50 Or CurrentShapePositions(1) = 60 Or CurrentShapePositions(1) = 70 Or CurrentShapePositions(1) = 80 Or CurrentShapePositions(1) = 90 Or CurrentShapePositions(1) = 100 Or CurrentShapePositions(1) = 110 Or CurrentShapePositions(1) = 120 Or CurrentShapePositions(1) = 130 Or CurrentShapePositions(1) = 140 Or CurrentShapePositions(1) = 150 Or CurrentShapePositions(1) = 160 Or CurrentShapePositions(1) = 170 Or CurrentShapePositions(1) = 180 Or CurrentShapePositions(1) = 190 Then
                            MoveRightToFixRotation = True
                        ElseIf CurrentShapePositions(1) = 9 Or CurrentShapePositions(1) = 19 Or CurrentShapePositions(1) = 29 Or CurrentShapePositions(1) = 39 Or CurrentShapePositions(1) = 49 Or CurrentShapePositions(1) = 59 Or CurrentShapePositions(1) = 69 Or CurrentShapePositions(1) = 79 Or CurrentShapePositions(1) = 89 Or CurrentShapePositions(1) = 99 Or CurrentShapePositions(1) = 109 Or CurrentShapePositions(1) = 119 Or CurrentShapePositions(1) = 129 Or CurrentShapePositions(1) = 139 Or CurrentShapePositions(1) = 149 Or CurrentShapePositions(1) = 159 Or CurrentShapePositions(1) = 169 Or CurrentShapePositions(1) = 179 Or CurrentShapePositions(1) = 189 Or CurrentShapePositions(1) = 199 Then
                            MoveLeftToFixRotation = True
                        End If
                    End If
                    If MoveRightToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) + 1).Tag = "Full" Then
                                Rotating = False
                            End If
                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) + 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) + 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) + 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) + 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If
                    End If


                    If MoveLeftToFixRotation = True Then
                        For i = 0 To 3
                            If Grid(CurrentShapePositions(i) - 1).Tag = "Full" Then
                                Rotating = False
                            End If

                        Next
                        If Rotating = True Then
                            Grid(CurrentShapePositions(0)).Image = Nothing
                            Grid(CurrentShapePositions(0)).Tag = "Empty"
                            Grid(CurrentShapePositions(1)).Image = Nothing
                            Grid(CurrentShapePositions(1)).Tag = "Empty"
                            Grid(CurrentShapePositions(2)).Image = Nothing
                            Grid(CurrentShapePositions(2)).Tag = "Empty"
                            Grid(CurrentShapePositions(3)).Image = Nothing
                            Grid(CurrentShapePositions(3)).Tag = "Empty"
                            CurrentShapePositions(0) = CurrentShapePositions(0) - 1
                            CurrentShapePositions(1) = CurrentShapePositions(1) - 1
                            CurrentShapePositions(2) = CurrentShapePositions(2) - 1
                            CurrentShapePositions(3) = CurrentShapePositions(3) - 1
                            Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                            Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                            Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                        End If
                    End If
            End Select
        End If





        If MoveRight = True Then
            Grid(CurrentShapePositions(0)).Image = Nothing
            Grid(CurrentShapePositions(0)).Tag = "Empty"
            Grid(CurrentShapePositions(1)).Image = Nothing
            Grid(CurrentShapePositions(1)).Tag = "Empty"
            Grid(CurrentShapePositions(2)).Image = Nothing
            Grid(CurrentShapePositions(2)).Tag = "Empty"
            Grid(CurrentShapePositions(3)).Image = Nothing
            Grid(CurrentShapePositions(3)).Tag = "Empty"
            CurrentShapePositions(0) = CurrentShapePositions(0) + 1
            CurrentShapePositions(1) = CurrentShapePositions(1) + 1
            CurrentShapePositions(2) = CurrentShapePositions(2) + 1
            CurrentShapePositions(3) = CurrentShapePositions(3) + 1
            Select Case CurrentShape
                Case "i"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "o"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "t"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "s"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "z"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "j"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "l"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
            End Select
        ElseIf Moveleft = True Then
            Grid(CurrentShapePositions(0)).Image = Nothing
            Grid(CurrentShapePositions(0)).Tag = "Empty"
            Grid(CurrentShapePositions(1)).Image = Nothing
            Grid(CurrentShapePositions(1)).Tag = "Empty"
            Grid(CurrentShapePositions(2)).Image = Nothing
            Grid(CurrentShapePositions(2)).Tag = "Empty"
            Grid(CurrentShapePositions(3)).Image = Nothing
            Grid(CurrentShapePositions(3)).Tag = "Empty"
            CurrentShapePositions(0) = CurrentShapePositions(0) - 1
            CurrentShapePositions(1) = CurrentShapePositions(1) - 1
            CurrentShapePositions(2) = CurrentShapePositions(2) - 1
            CurrentShapePositions(3) = CurrentShapePositions(3) - 1
            Select Case CurrentShape
                Case "i"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "o"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "t"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "s"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "z"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "j"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "l"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
            End Select
            DisplayFinalDropPos()
        End If
        If MoveDown = True Then
            Grid(CurrentShapePositions(0)).Image = Nothing
            Grid(CurrentShapePositions(0)).Tag = "Empty"
            Grid(CurrentShapePositions(1)).Image = Nothing
            Grid(CurrentShapePositions(1)).Tag = "Empty"
            Grid(CurrentShapePositions(2)).Image = Nothing
            Grid(CurrentShapePositions(2)).Tag = "Empty"
            Grid(CurrentShapePositions(3)).Image = Nothing
            Grid(CurrentShapePositions(3)).Tag = "Empty"
            CurrentShapePositions(0) = CurrentShapePositions(0) - 10
            CurrentShapePositions(1) = CurrentShapePositions(1) - 10
            CurrentShapePositions(2) = CurrentShapePositions(2) - 10
            CurrentShapePositions(3) = CurrentShapePositions(3) - 10
            Score = Score + 1
            Select Case CurrentShape
                Case "i"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.CyanTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "o"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.YellowTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "t"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "s"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "z"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "j"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                Case "l"
                    Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                    Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                    Grid(CurrentShapePositions(3)).Tag = "FullFalling"
            End Select
            DisplayFinalDropPos()
        End If


        '------------------------------------------------------------ROTATION------------------------------------------------------------------------

        If Rotating = True Then
            Try

                Select Case CurrentShape
                    Case "i"
                        Grid(CurrentShapePositions(0)).Image = Nothing
                        Grid(CurrentShapePositions(0)).Tag = "Empty"
                        Grid(CurrentShapePositions(1)).Image = Nothing
                        Grid(CurrentShapePositions(1)).Tag = "Empty"
                        Grid(CurrentShapePositions(2)).Image = Nothing
                        Grid(CurrentShapePositions(2)).Tag = "Empty"
                        Grid(CurrentShapePositions(3)).Image = Nothing
                        Grid(CurrentShapePositions(3)).Tag = "Empty"
                        Try

                            If State = 1 Then
                                ianchor = CurrentShapePositions(1) - 10
                                If Grid(ianchor + 21).Tag = "Full" Or Grid(ianchor + 11).Tag = "Full" Or Grid(ianchor + 1).Tag = "Full" Or Grid(ianchor - 9).Tag = "Full" Then
                                    Rotating = False
                                Else
                                    CurrentShapePositions(0) = ianchor + 21
                                    CurrentShapePositions(1) = ianchor + 11
                                    CurrentShapePositions(2) = ianchor + 1
                                    CurrentShapePositions(3) = ianchor - 9

                                    State = 2
                                    Rotating = False
                                End If

                            ElseIf State = 2 Then
                                ianchor = CurrentShapePositions(1) - 1
                                If Grid(ianchor - 8).Tag = "Full" Or Grid(ianchor - 9).Tag = "Full" Or Grid(ianchor - 10).Tag = "Full" Or Grid(ianchor - 11).Tag = "Full" Then
                                    Rotating = False
                                Else
                                    CurrentShapePositions(0) = ianchor - 8
                                    CurrentShapePositions(1) = ianchor - 9
                                    CurrentShapePositions(2) = ianchor - 10
                                    CurrentShapePositions(3) = ianchor - 11
                                    State = 3
                                    Rotating = False
                                End If


                            ElseIf State = 3 Then
                                ianchor = CurrentShapePositions(1) + 10
                                If Grid(ianchor - 21).Tag = "Full" Or Grid(ianchor - 11).Tag = "Full" Or Grid(ianchor - 1).Tag = "Full" Or Grid(ianchor + 9).Tag = "Full" Then
                                    Rotating = False
                                Else
                                    CurrentShapePositions(0) = ianchor - 21
                                    CurrentShapePositions(1) = ianchor - 11
                                    CurrentShapePositions(2) = ianchor - 1
                                    CurrentShapePositions(3) = ianchor + 9

                                    State = 4
                                    Rotating = False
                                End If
                            ElseIf State = 4 Then
                                ianchor = CurrentShapePositions(1) + 1
                                If Grid(ianchor + 8).Tag = "Full" Or Grid(ianchor + 9).Tag = "Full" Or Grid(ianchor + 10).Tag = "Full" Or Grid(ianchor + 11).Tag = "Full" Then
                                    Rotating = False
                                Else
                                    CurrentShapePositions(0) = ianchor + 8
                                    CurrentShapePositions(1) = ianchor + 9
                                    CurrentShapePositions(2) = ianchor + 10
                                    CurrentShapePositions(3) = ianchor + 11

                                    State = 1
                                    Rotating = False
                                End If
                            End If
                        Catch ex As Exception
                            Rotating = False
                        End Try

                        Grid(CurrentShapePositions(0)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.CyanTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"

                    Case "t"
                        Grid(CurrentShapePositions(0)).Image = Nothing
                        Grid(CurrentShapePositions(0)).Tag = "Empty"
                        Grid(CurrentShapePositions(1)).Image = Nothing
                        Grid(CurrentShapePositions(1)).Tag = "Empty"
                        Grid(CurrentShapePositions(2)).Image = Nothing
                        Grid(CurrentShapePositions(2)).Tag = "Empty"
                        Grid(CurrentShapePositions(3)).Image = Nothing
                        Grid(CurrentShapePositions(3)).Tag = "Empty"

                        If State = 1 Then
                            If Grid(CurrentShapePositions(2) + 10).Tag = "Full" Or Grid(CurrentShapePositions(2) - 10).Tag = "Full" Or Grid(CurrentShapePositions(2) + 1).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) + 10
                                CurrentShapePositions(3) = CurrentShapePositions(2) - 10
                                CurrentShapePositions(0) = CurrentShapePositions(2) + 1

                                State = 2
                                Rotating = False
                            End If


                        ElseIf State = 2 Then
                            If Grid(CurrentShapePositions(2) + 1).Tag = "Full" Or Grid(CurrentShapePositions(2) - 1).Tag = "Full" Or Grid(CurrentShapePositions(2) - 10).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) + 1
                                CurrentShapePositions(3) = CurrentShapePositions(2) - 1
                                CurrentShapePositions(0) = CurrentShapePositions(2) - 10

                                State = 3
                                Rotating = False
                            End If
                        ElseIf State = 3 Then
                            If Grid(CurrentShapePositions(2) - 10).Tag = "Full" Or Grid(CurrentShapePositions(2) + 10).Tag = "Full" Or Grid(CurrentShapePositions(2) - 1).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) - 10
                                CurrentShapePositions(3) = CurrentShapePositions(2) + 10
                                CurrentShapePositions(0) = CurrentShapePositions(2) - 1

                                State = 4
                                Rotating = False
                            End If
                        ElseIf State = 4 Then
                            If Grid(CurrentShapePositions(2) - 1).Tag = "Full" Or Grid(CurrentShapePositions(2) + 1).Tag = "Full" Or Grid(CurrentShapePositions(2) + 10).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) - 1
                                CurrentShapePositions(3) = CurrentShapePositions(2) + 1
                                CurrentShapePositions(0) = CurrentShapePositions(2) + 10

                                State = 1
                                Rotating = False
                            End If

                        End If
                        Grid(CurrentShapePositions(0)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.PurpleTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"

                    Case "s"
                        Grid(CurrentShapePositions(0)).Image = Nothing
                        Grid(CurrentShapePositions(0)).Tag = "Empty"
                        Grid(CurrentShapePositions(1)).Image = Nothing
                        Grid(CurrentShapePositions(1)).Tag = "Empty"
                        Grid(CurrentShapePositions(2)).Image = Nothing
                        Grid(CurrentShapePositions(2)).Tag = "Empty"
                        Grid(CurrentShapePositions(3)).Image = Nothing
                        Grid(CurrentShapePositions(3)).Tag = "Empty"

                        If State = 1 Then
                            If Grid(CurrentShapePositions(2) - 9).Tag = "Full" Or Grid(CurrentShapePositions(2) + 1).Tag = "Full" Or Grid(CurrentShapePositions(2) + 10).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) - 9
                                CurrentShapePositions(0) = CurrentShapePositions(2) + 1
                                CurrentShapePositions(3) = CurrentShapePositions(2) + 10

                                State = 2
                                Rotating = False
                            End If

                        ElseIf State = 2 Then
                            If Grid(CurrentShapePositions(2) - 11).Tag = "Full" Or Grid(CurrentShapePositions(2) - 10).Tag = "Full" Or Grid(CurrentShapePositions(2) + 1).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) - 11
                                CurrentShapePositions(0) = CurrentShapePositions(2) - 10
                                CurrentShapePositions(3) = CurrentShapePositions(2) + 1

                                State = 3
                                Rotating = False
                            End If
                        ElseIf State = 3 Then
                            If Grid(CurrentShapePositions(2) + 9).Tag = "Full" Or Grid(CurrentShapePositions(2) - 1).Tag = "Full" Or Grid(CurrentShapePositions(2) - 10).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) + 9
                                CurrentShapePositions(0) = CurrentShapePositions(2) - 1
                                CurrentShapePositions(3) = CurrentShapePositions(2) - 10

                                State = 4
                                Rotating = False
                            End If
                        ElseIf State = 4 Then
                            If Grid(CurrentShapePositions(2) + 11).Tag = "Full" Or Grid(CurrentShapePositions(2) + 10).Tag = "Full" Or Grid(CurrentShapePositions(2) - 1).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(1) = CurrentShapePositions(2) + 11
                                CurrentShapePositions(0) = CurrentShapePositions(2) + 10
                                CurrentShapePositions(3) = CurrentShapePositions(2) - 1

                                State = 1
                                Rotating = False
                            End If
                        End If
                        Grid(CurrentShapePositions(0)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.GreenTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "z"
                        Grid(CurrentShapePositions(0)).Image = Nothing
                        Grid(CurrentShapePositions(0)).Tag = "Empty"
                        Grid(CurrentShapePositions(1)).Image = Nothing
                        Grid(CurrentShapePositions(1)).Tag = "Empty"
                        Grid(CurrentShapePositions(2)).Image = Nothing
                        Grid(CurrentShapePositions(2)).Tag = "Empty"
                        Grid(CurrentShapePositions(3)).Image = Nothing
                        Grid(CurrentShapePositions(3)).Tag = "Empty"

                        If State = 1 Then
                            If Grid(CurrentShapePositions(2) + 11).Tag = "Full" Or Grid(CurrentShapePositions(2) + 1).Tag = "Full" Or Grid(CurrentShapePositions(2) - 10).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(2) + 11
                                CurrentShapePositions(1) = CurrentShapePositions(2) + 1
                                CurrentShapePositions(3) = CurrentShapePositions(2) - 10

                                State = 2
                                Rotating = False
                            End If

                        ElseIf State = 2 Then
                            If Grid(CurrentShapePositions(2) - 9).Tag = "Full" Or Grid(CurrentShapePositions(2) - 10).Tag = "Full" Or Grid(CurrentShapePositions(2) - 1).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(2) - 9
                                CurrentShapePositions(1) = CurrentShapePositions(2) - 10
                                CurrentShapePositions(3) = CurrentShapePositions(2) - 1

                                State = 3
                                Rotating = False
                            End If
                        ElseIf State = 3 Then
                            If Grid(CurrentShapePositions(2) - 11).Tag = "Full" Or Grid(CurrentShapePositions(2) - 1).Tag = "Full" Or Grid(CurrentShapePositions(2) + 10).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(2) - 11
                                CurrentShapePositions(1) = CurrentShapePositions(2) - 1
                                CurrentShapePositions(3) = CurrentShapePositions(2) + 10

                                State = 4
                                Rotating = False
                            End If
                        ElseIf State = 4 Then
                            If Grid(CurrentShapePositions(2) + 9).Tag = "Full" Or Grid(CurrentShapePositions(2) + 10).Tag = "Full" Or Grid(CurrentShapePositions(2) + 1).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(2) + 9
                                CurrentShapePositions(1) = CurrentShapePositions(2) + 10
                                CurrentShapePositions(3) = CurrentShapePositions(2) + 1

                                State = 1
                                Rotating = False
                            End If

                        End If
                        Grid(CurrentShapePositions(0)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.RedTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "j"
                        Grid(CurrentShapePositions(0)).Image = Nothing
                        Grid(CurrentShapePositions(0)).Tag = "Empty"
                        Grid(CurrentShapePositions(1)).Image = Nothing
                        Grid(CurrentShapePositions(1)).Tag = "Empty"
                        Grid(CurrentShapePositions(2)).Image = Nothing
                        Grid(CurrentShapePositions(2)).Tag = "Empty"
                        Grid(CurrentShapePositions(3)).Image = Nothing
                        Grid(CurrentShapePositions(3)).Tag = "Empty"
                        If State = 1 Then
                            If Grid(CurrentShapePositions(1) + 10).Tag = "Full" Or Grid(CurrentShapePositions(1) - 10).Tag = "Full" Or Grid(CurrentShapePositions(1) + 11).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) + 10
                                CurrentShapePositions(2) = CurrentShapePositions(1) - 10
                                CurrentShapePositions(3) = CurrentShapePositions(1) + 11

                                State = 2
                                Rotating = False
                            End If
                        ElseIf State = 2 Then
                            If Grid(CurrentShapePositions(1) - 1).Tag = "Full" Or Grid(CurrentShapePositions(1) + 1).Tag = "Full" Or Grid(CurrentShapePositions(1) - 9).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) - 1
                                CurrentShapePositions(2) = CurrentShapePositions(1) + 1
                                CurrentShapePositions(3) = CurrentShapePositions(1) - 9

                                State = 3
                                Rotating = False
                            End If
                        ElseIf State = 3 Then
                            If Grid(CurrentShapePositions(1) - 10).Tag = "Full" Or Grid(CurrentShapePositions(1) + 10).Tag = "Full" Or Grid(CurrentShapePositions(1) - 11).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) - 10
                                CurrentShapePositions(2) = CurrentShapePositions(1) + 10
                                CurrentShapePositions(3) = CurrentShapePositions(1) - 11

                                State = 4
                                Rotating = False
                            End If

                        ElseIf State = 4 Then
                            If Grid(CurrentShapePositions(1) - 1).Tag = "Full" Or Grid(CurrentShapePositions(1) + 1).Tag = "Full" Or Grid(CurrentShapePositions(1) + 9).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) - 1
                                CurrentShapePositions(2) = CurrentShapePositions(1) + 1
                                CurrentShapePositions(3) = CurrentShapePositions(1) + 9

                                State = 1
                                Rotating = False
                            End If

                        End If
                        Grid(CurrentShapePositions(0)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.BlueTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                    Case "l"
                        Grid(CurrentShapePositions(0)).Image = Nothing
                        Grid(CurrentShapePositions(0)).Tag = "Empty"
                        Grid(CurrentShapePositions(1)).Image = Nothing
                        Grid(CurrentShapePositions(1)).Tag = "Empty"
                        Grid(CurrentShapePositions(2)).Image = Nothing
                        Grid(CurrentShapePositions(2)).Tag = "Empty"
                        Grid(CurrentShapePositions(3)).Image = Nothing
                        Grid(CurrentShapePositions(3)).Tag = "Empty"
                        If State = 1 Then
                            If Grid(CurrentShapePositions(1) + 10).Tag = "Full" Or Grid(CurrentShapePositions(1) - 10).Tag = "Full" Or Grid(CurrentShapePositions(1) - 9).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) + 10
                                CurrentShapePositions(2) = CurrentShapePositions(1) - 10
                                CurrentShapePositions(3) = CurrentShapePositions(1) - 9

                                State = 2
                                Rotating = False
                            End If

                        ElseIf State = 2 Then
                            If Grid(CurrentShapePositions(1) + 1).Tag = "Full" Or Grid(CurrentShapePositions(1) - 1).Tag = "Full" Or Grid(CurrentShapePositions(1) - 11).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) + 1
                                CurrentShapePositions(2) = CurrentShapePositions(1) - 1
                                CurrentShapePositions(3) = CurrentShapePositions(1) - 11

                                State = 3
                                Rotating = False
                            End If

                        ElseIf State = 3 Then
                            If Grid(CurrentShapePositions(1) - 10).Tag = "Full" Or Grid(CurrentShapePositions(1) + 10).Tag = "Full" Or Grid(CurrentShapePositions(1) + 9).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) - 10
                                CurrentShapePositions(2) = CurrentShapePositions(1) + 10
                                CurrentShapePositions(3) = CurrentShapePositions(1) + 9

                                State = 4
                                Rotating = False
                            End If

                        ElseIf State = 4 Then
                            If Grid(CurrentShapePositions(1) - 1).Tag = "Full" Or Grid(CurrentShapePositions(1) + 1).Tag = "Full" Or Grid(CurrentShapePositions(1) + 11).Tag = "Full" Then
                                Rotating = False
                            Else
                                CurrentShapePositions(0) = CurrentShapePositions(1) - 1
                                CurrentShapePositions(2) = CurrentShapePositions(1) + 1
                                CurrentShapePositions(3) = CurrentShapePositions(1) + 11

                                State = 1
                                Rotating = False
                            End If

                        End If
                        Grid(CurrentShapePositions(0)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(1)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(2)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(3)).Image = My.Resources.OrangeTetrisBlock
                        Grid(CurrentShapePositions(0)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(1)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(2)).Tag = "FullFalling"
                        Grid(CurrentShapePositions(3)).Tag = "FullFalling"
                End Select
                DisplayFinalDropPos()
            Catch ex As Exception
                Rotating = False
            End Try

        End If

    End Sub

    Private Sub CheckRows_Tick(sender As Object, e As EventArgs) Handles CheckRows.Tick
        Dim CheckCount As Integer = 0

        'Row 1
        For i = 0 To 9
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 0 To 9
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"
                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 0 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 2
        For i = 10 To 19
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 10 To 19
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 10 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 3
        For i = 20 To 29
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 20 To 29
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 20 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 4
        For i = 30 To 39
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 30 To 39
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 30 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0

        'Row 5
        For i = 40 To 49
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 40 To 49
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 40 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 6
        For i = 50 To 59
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 50 To 19
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 50 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 7
        For i = 60 To 69
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 60 To 19
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 60 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 8
        For i = 70 To 79
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 70 To 79
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 70 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 9
        For i = 80 To 89
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 80 To 89
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"
                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 80 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 10
        For i = 90 To 99
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 90 To 99
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"
                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 90 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 11
        For i = 100 To 109
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 100 To 109
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 100 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 12
        For i = 110 To 119
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 110 To 119
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 110 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 13
        For i = 120 To 129
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 120 To 129
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 120 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 14
        For i = 130 To 139
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 130 To 139
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"
                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 130 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 15
        For i = 140 To 149
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 140 To 149
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"
                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 140 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 16
        For i = 150 To 159
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 150 To 159
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"
                RowCleared(Consecutiverows)
                CheckCount = 0
            Next
            For i = 150 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 17
        For i = 160 To 169
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 160 To 169
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 160 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 18
        For i = 170 To 179
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 170 To 179
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 170 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        'Row 19
        For i = 180 To 189
            If Grid(i).Tag = "Full" Then
                CheckCount = CheckCount + 1
            End If
        Next
        If CheckCount = 10 Then
            Mover.Enabled = False
            FallingTimer.Enabled = False
            ClearenceCounter = ClearenceCounter + 1
            Consecutiverows = Consecutiverows + 1
            For i = 180 To 189
                Grid(i).Image = Nothing
                Grid(i).Tag = "Empty"

                RowCleared(Consecutiverows)
                CheckCount = 0

            Next
            For i = 180 To 189
                If Grid(i + 10).Tag = "Full" Then
                    Grid(i).Tag = "Full"
                    Grid(i).Image = Grid(i + 10).Image
                Else
                    Grid(i).Tag = "Empty"
                    Grid(i).Image = Nothing
                End If

            Next
            Mover.Enabled = True
            FallingTimer.Enabled = True
        End If
        CheckCount = 0
        ClearenceThisRun = ClearenceCounter
        ClearenceCounter = 0
        If ClearenceThisRun = 0 Then
            ClearenceCounter = 0
            ClearenceThisRun = 0
            Consecutiverows = 0
        End If

    End Sub

    Private Sub RowCleared(ByVal RowNumber)
        If RowNumber > 1 Then
            Score = Score + (10 * RowNumber)
        Else
            Score = Score + 4
        End If

        If FallingTimer.Interval > 100 Then
            If FallingTimer.Interval > 500 Then
                FallingTimer.Interval = FallingTimer.Interval - 10
            ElseIf FallingTimer.Interval > 350 Then
                FallingTimer.Interval = FallingTimer.Interval - 5
            Else
                FallingTimer.Interval = FallingTimer.Interval - 2
            End If
        End If
    End Sub

    Private Sub gameover()
        Dim name As String
        Scorelbl.Text = "Score: " & Score
        FallingTimer.Enabled = False
        Mover.Enabled = False
        CheckRows.Enabled = False
        name = InputBox("Your Final Score is: " & Score & Chr(13) & "Enter your name:", "GAME OVER!", "")

        If Score > 0 Then
            If name = "" Then
                Exit Sub
            Else
                FileOpen(1, "Highscores.txt", OpenMode.Append)
                PrintLine(1, name & ": " & Score & Chr(13))
                FileClose(1)
            End If
        End If

        For i = 199 To 0 Step -1
            Grid(i).Image = Nothing
            Grid(i).Tag = "Empty"
        Next
        Score = 0
        GamePanel.Hide()
        Title.Show()
        Exitbtn.Show()
        SettingsBtn.Show()
        Highscoresbtn.Show()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        scorespanel.Hide()
        SettingsBtn.Show()
        Exitbtn.Show()
        lblControls.Show()
    End Sub

    Private Sub Highscoresbtn_Click(sender As Object, e As EventArgs) Handles Highscoresbtn.Click
        scorespanel.Show()
        lblControls.Hide()
        scorespanel.Size = Me.Size
        scorespanel.Left = 0
        scorespanel.Top = 0
        SettingsBtn.Hide()
        Exitbtn.Hide()

        'GET AND DISPLAY HIGHSCORES
        Dim currentline As String
        Dim splitrecord() As String
        Dim arrayelements As Integer
        Dim holdingname As String
        Dim holdingscore As Integer
        Dim namearr(1000) As String
        Dim scorearr(1000) As Integer
        Dim count As Integer = 0

        FileOpen(1, "Highscores.txt", OpenMode.Input)
        Do Until EOF(1) = True
            currentline = LineInput(1)
            splitrecord = currentline.Split(":")
            namearr(count) = splitrecord(0)
            Try
                scorearr(count) = splitrecord(1)
            Catch ex As Exception
                count = count - 1
            End Try

            count = count + 1

        Loop
        FileClose(1)
        arrayelements = count - 2
        For i = 0 To arrayelements

            For j = 0 To arrayelements
                If scorearr(j + 1) > scorearr(j) Then
                    holdingscore = scorearr(j)
                    holdingname = namearr(j)
                    scorearr(j) = scorearr(j + 1)
                    namearr(j) = namearr(j + 1)
                    scorearr(j + 1) = holdingscore
                    namearr(j + 1) = holdingname


                End If
            Next
        Next

        HighscoresDisplaylbl.Text = "HIGHSCORES: " & Chr(13) & Chr(13)
        If count < 10 Then
            For i = 0 To count - 1

                HighscoresDisplaylbl.Text = HighscoresDisplaylbl.Text & (i + 1)

                HighscoresDisplaylbl.Text = HighscoresDisplaylbl.Text & ". " & namearr(i) & ": " & scorearr(i) & Chr(13)
            Next
        Else
            For i = 0 To 9
                HighscoresDisplaylbl.Text = HighscoresDisplaylbl.Text & (i + 1)

                HighscoresDisplaylbl.Text = HighscoresDisplaylbl.Text & ". " & namearr(i) & ": " & scorearr(i) & Chr(13)
            Next

        End If
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        SettingsPanel.Show()
        Highscoresbtn.Hide()
        Title.Hide()
        lblControls.Hide()
        Exitbtn.Hide()

        SettingsPanel.Size = Me.Size
        SettingsPanel.Left = 0
        SettingsPanel.Top = 0
    End Sub

    Private Sub ColourBtn_Click(sender As Object, e As EventArgs) Handles ColourBtn.Click
        If BGColour.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.BackColor = BGColour.Color
        End If

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        SettingsPanel.Hide()
        Highscoresbtn.Show()
        Title.Show()
        Exitbtn.Show()
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Quitbtn_Click(sender As Object, e As EventArgs) Handles Quitbtn.Click
        Scorelbl.Text = "Score: " & Score
        FallingTimer.Enabled = False
        Mover.Enabled = False
        CheckRows.Enabled = False
        For i = 199 To 0 Step -1
            Grid(i).Image = Nothing
            Grid(i).Tag = "Empty"
        Next
        Score = 0
        GamePanel.Hide()
        Title.Show()
        Exitbtn.Show()
        SettingsBtn.Show()
        Highscoresbtn.Show()
        lblControls.Show()
    End Sub

    Private Sub DisplayFinalDropPos()
        If Ghost.Checked = True Then
            Dim negativeamount As Integer
            ClearShadow()
            negativeamount = 180
            If CurrentShape = "i" And (State = 1 Or State = 3) Then
                negativeamount = 190
            End If

            Try
                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                    Else
                        ShadowPositions(0) = -1
                    End If
                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                    Else
                        ShadowPositions(1) = -1
                    End If
                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                    Else
                        ShadowPositions(2) = -1
                    End If
                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                    Else
                        ShadowPositions(3) = -1
                    End If
                Else
                    negativeamount = negativeamount - 10
                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                        Else
                            ShadowPositions(0) = -1
                        End If
                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                        Else
                            ShadowPositions(1) = -1
                        End If
                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                        Else
                            ShadowPositions(2) = -1
                        End If
                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                        Else
                            ShadowPositions(3) = -1
                        End If
                    Else
                        negativeamount = negativeamount - 10
                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                            Else
                                ShadowPositions(0) = -1
                            End If
                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                            Else
                                ShadowPositions(1) = -1
                            End If
                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                            Else
                                ShadowPositions(2) = -1
                            End If
                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                            Else
                                ShadowPositions(3) = -1
                            End If
                        Else
                            negativeamount = negativeamount - 10
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                Else
                                    ShadowPositions(0) = -1
                                End If
                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                Else
                                    ShadowPositions(1) = -1
                                End If
                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                Else
                                    ShadowPositions(2) = -1
                                End If
                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                Else
                                    ShadowPositions(3) = -1
                                End If
                            Else
                                negativeamount = negativeamount - 10
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                    Else
                                        ShadowPositions(0) = -1
                                    End If
                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                    Else
                                        ShadowPositions(1) = -1
                                    End If
                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                    Else
                                        ShadowPositions(2) = -1
                                    End If
                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                    Else
                                        ShadowPositions(3) = -1
                                    End If
                                Else
                                    negativeamount = negativeamount - 10
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                        Else
                                            ShadowPositions(0) = -1
                                        End If
                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                        Else
                                            ShadowPositions(1) = -1
                                        End If
                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                        Else
                                            ShadowPositions(2) = -1
                                        End If
                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                        Else
                                            ShadowPositions(3) = -1
                                        End If
                                    Else
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If


            Catch ex As Exception
                Try
                    negativeamount = negativeamount - 10
                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                        Else
                            ShadowPositions(0) = -1
                        End If
                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                        Else
                            ShadowPositions(1) = -1
                        End If
                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                        Else
                            ShadowPositions(2) = -1
                        End If
                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                        Else
                            ShadowPositions(3) = -1
                        End If
                    Else
                        negativeamount = negativeamount - 10
                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                            Else
                                ShadowPositions(0) = -1
                            End If
                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                            Else
                                ShadowPositions(1) = -1
                            End If
                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                            Else
                                ShadowPositions(2) = -1
                            End If
                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                            Else
                                ShadowPositions(3) = -1
                            End If
                        Else
                            negativeamount = negativeamount - 10
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                Else
                                    ShadowPositions(0) = -1
                                End If
                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                Else
                                    ShadowPositions(1) = -1
                                End If
                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                Else
                                    ShadowPositions(2) = -1
                                End If
                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                Else
                                    ShadowPositions(3) = -1
                                End If
                            Else
                                negativeamount = negativeamount - 10
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                    Else
                                        ShadowPositions(0) = -1
                                    End If
                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                    Else
                                        ShadowPositions(1) = -1
                                    End If
                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                    Else
                                        ShadowPositions(2) = -1
                                    End If
                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                    Else
                                        ShadowPositions(3) = -1
                                    End If
                                Else
                                    negativeamount = negativeamount - 10
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                        Else
                                            ShadowPositions(0) = -1
                                        End If
                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                        Else
                                            ShadowPositions(1) = -1
                                        End If
                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                        Else
                                            ShadowPositions(2) = -1
                                        End If
                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                        Else
                                            ShadowPositions(3) = -1
                                        End If
                                    Else
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                Catch exfirst As Exception
                    Try
                        negativeamount = negativeamount - 10
                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                            Else
                                ShadowPositions(0) = -1
                            End If
                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                            Else
                                ShadowPositions(1) = -1
                            End If
                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                            Else
                                ShadowPositions(2) = -1
                            End If
                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                            Else
                                ShadowPositions(3) = -1
                            End If
                        Else
                            negativeamount = negativeamount - 10
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                Else
                                    ShadowPositions(0) = -1
                                End If
                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                Else
                                    ShadowPositions(1) = -1
                                End If
                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                Else
                                    ShadowPositions(2) = -1
                                End If
                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                Else
                                    ShadowPositions(3) = -1
                                End If
                            Else
                                negativeamount = negativeamount - 10
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                    Else
                                        ShadowPositions(0) = -1
                                    End If
                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                    Else
                                        ShadowPositions(1) = -1
                                    End If
                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                    Else
                                        ShadowPositions(2) = -1
                                    End If
                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                    Else
                                        ShadowPositions(3) = -1
                                    End If
                                Else
                                    negativeamount = negativeamount - 10
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                        Else
                                            ShadowPositions(0) = -1
                                        End If
                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                        Else
                                            ShadowPositions(1) = -1
                                        End If
                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                        Else
                                            ShadowPositions(2) = -1
                                        End If
                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                        Else
                                            ShadowPositions(3) = -1
                                        End If
                                    Else
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Catch ex1 As Exception
                        Try
                            negativeamount = negativeamount - 10
                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                Else
                                    ShadowPositions(0) = -1
                                End If
                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                Else
                                    ShadowPositions(1) = -1
                                End If
                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                Else
                                    ShadowPositions(2) = -1
                                End If
                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                Else
                                    ShadowPositions(3) = -1
                                End If
                            Else
                                negativeamount = negativeamount - 10
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                    Else
                                        ShadowPositions(0) = -1
                                    End If
                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                    Else
                                        ShadowPositions(1) = -1
                                    End If
                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                    Else
                                        ShadowPositions(2) = -1
                                    End If
                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                    Else
                                        ShadowPositions(3) = -1
                                    End If
                                Else
                                    negativeamount = negativeamount - 10
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                        Else
                                            ShadowPositions(0) = -1
                                        End If
                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                        Else
                                            ShadowPositions(1) = -1
                                        End If
                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                        Else
                                            ShadowPositions(2) = -1
                                        End If
                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                        Else
                                            ShadowPositions(3) = -1
                                        End If
                                    Else
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Catch ex2 As Exception
                            Try
                                negativeamount = negativeamount - 10
                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                    Else
                                        ShadowPositions(0) = -1
                                    End If
                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                    Else
                                        ShadowPositions(1) = -1
                                    End If
                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                    Else
                                        ShadowPositions(2) = -1
                                    End If
                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                    Else
                                        ShadowPositions(3) = -1
                                    End If
                                Else
                                    negativeamount = negativeamount - 10
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                        Else
                                            ShadowPositions(0) = -1
                                        End If
                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                        Else
                                            ShadowPositions(1) = -1
                                        End If
                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                        Else
                                            ShadowPositions(2) = -1
                                        End If
                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                        Else
                                            ShadowPositions(3) = -1
                                        End If
                                    Else
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            Catch ex3 As Exception
                                Try
                                    negativeamount = negativeamount - 10
                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                        Else
                                            ShadowPositions(0) = -1
                                        End If
                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                        Else
                                            ShadowPositions(1) = -1
                                        End If
                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                        Else
                                            ShadowPositions(2) = -1
                                        End If
                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                        Else
                                            ShadowPositions(3) = -1
                                        End If
                                    Else
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Catch ex4 As Exception
                                    Try
                                        negativeamount = negativeamount - 10
                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                            Else
                                                ShadowPositions(0) = -1
                                            End If
                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                            Else
                                                ShadowPositions(1) = -1
                                            End If
                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                            Else
                                                ShadowPositions(2) = -1
                                            End If
                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                            Else
                                                ShadowPositions(3) = -1
                                            End If
                                        Else
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Catch ex5 As Exception
                                        Try
                                            negativeamount = negativeamount - 10
                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                Else
                                                    ShadowPositions(0) = -1
                                                End If
                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                Else
                                                    ShadowPositions(1) = -1
                                                End If
                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                Else
                                                    ShadowPositions(2) = -1
                                                End If
                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                Else
                                                    ShadowPositions(3) = -1
                                                End If
                                            Else
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Catch ex6 As Exception
                                            Try
                                                negativeamount = negativeamount - 10
                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                    Else
                                                        ShadowPositions(0) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                    Else
                                                        ShadowPositions(1) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                    Else
                                                        ShadowPositions(2) = -1
                                                    End If
                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                    Else
                                                        ShadowPositions(3) = -1
                                                    End If
                                                Else
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            Catch ex7 As Exception
                                                Try
                                                    negativeamount = negativeamount - 10
                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                        Else
                                                            ShadowPositions(0) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                        Else
                                                            ShadowPositions(1) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                        Else
                                                            ShadowPositions(2) = -1
                                                        End If
                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                        Else
                                                            ShadowPositions(3) = -1
                                                        End If
                                                    Else
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                Catch ex8 As Exception
                                                    Try
                                                        negativeamount = negativeamount - 10
                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                            Else
                                                                ShadowPositions(0) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                            Else
                                                                ShadowPositions(1) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                            Else
                                                                ShadowPositions(2) = -1
                                                            End If
                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                            Else
                                                                ShadowPositions(3) = -1
                                                            End If
                                                        Else
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If

                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    Catch ex9 As Exception
                                                        Try
                                                            negativeamount = negativeamount - 10
                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                Else
                                                                    ShadowPositions(0) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                Else
                                                                    ShadowPositions(1) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                Else
                                                                    ShadowPositions(2) = -1
                                                                End If
                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                Else
                                                                    ShadowPositions(3) = -1
                                                                End If
                                                            Else
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        Catch ex10 As Exception
                                                            Try
                                                                negativeamount = negativeamount - 10
                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                    Else
                                                                        ShadowPositions(0) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                    Else
                                                                        ShadowPositions(1) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                    Else
                                                                        ShadowPositions(2) = -1
                                                                    End If
                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                    Else
                                                                        ShadowPositions(3) = -1
                                                                    End If
                                                                Else
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            Catch ex11 As Exception
                                                                Try
                                                                    negativeamount = negativeamount - 10
                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                        Else
                                                                            ShadowPositions(0) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                        Else
                                                                            ShadowPositions(1) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                        Else
                                                                            ShadowPositions(2) = -1
                                                                        End If
                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                        Else
                                                                            ShadowPositions(3) = -1
                                                                        End If
                                                                    Else
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                Catch ex12 As Exception
                                                                    Try
                                                                        negativeamount = negativeamount - 10
                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                            Else
                                                                                ShadowPositions(0) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                            Else
                                                                                ShadowPositions(1) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                            Else
                                                                                ShadowPositions(2) = -1
                                                                            End If
                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                            Else
                                                                                ShadowPositions(3) = -1
                                                                            End If
                                                                        Else
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    Catch ex13 As Exception
                                                                        Try
                                                                            negativeamount = negativeamount - 10
                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(0) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(1) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(2) = -1
                                                                                End If
                                                                                If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                    Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                    ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                Else
                                                                                    ShadowPositions(3) = -1
                                                                                End If
                                                                            Else
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        Catch ex14 As Exception
                                                                            Try
                                                                                negativeamount = negativeamount - 10
                                                                                If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(0) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(1) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(2) = -1
                                                                                    End If
                                                                                    If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                        Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                        ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                    Else
                                                                                        ShadowPositions(3) = -1
                                                                                    End If
                                                                                Else
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            Catch ex15 As Exception
                                                                                Try
                                                                                    negativeamount = negativeamount - 10
                                                                                    If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(0) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(1) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(2) = -1
                                                                                        End If
                                                                                        If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                            Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                            ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                        Else
                                                                                            ShadowPositions(3) = -1
                                                                                        End If
                                                                                    Else
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    End If
                                                                                Catch ex16 As Exception
                                                                                    Try
                                                                                        negativeamount = negativeamount - 10
                                                                                        If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(1) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(2) - negativeamount).Tag <> "Full" And Grid(CurrentShapePositions(3) - negativeamount).Tag <> "Full" And (CurrentShapePositions(0) - negativeamount) >= 0 And (CurrentShapePositions(1) - negativeamount) >= 0 And (CurrentShapePositions(2) - negativeamount) >= 0 And (CurrentShapePositions(3) - negativeamount) >= 0 Then
                                                                                            If Grid(CurrentShapePositions(0) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(0) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(0) = CurrentShapePositions(0) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(0) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(1) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(1) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(1) = CurrentShapePositions(1) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(1) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(2) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(2) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(2) = CurrentShapePositions(2) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(2) = -1
                                                                                            End If
                                                                                            If Grid(CurrentShapePositions(3) - negativeamount).Tag <> "FullFalling" Then
                                                                                                Grid(CurrentShapePositions(3) - negativeamount).Image = My.Resources.GreyDropBlock
                                                                                                ShadowPositions(3) = CurrentShapePositions(3) - negativeamount
                                                                                            Else
                                                                                                ShadowPositions(3) = -1
                                                                                            End If

                                                                                        End If
                                                                                    Catch ex17 As Exception
                                                                                        MsgBox("Something has gone horribly, HORRIBLY WRONG")
                                                                                    End Try
                                                                                End Try
                                                                            End Try
                                                                        End Try
                                                                    End Try
                                                                End Try
                                                            End Try
                                                        End Try
                                                    End Try
                                                End Try
                                            End Try
                                        End Try
                                    End Try
                                End Try
                            End Try
                        End Try
                    End Try
                End Try
            End Try


        End If
    End Sub

    Private Sub ClearShadow()
        Try
            For i = 0 To 3
                If Grid(ShadowPositions(i)).Tag = "Empty" Then
                    Grid(ShadowPositions(i)).Image = Nothing
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
End Class
