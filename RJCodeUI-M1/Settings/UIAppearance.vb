Public Structure UIAppearance
    '' UI Appearance Settings (Default Settings-No Loading Data from Settings File)
    Friend Shared Theme As UITheme = UITheme.Light 'Sets or gets the theme, either dark or light.
    Friend Shared Style As UIStyle = UIStyle.CCB 'Set or get the style
    Friend Shared PrimaryStyleColor As Color = RJColors.CCB 'Sets or gets the style color of the form's title bar
    Friend Shared StyleColor As Color = RJColors.CCB 'Sets or gets the style color of buttons, combo boxes, date and time pickers, data grid views, check boxes, radio buttons and others (color is a slightly more opaque than the PrimaryStyleColor field - See SettingsManager Class)
    Friend Shared BackgroundColor As Color = RJColors.LightBackground 'Sets or gets the background color of forms
    Friend Shared ItemBackgroundColor As Color = RJColors.LightItemBackground
    Friend Shared ActiveBackgroundColor As Color = RJColors.LightActiveBackground
    Friend Shared PrimaryTextColor As Color = RJColors.LightTextColor 'Sets or gets text color for text boxes, combo box, date and time picker (color is slightly more highlighted than Text Color field, see SettingsManager class )
    Friend Shared TextColor As Color = RJColors.LightTextColor 'Sets or gets the color of the label text, option button and others, also applies to the text and BarIcon control on the title bar of the main form in supernova style.
    Friend Shared FormBorderColor As Color = RJColors.CCB 'Sets or gets the border color of the form
    Friend Shared DeactiveFormColor As Color = Color.FromArgb(205, 212, 220) '(76, 70, 116)Sets or gets the color of the title bar when the form is deactivated.
    Friend Shared FormBorderSize As Integer = 1 'Sets the width of the form border
    Friend Shared ChildFormMarker As Boolean = True 'Sets or gets whether the child form marker will show on the main form side menu menu button
    Friend Shared FormIconActiveMenuItem As Boolean = False 'Sets or gets whether the form icon will be displayed on an active menu item
    Friend Shared MultiChildForms As Boolean = True 'Sets or gets if the user can open multiple child forms within the desktop panel or can just open a single form (close the old one and open the new form)
    Friend Shared TextFamilyName As String = "Verdana"
    Friend Shared TextSize As Single = 9.5F 'Sets a default font size, applies to most custom controls at design time,
    'however, it can be changed later from the control's properties unless there is a restriction on a specific control.
End Structure