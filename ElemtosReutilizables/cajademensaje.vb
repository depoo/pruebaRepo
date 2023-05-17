Public Class cajademensaje

    Public Shared Sub Casillasvacias()
        MsgBox("Rellenar las casillas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    End Sub

    Public Shared Sub Limitedeintentos()
        MsgBox("Ha excedido el límite de intentos, intente de nuevo en 15 segundos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de autenticación")
    End Sub

    Public Shared Sub Credencialesincorrectas()
        MsgBox("Credenciales incorrectas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de autenticación")
    End Sub

    Public Shared Sub Errordeobtencion()
        MsgBox("Ha ocurrido un error al obtener los datos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    End Sub

    Public Shared Sub errorglobal()
        MsgBox("Ha ocurrido un error al realizar la operacion", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    End Sub

    Public Shared Sub Eliminarregistro()
        MessageBox.Show("La eliminación se realizó correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub Eliminarregistro2()
        MessageBox.Show("No se encontró la persona natural con ID ", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub Creacionderegistro()
        MessageBox.Show("La inserción se realizó correctamente.", "Inserción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub Actualizacionderegistro()
        MessageBox.Show("La actualización se realizó correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub Actualizacionderegistro2()
        MessageBox.Show("No se encontró la persona natural con ID ", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub



End Class
