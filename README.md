# TriviaMusical

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 la invisibilidad de los objetos del formulario a traves de las 
 propiedades de la etiqueta: label.Visible = False y caambia el valor 
 de la propiedad a traves del codigo cuando ocurre el evento Click 
 sobre el Boton Responder.
 
 # Actualizacion: 03/01/2025
 # Hora: 10:53

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# MusicalTrivia

# Description

This project consists of the development of an application that uses
the invisibility of the form objects through the
label properties: label.Visible = False and changes the value
of the property through the code when the Click event occurs
on the Reply Button.

# Update: 01/03/2025
# Time: 10:53

Technical Details of the Project:
Language: Visual Basic.NET
Framework Version: 4.7.2

![imagen](https://github.com/user-attachments/assets/c95c578a-e896-4ebd-9ce3-f764bae44dad)

Code of the Project:

Imports System.Reflection.Emit

Public Class frmTriviaMusical
    Private Sub btnResponder_Click(sender As Object, e As EventArgs) Handles btnResponder.Click
        lblBajo.Visible = True
        bbTriviaM.Visible = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
