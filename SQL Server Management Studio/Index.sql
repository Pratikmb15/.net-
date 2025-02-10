CREATE TABLE Students (
    student_id INT PRIMARY KEY, -- Clustered Index automatically created
    name VARCHAR(50),
    email VARCHAR(100)
);

create nonclustered index nc_idx_name
on students(name);

create unique index uq_nc_idx_email
on students(email);

drop index nc_idx_name on students;
