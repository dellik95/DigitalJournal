
IF OBJECT_ID(N'[dbo].[FK__Authoriza__Teach__5165187F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Authorizations] DROP CONSTRAINT [FK__Authoriza__Teach__5165187F];
GO
IF OBJECT_ID(N'[dbo].[FK__GroupsSub__Group__3F466844]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupsSubjects] DROP CONSTRAINT [FK__GroupsSub__Group__3F466844];
GO
IF OBJECT_ID(N'[dbo].[FK__GroupsSub__Subje__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GroupsSubjects] DROP CONSTRAINT [FK__GroupsSub__Subje__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__Marks__Group_ID__2F10007B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Marks] DROP CONSTRAINT [FK__Marks__Group_ID__2F10007B];
GO
IF OBJECT_ID(N'[dbo].[FK__Marks__Student_I__2E1BDC42]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Marks] DROP CONSTRAINT [FK__Marks__Student_I__2E1BDC42];
GO
IF OBJECT_ID(N'[dbo].[FK__Marks__Subjects___2D27B809]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Marks] DROP CONSTRAINT [FK__Marks__Subjects___2D27B809];
GO
IF OBJECT_ID(N'[dbo].[FK__Students__Cours___286302EC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK__Students__Cours___286302EC];
GO
IF OBJECT_ID(N'[dbo].[FK__Students__Group___276EDEB3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK__Students__Group___276EDEB3];
GO
IF OBJECT_ID(N'[dbo].[FK__Teacher__Academi__38996AB5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK__Teacher__Academi__38996AB5];
GO
IF OBJECT_ID(N'[dbo].[FK__Teacher__Positio__37A5467C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK__Teacher__Positio__37A5467C];
GO
IF OBJECT_ID(N'[dbo].[FK__TeacherCa__Cathe__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherCathedra] DROP CONSTRAINT [FK__TeacherCa__Cathe__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__TeacherCa__Teach__3B75D760]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherCathedra] DROP CONSTRAINT [FK__TeacherCa__Teach__3B75D760];
GO
IF OBJECT_ID(N'[dbo].[FK__TeacherSu__Statu__4CA06362]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherSubjectsStatus] DROP CONSTRAINT [FK__TeacherSu__Statu__4CA06362];
GO
IF OBJECT_ID(N'[dbo].[FK__TeacherSu__Subje__4BAC3F29]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherSubjectsStatus] DROP CONSTRAINT [FK__TeacherSu__Subje__4BAC3F29];
GO
IF OBJECT_ID(N'[dbo].[FK__TeacherSu__Teach__4AB81AF0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherSubjectsStatus] DROP CONSTRAINT [FK__TeacherSu__Teach__4AB81AF0];
GO


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[Academic_degree]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Academic_degree];
GO


IF OBJECT_ID(N'[dbo].[Authorizations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Authorizations];
GO
IF OBJECT_ID(N'[dbo].[Cathedra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cathedra];
GO
IF OBJECT_ID(N'[dbo].[Cours]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cours];
GO
IF OBJECT_ID(N'[dbo].[Curriculum]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Curriculum];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[GroupsSubjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupsSubjects];
GO
IF OBJECT_ID(N'[dbo].[Marks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Marks];
GO
IF OBJECT_ID(N'[dbo].[Number_lab_modules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Number_lab_modules];
GO
IF OBJECT_ID(N'[dbo].[Number_of_modules]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Number_of_modules];
GO
IF OBJECT_ID(N'[dbo].[Position]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Position];
GO
IF OBJECT_ID(N'[dbo].[Statuss]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Statuss];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[Subjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subjects];
GO
IF OBJECT_ID(N'[dbo].[Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teacher];
GO
IF OBJECT_ID(N'[dbo].[TeacherCathedra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherCathedra];
GO
IF OBJECT_ID(N'[dbo].[TeacherSubjectsStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherSubjectsStatus];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Academic_degree'
CREATE TABLE [dbo].[Academic_degree] (
    [Academic_degree_ID] smallint IDENTITY(1,1) NOT NULL,
    [AcademicDegree] varchar(20)  NOT NULL
);
GO



-- Creating table 'Authorizations'
CREATE TABLE [dbo].[Authorizations] (
    [Authorizations_ID] smallint IDENTITY(1,1) NOT NULL,
    [Ligin] varchar(20)  NOT NULL,
    [Pass] varchar(20)  NOT NULL,
    [Teacher_ID] smallint  NOT NULL
);
GO

-- Creating table 'Cathedra'
CREATE TABLE [dbo].[Cathedra] (
    [Cathedra_ID] smallint IDENTITY(1,1) NOT NULL,
    [CathName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Cours'
CREATE TABLE [dbo].[Cours] (
    [Cours_ID] smallint IDENTITY(1,1) NOT NULL,
    [NumCours] smallint  NOT NULL
);
GO

-- Creating table 'Curriculum'
CREATE TABLE [dbo].[Curriculum] (
    [Curriculum_ID] smallint IDENTITY(1,1) NOT NULL,
    [CurName] varchar(20)  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Group_ID] smallint IDENTITY(1,1) NOT NULL,
    [NumGroup] varchar(20)  NOT NULL
);
GO

-- Creating table 'GroupsSubjects'
CREATE TABLE [dbo].[GroupsSubjects] (
    [GroupsSubjects_ID] smallint IDENTITY(1,1) NOT NULL,
    [Group_ID] smallint  NOT NULL,
    [Subjects_ID] smallint  NOT NULL
);
GO

-- Creating table 'Marks'
CREATE TABLE [dbo].[Marks] (
    [Marks_ID] smallint IDENTITY(1,1) NOT NULL,
    [Mark] int  NULL,
    [Subjects_ID] smallint  NOT NULL,
    [Student_ID] smallint  NOT NULL,
    [Group_ID] smallint  NOT NULL
);
GO

-- Creating table 'Number_lab_modules'
CREATE TABLE [dbo].[Number_lab_modules] (
    [Number_lab_modules_ID] smallint IDENTITY(1,1) NOT NULL,
    [NlM] smallint  NOT NULL
);
GO

-- Creating table 'Number_of_modules'
CREATE TABLE [dbo].[Number_of_modules] (
    [Number_of_modules_ID] smallint IDENTITY(1,1) NOT NULL,
    [NoM] smallint  NOT NULL
);
GO

-- Creating table 'Position'
CREATE TABLE [dbo].[Position] (
    [Position_ID] smallint IDENTITY(1,1) NOT NULL,
    [PName] varchar(20)  NOT NULL
);
GO

-- Creating table 'Statuss'
CREATE TABLE [dbo].[Statuss] (
    [Statuss_ID] smallint IDENTITY(1,1) NOT NULL,
    [StatName] varchar(20)  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Student_ID] smallint IDENTITY(1,1) NOT NULL,
    [LName] varchar(20)  NOT NULL,
    [FName] varchar(20)  NOT NULL,
    [SName] varchar(20)  NOT NULL,
    [Group_ID] smallint  NOT NULL,
    [Cours_ID] smallint  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [Subjects_ID] smallint IDENTITY(1,1) NOT NULL,
    [SubName] varchar(50)  NOT NULL
);
GO

-- Creating table 'Teacher'
CREATE TABLE [dbo].[Teacher] (
    [Teacher_ID] smallint IDENTITY(1,1) NOT NULL,
    [LName] varchar(20)  NOT NULL,
    [FName] varchar(20)  NOT NULL,
    [SName] varchar(20)  NOT NULL,
    [Position_ID] smallint  NOT NULL,
    [Academic_degree] smallint  NOT NULL
);
GO

-- Creating table 'TeacherCathedra'
CREATE TABLE [dbo].[TeacherCathedra] (
    [TeacherCathedra_ID] smallint IDENTITY(1,1) NOT NULL,
    [Teacher_ID] smallint  NOT NULL,
    [Cathedra_ID] smallint  NOT NULL
);
GO

-- Creating table 'TeacherSubjectsStatus'
CREATE TABLE [dbo].[TeacherSubjectsStatus] (
    [TeacherSubjects_ID] smallint IDENTITY(1,1) NOT NULL,
    [Teacher_ID] smallint  NOT NULL,
    [Subjects_ID] smallint  NOT NULL,
    [Statuss_ID] smallint  NOT NULL
);
GO

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Academic_degree_ID] in table 'Academic_degree'
ALTER TABLE [dbo].[Academic_degree]
ADD CONSTRAINT [PK_Academic_degree]
    PRIMARY KEY CLUSTERED ([Academic_degree_ID] ASC);
GO


GO

-- Creating primary key on [Authorizations_ID] in table 'Authorizations'
ALTER TABLE [dbo].[Authorizations]
ADD CONSTRAINT [PK_Authorizations]
    PRIMARY KEY CLUSTERED ([Authorizations_ID] ASC);
GO

-- Creating primary key on [Cathedra_ID] in table 'Cathedra'
ALTER TABLE [dbo].[Cathedra]
ADD CONSTRAINT [PK_Cathedra]
    PRIMARY KEY CLUSTERED ([Cathedra_ID] ASC);
GO

-- Creating primary key on [Cours_ID] in table 'Cours'
ALTER TABLE [dbo].[Cours]
ADD CONSTRAINT [PK_Cours]
    PRIMARY KEY CLUSTERED ([Cours_ID] ASC);
GO

-- Creating primary key on [Curriculum_ID] in table 'Curriculum'
ALTER TABLE [dbo].[Curriculum]
ADD CONSTRAINT [PK_Curriculum]
    PRIMARY KEY CLUSTERED ([Curriculum_ID] ASC);
GO

-- Creating primary key on [Group_ID] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([Group_ID] ASC);
GO

-- Creating primary key on [GroupsSubjects_ID] in table 'GroupsSubjects'
ALTER TABLE [dbo].[GroupsSubjects]
ADD CONSTRAINT [PK_GroupsSubjects]
    PRIMARY KEY CLUSTERED ([GroupsSubjects_ID] ASC);
GO

-- Creating primary key on [Marks_ID] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [PK_Marks]
    PRIMARY KEY CLUSTERED ([Marks_ID] ASC);
GO

-- Creating primary key on [Number_lab_modules_ID] in table 'Number_lab_modules'
ALTER TABLE [dbo].[Number_lab_modules]
ADD CONSTRAINT [PK_Number_lab_modules]
    PRIMARY KEY CLUSTERED ([Number_lab_modules_ID] ASC);
GO

-- Creating primary key on [Number_of_modules_ID] in table 'Number_of_modules'
ALTER TABLE [dbo].[Number_of_modules]
ADD CONSTRAINT [PK_Number_of_modules]
    PRIMARY KEY CLUSTERED ([Number_of_modules_ID] ASC);
GO

-- Creating primary key on [Position_ID] in table 'Position'
ALTER TABLE [dbo].[Position]
ADD CONSTRAINT [PK_Position]
    PRIMARY KEY CLUSTERED ([Position_ID] ASC);
GO

-- Creating primary key on [Statuss_ID] in table 'Statuss'
ALTER TABLE [dbo].[Statuss]
ADD CONSTRAINT [PK_Statuss]
    PRIMARY KEY CLUSTERED ([Statuss_ID] ASC);
GO

-- Creating primary key on [Student_ID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Student_ID] ASC);
GO

-- Creating primary key on [Subjects_ID] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([Subjects_ID] ASC);
GO

-- Creating primary key on [Teacher_ID] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [PK_Teacher]
    PRIMARY KEY CLUSTERED ([Teacher_ID] ASC);
GO

-- Creating primary key on [TeacherCathedra_ID] in table 'TeacherCathedra'
ALTER TABLE [dbo].[TeacherCathedra]
ADD CONSTRAINT [PK_TeacherCathedra]
    PRIMARY KEY CLUSTERED ([TeacherCathedra_ID] ASC);
GO

-- Creating primary key on [TeacherSubjects_ID] in table 'TeacherSubjectsStatus'
ALTER TABLE [dbo].[TeacherSubjectsStatus]
ADD CONSTRAINT [PK_TeacherSubjectsStatus]
    PRIMARY KEY CLUSTERED ([TeacherSubjects_ID] ASC);
GO

-- Creating foreign key on [Academic_degree] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [FK__Teacher__Academi__38996AB5]
    FOREIGN KEY ([Academic_degree])
    REFERENCES [dbo].[Academic_degree]
        ([Academic_degree_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Teacher__Academi__38996AB5'
CREATE INDEX [IX_FK__Teacher__Academi__38996AB5]
ON [dbo].[Teacher]
    ([Academic_degree]);
GO



-- Creating foreign key on [Teacher_ID] in table 'Authorizations'
ALTER TABLE [dbo].[Authorizations]
ADD CONSTRAINT [FK__Authoriza__Teach__5165187F]
    FOREIGN KEY ([Teacher_ID])
    REFERENCES [dbo].[Teacher]
        ([Teacher_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Authoriza__Teach__5165187F'
CREATE INDEX [IX_FK__Authoriza__Teach__5165187F]
ON [dbo].[Authorizations]
    ([Teacher_ID]);
GO

-- Creating foreign key on [Cathedra_ID] in table 'TeacherCathedra'
ALTER TABLE [dbo].[TeacherCathedra]
ADD CONSTRAINT [FK__TeacherCa__Cathe__3C69FB99]
    FOREIGN KEY ([Cathedra_ID])
    REFERENCES [dbo].[Cathedra]
        ([Cathedra_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeacherCa__Cathe__3C69FB99'
CREATE INDEX [IX_FK__TeacherCa__Cathe__3C69FB99]
ON [dbo].[TeacherCathedra]
    ([Cathedra_ID]);
GO

-- Creating foreign key on [Cours_ID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK__Students__Cours___286302EC]
    FOREIGN KEY ([Cours_ID])
    REFERENCES [dbo].[Cours]
        ([Cours_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Students__Cours___286302EC'
CREATE INDEX [IX_FK__Students__Cours___286302EC]
ON [dbo].[Students]
    ([Cours_ID]);
GO

-- Creating foreign key on [Group_ID] in table 'GroupsSubjects'
ALTER TABLE [dbo].[GroupsSubjects]
ADD CONSTRAINT [FK__GroupsSub__Group__3F466844]
    FOREIGN KEY ([Group_ID])
    REFERENCES [dbo].[Groups]
        ([Group_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__GroupsSub__Group__3F466844'
CREATE INDEX [IX_FK__GroupsSub__Group__3F466844]
ON [dbo].[GroupsSubjects]
    ([Group_ID]);
GO

-- Creating foreign key on [Group_ID] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK__Marks__Group_ID__2F10007B]
    FOREIGN KEY ([Group_ID])
    REFERENCES [dbo].[Groups]
        ([Group_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Marks__Group_ID__2F10007B'
CREATE INDEX [IX_FK__Marks__Group_ID__2F10007B]
ON [dbo].[Marks]
    ([Group_ID]);
GO

-- Creating foreign key on [Group_ID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK__Students__Group___276EDEB3]
    FOREIGN KEY ([Group_ID])
    REFERENCES [dbo].[Groups]
        ([Group_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Students__Group___276EDEB3'
CREATE INDEX [IX_FK__Students__Group___276EDEB3]
ON [dbo].[Students]
    ([Group_ID]);
GO

-- Creating foreign key on [Subjects_ID] in table 'GroupsSubjects'
ALTER TABLE [dbo].[GroupsSubjects]
ADD CONSTRAINT [FK__GroupsSub__Subje__403A8C7D]
    FOREIGN KEY ([Subjects_ID])
    REFERENCES [dbo].[Subjects]
        ([Subjects_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__GroupsSub__Subje__403A8C7D'
CREATE INDEX [IX_FK__GroupsSub__Subje__403A8C7D]
ON [dbo].[GroupsSubjects]
    ([Subjects_ID]);
GO

-- Creating foreign key on [Student_ID] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK__Marks__Student_I__2E1BDC42]
    FOREIGN KEY ([Student_ID])
    REFERENCES [dbo].[Students]
        ([Student_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Marks__Student_I__2E1BDC42'
CREATE INDEX [IX_FK__Marks__Student_I__2E1BDC42]
ON [dbo].[Marks]
    ([Student_ID]);
GO

-- Creating foreign key on [Subjects_ID] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK__Marks__Subjects___2D27B809]
    FOREIGN KEY ([Subjects_ID])
    REFERENCES [dbo].[Subjects]
        ([Subjects_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Marks__Subjects___2D27B809'
CREATE INDEX [IX_FK__Marks__Subjects___2D27B809]
ON [dbo].[Marks]
    ([Subjects_ID]);
GO

-- Creating foreign key on [Position_ID] in table 'Teacher'
ALTER TABLE [dbo].[Teacher]
ADD CONSTRAINT [FK__Teacher__Positio__37A5467C]
    FOREIGN KEY ([Position_ID])
    REFERENCES [dbo].[Position]
        ([Position_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Teacher__Positio__37A5467C'
CREATE INDEX [IX_FK__Teacher__Positio__37A5467C]
ON [dbo].[Teacher]
    ([Position_ID]);
GO

-- Creating foreign key on [Statuss_ID] in table 'TeacherSubjectsStatus'
ALTER TABLE [dbo].[TeacherSubjectsStatus]
ADD CONSTRAINT [FK__TeacherSu__Statu__4CA06362]
    FOREIGN KEY ([Statuss_ID])
    REFERENCES [dbo].[Statuss]
        ([Statuss_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeacherSu__Statu__4CA06362'
CREATE INDEX [IX_FK__TeacherSu__Statu__4CA06362]
ON [dbo].[TeacherSubjectsStatus]
    ([Statuss_ID]);
GO

-- Creating foreign key on [Subjects_ID] in table 'TeacherSubjectsStatus'
ALTER TABLE [dbo].[TeacherSubjectsStatus]
ADD CONSTRAINT [FK__TeacherSu__Subje__4BAC3F29]
    FOREIGN KEY ([Subjects_ID])
    REFERENCES [dbo].[Subjects]
        ([Subjects_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeacherSu__Subje__4BAC3F29'
CREATE INDEX [IX_FK__TeacherSu__Subje__4BAC3F29]
ON [dbo].[TeacherSubjectsStatus]
    ([Subjects_ID]);
GO

-- Creating foreign key on [Teacher_ID] in table 'TeacherCathedra'
ALTER TABLE [dbo].[TeacherCathedra]
ADD CONSTRAINT [FK__TeacherCa__Teach__3B75D760]
    FOREIGN KEY ([Teacher_ID])
    REFERENCES [dbo].[Teacher]
        ([Teacher_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeacherCa__Teach__3B75D760'
CREATE INDEX [IX_FK__TeacherCa__Teach__3B75D760]
ON [dbo].[TeacherCathedra]
    ([Teacher_ID]);
GO

-- Creating foreign key on [Teacher_ID] in table 'TeacherSubjectsStatus'
ALTER TABLE [dbo].[TeacherSubjectsStatus]
ADD CONSTRAINT [FK__TeacherSu__Teach__4AB81AF0]
    FOREIGN KEY ([Teacher_ID])
    REFERENCES [dbo].[Teacher]
        ([Teacher_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeacherSu__Teach__4AB81AF0'
CREATE INDEX [IX_FK__TeacherSu__Teach__4AB81AF0]
ON [dbo].[TeacherSubjectsStatus]
    ([Teacher_ID]);
GO

