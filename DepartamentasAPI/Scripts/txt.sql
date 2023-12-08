--CREATE TABLE departments (
--  id SERIAL PRIMARY KEY,
--  depname VARCHAR(50)
--);
 
--CREATE TABLE students (
--  id SERIAL PRIMARY KEY,
--  studname VARCHAR(50)
--);
 
--CREATE TABLE courses (
--  id SERIAL PRIMARY KEY,
--  courname VARCHAR(50)
--);
 
--CREATE TABLE depcourstud (
--  courseid INT,
--  studentid INT,
--  departmentid INT,
--  PRIMARY KEY (courseid, studentid, departmentid),
--  CONSTRAINT courses_course_id_fkey FOREIGN KEY (courseid) REFERENCES courses.id,
--  CONSTRAINT departments_department_id_fkey FOREIGN KEY (departmentid) REFERENCES departments.id,
--  CONSTRAINT students_student_id_fkey FOREIGN KEY (studentid) REFERENCES students.id
--);