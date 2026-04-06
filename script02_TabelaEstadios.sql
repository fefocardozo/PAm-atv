BEGIN TRANSACTION;
CREATE TABLE [TB_ESTADIOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NULL,
    [Cidade] varchar(200) NULL,
    [Capacidade] varchar(200) NULL,
    CONSTRAINT [PK_TB_ESTADIOS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIOS]'))
    SET IDENTITY_INSERT [TB_ESTADIOS] ON;
INSERT INTO [TB_ESTADIOS] ([Id], [Capacidade], [Cidade], [Nome])
VALUES (1, '78838', 'Rio de Janeiro', 'Maracaña'),
(2, '49205', 'São Paulo', 'Neo Química Arena'),
(3, '61842', 'Belo Horizonte', 'Mineirão'),
(4, '50842', 'Porto Alegre', 'Beira Rio'),
(5, '50000', 'Salvador', 'Arena Fonte Nova'),
(6, '44000', 'Manaus', 'Arena da Amazônia'),
(7, '72788', 'Brasília', 'Mané Garrincha');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIOS]'))
    SET IDENTITY_INSERT [TB_ESTADIOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260406113850_MigracaoEstadios', N'10.0.5');

COMMIT;
GO

