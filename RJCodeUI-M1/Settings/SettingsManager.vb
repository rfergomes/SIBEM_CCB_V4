Imports PROJETOBASE.My

Public Module SettingsManager

    'Save appearance settings
    Sub SaveAppearanceSettings(theme As Integer, style As Integer, formBorderSize As Integer, colorFormBorder As Boolean,
                               childFormMarker As Boolean, formIconActiveMenuItem As Boolean, multiChildForms As Boolean)
        'Set values
        UIAppearanceSettings.Default.Theme = theme
        UIAppearanceSettings.Default.Style = style
        UIAppearanceSettings.Default.FormBorderSize = formBorderSize
        UIAppearanceSettings.Default.ColorFormBorder = colorFormBorder
        UIAppearanceSettings.Default.ChildFormMarker = childFormMarker
        UIAppearanceSettings.Default.FormIconActiveMenuItem = formIconActiveMenuItem
        UIAppearanceSettings.Default.MultiChildForms = multiChildForms
        UIAppearanceSettings.Default.Save() 'Save current settings to application configuration file.
    End Sub

    'Load appearance settings
    Sub LoadApperanceSettings()
        UIAppearance.Theme = CType(UIAppearanceSettings.Default.Theme, UITheme) 'Set topic
        UIAppearance.Style = CType(UIAppearanceSettings.Default.Style, UIStyle) 'Set style
        UIAppearance.FormBorderSize = UIAppearanceSettings.Default.FormBorderSize 'Set the border size of the form
        UIAppearance.ChildFormMarker = UIAppearanceSettings.Default.ChildFormMarker 'Set whether to show the marker of the current child form.
        UIAppearance.FormIconActiveMenuItem = UIAppearanceSettings.Default.FormIconActiveMenuItem 'Set whether the icon of the active menu item is equal to the icon of its associated form.
        UIAppearance.MultiChildForms = UIAppearanceSettings.Default.MultiChildForms ' Set if you want to open multiple child forms in the application

        '- >>> Set theme colors
        If UIAppearance.Theme = UITheme.Light Then 'Light Topic
            UIAppearance.BackgroundColor = RJColors.LightBackground
            UIAppearance.ItemBackgroundColor = RJColors.LightItemBackground
            UIAppearance.ActiveBackgroundColor = RJColors.LightActiveBackground
            UIAppearance.PrimaryTextColor = ColorEditor.Darken(RJColors.LightTextColor, 15)
            UIAppearance.TextColor = RJColors.LightTextColor
        Else 'Dark Theme
            UIAppearance.BackgroundColor = RJColors.DarkBackground
            UIAppearance.ItemBackgroundColor = RJColors.DarkItemBackground
            UIAppearance.ActiveBackgroundColor = RJColors.DarkActiveBackground
            UIAppearance.PrimaryTextColor = ColorEditor.Lighten(RJColors.DarkTextColor, 25)
            UIAppearance.TextColor = RJColors.DarkTextColor
        End If

        '- >>> Set style color
        Select Case UIAppearance.Style
            Case UIStyle.Axolotl
                UIAppearance.PrimaryStyleColor = RJColors.Axolotl

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Axolotl, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Axolotl, 15)
                End If

            Case UIStyle.CCB
                UIAppearance.PrimaryStyleColor = RJColors.CCB

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.CCB, 20)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.CCB, 80)
                End If

            Case UIStyle.FireOpal
                UIAppearance.PrimaryStyleColor = RJColors.FireOpal

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.FireOpal, 12)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.FireOpal, 15)
                End If

            Case UIStyle.Forest
                UIAppearance.PrimaryStyleColor = RJColors.Forest

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Forest, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Forest, 15)
                End If

            Case UIStyle.Lisianthus
                UIAppearance.PrimaryStyleColor = RJColors.Lisianthus

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Lisianthus, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Lisianthus, 15)
                End If

            Case UIStyle.Neptune
                UIAppearance.PrimaryStyleColor = RJColors.Neptune

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Neptune, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Neptune, 15)
                End If

            Case UIStyle.Petunia
                UIAppearance.PrimaryStyleColor = RJColors.Petunia

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Petunia, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Petunia, 15)
                End If

            Case UIStyle.Ruby
                UIAppearance.PrimaryStyleColor = RJColors.Ruby

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Ruby, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Ruby, 15)
                End If

            Case UIStyle.Sky
                UIAppearance.PrimaryStyleColor = RJColors.Sky

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Sky, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Sky, 15)
                End If

            Case UIStyle.Spinel
                UIAppearance.PrimaryStyleColor = RJColors.Spinel

                If UIAppearance.Theme = UITheme.Dark Then
                    UIAppearance.StyleColor = ColorEditor.Darken(RJColors.Spinel, 10)
                Else
                    UIAppearance.StyleColor = ColorEditor.Lighten(RJColors.Spinel, 15)
                End If

            Case UIStyle.Supernova
                UIAppearance.StyleColor = RJColors.Lisianthus
                UIAppearance.PrimaryStyleColor = RJColors.FantasyColorScheme1
        End Select

        '->>> Set form border color
        If UIAppearanceSettings.Default.ColorFormBorder = True Then
            UIAppearance.FormBorderColor = UIAppearance.PrimaryStyleColor
        Else
            UIAppearance.FormBorderColor = RJColors.DefaultFormBorderColor
        End If
    End Sub
End Module
