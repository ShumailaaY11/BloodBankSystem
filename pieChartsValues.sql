INSERT INTO Donors VALUES ('D-001','Ahmed Ali','O+','1990-01-15','0300-1234567','ahmed@mail.com','Lahore',NULL,1)
INSERT INTO Donors VALUES ('D-002','Sara Khan','A+','1995-06-05','0311-9876543','sara@mail.com','Karachi',NULL,1)
INSERT INTO Donors VALUES ('D-003','Usman Tariq','B+','1988-02-08','0345-7778899','usman@mail.com','Islamabad',NULL,1)

INSERT INTO BloodUnits VALUES ('BU-001','O+','2026-05-01','2026-07-01','D-001','Available',1)
INSERT INTO BloodUnits VALUES ('BU-002','A+','2026-05-10','2026-07-10','D-002','Available',2)
INSERT INTO BloodUnits VALUES ('BU-003','B+','2026-05-15','2026-07-15',NULL,'Available',1)
INSERT INTO BloodUnits VALUES ('BU-004','AB+','2026-05-20','2026-07-20',NULL,'Reserved',1)
INSERT INTO BloodUnits VALUES ('BU-005','O-','2026-05-22','2026-07-22',NULL,'Available',1)

INSERT INTO BloodRequests VALUES ('REQ-001','Hassan Ali','O+',2,'2026-05-28','2026-06-01','Pending','DHQ Hospital',NULL)
INSERT INTO BloodRequests VALUES ('REQ-002','Fatima Noor','A+',1,'2026-05-25','2026-06-10','Fulfilled','CMH Lahore',NULL)
INSERT INTO BloodRequests VALUES ('REQ-003','Kamran Baig','B+',3,'2026-05-20','2026-05-22','Cancelled','Services Hospital',NULL)
INSERT INTO BloodRequests VALUES ('REQ-004','Nadia Shah','AB+',1,'2026-06-01','2026-06-15','Pending','Jinnah Hospital',NULL)