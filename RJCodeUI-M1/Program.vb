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

    Sub Main()

        'Load current appearance settings before executing and displaying any form.
        SettingsManager.LoadApperanceSettings()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainFormDemo) 'Run form.
    End Sub

End Module
