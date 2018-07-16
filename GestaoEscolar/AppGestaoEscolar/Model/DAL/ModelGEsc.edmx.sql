
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/16/2018 13:48:02
-- Generated from EDMX file: C:\Users\Hermano\source\repos\UP-ADS-CS-Ex02\GestaoEscolar\AppGestaoEscolar\Model\DAL\ModelGEsc.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GestaoEscolarDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProfessorDisciplina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Disciplinas] DROP CONSTRAINT [FK_ProfessorDisciplina];
GO
IF OBJECT_ID(N'[dbo].[FK_AlunoDisciplina_Aluno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlunoDisciplina] DROP CONSTRAINT [FK_AlunoDisciplina_Aluno];
GO
IF OBJECT_ID(N'[dbo].[FK_AlunoDisciplina_Disciplina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlunoDisciplina] DROP CONSTRAINT [FK_AlunoDisciplina_Disciplina];
GO
IF OBJECT_ID(N'[dbo].[FK_Professor_inherits_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Professor] DROP CONSTRAINT [FK_Professor_inherits_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_Aluno_inherits_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Aluno] DROP CONSTRAINT [FK_Aluno_inherits_Usuario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Disciplinas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Disciplinas];
GO
IF OBJECT_ID(N'[dbo].[Usuarios_Professor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios_Professor];
GO
IF OBJECT_ID(N'[dbo].[Usuarios_Aluno]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios_Aluno];
GO
IF OBJECT_ID(N'[dbo].[AlunoDisciplina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlunoDisciplina];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [Email] nvarchar(50)  NULL,
    [DataNasc] datetime  NOT NULL,
    [Sexo] nvarchar(50)  NOT NULL,
    [CPF] bigint  NOT NULL,
    [Telefone] bigint  NOT NULL,
    [Endereco] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Disciplinas'
CREATE TABLE [dbo].[Disciplinas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CargaHoraria] int  NOT NULL,
    [ProfessorId] int  NOT NULL
);
GO

-- Creating table 'Usuarios_Professor'
CREATE TABLE [dbo].[Usuarios_Professor] (
    [Formacao] nvarchar(max)  NOT NULL,
    [Salario] decimal(18,0)  NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Usuarios_Aluno'
CREATE TABLE [dbo].[Usuarios_Aluno] (
    [Matricula] int  NOT NULL,
    [Idade] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'AlunoDisciplina'
CREATE TABLE [dbo].[AlunoDisciplina] (
    [Aluno_Id] int  NOT NULL,
    [Disciplina_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Disciplinas'
ALTER TABLE [dbo].[Disciplinas]
ADD CONSTRAINT [PK_Disciplinas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios_Professor'
ALTER TABLE [dbo].[Usuarios_Professor]
ADD CONSTRAINT [PK_Usuarios_Professor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios_Aluno'
ALTER TABLE [dbo].[Usuarios_Aluno]
ADD CONSTRAINT [PK_Usuarios_Aluno]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Aluno_Id], [Disciplina_Id] in table 'AlunoDisciplina'
ALTER TABLE [dbo].[AlunoDisciplina]
ADD CONSTRAINT [PK_AlunoDisciplina]
    PRIMARY KEY CLUSTERED ([Aluno_Id], [Disciplina_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProfessorId] in table 'Disciplinas'
ALTER TABLE [dbo].[Disciplinas]
ADD CONSTRAINT [FK_ProfessorDisciplina]
    FOREIGN KEY ([ProfessorId])
    REFERENCES [dbo].[Usuarios_Professor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfessorDisciplina'
CREATE INDEX [IX_FK_ProfessorDisciplina]
ON [dbo].[Disciplinas]
    ([ProfessorId]);
GO

-- Creating foreign key on [Aluno_Id] in table 'AlunoDisciplina'
ALTER TABLE [dbo].[AlunoDisciplina]
ADD CONSTRAINT [FK_AlunoDisciplina_Aluno]
    FOREIGN KEY ([Aluno_Id])
    REFERENCES [dbo].[Usuarios_Aluno]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Disciplina_Id] in table 'AlunoDisciplina'
ALTER TABLE [dbo].[AlunoDisciplina]
ADD CONSTRAINT [FK_AlunoDisciplina_Disciplina]
    FOREIGN KEY ([Disciplina_Id])
    REFERENCES [dbo].[Disciplinas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlunoDisciplina_Disciplina'
CREATE INDEX [IX_FK_AlunoDisciplina_Disciplina]
ON [dbo].[AlunoDisciplina]
    ([Disciplina_Id]);
GO

-- Creating foreign key on [Id] in table 'Usuarios_Professor'
ALTER TABLE [dbo].[Usuarios_Professor]
ADD CONSTRAINT [FK_Professor_inherits_Usuario]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Usuarios_Aluno'
ALTER TABLE [dbo].[Usuarios_Aluno]
ADD CONSTRAINT [FK_Aluno_inherits_Usuario]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------