﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.42000
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")>  _
    Partial Friend NotInheritable Class UIAppearanceSettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As UIAppearanceSettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New UIAppearanceSettings()),UIAppearanceSettings)
        
        Public Shared ReadOnly Property [Default]() As UIAppearanceSettings
            Get
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property Style() As Integer
            Get
                Return CType(Me("Style"),Integer)
            End Get
            Set
                Me("Style") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ColorFormBorder() As Boolean
            Get
                Return CType(Me("ColorFormBorder"),Boolean)
            End Get
            Set
                Me("ColorFormBorder") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ChildFormMarker() As Boolean
            Get
                Return CType(Me("ChildFormMarker"),Boolean)
            End Get
            Set
                Me("ChildFormMarker") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property FormIconActiveMenuItem() As Boolean
            Get
                Return CType(Me("FormIconActiveMenuItem"),Boolean)
            End Get
            Set
                Me("FormIconActiveMenuItem") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property MultiChildForms() As Boolean
            Get
                Return CType(Me("MultiChildForms"),Boolean)
            End Get
            Set
                Me("MultiChildForms") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property FormBorderSize() As Integer
            Get
                Return CType(Me("FormBorderSize"),Integer)
            End Get
            Set
                Me("FormBorderSize") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Theme() As Integer
            Get
                Return CType(Me("Theme"),Integer)
            End Get
            Set
                Me("Theme") = value
            End Set
        End Property
    End Class
End Namespace
