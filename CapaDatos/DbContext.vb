Imports Microsoft.EntityFrameworkCore
Public Class MiDbContext
    Inherits DbContext

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseSqlServer("server=dbRestaurante.mssql.somee.com; initial catalog=dbRestaurante ;user id=kevinsuica1_SQLLogin_1; pwd=ydhu6dbsho; TrustServerCertificate=True; Encrypt=False")
    End Sub

    Public Property TipoDocumento As DbSet(Of TipoDocumento)
    Public Property Sexo As DbSet(Of Sexo)
    Public Property Actores As DbSet(Of Actores)
    Public Property Operadores As DbSet(Of Operadores)
    Public Property NumeroContacto As DbSet(Of NumeroContacto)
    Public Property Roles As DbSet(Of Roles)
    Public Property Usuario As DbSet(Of Usuario)
    Public Property CargoTrabajador As DbSet(Of CargoTrabajador)
    Public Property UnidadMedida As DbSet(Of UnidadMedida)
    Public Property Categorias As DbSet(Of Categorias)
    Public Property Productos As DbSet(Of Productos)
    Public Property Almacen As DbSet(Of Almacen)
    Public Property Movimientos As DbSet(Of Movimientos)

End Class