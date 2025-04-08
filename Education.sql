-- Insert education entries
INSERT INTO Educations (University, Specialization, Year) VALUES
('Harvard Medical School', 'Doctor of Medicine', '2000-01-01'),
('Johns Hopkins School of Medicine', 'MD in Cardiology', '2002-01-01'),
('Stanford University School of Medicine', 'MD with Honors', '2005-01-01'),
('University of California, San Francisco', 'Medical Doctorate', '2008-01-01'),
('Mayo Clinic Alix School of Medicine', 'MD in Neurology', '2010-01-01'),
('University of Oxford Medical Sciences', 'MBBS Ph.D.', '2012-01-01'),
('University of Cambridge School of Medicine', 'MBBS with Research', '2014-01-01'),
('Imperial College London Faculty of Medicine', 'MD in Dermatology', '2016-01-01'),
('Karolinska Institute', 'Medical Degree', '2018-01-01'),
('University of Tokyo Faculty of Medicine', 'MD with Specialization', '2020-01-01');

-- Assign educations to doctors (each doctor gets 1-3 educations)
-- Doctor 1
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (1, 1), (1, 5);

-- Doctor 2
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (2, 2), (2, 6), (2, 9);

-- Doctor 3
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (3, 3), (3, 7);

-- Doctor 4
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (4, 1), (4, 4), (4, 8);

-- Doctor 5
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (5, 2), (5, 5);

-- Doctor 6
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (6, 3), (6, 6), (6, 10);

-- Doctor 7
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (7, 4), (7, 7);

-- Doctor 8
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (8, 5), (8, 8), (8, 1);

-- Doctor 9
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (9, 6), (9, 9);

-- Doctor 10
INSERT INTO DoctorEducation (DoctorsId, EducationsId) VALUES (10, 7), (10, 10), (10, 2);