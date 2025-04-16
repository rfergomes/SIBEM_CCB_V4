'Última Atualização:    04/10/2024
'Data:                  04/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Friend Module Program
    ' Use this module to set the start form,
    ' The properties of the project is configured to execute the Main method of this module.

    ' Note: In case you want to set the startup form from the project properties:
    ' -> Check the checkbox-> Enable application framework
    ' -> Set the start form.
    ' -> And call the LoadApperanceSettings() method of the SettingsManager module in the constructor of the startup form.
    Dim SQLite As New ConnectionFactory()
    Dim MySQL As New ConnectionFactory(DatabaseType.MySQL_SYS)

    Sub Main()

        'Load current appearance settings before executing and displaying any form.
        SettingsManager.LoadApperanceSettings()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim sistemaBLL = New SistemaBLL(SQLite)
        Dim Sistema As List(Of SistemaDTO) = sistemaBLL.BuscarTodos()

        ' Atribui o primeiro elemento da lista, caso ela não esteja vazia
        If Sistema.Count > 0 Then
            VarGlob.SistemaAtivo = Sistema.FirstOrDefault(Function(s) s.Ativo = -1)
            If VarGlob.SistemaAtivo IsNot Nothing Then
                If My.Settings.Login Then
                    My.Settings.Login = False
                    My.Settings.Save()
                    ' Se o login estiver habilitado, mostra o formulário principal
                    Application.Run(New LoginFormDemo)
                Else
                    ' Se o login não estiver habilitado, mostra o formulário principal
                    Application.Run(New MainFormDemo)
                End If
            Else
                Dim Form As Form = New FormToken
                Form.ShowDialog()
            End If
        Else
            Dim Form As Form = New FormToken
            Form.ShowDialog()
        End If
    End Sub

End Module
