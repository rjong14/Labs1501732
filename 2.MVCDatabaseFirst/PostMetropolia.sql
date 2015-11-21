﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO Course AS Target
USING (VALUES
    	(1, 'Economics', 3), (2, 'Literature', 3), (3, 'ASP.NET', 4)
)
AS Source (CourseID, Title, Credits)
ON Target.CourseID = Source.CourseID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Title, Credits)
VALUES (Title, Credits);
MERGE INTO Student AS Target
USING (VALUES
    	(1, 'Vallen', 'Veronica','2014-07-15'),
    	(2, 'Gavrilenko', 'Natalia','2013-8-02'),
    	(3, 'Tran', 'Bao', '2012-07-03')

)
AS Source (StudentID, LastName, FirstName, EnrollmentDate)
ON Target.StudentID = Source.StudentID
WHEN NOT MATCHED BY TARGET THEN
INSERT (LastName, FirstName, EnrollmentDate)
VALUES (LastName, FirstName, EnrollmentDate);


MERGE INTO Enrollment AS Target
USING (VALUES
    (1, 2.00, 1, 1),    (2, 3.50, 1, 2),
    (3, 4.00, 2, 3),    (4, 1.80, 2, 1),
    (5, 3.20, 3, 1),    (6, 4.00, 3, 2)
)
AS Source (EnrollmentID, Grade, CourseID, StudentID)
ON Target.EnrollmentID = Source.EnrollmentID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Grade, CourseID, StudentID)
VALUES (Grade, CourseID, StudentID);