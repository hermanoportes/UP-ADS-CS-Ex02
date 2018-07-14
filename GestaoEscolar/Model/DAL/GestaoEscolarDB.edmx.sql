
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/14/2018 19:58:53
-- Generated from EDMX file: C:\Users\Hermano\Source\Repos\UP-ADS-CS-Ex02\GestaoEscolar\Model\DAL\GestaoEscolarDB.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [DataNasc] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Disciplinas'
CREATE TABLE [dbo].[Disciplinas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CargaHoraria] nvarchar(max)  NOT NULL,
    [ProfessorId] int  NOT NULL
);
GO

-- Creating table 'Usuarios_Professor'
CREATE TABLE [dbo].[Usuarios_Professor] (
    [Formacao] nvarchar(max)  NOT NULL,
    [Salario] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Usuarios_Aluno'
CREATE TABLE [dbo].[Usuarios_Aluno] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Idade] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
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