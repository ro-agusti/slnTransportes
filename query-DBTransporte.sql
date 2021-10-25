----crear dataBase
Create DataBase DBTransporte

---- crear tabla
GO
Use DBTransporte
GO
Create Table Auto
(
Id Int Primary Key Identity,
Marca Varchar(50) not null,
Modelo Varchar(50) not null,
Matricula char(6)not null,
Precio Decimal 
)

----SELECT tabla auto
SELECT Id,Marca,Modelo,Matricula,Precio FROM dbo.Auto

----SELECT tabla auto por marca
SELECT Id,Marca,Modelo,Matricula,Precio FROM dbo.Auto WHERE Marca = 'Toyota'
--C#
SELECT Id,Marca,Modelo,Matricula,Precio FROM dbo.Auto WHERE Marca = @Marca

----INSERT auto
INSERT dbo.Auto(Marca,Modelo,Matricula,Precio) VALUES ('Toyota','hilux','tre253',150)
INSERT dbo.Auto(Marca,Modelo,Matricula,Precio) VALUES ('Toyota','corolla','rog521',100)
INSERT dbo.Auto(Marca,Modelo,Matricula,Precio) VALUES ('Sheep','renegade','nhd365',90)
INSERT dbo.Auto(Marca,Modelo,Matricula,Precio) VALUES ('Sheep','wrangler','mbo325',170)
--C#
INSERT dbo.Auto(Marca,Modelo,Matricula,Precio) VALUES (@Marca,@Modelo,@Matricula,@Precio)

----UPDATE auto
UPDATE dbo.Auto SET Marca='jeep', Modelo='renegade', Matricula = 'nhd365', Precio = 90 WHERE Id=4
UPDATE dbo.Auto SET Marca='jeep', Modelo='wrangler', Matricula = 'mbo325', Precio = 170 WHERE Id=5
--C#
UPDATE dbo.Auto SET Marca=@Marca, Modelo=@Modelo, Matricula = @Matricula, Precio = @Precio WHERE Id=@Id

----DELETE auto
DELETE FROM Auto where Id=5
--C#
DELETE FROM Auto where Id=@ID

SELECT distinct Marca FROM dbo.Auto