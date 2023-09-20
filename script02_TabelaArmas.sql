BEGIN TRANSACTION;
GO

CREATE TABLE [TB_ARMA] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_TB_ARMA] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMA]'))
    SET IDENTITY_INSERT [TB_ARMA] ON;
INSERT INTO [TB_ARMA] ([Id], [Dano], [Nome])
VALUES (1, 90, N'Exbalibur'),
(2, 80, N'AWP'),
(3, 25, N'Cacetete'),
(4, 50, N'Espada'),
(5, 65, N'Espadao'),
(6, 40, N'Arco'),
(7, 100, N'Chinelo de Mãe');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMA]'))
    SET IDENTITY_INSERT [TB_ARMA] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230920011354_MigracaoArma', N'7.0.11');
GO

COMMIT;
GO

