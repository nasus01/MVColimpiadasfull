
CREATE TABLE [tblmodalidades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblmodalidades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tblpaises](
	[idpais] [int] IDENTITY(1,1) NOT NULL,
	[nombrepais] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblpaises] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [tblpaises] ON 

INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (1, N'Colombia')
INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (2, N'Brazil')
INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (3, N'Argentina')
INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (5, N'peru')
INSERT [tblpaises] ([idpais], [nombrepais]) VALUES (6, N'Australia')
SET IDENTITY_INSERT [tblpaises] OFF
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [spConsultaPaises]
as 
select * from dbo.tblpaises

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [spEliminarPais]
@idpais int
as
delete from dbo.tblpaises where
idpais = @idpais

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [spGuardarCambiosPais]
@idpais int, 
@nombrepais varchar(50)
as
update dbo.tblpaises set 
nombrepais = @nombrepais where 
idpais = @idpais

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [spNueoPais]
@nombrepais varchar(50)
as
insert into dbo.tblpaises(nombrepais)
values(@nombrepais)

GO
USE [master]
GO
ALTER DATABASE [bdolimpiadas] SET  READ_WRITE 
GO
