Public Module RJColors
    'Fields
    Public colorIndex As Integer
    '-> RJColors
    Public ReadOnly SideMenuColor As Color = Color.FromArgb(3, 61, 96) '(49, 42, 81)
    Public ReadOnly DefaultFormBorderColor As Color = Color.FromArgb(3, 61, 96) '(111, 106, 143)
    'Color the styles
    Public ReadOnly Axolotl As Color = Color.FromArgb(248, 112, 171)
    Public ReadOnly CCB As Color = Color.FromArgb(3, 61, 96)
    Public ReadOnly FireOpal As Color = Color.FromArgb(245, 124, 37)
    Public ReadOnly Forest As Color = Color.FromArgb(20, 138, 75)
    Public ReadOnly Lisianthus As Color = Color.FromArgb(123, 104, 238)
    Public ReadOnly Neptune As Color = Color.FromArgb(83, 97, 212)
    Public ReadOnly Petunia As Color = Color.FromArgb(171, 48, 243)
    Public ReadOnly Ruby As Color = Color.FromArgb(224, 40, 67)
    Public ReadOnly Sky As Color = Color.FromArgb(90, 146, 246)
    Public ReadOnly Spinel As Color = Color.FromArgb(251, 111, 126)
    'Fantasy color scheme
    Public ReadOnly FantasyColorScheme1 As Color = Color.FromArgb(104, 85, 230)
    Public ReadOnly FantasyColorScheme2 As Color = Color.FromArgb(47, 168, 210)
    Public ReadOnly FantasyColorScheme3 As Color = Color.FromArgb(70, 132, 235)
    Public ReadOnly FantasyColorScheme4 As Color = Color.FromArgb(238, 96, 112)
    Public ReadOnly FantasyColorScheme5 As Color = Color.FromArgb(73, 84, 228)
    Public ReadOnly FantasyColorScheme6 As Color = Color.FromArgb(230, 52, 114)
    Public ReadOnly FantasyColorScheme7 As Color = Color.FromArgb(208, 101, 243)
    Public ReadOnly FantasyColorScheme8 As Color = Color.FromArgb(238, 134, 139)
    Public ReadOnly FantasyColorScheme9 As Color = Color.FromArgb(250, 173, 112)
    Public ReadOnly FantasyColorScheme10 As Color = Color.FromArgb(133, 108, 238)
    Public ReadOnly FantasyColorScheme11 As Color = Color.FromArgb(224, 195, 252)
    Public ReadOnly FantasyColorScheme12 As Color = Color.FromArgb(125, 179, 250)
    'Colors for the DARK theme
    Public ReadOnly DarkBackground As Color = Color.FromArgb(73, 101, 108) '(58, 52, 95)
    Public ReadOnly DarkItemBackground As Color = Color.FromArgb(73, 101, 108) '(66, 60, 109)
    Public ReadOnly DarkActiveBackground As Color = Color.FromArgb(3, 61, 96) '(77, 70, 130)
    Public ReadOnly DarkTextColor As Color = Color.FromArgb(255, 255, 255)
    'Colors for the LIGHT theme
    Public ReadOnly LightBackground As Color = Color.FromArgb(240, 245, 249)
    Public ReadOnly LightItemBackground As Color = Color.FromArgb(250, 252, 253)
    Public ReadOnly LightActiveBackground As Color = Color.FromArgb(231, 238, 246)
    Public ReadOnly LightTextColor As Color = Color.FromArgb(3, 61, 96) '(132, 129, 132)
    'Actions colors
    Public ReadOnly Add As Color = Color.FromArgb(137, 184, 129)
    Public ReadOnly Edit As Color = Color.FromArgb(104, 168, 208)
    Public ReadOnly Delete As Color = Color.FromArgb(220, 60, 0) '(180, 68, 57)
    Public ReadOnly Confirm As Color = Color.FromArgb(93, 177, 150) '(55, 159, 113)
    Public ReadOnly Cancel As Color = Color.FromArgb(165, 165, 165) '(172, 186, 195)
    Public ReadOnly Deactive As Color = Color.FromArgb(111, 127, 148)
    Public ReadOnly DeactiveDark As Color = Color.FromArgb(53, 64, 81)
    'Supernova Color List
    Private ReadOnly SupernovaColors As List(Of Color) = New List(Of Color)() From {
        FantasyColorScheme1,
        FantasyColorScheme2,
        FantasyColorScheme3,
        FantasyColorScheme4,
        FantasyColorScheme5,
        FantasyColorScheme6,
        FantasyColorScheme7,
        FantasyColorScheme8,
        FantasyColorScheme9,
        FantasyColorScheme10
    }
    'Get a color from the supernova color list
    Function GetSupernovaColor() As Color
        Dim color As Color = SupernovaColors(colorIndex)
        colorIndex += 1
        If colorIndex >= SupernovaColors.Count Then colorIndex = 0
        Return color
    End Function

End Module
