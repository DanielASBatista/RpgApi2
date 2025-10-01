BEGIN TRANSACTION;
ALTER TABLE [TB_PERSONAGENS] ADD [FotoPersonagem] varbinary(max) NULL;

ALTER TABLE [TB_PERSONAGENS] ADD [UsuarioId] int NULL;

CREATE TABLE [TB_USUARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] nvarchar(max) NULL DEFAULT N'Jogador',
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY ([Id])
);

UPDATE [TB_ARMAS] SET [Dano] = 70, [Nome] = N'Anti-Material Rifle'
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMAS] SET [Dano] = 50, [Nome] = N'Umbra'
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMAS] SET [Dano] = 100, [Nome] = N'Salame'
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMAS] SET [Dano] = 35, [Nome] = N'Blade of Chaos'
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMAS] SET [Dano] = 55, [Nome] = N'Marreta'
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMAS] SET [Dano] = 70, [Nome] = N'AK-43'
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_ARMAS] SET [Dano] = 80, [Nome] = N'El Machete'
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] ON;
INSERT INTO [TB_USUARIOS] ([Id], [DataAcesso], [Email], [Foto], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [Perfil], [Username])
VALUES (1, NULL, N'seuEmail@gmail.com', NULL, -23.520024100000001E0, -46.596497999999997E0, 0x9570C45EEC936F4FDD72C52A05A555C7F7510CA94C9E5617CC0BBDBCE2BB1C160F7A03001CFEA290D39AC026A380C3065B787A504302C9A818A376B18BEAA638, 0x0307AFD21562B20C53EA3C1B1D56261FECA41998DE96AFC4736A99EBD1A1962F7FA327B1FA31DA3D73BA126D6D9930345831545CFCBD45E2345173F7DB45B09C18DF5C2BE20C5DE5D2CB979D3CDA7F22B027E4C5BD5E289A666100CFADAEE86E9189B9EB051A3C3865035C688E9C2CB17D19D3D17E4FE3D2C96C2E1CE5A012A8, N'Admin', N'UsuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] OFF;

CREATE INDEX [IX_TB_PERSONAGENS_UsuarioId] ON [TB_PERSONAGENS] ([UsuarioId]);

ALTER TABLE [TB_PERSONAGENS] ADD CONSTRAINT [FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIOS] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251001013606_MigracaoUsuario', N'9.0.9');

COMMIT;
GO

