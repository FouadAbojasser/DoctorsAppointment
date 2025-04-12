-- Insert sample specialties with degrees
INSERT INTO Specialities (Title, Degree) VALUES
('Cardiology', 'D.N.Sc.'),
('Dermatology', 'M.B.B.S, Ph.D'),
('Family Medicine', 'D.N.Sc. - M.B.B.S, Ph.D'),
('Obstetrics & Gynecology', 'Ph.D'),
('Oncology', 'M.B.B.S, Ph.D'),
('Orthopedic Surgery', 'M.B.B.S, Ph.D'),
('Neurology', 'M.D., Ph.D'),
('Pediatrics', 'M.B.B.S, D.C.H.'),
('Psychiatry', 'M.D., D.P.M.'),
('General Surgery', 'M.S., F.R.C.S.'),
('Emergency Medicine', 'M.B.B.S, E.M.D.M.'),
('Radiology', 'M.D., D.M.R.D.'),
('Anesthesiology', 'M.D., D.A.'),
('Pathology', 'M.D., D.Path.'),
('Internal Medicine', 'M.D., D.M.');

-- For joining with Doctors table (many-to-many example)
-- Assuming you have 10 doctors (IDs 1-10), assign 2-4 specialties per doctor
INSERT INTO DoctorSpeciality (DoctorsId, SpecialitiesId) VALUES
-- Doctor 1 specialties
(1, 1), (1, 6), 
-- Doctor 2 specialties
(2, 2), (2, 5), (2, 8),
-- Doctor 3 specialties
(3, 3), (3, 9),
-- Doctor 4 specialties
(4, 4), (4, 7), (4, 10),(4, 6),
-- Doctor 5 specialties
(5, 1), (5, 11),
-- Doctor 6 specialties
(6, 2), (6, 6), (6, 12),
-- Doctor 7 specialties
(7, 3), (7, 8), (7, 13),
-- Doctor 8 specialties
(8, 4), (8, 9), (8, 14),
-- Doctor 9 specialties
(9, 5), (9, 10), (9, 15),
-- Doctor 10 specialties
(10, 1), (10, 7);