go
USE CATALOGO_P3_DB

GO
CREATE TABLE [dbo].[ROLES](
    [id_rol] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [nombre] [varchar](150) NOT NULL
);

GO
Create table [dbo].[USUARIOS](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [username] [varchar](50) NOT NULL,
    [password] [varchar](150) NOT NULL,
    [id_rol] [int] NOT NULL

    CONSTRAINT [FK_UsuariosXRoles] FOREIGN KEY ([id_rol]) REFERENCES [dbo].[ROLES]([id_rol])
);

insert into ROLES values ('admin'), ('user')
insert into USUARIOS values ('superadmin', 'maxiprograma', 2)

