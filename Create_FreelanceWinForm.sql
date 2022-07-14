CREATE DATABASE FreeLanceWinForm
GO

USE FreeLanceWinForm
--Table: User
CREATE TABLE "User" (
    userID int  NOT NULL IDENTITY,
    userName nvarchar(50) UNIQUE,
	password nvarchar(50) ,
    fullName nvarchar(50) ,
    balance decimal(8,2) ,
	phone nvarchar(10) ,
	location nvarchar(255)
    CONSTRAINT UserID PRIMARY KEY  (userID)
);

-- Table: Seeker
CREATE TABLE Seeker (
    seekerID int NOT NULL,
	overview nvarchar(255),
	school nvarchar(100),
	major nvarchar(100)
    CONSTRAINT Seeker_pk PRIMARY KEY  (seekerID)
);

-- Table: Hirer
CREATE TABLE Hirer (
    hirerID int NOT NULL,
	companyName nvarchar(100),
    CONSTRAINT Hirer_pk PRIMARY KEY  (hirerID)
);

-- Table: Skill
CREATE TABLE Skill (
    skillID int  NOT NULL IDENTITY,
    skillName nvarchar(128)  NOT NULL,
    CONSTRAINT Skill_pk PRIMARY KEY  (skillID)
);

-- Table: HasSkill
CREATE TABLE HasSkill (
    hasSkillID int  NOT NULL IDENTITY,
    seekerID int  NOT NULL,
    skillID int  NOT NULL,
    CONSTRAINT HasSkill_pk PRIMARY KEY  (hasSkillID)
);

	-- Table: Proposal
CREATE TABLE Proposal (
    proposalID int  NOT NULL IDENTITY,
    projectID int  NOT NULL,
    seekerID int  NOT NULL,
    paymentAmount decimal(8,2),
    status nvarchar(50),
	createdDate date DEFAULT GETDATE(),
    message nvarchar(255),

    CONSTRAINT Proposal_pk PRIMARY KEY  (proposalID)
);

-- Table: Project
CREATE TABLE Project (
    projectID int  NOT NULL IDENTITY,
	projectName nvarchar(50) NOT NULL,
    description text,
	hirerID int  NOT NULL,
	location nvarchar(50),
	paymentAmount decimal(8,2),
	major nvarchar(50) ,
	complexity nvarchar(128),
	expectedDuration nvarchar(100) ,
	createdDate date,
    CONSTRAINT Project_pk PRIMARY KEY  (projectID)
);

-- Table: NeededSkills
CREATE TABLE NeededSkills (
    neededSkillsID int  NOT NULL IDENTITY,
    projectID int  NOT NULL,
    skillID int  NOT NULL,
    CONSTRAINT NeededSkills_pk PRIMARY KEY  (neededSkillsID)
);

---------------------------------------------------------------------
--HasSkill
ALTER TABLE HasSkill ADD CONSTRAINT HasSkill_Seeker
    FOREIGN KEY (seekerID)
    REFERENCES Seeker (seekerID);

ALTER TABLE HasSkill ADD CONSTRAINT HasSkill_Skill
    FOREIGN KEY (skillID)
    REFERENCES Skill (skillID);



--Project
ALTER TABLE Project ADD CONSTRAINT Project_Hirer
    FOREIGN KEY (hirerID)
    REFERENCES Hirer (hirerID);


--NeededSkills
ALTER TABLE NeededSkills ADD CONSTRAINT NeededSkills_Project
    FOREIGN KEY (projectID)
    REFERENCES Project (projectID);
ALTER TABLE NeededSkills ADD CONSTRAINT NeededSkills_Skill
    FOREIGN KEY (skillID)
    REFERENCES Skill (skillID);


--proposal
ALTER TABLE Proposal ADD CONSTRAINT Proposal_Seeker
    FOREIGN KEY (seekerID)
    REFERENCES Seeker (seekerID);
ALTER TABLE Proposal ADD CONSTRAINT Proposal_Project
    FOREIGN KEY (projectID)
    REFERENCES Project (projectID);


--seeker
ALTER TABLE Seeker ADD CONSTRAINT Seeker_User
    FOREIGN KEY (seekerID)
    REFERENCES [User] (userID);

--hirer
ALTER TABLE Hirer ADD CONSTRAINT Hirer_User
    FOREIGN KEY (hirerID)
    REFERENCES [User] (userID);

	----------------------------
--status của proposal gồm những trạng thái này
--proposal sent
--proposal rejected
--job started
--job waiting

--input skill
INSERT INTO Skill (skillName)
values
('html'),
('css'),
('c#'),
('spring'),
('node.js'),
('c++'),
('vue'),
('java'),
('react'),
('javascript'),
('bootstrap'),
('python'),
('ruby'),
('database design'),
('business analysis'),
('tester'),
('academic writing'),
('market research')