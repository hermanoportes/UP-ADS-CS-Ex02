
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/16/2018 21:27:25
-- Generated from EDMX file: C:\Users\Hermano\source\repos\UP-ADS-CS-Ex02\GestaoEscolar\AppGestaoEscolar\Model\DAL\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[FK_AlunoDisciplina_Aluno]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlunoDisciplina] DROP CONSTRAINT [FK_AlunoDisciplina_Aluno];
GO
IF OBJECT_ID(N'[dbo].[FK_AlunoDisciplina_Disciplina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlunoDisciplina] DROP CONSTRAINT [FK_AlunoDisciplina_Disciplina];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfessorDisciplina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Disciplinas] DROP CONSTRAINT [FK_ProfessorDisciplina];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Alunos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alunos];
GO
IF OBJECT_ID(N'[dbo].[Professores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Professores];
GO
IF OBJECT_ID(N'[dbo].[Disciplinas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Disciplinas];
GO
IF OBJECT_ID(N'[dbo].[AlunoDisciplina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlunoDisciplina];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Alunos'
CREATE TABLE [dbo].[Alunos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Matricula] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [DataNasc] nvarchar(max)  NOT NULL,
    [Sexo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Professores'
CREATE TABLE [dbo].[Professores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Formacao] nvarchar(max)  NOT NULL,
    [Salario] nvarchar(max)  NOT NULL,
    [DataInicial] nvarchar(max)  NOT NULL
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

-- Creating table 'AlunoDisciplina'
CREATE TABLE [dbo].[AlunoDisciplina] (
    [Alunos_Id] int  NOT NULL,
    [Disciplinas_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Alunos'
ALTER TABLE [dbo].[Alunos]
ADD CONSTRAINT [PK_Alunos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Professores'
ALTER TABLE [dbo].[Professores]
ADD CONSTRAINT [PK_Professores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Disciplinas'
ALTER TABLE [dbo].[Disciplinas]
ADD CONSTRAINT [PK_Disciplinas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Alunos_Id], [Disciplinas_Id] in table 'AlunoDisciplina'
ALTER TABLE [dbo].[AlunoDisciplina]
ADD CONSTRAINT [PK_AlunoDisciplina]
    PRIMARY KEY CLUSTERED ([Alunos_Id], [Disciplinas_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Alunos_Id] in table 'AlunoDisciplina'
ALTER TABLE [dbo].[AlunoDisciplina]
ADD CONSTRAINT [FK_AlunoDisciplina_Aluno]
    FOREIGN KEY ([Alunos_Id])
    REFERENCES [dbo].[Alunos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Disciplinas_Id] in table 'AlunoDisciplina'
ALTER TABLE [dbo].[AlunoDisciplina]
ADD CONSTRAINT [FK_AlunoDisciplina_Disciplina]
    FOREIGN KEY ([Disciplinas_Id])
    REFERENCES [dbo].[Disciplinas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlunoDisciplina_Disciplina'
CREATE INDEX [IX_FK_AlunoDisciplina_Disciplina]
ON [dbo].[AlunoDisciplina]
    ([Disciplinas_Id]);
GO

-- Creating foreign key on [ProfessorId] in table 'Disciplinas'
ALTER TABLE [dbo].[Disciplinas]
ADD CONSTRAINT [FK_ProfessorDisciplina]
    FOREIGN KEY ([ProfessorId])
    REFERENCES [dbo].[Professores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfessorDisciplina'
CREATE INDEX [IX_FK_ProfessorDisciplina]
ON [dbo].[Disciplinas]
    ([ProfessorId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------