BEGIN TRANSACTION;
CREATE TABLE [TB_ESTADIOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NULL,
    [Cidade] varchar(200) NULL,
    [Capacidade] int NOT NULL,
    CONSTRAINT [PK_TB_ESTADIOS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIOS]'))
    SET IDENTITY_INSERT [TB_ESTADIOS] ON;
INSERT INTO [TB_ESTADIOS] ([Id], [Capacidade], [Cidade], [Nome])
VALUES (1, 600000, 'São Paulo 1', 'Neo Quimica 1'),
(2, 600000, 'São Paulo 2', 'Neo Quimica 2'),
(3, 600000, 'São Paulo 3', 'Neo Quimica 3'),
(4, 600000, 'São Paulo 4', 'Neo Quimica 4'),
(5, 600000, 'São Paulo 5', 'Neo Quimica 5'),
(6, 600000, 'São Paulo 6', 'Neo Quimica 6'),
(7, 600000, 'São Paulo 7', 'Neo Quimica 7');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIOS]'))
    SET IDENTITY_INSERT [TB_ESTADIOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260406110117_MigracaoEstadios', N'10.0.5');

COMMIT;
GO

