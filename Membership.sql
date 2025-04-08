-- First, insert the membership types
INSERT INTO Memberships (Description, Year) VALUES
('European Society of Cardiology', '2015-01-01'),
('British Cardiovascular Society', '2016-01-01'),
('Fellow Royal Society of Medicine', '2017-01-01'),
('American College of Cardiology', '2018-01-01'),
('European Association for Cardio-Thoracic Surgery', '2019-01-01'),
('British Medical Association', '2020-01-01'),
('Royal College of Physicians', '2021-01-01'),
('European Society of Dermatology', '2022-01-01'),
('American Academy of Neurology', '2023-01-01'),
('World Medical Association', '2024-01-01');

-- Now assign random memberships to doctors (2-4 memberships per doctor)
-- Doctor 1
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(1, 1), (1, 3), (1, 5);

-- Doctor 2
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(2, 2), (2, 6), (2, 7), (2, 9);

-- Doctor 3
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(3, 4), (3, 8);

-- Doctor 4
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(4, 1), (4, 3), (4, 5), (4, 10);

-- Doctor 5
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(5, 2), (5, 8);

-- Doctor 6
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(6, 3), (6, 6), (6, 9);

-- Doctor 7
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(7, 1), (7, 4), (7, 7);

-- Doctor 8
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(8, 2), (8, 5), (8, 10);

-- Doctor 9
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(9, 3), (9, 8);

-- Doctor 10
INSERT INTO DoctorMembership (DoctorsId, MembershipsId) VALUES
(10, 1), (10, 4), (10, 6), (10, 9);