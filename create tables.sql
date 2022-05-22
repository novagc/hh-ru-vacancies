CREATE TABLE "Vacancies"(
    "IdVacancy" INTEGER NOT NULL,
    "Name" TEXT NOT NULL,
    "IdArea" INTEGER NOT NULL,
    "SalaryFrom" DECIMAL(8, 2) NOT NULL,
    "SalaryTo" DECIMAL(8, 2) NOT NULL,
    "SalaryCurrency" INTEGER NOT NULL,
    "PublishedAt" TIMESTAMP(0) WITHOUT TIME ZONE NOT NULL,
    "SnippetRequirement" TEXT NOT NULL,
    "SnippetResponsibility" TEXT NOT NULL,
    "Description" TEXT NOT NULL,
    "IdExperience" TEXT NOT NULL
);
ALTER TABLE
    "Vacancies" ADD PRIMARY KEY("IdVacancy");
CREATE TABLE "VacanciesSpecializations"(
    "IdVacancy" INTEGER NOT NULL,
    "IdSpecialization" TEXT NOT NULL
);
CREATE INDEX "vacanciesspecializations_idvacancy_index" ON
    "VacanciesSpecializations"("IdVacancy");
CREATE INDEX "vacanciesspecializations_idspecialization_index" ON
    "VacanciesSpecializations"("IdSpecialization");
CREATE TABLE "Specializations"(
    "IdSpecialization" TEXT NOT NULL,
    "Name" TEXT NOT NULL
);
ALTER TABLE
    "Specializations" ADD PRIMARY KEY("IdSpecialization");
CREATE TABLE "Area"(
    "IdArea" INTEGER NOT NULL,
    "Name" TEXT NOT NULL
);
ALTER TABLE
    "Area" ADD PRIMARY KEY("IdArea");
CREATE TABLE "Experience"(
    "IdExperience" TEXT NOT NULL,
    "Name" TEXT NOT NULL
);
ALTER TABLE
    "Experience" ADD PRIMARY KEY("IdExperience");
CREATE TABLE "Skills"(
    "IdSkill" SERIAL NOT NULL,
    "Name" TEXT NOT NULL
);
ALTER TABLE
    "Skills" ADD PRIMARY KEY("IdSkill");
CREATE TABLE "VacanciesSkills"(
    "IdVacancy" INTEGER NOT NULL,
    "IdSkill" INTEGER NOT NULL
);
CREATE INDEX "vacanciesskills_idvacancy_index" ON
    "VacanciesSkills"("IdVacancy");
CREATE INDEX "vacanciesskills_idskill_index" ON
    "VacanciesSkills"("IdSkill");
ALTER TABLE
    "Vacancies" ADD CONSTRAINT "vacancies_idarea_foreign" FOREIGN KEY("IdArea") REFERENCES "Area"("IdArea");
ALTER TABLE
    "Vacancies" ADD CONSTRAINT "vacancies_idexperience_foreign" FOREIGN KEY("IdExperience") REFERENCES "Experience"("IdExperience");
ALTER TABLE
    "VacanciesSpecializations" ADD CONSTRAINT "vacanciesspecializations_idvacancy_foreign" FOREIGN KEY("IdVacancy") REFERENCES "Vacancies"("IdVacancy");
ALTER TABLE
    "VacanciesSpecializations" ADD CONSTRAINT "vacanciesspecializations_idspecialization_foreign" FOREIGN KEY("IdSpecialization") REFERENCES "Specializations"("IdSpecialization");
ALTER TABLE
    "VacanciesSkills" ADD CONSTRAINT "vacanciesskills_idvacancy_foreign" FOREIGN KEY("IdVacancy") REFERENCES "Vacancies"("IdVacancy");
ALTER TABLE
    "VacanciesSkills" ADD CONSTRAINT "vacanciesskills_idskill_foreign" FOREIGN KEY("IdSkill") REFERENCES "Skills"("IdSkill");