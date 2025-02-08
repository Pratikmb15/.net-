CREATE TABLE Students (
    student_id INT PRIMARY KEY, -- Clustered Index automatically created
    name VARCHAR(50),
    email VARCHAR(100)
);

create non clustered index 