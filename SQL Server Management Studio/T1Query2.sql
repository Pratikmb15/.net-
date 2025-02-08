
Select * from Students;
select * from Courses;
select * from Attendance;
Select * from Enrollments;
select * from Instructors;
select * from Assignments;
select * from Grades;


insert into Courses values (104,'Data Structures and Algorithms',5)

insert into Students(student_id,name,email,date_of_birth) values (4,'Harry Brook','harry.brook@gmail.com','2003-07-17')

select Students.student_id,Students.name,Courses.course_id,Courses.course_name 
from Students 
left join Enrollments on Students.student_id=Enrollments.student_id
left join Courses on Enrollments.course_id= Courses.course_id

select Courses.course_id,Courses.course_name,Students.student_id,Students.name as student_name  
from Courses
left join Enrollments on Courses.course_id = Enrollments.course_id
left join Students on Enrollments.student_id = Students.student_id

select Students.student_id,Students.name as Student_name,Courses.course_id,Courses.course_name 
from Students 
full outer join Enrollments on Students.student_id=Enrollments.student_id
full outer join Courses on Enrollments.course_id= Courses.course_id

Select students.name as student_name,Courses.course_name,Instructors.name as instructor_name
from students
inner join Enrollments on Enrollments.student_id=Students.student_id
inner join Courses on Enrollments.course_id= Courses.course_id
inner join Instructors on Instructors.course_id= Courses.course_id

Select Students.name as Student_name,Assignments.course_id,Courses.course_name,Assignments.title,Grades.score
from Assignments
inner join Grades on Assignments.assignment_id= Grades.grade_id
inner join Students on Grades.student_id=Students.student_id
inner join Enrollments on Students.student_id=Enrollments.student_id
inner join Courses on Enrollments.course_id= Courses.course_id
----------------------------------------------
--select Courses.course_name,
--AVG(case when Attendance.status='Present' then 1 else 0 end)
--* 100 as Attendance_rate
--from Courses
--inner join Attendance on Courses.course_id=Attendance.course_id
--group by Courses.course_name;
----------------------------------------------
select Courses.course_name,
(sum(case when Attendance.status='Present' then 1 else 0 end)
* 100)/COUNT(*) as Attendance_rate
from Courses
inner join Attendance on Courses.course_id=Attendance.course_id
group by Courses.course_name;







