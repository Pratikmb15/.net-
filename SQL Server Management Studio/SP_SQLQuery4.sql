CREATE TABLE Students(
StudentID INT PRIMARY KEY,
Student_name varchar(50) NOT NULL,
SubjectID int,
Grade DECIMAL(5, 2)
);

CREATE TABLE Subjects(
SubjectID INT,
Subject_name varchar(30)
);

insert into Students(StudentID,Student_name,SubjectID,Grade) values (1,'Jason Roy',101,64),(2,'James Anderson',105,72),(3,'Sharon Thomas',101,83),(4,'Kevin Peterson',105,92);
insert into Students(StudentID,Student_name,SubjectID,Grade) values (7,'Sam Billings',107,92);

insert into Subjects(SubjectID,Subject_name) values(101,'Mathematics'),(105,'Physics'),(107,'Chemistry');


select * from Students;
select * from Subjects;


GO
CREATE PROC UPGRADESTUDENTSGRADE
@StudentID INT,@SubjectID INT,@UpdatedGrade DECIMAL(5, 2)

AS 
BEGIN
begin try

IF NOT EXISTS(SELECT 1 FROM STUDENTS WHERE StudentID=@StudentID)
THROW 50012 ,'Invalid StudentId',1;

IF NOT EXISTS(SELECT 1 FROM Subjects WHERE SubjectID=@SubjectID)
THROW 50013 ,'Invalid SubjectId',1;

IF @UpdatedGrade<0 OR @UpdatedGrade>100
THROW 50014 ,'Invalid Marks, Exceeds the range 0 to 100',1;

UPDATE Students
set Grade=@UpdatedGrade
where StudentID=@StudentID and SubjectID=@SubjectID;
DECLARE @CurrentGrades DECIMAL(5, 2);
Select  @CurrentGrades=Grade from Students where StudentID=@StudentID and SubjectID=@SubjectID;

PRINT 'Grade updated successfully . Current grade is '+ CAST( @CurrentGrades AS NVARCHAR(40));
end try
BEGIN CATCH 
SELECT ERROR_LINE(),ERROR_MESSAGE() AS MESSAGE;
END CATCH
END

EXEC UPGRADESTUDENTSGRADE 7,107,90;
