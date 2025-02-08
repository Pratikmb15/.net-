create database T1_DB;

use T1_DB;

CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    name VARCHAR(50),
    email VARCHAR(100),
    date_of_birth DATE
);

INSERT INTO Students (student_id, name, email, date_of_birth) VALUES
(1, 'John Dsouza', 'john.dsouza@example.com', '2001-05-14'),
(2, 'Shreya Sharma', 'shreya.sharma@example.com', '2000-08-22'),
(3, 'Robert Brown', 'robert.brown@example.com', '1999-12-30');

select * from Students;

CREATE TABLE Courses (
    course_id INT PRIMARY KEY,
    course_name VARCHAR(100),
    credits INT
)

INSERT INTO Courses (course_id, course_name, credits) VALUES
(101, 'Database Management', 4),
(102, 'Software Engineering', 3),
(103, 'Computer Networks', 5);

select * from Courses;

go

CREATE TABLE Assignments (
    assignment_id INT PRIMARY KEY,
    course_id INT,
    title VARCHAR(100),
    due_date DATE,
    FOREIGN KEY (course_id) REFERENCES Courses(course_id)
);


INSERT INTO Assignments (assignment_id, course_id, title, due_date) VALUES
(1, 101, 'Assignment 1', '2024-01-15'),
(2, 101, 'Assignment 2', '2024-02-10'),
(3, 102, 'Midterm Project', '2024-03-01'),
(4, 103, 'Final Exam', '2024-04-20');

select * from Assignments;

CREATE TABLE Grades (
    grade_id INT PRIMARY KEY,
    student_id INT,
    assignment_id INT,
    score DECIMAL(5, 2),
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (assignment_id) REFERENCES Assignments(assignment_id)
);


INSERT INTO Grades (grade_id, student_id, assignment_id, score) VALUES
(1, 1, 1, 85.5),
(2, 2, 1, 90.0),
(3, 3, 2, 75.0),
(4, 1, 3, 88.0),
(5, 2, 4, 92.0);

select * from Grades;

CREATE TABLE Instructors (
    instructor_id INT PRIMARY KEY,
    course_id INT,
    name VARCHAR(50),
    email VARCHAR(100),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id)
);

INSERT INTO Instructors (instructor_id, course_id, name, email) VALUES
(1, 101, 'Dr. Smith', 'smith@example.com'),
(2, 102, 'Dr. Johnson', 'johnson@example.com'),
(3, 103, 'Dr. Lee', 'lee@example.com');

CREATE TABLE Attendance (
    attendance_id INT PRIMARY KEY,
    student_id INT,
    course_id INT,
    attendance_date DATE,
    status VARCHAR(10),
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id)
);

INSERT INTO Attendance (attendance_id, student_id, course_id, attendance_date, status) VALUES
(1, 1, 101, '2024-01-10', 'Present'),
(2, 2, 101, '2024-01-10', 'Absent'),
(3, 3, 102, '2024-02-05', 'Present'),
(4, 1, 103, '2024-02-07', 'Absent'),
(5, 2, 103, '2024-02-07', 'Present');

select * from Attendance;

create table Enrollments(
Enrollment_id int Primary key identity(1,1),
student_id int,
course_id int,
FOREIGN KEY (student_id) REFERENCES Students(student_id),
FOREIGN KEY (course_id) REFERENCES Courses(course_id),
);

Insert into Enrollments (student_id,course_id) values (1,101),(2,101),(3,102),(1,103),(2,103);

select * from Enrollments;

select
Students.student_id,
Students.name as student_name, 
Enrollments.course_id,
Courses.course_name 
from Students 
inner join Enrollments on  Students.student_id=Enrollments.student_id
inner join Courses on  Enrollments.course_id=Courses.course_id;



















