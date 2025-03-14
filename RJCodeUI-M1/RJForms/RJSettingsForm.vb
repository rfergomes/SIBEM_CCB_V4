Public Class RJSettingsForm
    Inherits RJChildForm

    ''' <summary>
    ''' This class inherits from the <RJChildForm /> class
    ''' The PARTIAL class is who should inherit from RJChildForm (Found in RJSettingsForm.Designer.vb):
    '''     Partial Class RJSettingsForm
    '''             Inherits RJChildForm
    ''' It is optional that this class inherits from RJChildForm
    ''' </summary>
    ''' 

#Region "-> Constructor"

    Public Sub New()
        InitializeComponent() 'This form was built by the designer.
        LoadAppearanceSettings() 'Load and display the current appearance settings.
    End Sub
#End Region

#Region "-> Private methods"

    Private Sub LoadAppearanceSettings()
        'Show current appearance settings on the form.

        '-> Topic
        If UIAppearance.Theme = UITheme.Dark Then
            rbDarkTheme.Checked = True
        Else
            rbLightTheme.Checked = True
        End If
        '-> Style
        cbStyles.DataSource = [Enum].GetValues(GetType(UIStyle))
        cbStyles.SelectedIndex = CInt(UIAppearance.Style)
        '-> Form border size
        tbmFormBorderSize.Value = If(UIAppearance.FormBorderSize > 0, UIAppearance.FormBorderSize, 1)
        '-> If the border color of the form is colored or not.
        tbColorFormBorder.Checked = If(UIAppearance.FormBorderColor = RJColors.DefaultFormBorderColor, False, True)
        '-> Child form marker
        tbChildFormMarker.Checked = UIAppearance.ChildFormMarker
        '-> Show form icon in activated drop-down menu item.
        tbIconMenuItem.Checked = UIAppearance.FormIconActiveMenuItem
        '-> Open multiple child forms?
        tbMultiChildForms.Checked = UIAppearance.MultiChildForms
        '-> Preview
        panelBorde.Padding = New Padding(UIAppearance.FormBorderSize)
        panelBorde.BackColor = UIAppearance.FormBorderColor
        panelBackground.BackColor = UIAppearance.BackgroundColor
        If UIAppearance.Style = UIStyle.Supernova Then
            panelTitleBar.BackColor = ColorEditor.Darken(UIAppearance.BackgroundColor, 9)
        Else
            panelTitleBar.BackColor = UIAppearance.PrimaryStyleColor
        End If
    End Sub

    Private Sub SaveAppearanceSettings()
        'Save appearance settings
        SettingsManager.SaveAppearanceSettings(If(rbDarkTheme.Checked,
                                              CInt(UITheme.Dark),
                                              CInt(UITheme.Light)),
                                              CInt(cbStyles.SelectedValue),
                                              tbmFormBorderSize.Value,
                                              tbColorFormBorder.Checked,
                                              tbChildFormMarker.Checked,
                                              tbIconMenuItem.Checked,
                                              tbMultiChildForms.Checked)
        'Mostrar mensagem de reinicialização
        Dim result = RJMessageBox.Show("Reinicie o aplicativo para ver as alterações" & vbLf & "Reiniciar agora?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then 'Restart application
            Application.Restart()
            Environment.Exit(0)
            ' Nota: Ao executar a aplicação pelo visual studio, o arquivo de configuração é salvo
            ' na pasta PROJETOBASE.vshost.exe. E ao reiniciar a aplicação o arquivo de configuração
            ' é obtido da pasta C:\Users\YourUsername\AppData\Local\PROJETOBASE\PROJETOBASE.exe,
            ' já que após reiniciar a aplicação ela
            ' roda independente do visual studio, então ela não carregará as configurações que você estabeleceu na
            ' primeira reinicialização já que ela pegará o arquivo de configuração
            ' C:\Users\YourUsername\AppData\Local\PROJETOBASE\PROJETOBASE.exe. Se você quiser
            ' testar e aplicar as configurações estabelecidas quando estiver desenvolvendo a aplicação, eu recomendo
            ' que você feche a aplicação (ou pare de depurar) e execute novamente pelo visual studio ou compile o projeto
            ' e execute a aplicação diretamente da pasta bin do projeto.

        Else 'Show the reboot message label in case you did not reboot from the message box.
            lblRestartApp.Visible = True
        End If
    End Sub
#End Region

#Region "-> Métodos de evento"

    Private Sub btnApplyChanges_Click(sender As Object, e As EventArgs) Handles btnApplyChanges.Click
        SaveAppearanceSettings() 'Guardar la configuración de apariencia
    End Sub

    Private Sub lblRestartApp_Click(sender As Object, e As EventArgs) Handles lblRestartApp.Click
        'Restart application
        Application.Restart()
        Environment.Exit(0)
        ' Note: When executing the application from visual studio, the configuration file is saved 
        ' in the folder PROJETOBASE.vshost.exe. And when restarting the application the configuration
        ' file is obtained from the C:\Users\YourUsername\AppData\Local\PROJETOBASE\PROJETOBASE.exe folder, 
        ' since after restarting the application it
        ' runs independently of visual studio, so it will not load the settings you established on the 
        ' first restart since it will take the file of 
        ' C:\Users\YourUsername\AppData\Local\PROJETOBASE\PROJETOBASE.exe configuration. If you want to 
        ' test and apply the settings established when you are developing the application, I recommend 
        ' you close the application (or stop debugging) and rerun from visual studio or compile the project
        ' and run the application directly from the project's bin folder.
    End Sub

#Region "- Preview changes"

    Private Sub rbLightTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbLightTheme.CheckedChanged
        If rbLightTheme.Checked Then
            panelBackground.BackColor = RJColors.LightBackground
        Else
            panelBackground.BackColor = RJColors.DarkBackground
        End If

        If cbStyles.SelectedIndex = CInt(UIStyle.Supernova) Then panelTitleBar.BackColor = ColorEditor.Darken(panelBackground.BackColor, 9)
    End Sub

    Private Sub cbStyles_OnSelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStyles.OnSelectedIndexChanged
        Dim style As UIStyle = CType(cbStyles.SelectedIndex, UIStyle)

        Select Case style
            Case UIStyle.Axolotl
                panelTitleBar.BackColor = RJColors.Axolotl
            Case UIStyle.FireOpal
                panelTitleBar.BackColor = RJColors.FireOpal
            Case UIStyle.CCB
                panelTitleBar.BackColor = RJColors.CCB
            Case UIStyle.Forest
                panelTitleBar.BackColor = RJColors.Forest
            Case UIStyle.Lisianthus
                panelTitleBar.BackColor = RJColors.Lisianthus
            Case UIStyle.Neptune
                panelTitleBar.BackColor = RJColors.Neptune
            Case UIStyle.Petunia
                panelTitleBar.BackColor = RJColors.Petunia
            Case UIStyle.Ruby
                panelTitleBar.BackColor = RJColors.Ruby
            Case UIStyle.Sky
                panelTitleBar.BackColor = RJColors.Sky
            Case UIStyle.Spinel
                panelTitleBar.BackColor = RJColors.Spinel
            Case UIStyle.Supernova
                panelTitleBar.BackColor = ColorEditor.Darken(panelBackground.BackColor, 9)
        End Select

        If tbColorFormBorder.Checked Then

            If cbStyles.SelectedIndex = CInt(UIStyle.Supernova) Then
                panelBorde.BackColor = RJColors.FantasyColorScheme1
            Else
                panelBorde.BackColor = panelTitleBar.BackColor
            End If
        Else
            panelBorde.BackColor = RJColors.DefaultFormBorderColor
        End If
    End Sub

    Private Sub tbmFormBorderSize_Scroll(sender As Object, e As EventArgs) Handles tbmFormBorderSize.Scroll
        panelBorde.Padding = New Padding(tbmFormBorderSize.Value)
    End Sub

    Private Sub tbColorFormBorder_CheckedChanged(sender As Object, e As EventArgs) Handles tbColorFormBorder.CheckedChanged
        If tbColorFormBorder.Checked Then

            If cbStyles.SelectedIndex = CInt(UIStyle.Supernova) Then
                panelBorde.BackColor = RJColors.FantasyColorScheme1
            Else
                panelBorde.BackColor = panelTitleBar.BackColor
            End If
        Else
            panelBorde.BackColor = RJColors.DefaultFormBorderColor
        End If
    End Sub

#End Region

#End Region

End Class
