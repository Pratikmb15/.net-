create database Cursor_db
USE Cursor_db;

-- Ensure the table exists
CREATE TABLE Student_details(
    Roll_no INT PRIMARY KEY IDENTITY(1,1),
    Student_name VARCHAR(100) NOT NULL,
    Class VARCHAR(10) NOT NULL,
    Marks_Science INT NOT NULL,
    Marks_Maths INT NOT NULL,
    Marks_Eng INT NOT NULL
);

-- Insert sample data (if not already inserted)
INSERT INTO Student_details(Student_name, Class, Marks_Science, Marks_Maths, Marks_Eng)
VALUES 
('Anil', '8th', 64, 78, 54),
('Ajay', '10th', 83, 62, 68),
('Riya', '9th', 78, 92, 71),
('Aditi', '10th', 92, 78, 84);

SELECT * FROM Student_details;

DECLARE @Roll_no INT,
        @Student_name VARCHAR(100),
        @Marks_Science INT,
        @Marks_Maths INT,
        @Marks_Eng INT,
        @TotalMarks INT,
        @Percentage DECIMAL(5,2);  

-- Declare and open cursor
DECLARE Student_cursor CURSOR FOR 
SELECT Roll_no, Student_name, Marks_Science, Marks_Maths, Marks_Eng FROM Student_details;

OPEN Student_cursor;

FETCH NEXT FROM Student_cursor INTO @Roll_no, @Student_name, @Marks_Science, @Marks_Maths, @Marks_Eng;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Print student details
    PRINT CONCAT('Student Name: ', @Student_name);
    PRINT CONCAT('Roll No: ', @Roll_no);
    PRINT CONCAT('Science Marks: ', @Marks_Science);
    PRINT CONCAT('Maths Marks: ', @Marks_Maths);
    PRINT CONCAT('English Marks: ', @Marks_Eng);

    -- Calculate Total Marks
    SET @TotalMarks = @Marks_Science + @Marks_Maths + @Marks_Eng;
    PRINT CONCAT('Total Marks: ', @TotalMarks);

    -- Calculate Percentage
    SET @Percentage = CAST(@TotalMarks AS DECIMAL(10,2)) / 3;
    PRINT CONCAT('Percentage: ', @Percentage, '%');

    -- Assign Grade
    IF @Percentage > 80
        PRINT 'Grade: A';
    ELSE IF @Percentage >= 60 AND @Percentage <= 80
        PRINT 'Grade: B';
    ELSE
        PRINT 'Grade: C';

    PRINT '------------------------------';

    FETCH NEXT FROM Student_cursor INTO @Roll_no, @Student_name, @Marks_Science, @Marks_Maths, @Marks_Eng;
END

-- Close and deallocate cursor
CLOSE Student_cursor;
DEALLOCATE Student_cursor;
